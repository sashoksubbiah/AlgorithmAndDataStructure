using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
   public class InsertionSort<T> where T : IComparable<T>
    {
       

        //PesudoCode
        //Ref : https://visualgo.net/sorting
        //mark first element as sorted
        //for each unsorted element
        //    'extract' the element
        //    for i = lastSortedIndex to 0
        //        if currentSortedElement > extractedElement
        //             move sorted element to the right by 1
        //             else: insert extracted element

        public T[] Sort(T[] items)
        {
            if (items == null)
            {
                throw new ArgumentNullException("input value cannot be null");
            }
            if (items.Length == 0)
            {
                throw new ArgumentException("input collection should have atleast one value ");
            }
            T[] intersortedArray;
            T[] sortedArray = new T[items.Length]; 
            for (int i = 1; i < items.Length; i++)
            {
                intersortedArray = intermediateSortedArray(items, i);
                var NextIndexValueToCompare = intersortedArray.Length;    // Next value will be array index plus one so array.length
                sortedArray =  CompareAndSortArray(intersortedArray, items[NextIndexValueToCompare]);
            }
            return sortedArray;
        }

        public T[] CompareAndSortArray(T[] sortedArray, T nextValueToCompare)
        {
            T[] interSortedArray = new T[sortedArray.Length + 1];
            ValueSwaper<T> swapper = new ValueSwaper<T>();
            T[] temparray = new T[sortedArray.Length + 1 ];
            for (int i = 0; i < sortedArray.Length; i++)
            {
                temparray[i] = sortedArray[i];
            }
           
            temparray[sortedArray.Length  ] = nextValueToCompare;
            bool swapped ;
            do
            {
                swapped = false;
                for (int i = temparray.Length - 1; i > 0; i--)
                {
                    if (temparray[i].CompareTo(temparray[i - 1]) == -1)
                    {
                        interSortedArray = swapper.Swap(temparray, i - 1, i);
                        swapped = true;
                    }
                }

            } while (swapped);
           return swapped == true   ?  interSortedArray : temparray;
 }

        public T[] intermediateSortedArray(T[] item , int index)
        {
            T[] sortedArray = new T[index];
            for (int i = 0; i < index; i++)
            {
                sortedArray[i] = item[i];
            }
            return sortedArray;
        }

    }
}
