using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Sortowanie_pliku
{
    internal class MainSortowanie
    {
        BubbleSort bubble = new BubbleSort();
        QuickSort quickSort = new QuickSort();
        Stopwatch stopwatch = new Stopwatch();



        public void Sort(bool radioButton1, bool radioButton2, bool radioButton3, string filename, string[] fileText)
        {


            if (radioButton1)
            {
                
               File.WriteAllLines(filename, bubble.Sort(fileText));
              

            }
            else if (radioButton2)
            {
                
               File.WriteAllLines(filename, quickSort.Sort(fileText));
                
            }
            else if (radioButton3)
            {
                
                Array.Sort(fileText);
                File.WriteAllLines(filename, fileText);
                
            }

            

        }

            public void SortInt(bool radioButton1, bool radioButton2, bool radioButton3, string filename, int[] fileText)
            {

            if (radioButton1)
            {
                bubble.SortInt(fileText);
              string[] resultfileText = Array.ConvertAll(fileText, x => x.ToString());

                File.WriteAllLines(filename,resultfileText );


            }
            else if (radioButton2)
            {
                quickSort.SortInt(fileText, fileText[0], fileText.Last());
                string[] resultfileText = Array.ConvertAll(fileText, x => x.ToString());

                File.WriteAllLines(filename, resultfileText);


            }
            else if (radioButton3)
            {
                Array.Sort(fileText);

                string[] resultfileText = Array.ConvertAll(fileText, x => x.ToString());
                File.WriteAllLines(filename, resultfileText);
            }

        }


    }
}
