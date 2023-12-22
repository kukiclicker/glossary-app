using Glossary.Interfaces;
using GlossaryForm.Validation;
using System.Text.RegularExpressions;

namespace Glossary.Validations
{
    public class DefinitionValidation : Validation, IDefinitionValidation
    {
        public override bool IsFieldValid(string field)
        {
            string definitionPattern = "^(?=.*[a-zA-Z])[a-zA-Z0-9\\s\\-,.()\'\"]+$";
            return Regex.IsMatch(field,definitionPattern);
        }
    }
}
