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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewEditableTest = new DataGridLibrary.HunDataGridViewErp();
            this.StoreCode = new DataGridLibrary.IsColumnStoreCode();
            this.StoreName = new DataGridLibrary.HunColumnInfo();
            this.CustomerCode = new DataGridLibrary.IsColumnCustomerCode();
            this.CustomerName = new DataGridLibrary.HunColumnInfo();
            this.IntegerQuantity = new DataGridLibrary.HunColumnInteger();
            this.buttonGetDataPropertyList = new System.Windows.Forms.Button();
            this.textBoxDataPropertyList = new System.Windows.Forms.TextBox();
            this.buttonGetValues = new System.Windows.Forms.Button();
            this.textBoxValues = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditableTest)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEditableTest
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewEditableTest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewEditableTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEditableTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEditableTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StoreCode,
            this.StoreName,
            this.CustomerCode,
            this.CustomerName,
            this.IntegerQuantity});
            this.dataGridViewEditableTest.Location = new System.Drawing.Point(20, 12);
            this.dataGridViewEditableTest.Name = "dataGridViewEditableTest";
            this.dataGridViewEditableTest.Size = new System.Drawing.Size(1054, 348);
            this.dataGridViewEditableTest.TabIndex = 0;
            // 
            // StoreCode
            // 
            this.StoreCode.DataPropertyName = "store_code";
            this.StoreCode.DescriptionColumn = null;
            this.StoreCode.HeaderText = "Store code";
            this.StoreCode.MaxInputLength = 4;
            this.StoreCode.Name = "StoreCode";
            this.StoreCode.Required = true;
            // 
            // StoreName
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.StoreName.DefaultCellStyle = dataGridViewCellStyle5;
            this.StoreName.HeaderText = "Store name";
            this.StoreName.Name = "StoreName";
            this.StoreName.ReadOnly = true;
            this.StoreName.Width = 200;
            // 
            // CustomerCode
            // 
            this.CustomerCode.DataPropertyName = "customer_code";
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
            this.IntegerQuantity.DataPropertyName = "quantity";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            this.IntegerQuantity.DefaultCellStyle = dataGridViewCellStyle6;
            this.IntegerQuantity.HeaderText = "Integer quantity";
            this.IntegerQuantity.Name = "IntegerQuantity";
            // 
            // buttonGetDataPropertyList
            // 
            this.buttonGetDataPropertyList.Location = new System.Drawing.Point(24, 376);
            this.buttonGetDataPropertyList.Name = "buttonGetDataPropertyList";
            this.buttonGetDataPropertyList.Size = new System.Drawing.Size(156, 48);
            this.buttonGetDataPropertyList.TabIndex = 1;
            this.buttonGetDataPropertyList.Text = "Get data property list";
            this.buttonGetDataPropertyList.UseVisualStyleBackColor = true;
            this.buttonGetDataPropertyList.Click += new System.EventHandler(this.buttonGetDataPropertyList_Click);
            // 
            // textBoxDataPropertyList
            // 
            this.textBoxDataPropertyList.Location = new System.Drawing.Point(196, 388);
            this.textBoxDataPropertyList.Name = "textBoxDataPropertyList";
            this.textBoxDataPropertyList.Size = new System.Drawing.Size(548, 20);
            this.textBoxDataPropertyList.TabIndex = 2;
            // 
            // buttonGetValues
            // 
            this.buttonGetValues.Location = new System.Drawing.Point(24, 436);
            this.buttonGetValues.Name = "buttonGetValues";
            this.buttonGetValues.Size = new System.Drawing.Size(156, 48);
            this.buttonGetValues.TabIndex = 3;
            this.buttonGetValues.Text = "Get values";
            this.buttonGetValues.UseVisualStyleBackColor = true;
            this.buttonGetValues.Click += new System.EventHandler(this.buttonGetValues_Click);
            // 
            // textBoxValues
            // 
            this.textBoxValues.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxValues.Location = new System.Drawing.Point(196, 436);
            this.textBoxValues.Multiline = true;
            this.textBoxValues.Name = "textBoxValues";
            this.textBoxValues.Size = new System.Drawing.Size(552, 148);
            this.textBoxValues.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 595);
            this.Controls.Add(this.textBoxValues);
            this.Controls.Add(this.buttonGetValues);
            this.Controls.Add(this.textBoxDataPropertyList);
            this.Controls.Add(this.buttonGetDataPropertyList);
            this.Controls.Add(this.dataGridViewEditableTest);
            this.Name = "FormMain";
            this.Text = "DataGridView test";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditableTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridLibrary.HunDataGridViewErp dataGridViewEditableTest;
        private DataGridLibrary.IsColumnStoreCode StoreCode;
        private DataGridLibrary.HunColumnInfo StoreName;
        private DataGridLibrary.IsColumnCustomerCode CustomerCode;
        private DataGridLibrary.HunColumnInfo CustomerName;
        private DataGridLibrary.HunColumnInteger IntegerQuantity;
        private System.Windows.Forms.Button buttonGetDataPropertyList;
        private System.Windows.Forms.TextBox textBoxDataPropertyList;
        private System.Windows.Forms.Button buttonGetValues;
        private System.Windows.Forms.TextBox textBoxValues;
    }
}

