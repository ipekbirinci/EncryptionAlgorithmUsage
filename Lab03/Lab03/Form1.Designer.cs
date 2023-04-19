
namespace Lab03
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.studentNumbel = new System.Windows.Forms.Label();
            this.StudentIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textthatGoing = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Encyripted = new System.Windows.Forms.Label();
            this.CeaserAlgorithm = new System.Windows.Forms.RadioButton();
            this.VigenereAlgorithm = new System.Windows.Forms.RadioButton();
            this.Encrypt = new System.Windows.Forms.RadioButton();
            this.Decryption = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textwillshown = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // studentNumbel
            // 
            this.studentNumbel.AutoSize = true;
            this.studentNumbel.Location = new System.Drawing.Point(24, 22);
            this.studentNumbel.Name = "studentNumbel";
            this.studentNumbel.Size = new System.Drawing.Size(121, 20);
            this.studentNumbel.TabIndex = 0;
            this.studentNumbel.Text = "Student Number:";
            // 
            // StudentIdTextBox
            // 
            this.StudentIdTextBox.Location = new System.Drawing.Point(151, 19);
            this.StudentIdTextBox.MaxLength = 8;
            this.StudentIdTextBox.Name = "StudentIdTextBox";
            this.StudentIdTextBox.Size = new System.Drawing.Size(125, 27);
            this.StudentIdTextBox.TabIndex = 1;
            this.StudentIdTextBox.Text = "20191020";
            this.StudentIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StudentIdTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(699, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "SCORE:Your score will shown here";
            // 
            // textthatGoing
            // 
            this.textthatGoing.AutoSize = true;
            this.textthatGoing.Location = new System.Drawing.Point(24, 107);
            this.textthatGoing.Name = "textthatGoing";
            this.textthatGoing.Size = new System.Drawing.Size(299, 20);
            this.textthatGoing.TabIndex = 3;
            this.textthatGoing.Text = "Text that going to be encryted/desencypted";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 130);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(707, 34);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "MERHABA DUNYALI NASILSIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Algorithms:";
            // 
            // Encyripted
            // 
            this.Encyripted.AutoSize = true;
            this.Encyripted.Location = new System.Drawing.Point(376, 210);
            this.Encyripted.Name = "Encyripted";
            this.Encyripted.Size = new System.Drawing.Size(153, 20);
            this.Encyripted.TabIndex = 8;
            this.Encyripted.Text = "Encyrpted/Decrypted:";
            // 
            // CeaserAlgorithm
            // 
            this.CeaserAlgorithm.AutoSize = true;
            this.CeaserAlgorithm.Location = new System.Drawing.Point(6, 60);
            this.CeaserAlgorithm.Name = "CeaserAlgorithm";
            this.CeaserAlgorithm.Size = new System.Drawing.Size(121, 24);
            this.CeaserAlgorithm.TabIndex = 9;
            this.CeaserAlgorithm.TabStop = true;
            this.CeaserAlgorithm.Text = "Ceaser Cipher";
            this.CeaserAlgorithm.UseVisualStyleBackColor = true;
            this.CeaserAlgorithm.CheckedChanged += new System.EventHandler(this.Ceaser_CheckedChanged);
            // 
            // VigenereAlgorithm
            // 
            this.VigenereAlgorithm.AutoSize = true;
            this.VigenereAlgorithm.Location = new System.Drawing.Point(6, 30);
            this.VigenereAlgorithm.Name = "VigenereAlgorithm";
            this.VigenereAlgorithm.Size = new System.Drawing.Size(136, 24);
            this.VigenereAlgorithm.TabIndex = 10;
            this.VigenereAlgorithm.TabStop = true;
            this.VigenereAlgorithm.Text = "Vigenere Cipher";
            this.VigenereAlgorithm.UseVisualStyleBackColor = true;
            this.VigenereAlgorithm.CheckedChanged += new System.EventHandler(this.Vigenere_CheckedChanged);
            // 
            // Encrypt
            // 
            this.Encrypt.AutoSize = true;
            this.Encrypt.Location = new System.Drawing.Point(6, 30);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(79, 24);
            this.Encrypt.TabIndex = 11;
            this.Encrypt.TabStop = true;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.CheckedChanged += new System.EventHandler(this.Encrypt_CheckedChanged);
            // 
            // Decryption
            // 
            this.Decryption.AutoSize = true;
            this.Decryption.Location = new System.Drawing.Point(6, 60);
            this.Decryption.Name = "Decryption";
            this.Decryption.Size = new System.Drawing.Size(103, 24);
            this.Decryption.TabIndex = 12;
            this.Decryption.TabStop = true;
            this.Decryption.Text = "Decryption";
            this.Decryption.UseVisualStyleBackColor = true;
            this.Decryption.CheckedChanged += new System.EventHandler(this.Decryption_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(407, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Encryption/Decryption";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textwillshown
            // 
            this.textwillshown.AutoSize = true;
            this.textwillshown.Location = new System.Drawing.Point(24, 469);
            this.textwillshown.Name = "textwillshown";
            this.textwillshown.Size = new System.Drawing.Size(198, 20);
            this.textwillshown.TabIndex = 14;
            this.textwillshown.Text = "Encrypted or Decrypted text:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VigenereAlgorithm);
            this.groupBox1.Controls.Add(this.CeaserAlgorithm);
            this.groupBox1.Location = new System.Drawing.Point(24, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 125);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Encrypt);
            this.groupBox2.Controls.Add(this.Decryption);
            this.groupBox2.Location = new System.Drawing.Point(376, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 125);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(632, 280);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(461, 440);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(956, 620);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textwillshown);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Encyripted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textthatGoing);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentIdTextBox);
            this.Controls.Add(this.studentNumbel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentNumbel;
        private System.Windows.Forms.TextBox StudentIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textthatGoing;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Encyripted;
        private System.Windows.Forms.RadioButton CeaserAlgorithm;
        private System.Windows.Forms.RadioButton VigenereAlgorithm;
        private System.Windows.Forms.RadioButton Encrypt;
        private System.Windows.Forms.RadioButton Decryption;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label textwillshown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

