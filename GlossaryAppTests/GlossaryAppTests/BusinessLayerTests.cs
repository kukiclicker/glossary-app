using BusinessLogic;
using DataLayer;
using DataLayer.DAL;
using DataLayer.DAO;
using DataLayer.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlossaryAppTests
{
    [TestClass]
    public class BusinessLayerTests
    {
        public readonly Mock<IGlossaryRepository> mockGlossaryRepository = new Mock<IGlossaryRepository>();

        [TestMethod]
        [DataRow("hat")]
        public void GetDefinitionByTerm_ReturnsCorrectDefinition(string term)
        {
            // Arrange
            var expectedDefinition = "part of clothes you can put on your head";

            mockGlossaryRepository.Setup(repo => repo.GetAll()).Returns(new List<GlossaryDAO>
            {
                new GlossaryDAO { Term = "hat", Definition = "part of clothes you can put on your head" },
                new GlossaryDAO { Term = "glasses", Definition = "something you wear to see better" }
            });

            var glossaryBusiness = new GlossaryBusiness(mockGlossaryRepository.Object);

            // Act
            var result = glossaryBusiness.GetDefinitionByTerm(term);

            // Assert
            Assert.AreEqual(expectedDefinition, result);
        }
        [TestMethod]
        [DataRow("cat")]
        public void GetDefinitionByTerm_WhenTermDoesntExist_ReturnsEmpthyString(string term)
        {
            // Arrange
            var expectedDefinition = "";

            mockGlossaryRepository.Setup(repo => repo.GetAll()).Returns(new List<GlossaryDAO>
            {
                new GlossaryDAO { Term = "hat", Definition = "part of clothes you can put on your head" },
                new GlossaryDAO { Term = "glasses", Definition = "something you wear to see better" }
            });

            var glossaryBusiness = new GlossaryBusiness(mockGlossaryRepository.Object);

            // Act
            var result = glossaryBusiness.GetDefinitionByTerm(term);

            // Assert
            Assert.AreEqual(expectedDefinition, result);
        }
        [TestMethod]
        public void NumberOfTerms_ReturnsNumberOfTurnsDefined()
        {
            // Arrange
            var expectedNumber = 2;
            mockGlossaryRepository.Setup(repo => repo.GetAll()).Returns(new List<GlossaryDAO>
            {
                new GlossaryDAO { Term = "hat", Definition = "part of clothes you can put on your head" },
                new GlossaryDAO { Term = "glasses", Definition = "something you wear to see better" }
            });

            var glossaryBusiness = new GlossaryBusiness(mockGlossaryRepository.Object);

            // Act
            var result = glossaryBusiness.NumberOfTerms();

            // Assert
            Assert.AreEqual(expectedNumber, result);
        }
        [TestMethod]
        public void NumberOfTerms_WhenNoTermsAreDefined_ReturnsZero()
        {
            // Arrange
            var expectedNumber = 0;
            mockGlossaryRepository.Setup(repo => repo.GetAll()).Returns(new List<GlossaryDAO>{});

            var glossaryBusiness = new GlossaryBusiness(mockGlossaryRepository.Object);

            // Act
            var result = glossaryBusiness.NumberOfTerms();

            // Assert
            Assert.AreEqual(expectedNumber, result);
        }
        [TestMethod]
        [DataRow("hat")]
        public void TermExists_WhenTermExist_ReturnTrue(string term)
        {
            // Arrange
            mockGlossaryRepository.Setup(repo => repo.GetAll()).Returns(new List<GlossaryDAO>
            {
                new GlossaryDAO { Term = "hat", Definition = "part of clothes you can put on your head" },
                new GlossaryDAO { Term = "glasses", Definition = "something you wear to see better" }
            });

            var glossaryBusiness = new GlossaryBusiness(mockGlossaryRepository.Object);

            // Act
            var result = glossaryBusiness.TermExists(term);

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        [DataRow("cat")]
        public void TermExists_WhenTermDoesntExist_ReturnFalse(string term)
        {
            // Arrange
            mockGlossaryRepository.Setup(repo => repo.GetAll()).Returns(new List<GlossaryDAO>
            {
                new GlossaryDAO { Term = "hat", Definition = "part of clothes you can put on your head" },
                new GlossaryDAO { Term = "glasses", Definition = "something you wear to see better" }
            });

            var glossaryBusiness = new GlossaryBusiness(mockGlossaryRepository.Object);

            // Act
            var result = glossaryBusiness.TermExists(term);

            // Assert
            Assert.IsFalse(result);
        }

    }
}
