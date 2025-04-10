using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procurement_System.Services
{
    public static class CurrencyFormat
    {

        public static string FormatCurrency(double value)
        {
            return value.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-PH"));
        }

        public static string FormatCurrency(string value)
        {
            return FormatCurrency(Convert.ToDouble(value));
        }
    }
}
