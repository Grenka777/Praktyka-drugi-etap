using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Sortowanie_pliku
{
    public partial class Form1 : Form
    { 
        
        string[] fileText;
        string filename;
        int[] intFileText;

        public Form1()
        {
            InitializeComponent();
        }
       
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

           filename = openFileDialog1.FileName; 
            
            fileText = File.ReadAllLines(filename);
            

            MessageBox.Show("Plik był odczytany");
        }



        private void buttonSave_Click(object sender, EventArgs e)
        {
           
            Stopwatch stopwatch = new Stopwatch();
            MainSortowanie sortowanie = new MainSortowanie();


            try
            {
                stopwatch.Start();
                intFileText = fileText.Select(int.Parse).ToArray();
             sortowanie.SortInt(radioButtonBubble.Checked, radioButtonQuick.Checked, radioButtonLINQ.Checked, filename, intFileText);
                stopwatch.Stop();
                
            }
            catch (Exception)
            {
                stopwatch.Start();
                sortowanie.Sort(radioButtonBubble.Checked, radioButtonQuick.Checked, radioButtonLINQ.Checked, filename, fileText);
                stopwatch.Stop();

            }


            MessageBox.Show("Plik był zapisany. Czas trwania operacji: "+stopwatch.Elapsed);
        }
    }
}
