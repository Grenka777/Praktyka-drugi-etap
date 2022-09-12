using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kodowanie_ta_dekodowanie_textu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKod_Click(object sender, EventArgs e)
        {
           
            richTextBoxKodowanie.Text =  ToBase64Encode(textBoxKodowanie.Text);
        }



        private void buttonDeKod_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = ToBase64Decode(textBoxDekodowanie.Text);
        }



        #region method
        public static string ToBase64Encode(string text)
        {
            if (String.IsNullOrEmpty(text))
            {
                return text;
            }

            byte[] textByte = Encoding.UTF8.GetBytes(text);
            return Convert.ToBase64String(textByte);

        }


        public static string ToBase64Decode(string encodedText)
        {
            if (String.IsNullOrEmpty(encodedText))
            {
                return encodedText;
            }
            byte[] EncodedBytes = Convert.FromBase64String(encodedText);
            return Encoding.UTF8.GetString(EncodedBytes);
        }

        #endregion















        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
