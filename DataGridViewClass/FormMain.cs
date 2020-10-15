using DataGridLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewClass
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            StoreCode.DescriptionColumn = StoreName;
        }

        private string GetDataPropertyList()
        {
            // Some experimenting...
            var props = new StringBuilder();

            foreach (DataGridViewColumn column in dataGridViewEditableTest.Columns)
            {
                if (!string.IsNullOrEmpty(column.DataPropertyName))
                {
                    if (props.Length > 0) props.Append(", ");

                    props.Append(column.DataPropertyName);
                }
            }

            return props.ToString();
        }

        private void buttonGetDataPropertyList_Click(object sender, EventArgs e)
        {
            textBoxDataPropertyList.Text = GetDataPropertyList();
        }

        private string GetGridValues()
        {
            // Some experimenting...
            var values = new StringBuilder();

            foreach (DataGridViewRow row in dataGridViewEditableTest.Rows)
            {
                bool firstRow = true;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (!(cell.OwningColumn is HunColumnBase)) continue;

                    values.Append($"{(firstRow ? string.Empty : ", ")}{cell.Value?.ToString()}");

                    if (firstRow) firstRow = false;
                }

                values.AppendLine();
            }

            return values.ToString();
        }

        private void buttonGetValues_Click(object sender, EventArgs e)
        {
            textBoxValues.Text = GetGridValues();
        }
    }
}
