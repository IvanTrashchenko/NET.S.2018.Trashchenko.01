using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArrayIntegerExtensions.Tests
{
    [TestClass]
    public class ArrayIntegerExtensionTests
    {
        [TestMethod]
        public void MergeSort_WithPositiveNumbers_Success()
        {
            int[] array = { 3, 26, 5, 12, 1 };
            int[] expected = { 1, 3, 5, 12, 26 };

            ArrayIntegerExtension.MergeSort(array);

            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void MergeSort_WithPositiveAndNegativeNumbers_Success()
        {
            int[] array = { 34, -5, 12, 56, 1, 0, 7, 7, -7 };
            int[] expected = { -7, -5, 0, 1, 7, 7, 12, 34, 56 };

            ArrayIntegerExtension.MergeSort(array);

            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void MergeSort_WithNullArgument_ThrowArgumentNullException()
        {
            int[] array = null;

            ArrayIntegerExtension.MergeSort(array);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void MergeSort_EmptyArray_ThrowArgumentException()
        {
            int[] array = { };

            ArrayIntegerExtension.MergeSort(array);
        }

        [TestMethod]
        public void MergeSort_WithOneElement_Success()
        {
            int[] array = { 1 };
            int[] expected = { 1 };

            ArrayIntegerExtension.MergeSort(array);

            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void QuickSort_WithPositiveNumbers_Success()
        {
            int[] array = { 3, 26, 5, 12, 1 };
            int[] expected = { 1, 3, 5, 12, 26 };

            ArrayIntegerExtension.QuickSort(array);

            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void QuickSort_WithPositiveAndNegativeNumbers_Success()
        {
            int[] array = { 34, -5, 12, 56, 1, 0, 7, 7, -7 };
            int[] expected = { -7, -5, 0, 1, 7, 7, 12, 34, 56 };

            ArrayIntegerExtension.QuickSort(array);

            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void QuickSort_WithNullArgument_ThrowArgumentNullException()
        {
            int[] array = null;

            ArrayIntegerExtension.QuickSort(array, 0, 2);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void QuickSort_EmptyArray_ThrowArgumentException()
        {
            int[] array = { };

            ArrayIntegerExtension.QuickSort(array, 0, 2);
        }

        [TestMethod]
        public void QuickSort_WithStartGreaterThanOrEqualsEnd_Success()
        {
            int[] array = { 34, -5, 12, 56, 1, 0, 7, 7, -7 };
            int[] expected = { 34, -5, 12, 56, 1, 0, 7, 7, -7 };

            ArrayIntegerExtension.QuickSort(array, 3, 2);

            CollectionAssert.AreEqual(expected, array);
        }
    }
}