using DataLayer.DAL;
using DataLayer.DAO;
using DataLayer.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer
{
    public class GlossaryRepository : IGlossaryRepository
    {
        private readonly GlossaryAppDBEntities _dbContext;
        public GlossaryRepository(GlossaryAppDBEntities context)
        {
            _dbContext = context;
        }

        public Glossary CreateGlossary(string term, string definition)
        {
            return new Glossary(term, definition);
        }

        public void Delete(string term)
        {
            var glossary = _dbContext.GLOSSARIES.Where(x => x.Term.Equals(term)).First();
            if (glossary != null)
            {
                _dbContext.GLOSSARIES.Remove(glossary);
                _dbContext.SaveChanges();
            }
        }

        public IEnumerable<GlossaryDAO> GetAll()
        {
            return _dbContext.GLOSSARIES.Select(x=> new GlossaryDAO(){Definition=x.Definition,Term = x.Term}).OrderBy(x=>x.Term).ToList();
        }
        public void Insert(Glossary glossary)
        {
            _dbContext.GLOSSARIES.Add(glossary);
            _dbContext.SaveChanges();
        }
        

        public void Update(Glossary glossary)
        {
            var oldGlossary = _dbContext.GLOSSARIES.SingleOrDefault(x => x.Term == glossary.Term);
            if (oldGlossary != null)
            {
                oldGlossary.Term = glossary.Term;
                oldGlossary.Definition = glossary.Definition;
                _dbContext.SaveChanges();
            }
        }
    }
}
