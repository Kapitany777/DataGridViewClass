namespace DataGridViewClass
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewEditable1 = new DataGridLibrary.HunDataGridViewErp();
            this.StoreCode = new DataGridLibrary.IsColumnStoreCode();
            this.StoreName = new DataGridLibrary.HunColumnInfo();
            this.CustomerCode = new DataGridLibrary.IsColumnCustomerCode();
            this.CustomerName = new DataGridLibrary.HunColumnInfo();
            this.IntegerQuantity = new DataGridLibrary.HunColumnInteger();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditable1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEditable1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewEditable1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEditable1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEditable1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEditable1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StoreCode,
            this.StoreName,
            this.CustomerCode,
            this.CustomerName,
            this.IntegerQuantity});
            this.dataGridViewEditable1.Location = new System.Drawing.Point(20, 12);
            this.dataGridViewEditable1.Name = "dataGridViewEditable1";
            this.dataGridViewEditable1.Size = new System.Drawing.Size(768, 348);
            this.dataGridViewEditable1.TabIndex = 0;
            // 
            // StoreCode
            // 
            this.StoreCode.DescriptionColumn = null;
            this.StoreCode.HeaderText = "Store code";
            this.StoreCode.MaxInputLength = 4;
            this.StoreCode.Name = "StoreCode";
            this.StoreCode.Required = true;
            // 
            // StoreName
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.StoreName.DefaultCellStyle = dataGridViewCellStyle2;
            this.StoreName.HeaderText = "Store name";
            this.StoreName.Name = "StoreName";
            this.StoreName.ReadOnly = true;
            this.StoreName.Width = 200;
            // 
            // CustomerCode
            // 
            this.CustomerCode.DescriptionColumn = null;
            this.CustomerCode.HeaderText = "Customer code";
            this.CustomerCode.MaxInputLength = 8;
            this.CustomerCode.Name = "CustomerCode";
            this.CustomerCode.Required = true;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // IntegerQuantity
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            this.IntegerQuantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.IntegerQuantity.HeaderText = "Integer quantity";
            this.IntegerQuantity.Name = "IntegerQuantity";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewEditable1);
            this.Name = "FormMain";
            this.Text = "DataGridView test";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditable1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridLibrary.HunDataGridViewErp dataGridViewEditable1;
        private DataGridLibrary.IsColumnStoreCode StoreCode;
        private DataGridLibrary.HunColumnInfo StoreName;
        private DataGridLibrary.IsColumnCustomerCode CustomerCode;
        private DataGridLibrary.HunColumnInfo CustomerName;
        private DataGridLibrary.HunColumnInteger IntegerQuantity;
    }
}

