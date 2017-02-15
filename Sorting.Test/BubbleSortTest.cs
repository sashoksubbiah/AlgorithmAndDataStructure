using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorting;

namespace Sorting.Test
{
    [TestClass]
    public class BubbleSortTest
    {
        
        [TestMethod]
        public void BubbleSort_With_Valid_Input_Set()
        {
            BubbleSort<int> BubbleSort = new BubbleSort<int>();
            int[] unsortedArray = {  3, 4 ,8, 9, 6, 2, 1, 7, 5  };
            var actual = BubbleSort.Sort(unsortedArray);
            int[]  expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            CollectionAssert.AreEqual(expected, actual);

        }
    }
}
