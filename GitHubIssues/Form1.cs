using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Octokit;

namespace GitHubIssues
{
    public partial class Form1 : Form
    {
        Auth auth = new Auth();
        string tokenString;

        public Form1()
        {          
            InitializeComponent();           
        }

        private  void button1_ClickAsync(object sender, EventArgs e)
        {
            try
            {
             tokenString = txtToken.Text;
              completeComboBoxAsync(txtToken.Text, comboBox1);
                comboBoxIssues.Visible = true;
                labelIssuesNum.Visible = true;
                buttonVievPanelBD.Visible = true;
                button2.Visible = true;
                comboBox1.Visible = true;
                buttonEdit.Visible = true;
                buttonAdd.Visible = true;
                txtIssueBody.Visible = true;
                txtIssueTitle.Visible = true;
                richTextBox1.Visible = true;
                labelBody.Visible = true;
                labelRepo.Visible = true;
                labelTitle.Visible = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
                     
        }

        public async void completeComboBoxAsync(string token, ComboBox ComboBoxRepos )
        {
            try
            {
                var client = new GitHubClient(new Octokit.ProductHeaderValue("my-cool-app"));

                var tokenAuth = new Credentials(token);
                client.Credentials = tokenAuth;
                var user = await client.User.Current();

                var repos = await client.Repository.GetAllForCurrent();
                foreach (var repo in repos)
                {
                    ComboBoxRepos.Items.Add(repo.Name);

                }
                ComboBoxRepos.SelectedItem = ComboBoxRepos.Items[0];
            }
            catch (Exception)
            {

                MessageBox.Show("Nie prawdziły token");
            }

           

           
          
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            comboBoxIssues.Items.Clear();
            var data = await auth.GetAllIssues(tokenString, comboBox1);
            
            foreach (var item in data)
            {
                richTextBox1.Text += "Nazwa issues: "+ item.Title +"\tIssues body: "+item.Body +"\t"+"Numer issues: "+item.Number+"\n";

                comboBoxIssues.Items.Add(item.Number);
            }
            
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {


            try
            {
                if (txtIssueBody.Text == string.Empty || txtIssueTitle.Text == string.Empty)
                {
                    MessageBox.Show("Brak danych body albo title");
                }
                else
                {
                    auth.CreateIssue(tokenString, txtIssueTitle.Text, txtIssueBody.Text, comboBox1);
                    MessageBox.Show("Issues dodane!");
                    txtIssueTitle.Clear();
                    txtIssueBody.Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

          
            
        }

        private async void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                auth.UpdateIssue(tokenString, txtIssueTitle.Text, txtIssueBody.Text, comboBox1, comboBoxIssues);
                MessageBox.Show("Issues number " + comboBoxIssues.Text + " edytowane");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        DBConnect dBConnect = new DBConnect();

        private async void buttonInsert_Click(object sender, EventArgs e)
        {
            
            dBConnect.InsertDataAsync(auth,tokenString,comboBox1);
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            
            dBConnect.ReadData(dataGridView1);
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dBConnect.BackupDb(saveFileDialog1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dBConnect.RestoreDb(openFileDialog1);
        }

        private async void buttonRestoreToGit_Click(object sender, EventArgs e)
        {

             dBConnect.RestoreGit(tokenString, comboBox1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonVievPanelBD_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            buttonVievPanelBD.Visible = false;
        }
    }
}
