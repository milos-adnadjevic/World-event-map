﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApp2.Controller;
using WpfApp2.Model;
using WpfApp2.View;

namespace WpfApp2.Validations
{
    internal class TagIdValidation : ValidationRule
    {
        
        
            public static EventTagController eventTagController = new EventTagController();
            List<EventTag> alleventsTag = new List<EventTag>();

            public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
            {
                alleventsTag = eventTagController.GetAll();
            if (alleventsTag == null || alleventsTag.Count == 0)
            {
                return new ValidationResult(true, null);
            }
            try
                {

                    bool ok = false;
                    bool notOk = false;
                    var s = value as string;

                    foreach (EventTag e in alleventsTag)
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

