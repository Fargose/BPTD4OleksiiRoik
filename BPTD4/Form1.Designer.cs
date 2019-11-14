namespace BPTD4
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cipherInput = new System.Windows.Forms.RichTextBox();
            this.cipherOutput = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.decipherInput = new System.Windows.Forms.RichTextBox();
            this.decipherOutput = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1151, 580);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.cipherOutput);
            this.tabPage1.Controls.Add(this.cipherInput);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1143, 551);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Шифрування";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.decipherOutput);
            this.tabPage2.Controls.Add(this.decipherInput);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1143, 551);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Дешифрування";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // cipherInput
            // 
            this.cipherInput.Location = new System.Drawing.Point(6, 76);
            this.cipherInput.Name = "cipherInput";
            this.cipherInput.Size = new System.Drawing.Size(555, 469);
            this.cipherInput.TabIndex = 0;
            this.cipherInput.Text = "";
            // 
            // cipherOutput
            // 
            this.cipherOutput.Location = new System.Drawing.Point(597, 76);
            this.cipherOutput.Name = "cipherOutput";
            this.cipherOutput.ReadOnly = true;
            this.cipherOutput.Size = new System.Drawing.Size(540, 469);
            this.cipherOutput.TabIndex = 1;
            this.cipherOutput.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Обрати файл для шифрування";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(322, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Зашифрувати";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // decipherInput
            // 
            this.decipherInput.Location = new System.Drawing.Point(6, 76);
            this.decipherInput.Name = "decipherInput";
            this.decipherInput.ReadOnly = true;
            this.decipherInput.Size = new System.Drawing.Size(555, 469);
            this.decipherInput.TabIndex = 1;
            this.decipherInput.Text = "";
            // 
            // decipherOutput
            // 
            this.decipherOutput.Location = new System.Drawing.Point(567, 76);
            this.decipherOutput.Name = "decipherOutput";
            this.decipherOutput.ReadOnly = true;
            this.decipherOutput.Size = new System.Drawing.Size(555, 469);
            this.decipherOutput.TabIndex = 2;
            this.decipherOutput.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(257, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "Обрати файл для дешифрування";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(304, 25);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button4.Size = new System.Drawing.Size(257, 35);
            this.button4.TabIndex = 4;
            this.button4.Text = "Дешифрувати";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 604);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox cipherOutput;
        private System.Windows.Forms.RichTextBox cipherInput;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox decipherOutput;
        private System.Windows.Forms.RichTextBox decipherInput;
    }
}

