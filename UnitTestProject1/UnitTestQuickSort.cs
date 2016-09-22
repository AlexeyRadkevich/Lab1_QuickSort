using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1_QuickSort;

namespace UnitTestQuickSort
{
    [TestClass]
    public class UnitTestQuickSort
    {
        [TestMethod]
        public void Test_Sort()
        {
            QuickSort<int> testSort = new QuickSort<int>();
            int[] arr = { 1, 4, 9, 2, 5, 7, 6, 8, 3 };
            int[] expArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            testSort.Sort(arr, 0, 8);
            CollectionAssert.AreEqual(arr, expArr);
        }

        [TestMethod]
        public void Test_SortNull()
        {
            QuickSort<int> testSort = new QuickSort<int>();
            int[] arr = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] expArr = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            testSort.Sort(arr, 0, 8);
            CollectionAssert.AreEqual(arr, expArr);
        }
    }
}
