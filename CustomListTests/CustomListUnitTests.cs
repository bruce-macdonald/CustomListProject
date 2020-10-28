using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListUnitTestStarter;

namespace CustomListTests
{
    [TestClass]
    public class CustomListUnitTests
    {
        [TestMethod]
        public void Add_AddItemToEmptyList_ItemGoesToIndexZero()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int item = 10;
            int expected = 10;
            int actual;

            // Act
            testList.Add(item);
            actual = testList[0]; // error expected until "indexer property" is added to class

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Add_AddItemToEmptyList_CountIncrementsToOne()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int item = 10;
            int expected = 1;
            int actual;

            // Act
            testList.Add(item);
            actual = testList.Count; // error expected until "Count" is added to class

            // Assert
            Assert.AreEqual(expected, actual);
        }


        // how does the Capacity change as you add things? (starts at 4, and doubles)
        [TestMethod]
        public void Add_AddItemToListAtMaxCapacity_ArrayDoublesInSize()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int item = 10;
            int expected = 8;
            int actual;

            // Act
            testList.Add(item);
            testList.Add(item);
            testList.Add(item);
            testList.Add(item);
            testList.Add(item);
            actual = testList.Capacity; // error expected until "Capacity" is added to class

            // Assert
            Assert.AreEqual(expected, actual);
        }



        // what if i .Add to a list that has a couple things in it already (position of item)?
        [TestMethod]
        public void Add_AddThreeItemsToList_ThirdItemGoesToIndexTwo()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int item1 = 15;
            int item2 = 35;
            int item3 = 55;
            int expected = 55;
            int actual;

            // Act
            testList.Add(item1);
            testList.Add(item2);
            testList.Add(item3);
            actual = testList[2]; // error expected until "indexer property" is added to class

            // Assert
            Assert.AreEqual(expected, actual);
        }



        // what if i .Add to a list that has a couple things in it already (value of Count)?
        [TestMethod]
        public void Add_AddItemsToList_CountIncrementsToFour()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int item = 10;
            int expected = 4;
            int actual;

            // Act
            testList.Add(item);
            testList.Add(item);
            testList.Add(item);
            testList.Add(item);
            actual = testList.Count; // error expected until "Count" is added to class

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddItemToListAtMaxCapacity_ArrayAdjustsAndKeepsValuesFromFirstArray()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int item1 = 6;
            int item2 = 1;
            int item3 = 83;
            int item4 = 25;
            int item5 = 10;
            int expected = 83;
            int actual;

            // Act
            testList.Add(item1);
            testList.Add(item2);
            testList.Add(item3);
            testList.Add(item4);
            testList.Add(item5);
            actual = testList[2]; // error expected until "Indexer" is added to class

            // Assert           
            Assert.AreEqual(expected, actual);
        }

        // REMOVE TESTS:
        [TestMethod]
        public void Remove_RemoveItemFromList_CountDecrementsByOne()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int item = 10;
            int expected = 1;
            int actual;

            // Act
            testList.Add(item);
            testList.Add(item);
            testList.Remove(item);
            actual = testList.Count; 

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveItemFromList_IndexesSwitchProperly()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int item1 = 13;
            int item2 = 58;
            int item3 = 26;
            int item4 = 44;
            int expected = 44;
            int actual;

            // Act
            testList.Add(item1);
            testList.Add(item2);
            testList.Add(item3);
            testList.Add(item4);
            testList.Remove(item3);
            actual = testList[2];

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        //[HandleException]
        //attribute for exceptions
        public void Remove_RemoveItemThatDoesntExist_DoNothing()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int item = 10;
            int expected = 0;
            int actual;

            // Act
            testList.Add(0);
            testList.Remove(15);            
            actual = testList[0];

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveDuplicateItem_RemoveFirstInstanceOnly()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();                        
            int expected = 10;
            int actual;

            // Act
            testList.Add(10);
            testList.Add(15);
            testList.Add(17);
            testList.Add(14);
            testList.Add(25);
            testList.Add(10);
            testList.Remove(10);
            actual = testList[4];

            // Assert
            Assert.AreEqual(expected, actual);
        }



    }
}
