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
    public class NameValidation : ValidationRule
    {

        public static EventController eventController = new EventController();
        List<Event> allevents = new List<Event>();

        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            allevents = eventController.GetAll();
            if (allevents == null || allevents.Count == 0)
            {
                return new ValidationResult(true, null);
            }
            try
            {

                bool ok = false;
                bool notOk = false;
                var s = value as string;

                foreach (Event e in allevents)
                {
                    if (e.Name != s) { ok = true; }
                    else { notOk = true; }
                }

                if (ok && notOk == false)
                {
                    return new ValidationResult(true, null);
                }
                return new ValidationResult(false, "Name already in use");
            }
            catch
            {
                return new ValidationResult(false, "Unknown error occured.");
            }
        }
    }
}
