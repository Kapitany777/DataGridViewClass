using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataGridLibrary
{
    /// <summary>
    /// DataGridView Store column
    /// </summary>
    public class IsColumnStoreCode : HunColumnErp
    {
        #region Constructors
        public IsColumnStoreCode()
        {
            this.ErrorMessage = "Invalid store code!";

            this.MaxInputLength = 4;
        }
        #endregion

        public override bool ReadDescription(string value)
        {
            // Some fake data
            if (!value.StartsWith("K"))
            {
                return false;
            }

            this.Description = $"{value}: this is a really big store";

            return true;
        }
    }
}
