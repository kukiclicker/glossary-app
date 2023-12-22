
using DataLayer;
using DataLayer.DAL;
using DataLayer.DAO;
using DataLayer.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;


namespace GlossaryAppTests
{
    [TestClass]
    public class DataLayerTests
    {
        public readonly Mock<GlossaryAppDBEntities> mockDBContext= new Mock<GlossaryAppDBEntities>();

        [TestMethod]
        [DataRow("gaze","stare into something for too long")]
        public void CreateGlossary_ReturnsNewGlossary(string term, string definition)
        {
            var glossary = new GlossaryRepository(mockDBContext.Object);

            var result = glossary.CreateGlossary(term, definition);

            Assert.IsNotNull(result);
            Assert.AreEqual(result.Term, term);
            Assert.AreEqual(result.Definition, definition);
        }
        [TestMethod]
        [DataRow("hat")]
        public void Delete_DeletesGlossaryByTerm(string term)
        {
            // Arrange
             List<Glossary> glossaries = new List<Glossary>
             {
                 new Glossary { Term = "hat", Definition = "part of clothes you can put on your head" },
                 new Glossary { Term = "glasses", Definition = "something you wear to see better" }
             };
            var mockDbSet = new Mock<DbSet<Glossary>>();

            // Setup behavior for the DbSet
            mockDbSet.As<IQueryable<Glossary>>().Setup(m => m.Provider).Returns(glossaries.AsQueryable().Provider);
            mockDbSet.As<IQueryable<Glossary>>().Setup(m => m.Expression).Returns(glossaries.AsQueryable().Expression);
            mockDbSet.As<IQueryable<Glossary>>().Setup(m => m.ElementType).Returns(glossaries.AsQueryable().ElementType);
            mockDbSet.As<IQueryable<Glossary>>().Setup(m => m.GetEnumerator()).Returns(() => glossaries.GetEnumerator());

            // Setup behavior for the Remove method
            mockDbSet.Setup(m => m.Remove(It.IsAny<Glossary>())).Callback((Glossary entity) => glossaries.Remove(entity));

            // Setup context to return the mock DbSet
            mockDBContext.Setup(db => db.GLOSSARIES).Returns(mockDbSet.Object);

            var glossaryRepository = new GlossaryRepository(mockDBContext.Object);

            // Act
            glossaryRepository.Delete(term);

            // Assert
            mockDBContext.Verify(db => db.SaveChanges(), Times.Once);

            // Ensure the item is removed from the list
            Assert.AreEqual(1, glossaries.Count);

            // Ensure the Delete method removes the item
            Assert.IsFalse(glossaries.Any(g => g.Term == term));
        }
        [TestMethod]
        public void GetAll_ReturnsGlossaryList()
        {
            // Arrange
            var glossaryEntities = new List<Glossary>
            {
                new Glossary { Term = "hat", Definition = "part of clothes you can put on your head" },
                new Glossary { Term = "glasses", Definition = "something you wear to see better" }
            };

            var expectedGlossaries = glossaryEntities
                .Select(x => new GlossaryDAO { Term = x.Term , Definition= x.Definition})
                .OrderBy(x => x.Term)
                .ToList();

            var mockDbSet = new Mock<DbSet<Glossary>>();
            mockDbSet.As<IQueryable<Glossary>>().Setup(m => m.Provider).Returns(glossaryEntities.AsQueryable().Provider);
            mockDbSet.As<IQueryable<Glossary>>().Setup(m => m.Expression).Returns(glossaryEntities.AsQueryable().Expression);
            mockDbSet.As<IQueryable<Glossary>>().Setup(m => m.ElementType).Returns(glossaryEntities.AsQueryable().ElementType);
            mockDbSet.As<IQueryable<Glossary>>().Setup(m => m.GetEnumerator()).Returns(() => glossaryEntities.GetEnumerator());

            mockDBContext.Setup(db => db.GLOSSARIES).Returns(mockDbSet.Object);

            var glossaryRepository = new GlossaryRepository(mockDBContext.Object);

            // Act
            var result = glossaryRepository.GetAll();

            // Assert
            Assert.AreEqual(result.Count(), expectedGlossaries.Count);
        }
        [TestMethod]
        public void Insert_AddsGlossaryToContextAndSavesChanges()
        {
            // Arrange
            var mockDbSet = new Mock<DbSet<Glossary>>();
            mockDBContext.Setup(db => db.GLOSSARIES).Returns(mockDbSet.Object);
            var glossaryRepository = new GlossaryRepository(mockDBContext.Object);
            var glossaryToAdd = new Glossary { Term = "pen", Definition = "can be used for writting on a paper" };

            // Act
            glossaryRepository.Insert(glossaryToAdd);

            // Assert
            mockDBContext.Verify(db => db.SaveChanges(), Times.Once);
            // Verify that the correct glossary was added
            mockDbSet.Verify(dbSet => dbSet.Add(glossaryToAdd), Times.Once);
        }
        [TestMethod]
        [DataRow("hat","can be used as sun protection")]
        public void Update_UpdatesGlossaryAndSavesChanges(string term,string definition)
        {
            // Arrange
            var glossaryEntities = new List<Glossary>
        {
            new Glossary { Term = "hat", Definition = "part of clothes you can put on your head" },
            new Glossary { Term = "glasses", Definition = "something you wear to see better" }
        };

            var mockDbSet = new Mock<DbSet<Glossary>>();
            mockDbSet.As<IQueryable<Glossary>>().Setup(m => m.Provider).Returns(glossaryEntities.AsQueryable().Provider);
            mockDbSet.As<IQueryable<Glossary>>().Setup(m => m.Expression).Returns(glossaryEntities.AsQueryable().Expression);
            mockDbSet.As<IQueryable<Glossary>>().Setup(m => m.ElementType).Returns(glossaryEntities.AsQueryable().ElementType);
            mockDbSet.As<IQueryable<Glossary>>().Setup(m => m.GetEnumerator()).Returns(() => glossaryEntities.GetEnumerator());

            mockDBContext.Setup(db => db.GLOSSARIES).Returns(mockDbSet.Object);

            var glossaryRepository = new GlossaryRepository(mockDBContext.Object);

            var updatedGlossary = new Glossary { Term = term, Definition = definition};

            // Act
            glossaryRepository.Update(updatedGlossary);

            // Verify that SaveChanges is called
            mockDBContext.Verify(db => db.SaveChanges(), Times.Once);

            var result = glossaryRepository.GetAll().Single(x=>x.Term==updatedGlossary.Term).Definition;
            //Assert
            Assert.AreEqual(result, updatedGlossary.Definition);
        }
    }
}
