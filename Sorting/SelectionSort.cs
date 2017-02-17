using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class SelectionSort<T> where T : IComparable<T>
    {
        //PesudoCode
        //Ref : https://visualgo.net/sorting
        //repeat(numOfElements - 1) times
        //  set the first unsorted element as the minimum
        //  for each of the unsorted elements
        //      if element<currentMinimum
        //       set element as new minimum
        //  swap minimum with first unsorted position
        public IEnumerable<T> Sort(IEnumerable<T> items)
        {
            if (items == null)
            {
                throw new ArgumentNullException("input value cannot be null");
            }
            if (items.Count() == 0)
            {
                throw new ArgumentException("input collection should have atleast one value ");
            }
            ICollection<T> SortedArray = new List<T>();
            ValueSwaper<T> swapper = new ValueSwaper<T>();
            T unsortedArrayWithoutCurrentMin;
            for (int i = 1; i < items.Count(); i++)
            {
              unsortedArrayWithoutCurrentMin =
                                (SortedArray == null)
                                ? items.Skip(i - 1).Min()
                                : items.Except(SortedArray).Min();
                SortedArray.Add(unsortedArrayWithoutCurrentMin);
            }
            var maxvalue = items.Max();
            SortedArray.Add(maxvalue);
            return SortedArray;
        }
    }
}
