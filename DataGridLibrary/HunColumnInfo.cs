using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridLibrary
{
    /// <summary>
    /// DataGridView TextBoxColumn read only column class for information
    /// </summary>
    public class HunColumnInfo : DataGridViewTextBoxColumn
    {
        public HunColumnInfo()
        {
            this.ReadOnly = true;
        }
    }
}
