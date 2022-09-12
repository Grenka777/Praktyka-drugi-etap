
namespace Kodowanie_ta_dekodowanie_textu
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxDekodowanie = new System.Windows.Forms.TextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDeKod = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxKodowanie = new System.Windows.Forms.TextBox();
            this.richTextBoxKodowanie = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonKod = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonDeKod);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.richTextBox2);
            this.tabPage2.Controls.Add(this.textBoxDekodowanie);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(358, 239);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dekodowanie";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxDekodowanie
            // 
            this.textBoxDekodowanie.Location = new System.Drawing.Point(3, 50);
            this.textBoxDekodowanie.Multiline = true;
            this.textBoxDekodowanie.Name = "textBoxDekodowanie";
            this.textBoxDekodowanie.Size = new System.Drawing.Size(199, 30);
            this.textBoxDekodowanie.TabIndex = 6;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(7, 132);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(344, 90);
            this.richTextBox2.TabIndex = 7;
            this.richTextBox2.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(-3, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Wpisz tekst do dekodowania";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dekodowany tekst";
            // 
            // buttonDeKod
            // 
            this.buttonDeKod.Location = new System.Drawing.Point(208, 50);
            this.buttonDeKod.Name = "buttonDeKod";
            this.buttonDeKod.Size = new System.Drawing.Size(144, 30);
            this.buttonDeKod.TabIndex = 10;
            this.buttonDeKod.Text = "Dekodować";
            this.buttonDeKod.UseVisualStyleBackColor = true;
            this.buttonDeKod.Click += new System.EventHandler(this.buttonDeKod_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonKod);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.richTextBoxKodowanie);
            this.tabPage1.Controls.Add(this.textBoxKodowanie);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(358, 239);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kodowanie";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // textBoxKodowanie
            // 
            this.textBoxKodowanie.Location = new System.Drawing.Point(8, 59);
            this.textBoxKodowanie.Multiline = true;
            this.textBoxKodowanie.Name = "textBoxKodowanie";
            this.textBoxKodowanie.Size = new System.Drawing.Size(188, 30);
            this.textBoxKodowanie.TabIndex = 1;
            this.textBoxKodowanie.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // richTextBoxKodowanie
            // 
            this.richTextBoxKodowanie.Location = new System.Drawing.Point(8, 141);
            this.richTextBoxKodowanie.Name = "richTextBoxKodowanie";
            this.richTextBoxKodowanie.Size = new System.Drawing.Size(344, 90);
            this.richTextBoxKodowanie.TabIndex = 2;
            this.richTextBoxKodowanie.Text = "";
            this.richTextBoxKodowanie.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wpisz tekst do kodowania";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kodowany tekst";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonKod
            // 
            this.buttonKod.Location = new System.Drawing.Point(202, 59);
            this.buttonKod.Name = "buttonKod";
            this.buttonKod.Size = new System.Drawing.Size(153, 30);
            this.buttonKod.TabIndex = 5;
            this.buttonKod.Text = "Kodować";
            this.buttonKod.UseVisualStyleBackColor = true;
            this.buttonKod.Click += new System.EventHandler(this.buttonKod_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(366, 265);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 265);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonDeKod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox textBoxDekodowanie;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonKod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxKodowanie;
        private System.Windows.Forms.TextBox textBoxKodowanie;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

