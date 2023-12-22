using GlossaryForm.Interfaces;

namespace Glossary.Interfaces
{
    public interface IDefinitionValidation : IValidation
    {
        new bool IsFieldValid(string field);
    }
}
