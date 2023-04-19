using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using testScript;

namespace Lab03
{
   
    public partial class Form1 : Form
    {
        bool isCeaser;
        bool isEncrypted;
        public Form1()
        {
            InitializeComponent();

        }

        private void StudentIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string studentNumber = StudentIdTextBox.Text;
            string plainText = textBox1.Text;
            //testClass test = new testClass();
            
            if (studentNumber.Length < 8)
            {
                MessageBox.Show("Enter 8 digits.");
            }
            else
            {
                string result = "";
                if (isCeaser)
                {
                    int ceaserKey = 7;
                    if (isEncrypted)
                    {
                        result = CeaserEncrypt(plainText, ceaserKey);
                        testClass test = new testClass();
                        int score = test.testFuncApp3(studentNumber, textBox1.Text, "Caesar", "encrypt",
                            result, CeaserEncrypt(textBox1.Text, 7), VigenereEncrypt(textBox1.Text, "esoguce"), CeaserDecrypt(textBox1.Text, 7),
                            VigenereDecrypt(textBox1.Text, "esoguce"));
                        label1.Text = "SCORE:"+ score.ToString();

                    }
                    else
                    {
                        result = CeaserDecrypt(plainText, ceaserKey);
                        testClass test = new testClass();
                        int score = test.testFuncApp3(studentNumber, textBox1.Text, "Caesar", "decrypt",
                             result, CeaserEncrypt(textBox1.Text, 7), VigenereEncrypt(textBox1.Text, "esoguce"), CeaserDecrypt(textBox1.Text, 7),
                             VigenereDecrypt(textBox1.Text, "esoguce"));
                        label1.Text = "SCORE:"+score.ToString();

                    }
                }
                else
                {
                    string vigenereKey = "esoguce";
                    if (isEncrypted)
                    {
                        result = VigenereEncrypt(plainText, vigenereKey);
                        testClass test = new testClass();
                        int score = test.testFuncApp3(studentNumber, textBox1.Text, "Vigenere", "encrypt",
                            result, CeaserEncrypt(textBox1.Text, 7), VigenereEncrypt(textBox1.Text, "esoguce"), CeaserDecrypt(textBox1.Text, 7),
                            VigenereDecrypt(textBox1.Text, "esoguce"));
                        label1.Text = "SCORE:" + score.ToString();
                    }
                    else
                    {
                        result = VigenereDecrypt(plainText, vigenereKey);
                        testClass test = new testClass();
                        int score = test.testFuncApp3(studentNumber, textBox1.Text, "Vigenere", "decrypt",
                             result, CeaserEncrypt(textBox1.Text, 7), VigenereEncrypt(textBox1.Text, "esoguce"), CeaserDecrypt(textBox1.Text, 7),
                             VigenereDecrypt(textBox1.Text, "esoguce"));
                        label1.Text = "SCORE:" + score.ToString();

                    }
                }
                string filename = studentNumber + ".csv";
                WriteToCSV(filename, result);
                textwillshown.Text = result;
            }
        }
        private void WriteToCSV(string filename, string result)
        {
            using (StreamWriter sw = new StreamWriter(filename, true))
            {
                sw.WriteLine(result);
            }
        }
        public static string CeaserEncrypt(string plainText, int key)
        {
            string cipherText = "";
            foreach (char c in plainText)
            {
                if (char.IsLetter(c))
                {
                    char newChar = (char)(((char.ToUpper(c) - 65 + key) % 26) + 65);
                    cipherText += newChar;
                }
                else
                {
                    cipherText += c;
                }
            }
            return cipherText;
        }

        public static string CeaserDecrypt(string cipherText, int key)
        {
            string plainText = "";
            foreach (char c in cipherText)
            {
                if (char.IsLetter(c))
                {
                    char newChar = (char)(((char.ToUpper(c) - 65 - key + 26) % 26) + 65);
                    plainText += newChar;
                }
                else
                {
                    plainText += c;
                }
            }
            return plainText;
        }

        public static string VigenereEncrypt(string plaintext, string key)
        {
            string ciphertext = "";
            int keyIndex = 0;

            foreach (char c in plaintext)
            {
                // Convert character to uppercase.
                char plainChar = char.ToUpper(c);

                // If plain character is not an uppercase letter, skip it.
                if (plainChar < 'A' || plainChar > 'Z')
                {
                    ciphertext += plainChar;
                    continue;
                }

                // Get ASCII code of key character and convert to uppercase.
                char keyChar = char.ToUpper(key[keyIndex % key.Length]);

                // Calculate shift amount.
                int shift = (keyChar - 'A');

                // Calculate ASCII code of cipher character.
                int cipherAscii = ((plainChar - 'A' + shift) % 26) + 'A';

                // Add cipher character to ciphertext.
                ciphertext += (char)cipherAscii;

                // Increment key index.
                keyIndex++;
            }

            return ciphertext;
        }

        public static string VigenereDecrypt(string ciphertext, string key)
        {
            string plaintext = "";
            int keyIndex = 0;

            foreach (char c in ciphertext)
            {
                // Convert character to uppercase.
                char cipherChar = char.ToUpper(c);

                // If cipher character is not an uppercase letter, skip it.
                if (cipherChar < 'A' || cipherChar > 'Z')
                {
                    plaintext += cipherChar;
                    continue;
                }

                // Get ASCII code of key character and convert to uppercase.
                char keyChar = char.ToUpper(key[keyIndex % key.Length]);

                // Calculate shift amount.
                int shift = (keyChar - 'A');

                // Calculate ASCII code of plain character.
                int plainAscii = ((cipherChar - 'A' - shift + 26) % 26) + 'A';

                // Add plain character to plaintext.
                plaintext += (char)plainAscii;

                // Increment key index.
                keyIndex++;
            }

            return plaintext;
        }


        private void Encrypt_CheckedChanged(object sender, EventArgs e)
        {

            isEncrypted = true;


        }

        private void Decryption_CheckedChanged(object sender, EventArgs e)
        {
            isEncrypted = false;
        }

        private void Ceaser_CheckedChanged(object sender, EventArgs e)
        {
            isCeaser = true;
        }

        private void Vigenere_CheckedChanged(object sender, EventArgs e)
        {
            isCeaser = false;
        }
    }



}
