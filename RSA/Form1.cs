using System;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace RSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckPrimes_Click(object sender, EventArgs e)
        {
            BigInteger p = BigInteger.Parse(txtP.Text);
            BigInteger q = BigInteger.Parse(txtQ.Text);

            bool value = true;
            while (value)
            {
                if (IsPrime(p) && IsPrime(q))
                {
                    MessageBox.Show("Input numbers are prime.");
                    value = false;
                }
                else if (!IsPrime(p))
                {
                    MessageBox.Show("p is not a prime number.");
                    return;
                }
                else if (!IsPrime(q))
                {
                    MessageBox.Show("q is not a prime number.");
                    return;
                }
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            BigInteger p = BigInteger.Parse(txtP.Text);
            BigInteger q = BigInteger.Parse(txtQ.Text);
            BigInteger eValue = fE((p - 1) * (q - 1));
            BigInteger n = p * q;

            string inputText = txtInputText.Text;
            BigInteger encrypted = Encrypt(inputText, n, eValue);

            txtOutput.Text = $"e: {eValue}, d: {fD(eValue, (p - 1) * (q - 1))}\r\n";

            txtOutput.AppendText($"Encrypted Text: {encrypted}");
        }



        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            BigInteger p = BigInteger.Parse(txtP.Text);
            BigInteger q = BigInteger.Parse(txtQ.Text);
            BigInteger eValue = fE((p - 1) * (q - 1));
            BigInteger d = fD(eValue, (p - 1) * (q - 1));
            BigInteger n = p * q;

            string[] encryptedText = txtOutput.Text.Split(',');
            List<string> numericStrings = new List<string>();
            foreach (string s in encryptedText)
            {
                string numericString = new string(s.Where(char.IsDigit).ToArray());
                if (!string.IsNullOrEmpty(numericString))
                {
                    numericStrings.Add(numericString);
                }
            }

            string joinedText = string.Join("", numericStrings);

            BigInteger encrypted;
            if (BigInteger.TryParse(joinedText, out encrypted))
            {
                string decrypted = Decrypt(encrypted, n, d);
                MessageBox.Show("Decrypted text: " + decrypted);
            }
            else
            {
                MessageBox.Show("Invalid encrypted text format.");
            }
        }


        public bool IsPrime(BigInteger number)
        {
            if (number <= 1)
                return false;
            if (number == 2)
                return true;
            if (number % 2 == 0)
                return false;

            for (BigInteger i = 3; BigInteger.Pow(i, 2) <= number; i += 2)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        public BigInteger fE(BigInteger fi)
        {
            for (BigInteger e = 2; e < fi; e++)
            {
                if (BigInteger.GreatestCommonDivisor(e, fi) == 1)
                {
                    return e;
                }
            }
            throw new Exception("Error");
        }

        public BigInteger fD(BigInteger e, BigInteger fi)
        {
            BigInteger fi0 = fi;
            BigInteger y = 0, x = 1;

            if (fi == 1)
                return 0;

            while (e > 1)
            {
                BigInteger q = e / fi;
                BigInteger t = fi;

                fi = e % fi;
                e = t;
                t = y;

                y = x - q * y;
                x = t;
            }

            if (x < 0)
                x += fi0;

            return x;
        }

        public BigInteger Encrypt(string text, BigInteger n, BigInteger e)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(text);
            BigInteger plaintext = new BigInteger(bytes);

            return BigInteger.ModPow(plaintext, e, n);
        }



        public string Decrypt(BigInteger ciphertext, BigInteger n, BigInteger d)
        {
            BigInteger decryptedBigInt = BigInteger.ModPow(ciphertext, d, n);
            byte[] decryptedBytes = decryptedBigInt.ToByteArray();

            return Encoding.Unicode.GetString(decryptedBytes);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtP_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtQ_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtInputText_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
