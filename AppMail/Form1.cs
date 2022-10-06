using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMail
{
    public partial class Form1 : Form
    {
        AuthJira auth = new AuthJira();
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
               await auth.GetDataProjects(txtEmailUser,txtToken,txtDomain);
               richTextBox1.Text = auth.BodyEmail; 
                groupBox2.Visible = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WorkEmail workEmail = new WorkEmail(txtFromEmail,txtPasswordFromEmail);
            try
            {
                workEmail.SendEmail(txtEmailUser,txtToken,txtDomain);
                MessageBox.Show("Email było wyslano do poczty");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
