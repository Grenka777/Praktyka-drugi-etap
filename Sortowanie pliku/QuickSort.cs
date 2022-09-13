using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie_pliku
{
    internal class QuickSort : IStrategy1
    {

        public string[] Sort(string[] letters)
        {

            if (letters.Length < 2) { return letters; }
            int p = letters[0].Length;
            return Sort(letters.Where(x => x.Length < p).ToArray())
                .Concat(letters.Where(x => x.Length == p))
                .Concat(Sort(letters.Where(x => x.Length > p).ToArray()))
                .ToArray();



        }


        public int[] SortInt(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];
            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                SortInt(array, leftIndex, j);
            if (i < rightIndex)
                SortInt(array, i, rightIndex);
            return array;
        }





    }
}
