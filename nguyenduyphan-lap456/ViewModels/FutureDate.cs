using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nguyenduyphan_lap456.ViewModels
{
    public class FutureDate : validationAttribute
    
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "dd/M/yyyy",
            CultureInfo.CurrentCulture,
            DateTimeStyles.None,
            out dateTime);

            return (isValid && dateTime > DateTime.Now);

        }

    }
}