using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Sorting.Test
{
    [TestClass]
    public class SelectionSortTest
    {
        [TestMethod]
        public void SelectionSort_With_Valid_Input()
        {
            SelectionSort<int> selectionSort = new SelectionSort<int>();
            int[] unsortedArray = { 3, 4, 8, 9, 6, 2, 1, 7, 5, 11, 13, 12, 19 };
            var actual = selectionSort.Sort(unsortedArray).ToArray();
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 13, 19 };
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
