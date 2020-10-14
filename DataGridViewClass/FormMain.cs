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
    }
}
