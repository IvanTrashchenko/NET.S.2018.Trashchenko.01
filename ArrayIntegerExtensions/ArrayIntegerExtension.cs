using System;

namespace ArrayIntegerExtensions
{
    /// <summary>
    /// Class of sort methods.
    /// </summary>
    public static class ArrayIntegerExtension
    {
        #region Sorting Methods
        /// <summary>
        /// Method which performs merge sort for an array.
        /// </summary>
        /// <param name="array">Array to be sorted.</param>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when array is empty.</exception>
        public static void MergeSort(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length == 0)
            {
                throw new ArgumentException(nameof(array));
            }

            MergeSort(array, 0, array.Length - 1);
        }

        /// <summary>
        /// Method which performs merge sort for an array with specific left border and specific right border.
        /// </summary>
        /// <param name="array">Array to be sorted.</param>
        /// <param name="start">Left border of array.</param>
        /// <param name="end">Right border of array.</param>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when array is empty.</exception>
        public static void MergeSort(int[] array, int start, int end)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length == 0)
            {
                throw new ArgumentException(nameof(array));
            }

            if (start < end)
            {
                int middle = (start / 2) + (end / 2);
                MergeSort(array, start, middle);
                MergeSort(array, middle + 1, end);
                Merge(array, start, middle, end);
            }
        }

        /// <summary>
        /// Method which performs quick sort for an array.
        /// </summary>
        /// <param name="array">Array to be sorted.</param>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when array is empty.</exception>
        public static void QuickSort(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length == 0)
            {
                throw new ArgumentException(nameof(array));
            }

            QuickSort(array, 0, array.Length - 1);
        }

        /// <summary>
        /// Method which performs quick sort for an array with specific left border and specific right border.
        /// </summary>
        /// <param name="array">Array to be sorted.</param>
        /// <param name="start">Left border of array.</param>
        /// <param name="end">Right border of array.</param>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when array is empty.</exception>
        public static void QuickSort(int[] array, int start, int end)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length == 0)
            {
                throw new ArgumentException(nameof(array));
            }

            int left = start, right = end;
            int pivot = array[(left + right) / 2];

            while (left <= right)
            {
                while (array[left] < pivot)
                {
                    left++;
                }

                while (array[right] > pivot)
                {
                    right--;
                }

                if (left <= right)
                {
                    Swap(ref array[left++], ref array[right--]);
                }
            }

            if (start < right)
            {
                QuickSort(array, start, right);
            }

            if (end > left)
            {
                QuickSort(array, left, end);
            }
        }
        #endregion

        #region Private methods
        /// <summary>
        /// Method which merges elements into array.
        /// </summary>
        /// <param name="array">Original array.</param>
        /// <param name="start">Left border.</param>
        /// <param name="middle">Index of middle element.</param>
        /// <param name="end">Right border.</param>
        private static void Merge(int[] array, int start, int middle, int end)
        {
            int left = start;
            int right = middle + 1;
            int[] tempArray = new int[(end - start) + 1];
            int marker = 0;

            while ((left <= middle) && (right <= end))
            {
                if (array[left] < array[right])
                {
                    tempArray[marker++] = array[left++];
                }
                else
                {
                    tempArray[marker++] = array[right++];
                }
            }

            if (left <= middle)
            {
                while (left <= middle)
                {
                    tempArray[marker++] = array[left++];
                }
            }

            if (right <= end)
            {
                while (right <= end)
                {
                    tempArray[marker++] = array[right++];
                }
            }

            for (int i = 0; i < tempArray.Length; i++)
            {
                array[start + i] = tempArray[i];
            }
        }

        /// <summary>
        /// Method which mutually exchanges the values of two variables.
        /// </summary>
        /// <param name="firstElement">First element to be swapped.</param>
        /// <param name="secondElement">Second element to be swapped.</param>
        private static void Swap(ref int firstElement, ref int secondElement)
        {
            int temp = firstElement;
            firstElement = secondElement;
            secondElement = temp;
        }
        #endregion
    }
}