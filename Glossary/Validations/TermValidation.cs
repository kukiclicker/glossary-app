using GlossaryForm.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GlossaryForm.Validation
{
    public class TermValidation : Validation,ITermValidation
    {
        public override bool IsFieldValid(string field)
        {
            string termPattern = "^(?=.*[a-zA-Z])[a-zA-Z0-9\\s\\-,.()]{1,255}$";
            return Regex.IsMatch(field,termPattern);
        }
    }
}
