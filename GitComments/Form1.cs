using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Octokit;

namespace GitComments
{
    public partial class Form1 : Form
    {
        AuthGitHub authGit = new AuthGitHub();
        GitLabAuth gitLab = new GitLabAuth();
        string tokenString;
        bool BoolHub;
        bool BoolLab;

        public Form1()
        {
            InitializeComponent();
            comboBoxSellect.SelectedItem = comboBoxSellect.Items[0];
        }


      

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            if (BoolHub)
            { 
                tokenString = txtToken.Text;
             authGit.CompleteComboboxRepo(tokenString, comboBoxRepos);
             authGit.ShowLimit(tokenString,labelLimit, labelRemaining, labelReset);

                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                labelLimit.Visible = true;
                labelRemaining.Visible = true;
                labelReset.Visible = true;

                labelRepos.Visible = true;
                comboBoxRepos.Visible = true;
                comboBoxIssues.Visible = true;
                buttonSellectAdd.Visible = true;

                labelLogOut.Enabled = true;
                buttonLogin.Enabled = false;
            }else if (BoolLab)
            {
                tokenString = txtToken.Text;
                gitLab.GetAllProject(tokenString, comboBoxRepos);

                labelRepos.Visible = true;
                comboBoxRepos.Visible = true;
                comboBoxIssues.Visible = true;
                buttonSellectAdd.Visible = true;

                labelLogOut.Enabled = true;
                buttonLogin.Enabled = false;
            }
               

            
            
            
            
           
        }

        private void buttonAddComents_Click(object sender, EventArgs e)
        {
            try
            {

                if (BoolHub)
                {
                    authGit.CreateComents(tokenString, comboBoxRepos, comboBoxIssues, (int)numericNumberComments.Value, (int)numericUpDownLength.Value);
                }
                else if (BoolLab)
                {
                    gitLab.CreateNotes(tokenString, comboBoxRepos, comboBoxIssues, (int)numericNumberComments.Value, (int)numericUpDownLength.Value);
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
          
            
        }

        private void buttonSellectAdd_Click(object sender, EventArgs e)
        {
            comboBoxIssues.Items.Clear();
            if (BoolHub)
            {
                tokenString = txtToken.Text;
                authGit.CompleteComboBoxIssues(tokenString, comboBoxRepos, comboBoxIssues);
                authGit.ShowLimit(tokenString, labelLimit, labelRemaining, labelReset);


                comboBoxIssues.Enabled = true;
                numericUpDownLength.Visible = true;
                numericNumberComments.Visible = true;
                labelLength.Visible = true;
                labelNumberComments.Visible = true;
                buttonAddComents.Visible = true;
              

            }
            else if (BoolLab)
            {
                tokenString = txtToken.Text;
                gitLab.completeComboBoxIssuesId(comboBoxIssues, tokenString, comboBoxRepos);


                comboBoxIssues.Enabled = true;
                numericUpDownLength.Visible = true;
                numericNumberComments.Visible = true;
                labelLength.Visible = true;
                labelNumberComments.Visible = true;
                buttonAddComents.Visible = true;
            }
        }

        private void comboBoxSellect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSellect.SelectedItem == comboBoxSellect.Items[0])
            {
                BoolHub = true;
                BoolLab = false;
            }
            else if (comboBoxSellect.SelectedItem == comboBoxSellect.Items[1])
            {
                BoolHub = false;
                BoolLab = true;
            }
        }

        private void labelLogOut_Click(object sender, EventArgs e)
        {

            if (BoolHub)
            {
                txtToken.Clear();

                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                labelLimit.Visible = false;
                labelRemaining.Visible = false;
                labelReset.Visible = false;

                labelRepos.Visible = false;
                comboBoxRepos.Visible = false;
                comboBoxIssues.Visible = false;
                buttonSellectAdd.Visible = false;

                comboBoxIssues.Enabled = false;
                numericUpDownLength.Visible = false;
                numericNumberComments.Visible = false;
                labelLength.Visible = false;
                labelNumberComments.Visible = false;
                buttonAddComents.Visible = false;


                labelLogOut.Enabled = false;
                buttonLogin.Enabled = true;
            }
            else if (BoolLab)
            {
                txtToken.Clear();

                labelRepos.Visible = false;
                comboBoxRepos.Visible = false;
                comboBoxIssues.Visible = false;
                buttonSellectAdd.Visible = false;

                comboBoxIssues.Enabled = false;
                numericUpDownLength.Visible = false;
                numericNumberComments.Visible = false;
                labelLength.Visible = false;
                labelNumberComments.Visible = false;
                buttonAddComents.Visible = false;


                labelLogOut.Enabled = false;
                buttonLogin.Enabled = true;
            }
        }
    }

}
