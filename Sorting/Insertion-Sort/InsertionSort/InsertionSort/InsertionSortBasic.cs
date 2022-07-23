using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    public class InsertionSortBasic
    {
        public void Sort(ref int[] sortMe)
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
    }
}
