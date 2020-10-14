using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridLibrary
{
    /// <summary>
    /// DataGridView Customer column
    /// </summary>
    public class IsColumnCustomerCode : HunColumnErp
    {
        #region Constructors
        public IsColumnCustomerCode()
        {
            this.ErrorMessage = "Invalid customer code!";
        }
        #endregion

        public override bool ReadDescription(string value)
        {
            // Some fake data
            switch (value)
            {
                case "1":
                    this.Description = "Uncle Bob";
                    break;

                case "2":
                    this.Description = "Uncle John";
                    break;

                case "9999":
                    this.Description = "Herr Müller";
                    break;

                default:
                    return false;
            }
            
            return true;
        }
    }
}
