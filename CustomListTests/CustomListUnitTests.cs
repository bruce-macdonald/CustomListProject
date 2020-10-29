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
            actual = testList[0];

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
            actual = testList.Count; 

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
            actual = testList.Capacity; 

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
            actual = testList[2]; 

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
            actual = testList.Count;

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
            actual = testList[2];

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

        [TestMethod]
        public void ToString__GiveACustomList_CustomListIsConvertedToString()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int item = 10;
            string expected = "10";
            string actual;
            // Act
            testList.Add(item);
            actual = testList.ToString();
            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void ToString__GiveACustomListOfMultipleItems_CustomListIsConvertedToString()
        {
            // Arrange
            CustomList<bool> testList = new CustomList<bool>();
            bool thing1 = false;
            bool thing2 = true;
            string expected = "falsetrue";
            string actual;
            // Act
            testList.Add(thing1);
            testList.Add(thing2);
            actual = testList.ToString();
            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void PlusOperator__GiveMultipleLists_ListsAreAddedTogether()
        {
            // Arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            int item1 = 12;
            int item2 = 16;
            CustomList<int> expected = new CustomList<int>();
            CustomList<int> actual = new CustomList<int>();
            // Act
            expected.Add(item1);
            expected.Add(item2);
            expected.Add(item1);
            expected.Add(item2);
            testList1.Add(item1);
            testList1.Add(item2);
            testList2.Add(item1);
            testList2.Add(item2);
            actual = testList1 + testList2;
            // Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod]
        public void MinusOperator__GiveMultipleListsThenSubtractOne_SubtractedDataWillBeGone()
        {
            // Arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            int item1 = 1;
            int item2 = 2;
            int item3 = 3;
            int item5 = 5;
            int item6 = 6;
            CustomList<int> expected = new CustomList<int>();
            CustomList<int> actual = new CustomList<int>();
            // Act
            expected.Add(item3);
            expected.Add(item5);
            testList1.Add(item1);
            testList1.Add(item3);
            testList1.Add(item5);
            testList2.Add(item1);
            testList2.Add(item2);
            testList2.Add(item6);
            actual = testList1 - testList2;
            // Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }


    }
}
