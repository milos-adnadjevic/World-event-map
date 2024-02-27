using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApp2.Controller;
using WpfApp2.Model;

namespace WpfApp2.Validations
{
    public class TypeIdValidation  : ValidationRule
    {

        public static EventTypeController eventTypeController = new EventTypeController();
        List<EventType> alleventsType = new List<EventType>();

        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            alleventsType = eventTypeController.GetAll();
            if(alleventsType == null || alleventsType.Count == 0)
            {
                return new ValidationResult(true, null);
            }
            try
            {

                bool ok = false;
                bool notOk = false;
                var s = value as string;

                foreach (EventType e in alleventsType)
                {
                    if (e.Id != s) { ok = true; }
                    else { notOk = true; }
                }

                if (ok && notOk == false)
                {
                    return new ValidationResult(true, null);
                }
                return new ValidationResult(false, "Id already in use");
            }
            catch
            {
                return new ValidationResult(false, "Unknown error occured.");
            }
        }

    }
}

