using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sorting.Test
{
    [TestClass]
    public class InsertionSortTest
    {
        [TestMethod]
        public void InsertionSort_With_Valid_Input_Set()
        {
            InsertionSort<int> InsertionSort = new InsertionSort<int>();
            int[] unsortedArray = { 3, 4, 8, 9, 6, 2, 1, 7, 5 };
            var actual = InsertionSort.Sort(unsortedArray);
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            CollectionAssert.AreEqual(expected, actual);
        }



      

    }
}
    

