using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using EditfileCSV;
using System.IO;
using System.Globalization;
using CsvHelper.Configuration;

namespace EditfileCSV
{
    public partial class Form1 : Form
    {
        public string separator;
        char separatorFile;
        EditFile editFile = new EditFile();
        
        public Form1()
        {
            InitializeComponent();

        }
        string filename;
        private void buttonReadFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "CSV|*.csv";

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            
            filename = openFileDialog1.FileName;

            try
            {
                editFile.ReadCSV(filename, dataGridView1);
                separatorFile = editFile.SeparatorDetector(filename);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            if (separatorFile == ',')
            {
                radioButtonPrzecinek.Checked = true ;
            }
            else if (separatorFile == ';')
            {
                radioButton2.Checked = true;
            }
            else if (separatorFile == '\t')
            {
                radioButton3.Checked = true;
            }
            else
            {
                radioButton1.Checked = true;
                textBoxInny.Text = Convert.ToString(separatorFile);
            }



        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                separator =  textBoxInny.Text;
            }
            else if (radioButton2.Checked)
            {
                separator = ";";
            }
            else if (radioButton3.Checked)
            {
                separator = "\t";
            }
            else if (radioButtonPrzecinek.Checked)
            {
                separator = ",";
            }

            try
            {
             editFile.EditCSV(dataGridView1, filename,separator);
                MessageBox.Show("Plik był zaktualizowany");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           

        }
    }
}
