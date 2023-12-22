using DataLayer.DAL;
using DataLayer.DAO;
using System.Collections.Generic;


namespace DataLayer.Interfaces
{
    public interface IGlossaryRepository
    {
        IEnumerable<GlossaryDAO> GetAll();
        void Insert(Glossary glossary);
        void Update(Glossary glossary);
        void Delete(string term);
        Glossary CreateGlossary(string term, string definition);
    }
}
