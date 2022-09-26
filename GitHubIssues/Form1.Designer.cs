
namespace GitHubIssues
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtToken = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtIssueTitle = new System.Windows.Forms.TextBox();
            this.txtIssueBody = new System.Windows.Forms.TextBox();
            this.labelToken = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelBody = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelRepo = new System.Windows.Forms.Label();
            this.comboBoxIssues = new System.Windows.Forms.ComboBox();
            this.labelIssuesNum = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonRestoreToGit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonVievPanelBD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(50, 31);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(100, 20);
            this.txtToken.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Zaloguj się";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // txtIssueTitle
            // 
            this.txtIssueTitle.Location = new System.Drawing.Point(416, 107);
            this.txtIssueTitle.Name = "txtIssueTitle";
            this.txtIssueTitle.Size = new System.Drawing.Size(213, 20);
            this.txtIssueTitle.TabIndex = 3;
            this.txtIssueTitle.Visible = false;
            // 
            // txtIssueBody
            // 
            this.txtIssueBody.Location = new System.Drawing.Point(416, 133);
            this.txtIssueBody.Name = "txtIssueBody";
            this.txtIssueBody.Size = new System.Drawing.Size(213, 20);
            this.txtIssueBody.TabIndex = 4;
            this.txtIssueBody.Visible = false;
            // 
            // labelToken
            // 
            this.labelToken.AutoSize = true;
            this.labelToken.Location = new System.Drawing.Point(6, 34);
            this.labelToken.Name = "labelToken";
            this.labelToken.Size = new System.Drawing.Size(38, 13);
            this.labelToken.TabIndex = 5;
            this.labelToken.Text = "Token";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(356, 110);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(55, 13);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Issue Title";
            this.labelTitle.Visible = false;
            // 
            // labelBody
            // 
            this.labelBody.AutoSize = true;
            this.labelBody.Location = new System.Drawing.Point(355, 137);
            this.labelBody.Name = "labelBody";
            this.labelBody.Size = new System.Drawing.Size(58, 13);
            this.labelBody.TabIndex = 7;
            this.labelBody.Text = "Issue body";
            this.labelBody.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(277, 195);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(373, 146);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(508, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(359, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Wyswietlic issues";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(543, 166);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(86, 23);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Dodać issues";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Visible = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(451, 166);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(86, 23);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.Text = "Edit issues";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Visible = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelRepo
            // 
            this.labelRepo.AutoSize = true;
            this.labelRepo.Location = new System.Drawing.Point(530, 6);
            this.labelRepo.Name = "labelRepo";
            this.labelRepo.Size = new System.Drawing.Size(74, 13);
            this.labelRepo.TabIndex = 15;
            this.labelRepo.Text = "Repozytorium:";
            this.labelRepo.Visible = false;
            // 
            // comboBoxIssues
            // 
            this.comboBoxIssues.FormattingEnabled = true;
            this.comboBoxIssues.Location = new System.Drawing.Point(508, 70);
            this.comboBoxIssues.Name = "comboBoxIssues";
            this.comboBoxIssues.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIssues.TabIndex = 16;
            this.comboBoxIssues.Visible = false;
            // 
            // labelIssuesNum
            // 
            this.labelIssuesNum.AutoSize = true;
            this.labelIssuesNum.Location = new System.Drawing.Point(530, 51);
            this.labelIssuesNum.Name = "labelIssuesNum";
            this.labelIssuesNum.Size = new System.Drawing.Size(75, 13);
            this.labelIssuesNum.TabIndex = 17;
            this.labelIssuesNum.Text = "Issues number";
            this.labelIssuesNum.Visible = false;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(3, 32);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(84, 23);
            this.buttonInsert.TabIndex = 18;
            this.buttonInsert.Text = "Zapisz do BD";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(262, 146);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(190, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Backup";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(190, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "Restore";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(93, 32);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(91, 23);
            this.buttonRead.TabIndex = 22;
            this.buttonRead.Text = "Wyświetlić BD";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonRestoreToGit
            // 
            this.buttonRestoreToGit.Location = new System.Drawing.Point(3, 3);
            this.buttonRestoreToGit.Name = "buttonRestoreToGit";
            this.buttonRestoreToGit.Size = new System.Drawing.Size(181, 23);
            this.buttonRestoreToGit.TabIndex = 23;
            this.buttonRestoreToGit.Text = "Restore to gitHub";
            this.buttonRestoreToGit.UseVisualStyleBackColor = true;
            this.buttonRestoreToGit.Click += new System.EventHandler(this.buttonRestoreToGit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.buttonRestoreToGit);
            this.panel1.Controls.Add(this.buttonRead);
            this.panel1.Controls.Add(this.buttonInsert);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(2, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 211);
            this.panel1.TabIndex = 24;
            this.panel1.Visible = false;
            // 
            // buttonVievPanelBD
            // 
            this.buttonVievPanelBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVievPanelBD.Location = new System.Drawing.Point(278, 130);
            this.buttonVievPanelBD.Name = "buttonVievPanelBD";
            this.buttonVievPanelBD.Size = new System.Drawing.Size(75, 59);
            this.buttonVievPanelBD.TabIndex = 25;
            this.buttonVievPanelBD.Text = "Pracować z BD";
            this.buttonVievPanelBD.UseVisualStyleBackColor = true;
            this.buttonVievPanelBD.Visible = false;
            this.buttonVievPanelBD.Click += new System.EventHandler(this.buttonVievPanelBD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(655, 353);
            this.Controls.Add(this.buttonVievPanelBD);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelIssuesNum);
            this.Controls.Add(this.comboBoxIssues);
            this.Controls.Add(this.labelRepo);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelBody);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelToken);
            this.Controls.Add(this.txtIssueBody);
            this.Controls.Add(this.txtIssueTitle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtToken);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIssueTitle;
        private System.Windows.Forms.TextBox txtIssueBody;
        private System.Windows.Forms.Label labelToken;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelBody;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelRepo;
        private System.Windows.Forms.ComboBox comboBoxIssues;
        private System.Windows.Forms.Label labelIssuesNum;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonRestoreToGit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonVievPanelBD;
    }
}

