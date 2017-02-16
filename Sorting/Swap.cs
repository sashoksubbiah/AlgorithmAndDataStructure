using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
   public  class ValueSwaper<T>
    {
        public  T[] Swap( T[] items , int left , int right)
        {
            if (left != right)
            {
                T temp = items[left];
                items[left] = items[right];
                items[right] = temp;
            }
            return items;
        }
    }
}
