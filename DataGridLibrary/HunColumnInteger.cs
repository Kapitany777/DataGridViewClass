using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridLibrary
{
    /// <summary>
    /// DataGridView TextBoxColumn for integer numbers
    /// </summary>
    public class HunColumnInteger : HunColumnBase
    {
        #region Constructors
        public HunColumnInteger()
        {
            this.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.DefaultCellStyle.Format = "N0";
            this.ValueType = typeof(int);
        }
        #endregion
    }
}
