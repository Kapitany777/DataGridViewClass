using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridLibrary
{
    public class HunDataGridViewErp : DataGridView
    {
        #region Constructors
        public HunDataGridViewErp()
        {
            this.CellEnter += DataGridViewEditable_CellEnter;
            this.CellValidating += DataGridViewEditable_CellValidating;
            this.CellValidated += HunDataGridViewErp_CellValidated;

            this.EditingControlShowing += DataGridViewEditable_EditingControlShowing;

            this.CellMouseDown += HunDataGridViewErp_CellMouseDown;
        }
        #endregion

        private void DataGridViewEditable_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (this.CurrentCell.ReadOnly)
            {
                SendKeys.Send("{tab}");
            }
            else
            {
                this.BeginEdit(true);
            }
        }

        private void DataGridViewEditable_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                if (this.Columns[e.ColumnIndex] is HunColumnErp)
                {
                    var column = this.Columns[e.ColumnIndex] as HunColumnErp;

                    if (column.CheckValue(e.FormattedValue.ToString().Trim()))
                    {
                        if (column.DescriptionColumn == null)
                        {
                            this[e.ColumnIndex + 1, e.RowIndex].Value = column.Description;
                        }
                        else
                        {
                            this[column.DescriptionColumn.Name, e.RowIndex].Value = column.Description;
                        }
                    }
                    else
                    {
                        MessageBox.Show(column.ErrorMessage);
                        e.Cancel = true;
                    }
                }
            }
            catch { }
        }

        private void HunDataGridViewErp_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Columns[e.ColumnIndex] is HunColumnErp)
            {
                this.CurrentCell.Value = this.CurrentCell.Value?.ToString().Trim();
            }
        }

        public void NewRow()
        {
            try
            {
                this.CurrentCell = this[0, this.RowCount - 1];
                this.FirstDisplayedScrollingRowIndex = this.RowCount - 1;
            }
            catch (Exception)
            {
            }
        }

        public void DeleteRows()
        {
            try
            {
                if (this.SelectedRows.Count > 0)
                {
                    for (int i = this.Rows.Count - 1; i >= 0; i--)
                    {
                        if (this.Rows[i].Selected)
                        {
                            this.Rows.Remove(this.Rows[i]);
                        }
                    }
                }
                else
                {
                    this.Rows.Remove(this.CurrentRow);
                }
            }
            catch (InvalidOperationException)
            {
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                SendKeys.Send("{tab}");
                return true;
            }
            else if (keyData == Keys.F2)
            {
                MessageBox.Show("F2 key pressed");
                return true;
            }
            else if (keyData == Keys.F9)
            {
                NewRow();
                return true;
            }
            else if (keyData == (Keys.Shift | Keys.F9))
            {
                DeleteRows();
                return true;
            }
            else if (keyData == (Keys.Shift | Keys.Up) || keyData == (Keys.Shift | Keys.Down))
            {
                this.CurrentRow.Selected = true;
                return base.ProcessCmdKey(ref msg, keyData);
            }
            else
            {
                if (this.CurrentRow != null)
                {
                    this.CurrentRow.Selected = false;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void DataGridViewEditable_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // Prevent multiple subscribing
            e.Control.KeyPress -= Integer_KeyPress;
            e.Control.KeyPress -= Erp_KeyPress;

            if (this.Columns[this.CurrentCell.ColumnIndex] is HunColumnInteger)
            {
                e.Control.KeyPress += Integer_KeyPress;
            }
            else if (this.Columns[this.CurrentCell.ColumnIndex] is HunColumnErp)
            {
                e.Control.KeyPress += Erp_KeyPress;
            }
        }

        private void Integer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Erp_KeyPress(object sender, KeyPressEventArgs e)
        {
            HunColumnErp column = this.Columns[this.CurrentCell.ColumnIndex] as HunColumnErp;

            if (string.IsNullOrEmpty(column.EnabledChars))
            {
                return;
            }

            if (!column.EnabledChars.Contains(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void HunDataGridViewErp_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && this.Columns[e.ColumnIndex] is HunColumnErp)
            {
                MessageBox.Show("Right mouse button pressed");

                this.Focus();
            }
        }

        public bool CheckRequired(out string columnHeaderText)
        {
            columnHeaderText = string.Empty;

            foreach (DataGridViewRow row in this.Rows)
            {
                bool hasValue = false;
                bool existsEmptyCell = false;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (!(cell.OwningColumn is HunColumnBase)) continue;

                    HunColumnBase column = cell.OwningColumn as HunColumnBase;

                    if (!string.IsNullOrEmpty(cell.Value?.ToString()))
                    {
                        hasValue = true;
                    }

                    if (column.Required && string.IsNullOrEmpty(cell.Value?.ToString()) && !existsEmptyCell)
                    {
                        columnHeaderText = column.HeaderText;
                        existsEmptyCell = true;
                    }
                }

                if (hasValue && existsEmptyCell)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
