using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Kurs_walut
{
    public partial class Form1 : Form
    {
        NbpConnect nbp;
        List<NbpTableRates> nbpRates;
       

        public Form1()
        {
            InitializeComponent();
            nbp = new NbpConnect();
            nbpRates = nbp.getRates();
            addPlnRates();

            completeComboBox();
        }

     public void addPlnRates()
        {
            NbpTableRate pln = new NbpTableRate();
            pln.Code = "PLN";
            pln.Currency = "Polish złoty";
            pln.Mid = 1;

            nbpRates.Add(pln);
        }


        public void completeComboBox()
        {
            foreach(NbpTableRate rate in nbpRates)
            {
                comboBoxFrom.Items.Add(rate);
                comboBoxTo.Items.Add(rate);
            }

            comboBoxFrom.SelectedItem = comboBoxFrom.Items[comboBoxFrom.Items.Count - 1];
            comboBoxTo.SelectedItem = comboBoxTo.Items[0];

            comboBoxFrom.DisplayMember = "Code";
            comboBoxFrom.ValueMember = "Code";
            comboBoxTo.DisplayMember = "Code";
            comboBoxTo.ValueMember = "Code";

        }

        private   void button1_Click(object sender, EventArgs e)
        {
            double amount;
            if(double.TryParse(textBoxAmount.Text, out amount))
            {
                NbpTableRate from = findCurrency(((NbpTableRate)comboBoxFrom.SelectedItem).Code);
                NbpTableRate to = findCurrency(((NbpTableRate)comboBoxTo.SelectedItem).Code);


                  double convertedAmount = Calculate.MainCalculate(amount, from, to);

                labelConverted.Text = String.Format("{0:0.00}", convertedAmount);

            }
            else
            {
                MessageBox.Show("Brak wejśćowych danych");
            }

        }

        private NbpTableRate findCurrency(string code)
        {
            NbpTableRate foundRate = null;

            foreach (NbpTableRate rate in nbpRates)
            {
                if (rate.Code.Equals(code))
                    foundRate = rate;
            }

            return foundRate;
        }



        private void buttonZamien_Click(object sender, EventArgs e)
        {
            NbpTableRate fromTemp = (NbpTableRate)comboBoxFrom.SelectedItem;

            comboBoxFrom.SelectedItem = comboBoxTo.SelectedItem;
            comboBoxTo.SelectedItem = fromTemp;
        }

        
    }
}
