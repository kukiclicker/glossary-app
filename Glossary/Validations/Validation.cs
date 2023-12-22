using GlossaryForm.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GlossaryForm.Validation
{
    public class Validation:IValidation
    {
        public virtual bool IsFieldEmpthy(string field)
        {
            return string.IsNullOrEmpty(field);
        }
        public virtual bool IsFieldValid(string field)
        {
            string defaultFieldPattern = "^[a-zA-Z]+$";
            return Regex.IsMatch(field,defaultFieldPattern);
        }
    }
}
