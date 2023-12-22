namespace GlossaryForm.Interfaces
{
    public interface ITermValidation:IValidation
    {
        new bool IsFieldValid(string field);
    }
}
