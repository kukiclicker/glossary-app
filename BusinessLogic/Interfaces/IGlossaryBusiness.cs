using DataLayer.DAL;
using DataLayer.DAO;
using System.Collections.Generic;

namespace BusinessLogic.Interfaces
{
    public interface IGlossaryBusiness
    {
        IEnumerable<GlossaryDAO> GetAll();
        string GetDefinitionByTerm(string term);
        Glossary CreateGlossary(string term, string definition);
        void Insert(Glossary glossary);
        void Update(Glossary glossary);
        void Delete(string term);
        int NumberOfTerms();
    }
}
