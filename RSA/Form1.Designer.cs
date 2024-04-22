namespace RSA
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
            label1 = new Label();
            txtP = new TextBox();
            txtQ = new TextBox();
            txtInputText = new TextBox();
            txtOutput = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnCheckPrimes = new Button();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(259, 7);
            label1.Name = "label1";
            label1.Size = new Size(149, 37);
            label1.TabIndex = 0;
            label1.Text = "RSA Cipher";
            // 
            // txtP
            // 
            txtP.Location = new Point(123, 75);
            txtP.Margin = new Padding(3, 2, 3, 2);
            txtP.Name = "txtP";
            txtP.Size = new Size(110, 23);
            txtP.TabIndex = 1;
            txtP.TextChanged += txtP_TextChanged;
            // 
            // txtQ
            // 
            txtQ.Location = new Point(421, 75);
            txtQ.Margin = new Padding(3, 2, 3, 2);
            txtQ.Name = "txtQ";
            txtQ.Size = new Size(110, 23);
            txtQ.TabIndex = 2;
            txtQ.TextChanged += txtQ_TextChanged;
            // 
            // txtInputText
            // 
            txtInputText.Location = new Point(123, 135);
            txtInputText.Margin = new Padding(3, 2, 3, 2);
            txtInputText.Multiline = true;
            txtInputText.Name = "txtInputText";
            txtInputText.Size = new Size(408, 57);
            txtInputText.TabIndex = 3;
            txtInputText.TextChanged += txtInputText_TextChanged;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(123, 241);
            txtOutput.Margin = new Padding(3, 2, 3, 2);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(408, 167);
            txtOutput.TabIndex = 4;
            txtOutput.TextChanged += txtOutput_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 58);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 5;
            label2.Text = "Input P";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(458, 58);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 6;
            label3.Text = "Input Q";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(293, 118);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 7;
            label4.Text = "Input text";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(283, 224);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 8;
            label5.Text = "Output text";
            // 
            // btnCheckPrimes
            // 
            btnCheckPrimes.Location = new Point(272, 76);
            btnCheckPrimes.Margin = new Padding(3, 2, 3, 2);
            btnCheckPrimes.Name = "btnCheckPrimes";
            btnCheckPrimes.Size = new Size(108, 22);
            btnCheckPrimes.TabIndex = 9;
            btnCheckPrimes.Text = "Check Prime";
            btnCheckPrimes.UseVisualStyleBackColor = true;
            btnCheckPrimes.Click += btnCheckPrimes_Click;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(192, 196);
            btnEncrypt.Margin = new Padding(3, 2, 3, 2);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(82, 22);
            btnEncrypt.TabIndex = 10;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(385, 196);
            btnDecrypt.Margin = new Padding(3, 2, 3, 2);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(82, 22);
            btnDecrypt.TabIndex = 11;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 463);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(btnCheckPrimes);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtOutput);
            Controls.Add(txtInputText);
            Controls.Add(txtQ);
            Controls.Add(txtP);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtP;
        private TextBox txtQ;
        private TextBox txtInputText;
        private TextBox txtOutput;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnCheckPrimes;
        private Button btnEncrypt;
        private Button btnDecrypt;
    }
}
