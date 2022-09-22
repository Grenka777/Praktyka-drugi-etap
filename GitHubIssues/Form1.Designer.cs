
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
            this.txtIssueTitle.Location = new System.Drawing.Point(262, 110);
            this.txtIssueTitle.Name = "txtIssueTitle";
            this.txtIssueTitle.Size = new System.Drawing.Size(213, 20);
            this.txtIssueTitle.TabIndex = 3;
            this.txtIssueTitle.Visible = false;
            // 
            // txtIssueBody
            // 
            this.txtIssueBody.Location = new System.Drawing.Point(262, 136);
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
            this.labelTitle.Location = new System.Drawing.Point(202, 113);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(55, 13);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Issue Title";
            this.labelTitle.Visible = false;
            // 
            // labelBody
            // 
            this.labelBody.AutoSize = true;
            this.labelBody.Location = new System.Drawing.Point(201, 140);
            this.labelBody.Name = "labelBody";
            this.labelBody.Size = new System.Drawing.Size(58, 13);
            this.labelBody.TabIndex = 7;
            this.labelBody.Text = "Issue body";
            this.labelBody.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.Location = new System.Drawing.Point(0, 197);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(497, 146);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(354, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 169);
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
            this.buttonAdd.Location = new System.Drawing.Point(389, 169);
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
            this.buttonEdit.Location = new System.Drawing.Point(297, 169);
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
            this.labelRepo.Location = new System.Drawing.Point(376, 9);
            this.labelRepo.Name = "labelRepo";
            this.labelRepo.Size = new System.Drawing.Size(74, 13);
            this.labelRepo.TabIndex = 15;
            this.labelRepo.Text = "Repozytorium:";
            this.labelRepo.Visible = false;
            // 
            // comboBoxIssues
            // 
            this.comboBoxIssues.FormattingEnabled = true;
            this.comboBoxIssues.Location = new System.Drawing.Point(354, 73);
            this.comboBoxIssues.Name = "comboBoxIssues";
            this.comboBoxIssues.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIssues.TabIndex = 16;
            this.comboBoxIssues.Visible = false;
            this.comboBoxIssues.SelectedIndexChanged += new System.EventHandler(this.comboBoxIssues_SelectedIndexChanged);
            // 
            // labelIssuesNum
            // 
            this.labelIssuesNum.AutoSize = true;
            this.labelIssuesNum.Location = new System.Drawing.Point(376, 54);
            this.labelIssuesNum.Name = "labelIssuesNum";
            this.labelIssuesNum.Size = new System.Drawing.Size(75, 13);
            this.labelIssuesNum.TabIndex = 17;
            this.labelIssuesNum.Text = "Issues number";
            this.labelIssuesNum.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(497, 343);
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
    }
}

