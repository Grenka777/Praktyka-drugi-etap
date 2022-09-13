using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Sortowanie_pliku
{
    internal class BubbleSort : IStrategy1
    {
        public string[] Sort(string[] letters)
        {
            bool swap;
            string temp; 


          do { 
                swap = false;

            for (int index = 0; index < (letters.Length - 1); index++)
            {
                if (string.Compare(letters[index], letters[index + 1]) < 0) 
                {

                        temp = letters[index];
                        letters[index] = letters[index + 1];
                        letters[index + 1] = temp;
                        swap = true;
                }
            }

          }while (swap);

            return letters;

           
        }


        public int[] SortInt(int[] arr)
        {
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            return arr;
        }

    }
}
