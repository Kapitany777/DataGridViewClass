using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridLibrary
{
    public abstract class HunColumnErp : HunColumnBase
    {
        #region Properties
        [Browsable(false)]
        public string Description { get; protected set; }

        [Browsable(false)]
        public string ErrorMessage { get; protected set; }

        [Browsable(false)]
        public HunColumnInfo DescriptionColumn { get; set; }

        [Browsable(false)]
        public string EnabledChars { get; protected set; }
        #endregion

        #region Constructors
        public HunColumnErp()
        {
            this.ErrorMessage = string.Empty;
            this.EnabledChars = string.Empty;
        }
        #endregion

        public bool CheckValue(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                this.Description = string.Empty;
                return true;
            }

            return ReadDescription(value);
        }

        public abstract bool ReadDescription(string value);
    }
}
