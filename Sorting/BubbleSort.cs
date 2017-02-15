using Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class BubbleSort<T> where T : IComparable<T>
    {
        //PesudoCode
        //Ref : https://visualgo.net/sorting
        //do
        //swapped = false
        //for i = 1 to indexOfLastUnsortedElement
        //if leftElement > rightElement
        //swap(leftElement, rightElement)
        //swapped = true
        //while swapped

        public T[] Sort(T[] items)
        {
            bool swapped;
            T[] sortedItem = new T[items.Length - 1];
            ValueSwaper<T> swapper = new ValueSwaper<T>();
            do
            {
                swapped = false;
                for (int i = 1; i < items.Length; i++)
                {
                    if (items[i - 1].CompareTo(items[i]) == 1 )
                    {
                        sortedItem  = swapper.Swap(items, i - 1, i);
                        swapped = true;
                    }   
                }

              
            } while (swapped);


            return sortedItem;
        }


       
    }
}
