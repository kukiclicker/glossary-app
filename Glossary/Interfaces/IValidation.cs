namespace GlossaryForm.Interfaces
{
    public interface IValidation
    {
        bool IsFieldValid(string field);
        bool IsFieldEmpthy(string field);

    }
}
