
namespace AppMail
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEmailUser = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelToken = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFromEmail = new System.Windows.Forms.TextBox();
            this.txtPasswordFromEmail = new System.Windows.Forms.TextBox();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmailUser
            // 
            this.txtEmailUser.Location = new System.Drawing.Point(77, 35);
            this.txtEmailUser.Name = "txtEmailUser";
            this.txtEmailUser.Size = new System.Drawing.Size(114, 20);
            this.txtEmailUser.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.Location = new System.Drawing.Point(0, 176);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(546, 158);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login to Jira";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(6, 119);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(208, 23);
            this.buttonSend.TabIndex = 3;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(77, 61);
            this.txtToken.Name = "txtToken";
            this.txtToken.PasswordChar = '*';
            this.txtToken.Size = new System.Drawing.Size(114, 20);
            this.txtToken.TabIndex = 4;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(5, 38);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email";
            // 
            // labelToken
            // 
            this.labelToken.AutoSize = true;
            this.labelToken.Location = new System.Drawing.Point(5, 68);
            this.labelToken.Name = "labelToken";
            this.labelToken.Size = new System.Drawing.Size(38, 13);
            this.labelToken.TabIndex = 6;
            this.labelToken.Text = "Token";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sender email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "App password";
            // 
            // txtFromEmail
            // 
            this.txtFromEmail.Location = new System.Drawing.Point(102, 38);
            this.txtFromEmail.Name = "txtFromEmail";
            this.txtFromEmail.Size = new System.Drawing.Size(112, 20);
            this.txtFromEmail.TabIndex = 9;
            // 
            // txtPasswordFromEmail
            // 
            this.txtPasswordFromEmail.Location = new System.Drawing.Point(102, 68);
            this.txtPasswordFromEmail.Name = "txtPasswordFromEmail";
            this.txtPasswordFromEmail.PasswordChar = '#';
            this.txtPasswordFromEmail.Size = new System.Drawing.Size(112, 20);
            this.txtPasswordFromEmail.TabIndex = 10;
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(77, 91);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(114, 20);
            this.txtDomain.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Your domain";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmailUser);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtDomain);
            this.groupBox1.Controls.Add(this.txtToken);
            this.groupBox1.Controls.Add(this.labelEmail);
            this.groupBox1.Controls.Add(this.labelToken);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 148);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jira authorization";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonSend);
            this.groupBox2.Controls.Add(this.txtPasswordFromEmail);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtFromEmail);
            this.groupBox2.Location = new System.Drawing.Point(310, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 148);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Email authorization";
            this.groupBox2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 334);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmailUser;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFromEmail;
        private System.Windows.Forms.TextBox txtPasswordFromEmail;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

