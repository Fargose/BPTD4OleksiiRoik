using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;

namespace BPTD4
{
    public partial class Form1 : Form
    {
        public string InputText { get; set; }
        public string CipherText { get; set; }
        public string DecipherText { get; set; }

        public string CipherPath { get; set; }

        public string DecipherPath { get; set; }

        RSAParameters privateKey;

        RSAParameters publicKey;

        public RSACryptoServiceProvider RSACryptoServiceProvider { get; set; }

        public Form1()
        {
            InitializeComponent();
            RSACryptoServiceProvider = new RSACryptoServiceProvider((int)(Math.Pow(2.0, 30)));
            privateKey = RSACryptoServiceProvider.ExportParameters(true);
            publicKey = RSACryptoServiceProvider.ExportParameters(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            CipherPath = openFileDialog.FileName;


            InputText = System.IO.File.ReadAllText(CipherPath);
            cipherInput.Text = InputText;
            button2.Enabled = true;
            button4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] input = Encoding.Unicode.GetBytes(InputText);
                RSACryptoServiceProvider.ImportParameters(publicKey);
                byte[] output = RSACryptoServiceProvider.Encrypt(input, false);
                CipherText = Convert.ToBase64String(output);
                using (StreamWriter s = new StreamWriter("CipheredText.txt"))
                { 
                    s.Write(CipherText);
                }
                cipherOutput.Text = CipherText;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            DecipherPath = openFileDialog.FileName;


            InputText = System.IO.File.ReadAllText(DecipherPath);
            decipherInput.Text = InputText;
            button4.Enabled = true;
            button2.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] input = Convert.FromBase64String(InputText);
                RSACryptoServiceProvider.ImportParameters(privateKey);
                byte[] output = RSACryptoServiceProvider.Decrypt(input, false);
                DecipherText = Encoding.Unicode.GetString(output);
                decipherOutput.Text = DecipherText;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
