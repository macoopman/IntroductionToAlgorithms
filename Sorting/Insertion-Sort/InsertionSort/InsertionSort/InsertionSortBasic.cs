using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    public class InsertionSortBasic
    {
        public void SortNonDecreasing(ref int[] sortMe)
        {
            for(var j = 1; j <= sortMe.Length - 1; j++)
            {
                var key = sortMe[j];

                var i = j - 1;
                while (i >= 0 && sortMe[i] > key)
                {
                    sortMe[i + 1] = sortMe[i];
                    i--;
                }
                sortMe[i+ 1] = key;
            }
        }

        public void SortNonIncreasing(ref int[] b)
        {
            for (int i = 1; i < b.Length; i++)
            {
                var key = b[i];
                var j = i - 1;
                
                while (j >= 0 && b[j] < key)
                {
                    b[j+1] = b[j];
                    j--;
                }
                b[j+1] = key;
            }
        }
    }
}
