using BusinessLogic.Interfaces;
using DataLayer.DAL;
using DataLayer.DAO;
using DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic
{
    public class GlossaryBusiness:IGlossaryBusiness
    {
        private readonly IGlossaryRepository glossaryRepository;
        public GlossaryBusiness(IGlossaryRepository _glossaryRepository)
        {
            glossaryRepository = _glossaryRepository;
        }

        public Glossary CreateGlossary(string term, string definition)
        {
            return glossaryRepository.CreateGlossary(term, definition);
        }

        public void Delete(string term)
        {
            glossaryRepository.Delete(term);
        }

        public IEnumerable<GlossaryDAO> GetAll()
        {
            return glossaryRepository.GetAll();
        }

        public string GetDefinitionByTerm(string term)
        {
            var glossary = glossaryRepository.GetAll()
                .Where(x => x.Term.Equals(term, StringComparison.OrdinalIgnoreCase))
                .FirstOrDefault();
            return glossary != null ? glossary.Definition: "";
        }

        public void Insert(Glossary glossary)
        {
            bool termExists = TermExists(glossary.Term);
            if (termExists)
            {
                throw new ArgumentException("Term already exist!");
            }
            glossary.Term = glossary.Term.ToLower();
            glossaryRepository.Insert(glossary);
        }
        public void Update(Glossary glossary)
        {
            bool termExists = TermExists(glossary.Term);
            if (!termExists)
            {
                throw new ArgumentException("Term doesn't exist!");
            }
            glossary.Term = glossary.Term.ToLower();
            glossaryRepository.Update(glossary);
        }
        public int NumberOfTerms()
        {
            return GetAll().Count();
        }
        public bool TermExists(string term)
        {
            return GetAll().Any(x => x.Term == term);
        }
    }
}
