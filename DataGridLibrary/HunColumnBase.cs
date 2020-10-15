using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridLibrary
{
    /// <summary>
    /// DataGridView TextBoxColumn base class
    /// </summary>
    public abstract class HunColumnBase : DataGridViewTextBoxColumn
    {
        #region Properties
        [Category("Kapitany"),
         DefaultValue(false)]
        public bool Required { get; set; }
        #endregion

        #region Constructors
        protected HunColumnBase()
        {
            this.Required = false;
        }
        #endregion

        public override object Clone()
        {
            HunColumnBase column = base.Clone() as HunColumnBase;

            column.Required = this.Required;

            return column;
        }
    }
}
