
namespace GitComments
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
            this.comboBoxRepos = new System.Windows.Forms.ComboBox();
            this.comboBoxIssues = new System.Windows.Forms.ComboBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelToken = new System.Windows.Forms.Label();
            this.labelRepos = new System.Windows.Forms.Label();
            this.labelIssuesNum = new System.Windows.Forms.Label();
            this.buttonAddComents = new System.Windows.Forms.Button();
            this.labelLength = new System.Windows.Forms.Label();
            this.numericNumberComments = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLength = new System.Windows.Forms.NumericUpDown();
            this.labelNumberComments = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLimit = new System.Windows.Forms.Label();
            this.labelRemaining = new System.Windows.Forms.Label();
            this.labelReset = new System.Windows.Forms.Label();
            this.comboBoxSellect = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSellectAdd = new System.Windows.Forms.Button();
            this.labelLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength)).BeginInit();
            this.SuspendLayout();
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(12, 55);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(121, 20);
            this.txtToken.TabIndex = 0;
            // 
            // comboBoxRepos
            // 
            this.comboBoxRepos.FormattingEnabled = true;
            this.comboBoxRepos.Location = new System.Drawing.Point(261, 15);
            this.comboBoxRepos.Name = "comboBoxRepos";
            this.comboBoxRepos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRepos.TabIndex = 1;
            this.comboBoxRepos.Visible = false;
            // 
            // comboBoxIssues
            // 
            this.comboBoxIssues.Enabled = false;
            this.comboBoxIssues.FormattingEnabled = true;
            this.comboBoxIssues.Location = new System.Drawing.Point(261, 81);
            this.comboBoxIssues.Name = "comboBoxIssues";
            this.comboBoxIssues.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIssues.TabIndex = 2;
            this.comboBoxIssues.Visible = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 81);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(57, 23);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelToken
            // 
            this.labelToken.AutoSize = true;
            this.labelToken.Location = new System.Drawing.Point(12, 39);
            this.labelToken.Name = "labelToken";
            this.labelToken.Size = new System.Drawing.Size(38, 13);
            this.labelToken.TabIndex = 4;
            this.labelToken.Text = "Token";
            // 
            // labelRepos
            // 
            this.labelRepos.AutoSize = true;
            this.labelRepos.Location = new System.Drawing.Point(258, -1);
            this.labelRepos.Name = "labelRepos";
            this.labelRepos.Size = new System.Drawing.Size(57, 13);
            this.labelRepos.TabIndex = 5;
            this.labelRepos.Text = "Repository";
            this.labelRepos.Visible = false;
            // 
            // labelIssuesNum
            // 
            this.labelIssuesNum.AutoSize = true;
            this.labelIssuesNum.Location = new System.Drawing.Point(258, 68);
            this.labelIssuesNum.Name = "labelIssuesNum";
            this.labelIssuesNum.Size = new System.Drawing.Size(69, 13);
            this.labelIssuesNum.TabIndex = 6;
            this.labelIssuesNum.Text = "Issues numer";
            this.labelIssuesNum.Visible = false;
            // 
            // buttonAddComents
            // 
            this.buttonAddComents.Location = new System.Drawing.Point(261, 206);
            this.buttonAddComents.Name = "buttonAddComents";
            this.buttonAddComents.Size = new System.Drawing.Size(121, 23);
            this.buttonAddComents.TabIndex = 8;
            this.buttonAddComents.Text = "Dodaj";
            this.buttonAddComents.UseVisualStyleBackColor = true;
            this.buttonAddComents.Visible = false;
            this.buttonAddComents.Click += new System.EventHandler(this.buttonAddComents_Click);
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(258, 123);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(69, 13);
            this.labelLength.TabIndex = 9;
            this.labelLength.Text = "Ilość znaków";
            this.labelLength.Visible = false;
            // 
            // numericNumberComments
            // 
            this.numericNumberComments.Location = new System.Drawing.Point(261, 178);
            this.numericNumberComments.Name = "numericNumberComments";
            this.numericNumberComments.Size = new System.Drawing.Size(120, 20);
            this.numericNumberComments.TabIndex = 10;
            this.numericNumberComments.Visible = false;
            // 
            // numericUpDownLength
            // 
            this.numericUpDownLength.Location = new System.Drawing.Point(261, 139);
            this.numericUpDownLength.Name = "numericUpDownLength";
            this.numericUpDownLength.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownLength.TabIndex = 11;
            this.numericUpDownLength.Visible = false;
            // 
            // labelNumberComments
            // 
            this.labelNumberComments.AutoSize = true;
            this.labelNumberComments.Location = new System.Drawing.Point(258, 160);
            this.labelNumberComments.Name = "labelNumberComments";
            this.labelNumberComments.Size = new System.Drawing.Size(86, 13);
            this.labelNumberComments.TabIndex = 12;
            this.labelNumberComments.Text = "Ilość komentarzy";
            this.labelNumberComments.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Limit";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Remaining";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Reset";
            this.label3.Visible = false;
            // 
            // labelLimit
            // 
            this.labelLimit.AutoSize = true;
            this.labelLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLimit.Location = new System.Drawing.Point(70, 151);
            this.labelLimit.Name = "labelLimit";
            this.labelLimit.Size = new System.Drawing.Size(16, 16);
            this.labelLimit.TabIndex = 16;
            this.labelLimit.Text = "0";
            this.labelLimit.Visible = false;
            // 
            // labelRemaining
            // 
            this.labelRemaining.AutoSize = true;
            this.labelRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRemaining.Location = new System.Drawing.Point(70, 180);
            this.labelRemaining.Name = "labelRemaining";
            this.labelRemaining.Size = new System.Drawing.Size(16, 16);
            this.labelRemaining.TabIndex = 17;
            this.labelRemaining.Text = "0";
            this.labelRemaining.Visible = false;
            // 
            // labelReset
            // 
            this.labelReset.AutoSize = true;
            this.labelReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelReset.Location = new System.Drawing.Point(70, 213);
            this.labelReset.Name = "labelReset";
            this.labelReset.Size = new System.Drawing.Size(16, 16);
            this.labelReset.TabIndex = 18;
            this.labelReset.Text = "0";
            this.labelReset.Visible = false;
            // 
            // comboBoxSellect
            // 
            this.comboBoxSellect.FormattingEnabled = true;
            this.comboBoxSellect.Items.AddRange(new object[] {
            "GitHub",
            "GitLab"});
            this.comboBoxSellect.Location = new System.Drawing.Point(12, 15);
            this.comboBoxSellect.Name = "comboBoxSellect";
            this.comboBoxSellect.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSellect.TabIndex = 22;
            this.comboBoxSellect.SelectedIndexChanged += new System.EventHandler(this.comboBoxSellect_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Platform";
            // 
            // buttonSellectAdd
            // 
            this.buttonSellectAdd.Location = new System.Drawing.Point(261, 39);
            this.buttonSellectAdd.Name = "buttonSellectAdd";
            this.buttonSellectAdd.Size = new System.Drawing.Size(121, 23);
            this.buttonSellectAdd.TabIndex = 24;
            this.buttonSellectAdd.Text = "Wybierz";
            this.buttonSellectAdd.UseVisualStyleBackColor = true;
            this.buttonSellectAdd.Visible = false;
            this.buttonSellectAdd.Click += new System.EventHandler(this.buttonSellectAdd_Click);
            // 
            // labelLogOut
            // 
            this.labelLogOut.Enabled = false;
            this.labelLogOut.Location = new System.Drawing.Point(76, 81);
            this.labelLogOut.Name = "labelLogOut";
            this.labelLogOut.Size = new System.Drawing.Size(57, 23);
            this.labelLogOut.TabIndex = 25;
            this.labelLogOut.Text = "Log Out";
            this.labelLogOut.UseVisualStyleBackColor = true;
            this.labelLogOut.Click += new System.EventHandler(this.labelLogOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(421, 240);
            this.Controls.Add(this.labelLogOut);
            this.Controls.Add(this.buttonSellectAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxSellect);
            this.Controls.Add(this.labelReset);
            this.Controls.Add(this.labelRemaining);
            this.Controls.Add(this.labelLimit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNumberComments);
            this.Controls.Add(this.numericUpDownLength);
            this.Controls.Add(this.numericNumberComments);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.buttonAddComents);
            this.Controls.Add(this.labelIssuesNum);
            this.Controls.Add(this.labelRepos);
            this.Controls.Add(this.labelToken);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.comboBoxIssues);
            this.Controls.Add(this.comboBoxRepos);
            this.Controls.Add(this.txtToken);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.ComboBox comboBoxRepos;
        private System.Windows.Forms.ComboBox comboBoxIssues;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelToken;
        private System.Windows.Forms.Label labelRepos;
        private System.Windows.Forms.Label labelIssuesNum;
        private System.Windows.Forms.Button buttonAddComents;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.NumericUpDown numericNumberComments;
        private System.Windows.Forms.NumericUpDown numericUpDownLength;
        private System.Windows.Forms.Label labelNumberComments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelLimit;
        private System.Windows.Forms.Label labelRemaining;
        private System.Windows.Forms.Label labelReset;
        private System.Windows.Forms.ComboBox comboBoxSellect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSellectAdd;
        private System.Windows.Forms.Button labelLogOut;
    }
}

