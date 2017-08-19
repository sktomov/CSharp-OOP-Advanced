namespace BashSoftTesting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using BashSoft.Contracts;
    using BashSoft.DataStructures;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class OrderedDataStructureTester
    {
        private ISimpleOrderedBag<string> names;

        [TestInitialize]
        public void SetUp()
        {
            this.names = new SimpleSortedList<string>();
        }

        [TestMethod]
        public void TestEmptyCtor()
        {
            //Arrange
            this.names = new SimpleSortedList<string>();
            //Act

            //Assert
            Assert.AreEqual(this.names.Capacity, 16);
            Assert.AreEqual(this.names.Size, 0);
        }

        [TestMethod]
        public void TestCtorWithInitialCapacity()
        {
            //Arrange
            this.names = new SimpleSortedList<string>(20);
            //Act

            //Assert
            Assert.AreEqual(this.names.Capacity, 20);
            Assert.AreEqual(this.names.Size, 0);
        }

        [TestMethod]
        public void TestCtorWithAllParams()
        {
            //Arrange
            this.names = new SimpleSortedList<string>(30, StringComparer.OrdinalIgnoreCase);
            //Act

            //Assert
            Assert.AreEqual(this.names.Capacity, 30);
            Assert.AreEqual(this.names.Size, 0);
        }

        [TestMethod]
        public void TestCtorWithInitialComparer()
        {
            //Arrange
            this.names = new SimpleSortedList<string>(StringComparer.OrdinalIgnoreCase);
            //Act

            //Assert
            Assert.AreEqual(this.names.Capacity, 16);
            Assert.AreEqual(this.names.Size, 0);
        }

        [TestMethod]
        public void TestAddIncreasesSize()
        {
            //Arrange

            //Act
            this.names.Add("Nasko");
            //Assert
            Assert.AreEqual(1, this.names.Size);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestAddNullThrowsException()
        {
            //Arrange

            //Act
            this.names.Add(null);
            //Assert
        }

        [TestMethod]
        public void TestAddUnsortedDataIsHeldSorted()
        {
            //Arrange
            var expextedList = new List<string>()
            {
                "Balkan",
                "Georgi",
                "Rosen"
            };
            //Act
            this.names.Add("Rosen");
            this.names.Add("Georgi");
            this.names.Add("Balkan");
            var current = this.names.Take(3).ToList();

            //Assert
            CollectionAssert.AreEqual(expextedList,current);
        }

        [TestMethod]
        public void TestAddingMoreThanInitialCapacity()
        {
            //Arrange

            //Act
            for (int i = 0; i < 17; i++)
            {
                this.names.Add($"a + {i}");
            }
            //Assert
            Assert.AreEqual(17, this.names.Size);
            Assert.AreNotEqual(16, this.names.Capacity);

        }

        [TestMethod]
        public void TestAddingAllFromCollectionIncreasesSize()
        {
            //Arrange
           
            var listToAdd = new List<string>()
            {
                "Ivan",
                "Baio"
            };
            //Act
            this.names.AddAll(listToAdd);

            //Assert
            Assert.AreEqual(2, this.names.Size);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAddingAllFromNullThrowsException()
        {
            //Arrange
            var listToAdd = new List<string>()
            {
                "Ivan",
                "Baio"
            };
            //Act
            this.names.AddAll(listToAdd);

            //Assert
            
        }

        [TestMethod]
        public void TestAddAllKeepsSorted()
        {
            //Arrange
            var expextedList = new List<string>()
            {
                "Baio",
                "Ivan"
            };
            var listToAdd = new List<string>()
            {
                "Ivan",
                "Baio"
            };
            //Act
            this.names.AddAll(listToAdd);
            var current = this.names.Take(2).ToList();

            //Assert
            CollectionAssert.AreEqual(expextedList, current);
        }

        [TestMethod]
        public void TestRemoveValidElementDecreasesSize()
        {
            //Arrange
            var element = "Test";
            //Act
            this.names.Add(element);
            this.names.Remove(element);
            //Assert
            Assert.AreEqual(0, this.names.Size);
        }

        [TestMethod]
        public void TestRemoveValidElementRemovesSelectedOne()
        {
            //Arrange
            this.names.Add("Ivan");
            this.names.Add("Nasko");
            //Act
            this.names.Remove("Nasko");
            //Assert
            CollectionAssert.DoesNotContain(this.names.ToList(), "Nasko");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestRemovingNullThrowsException()
        {
            //Arrange

            //Act
            this.names.Remove(null);
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestJoinWithNull()
        {
            //Arrange

            //Act
            this.names.JoinWith(null);
            //Assert
        }

        [TestMethod]
        public void TestJoinWorksFine()
        {
            //Arrange
            var expected = "Pesho-!" + "Yanko";

            this.names.Add("Pesho");
            this.names.Add("Yanko");

            //Act
            var current = this.names.JoinWith("-!");
            //Assert
            Assert.AreEqual(expected, current);
        }
    }
}
