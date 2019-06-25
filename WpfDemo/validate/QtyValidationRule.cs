using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfDemo.validate
{
    class IntValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            
            int qty = 0;
            if (int.TryParse(value.ToString(), out qty))
            {
                if (qty > 90)
                {
                    return new ValidationResult(false, "Over the quantity of MES Lot");
                }
                return new ValidationResult(true, null);
            }
            else
            {
                if (string.IsNullOrEmpty(value.ToString().Trim()))
                {
                    return new ValidationResult(true, null);
                }
                return new ValidationResult(false, "qty Must be an integer");
            }
            
        }
    }
}
