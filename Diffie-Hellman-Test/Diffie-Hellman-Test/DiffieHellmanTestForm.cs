using System;
using System.Numerics;
using System.Security.Cryptography;

namespace Diffie_Hellman_Test
{
    public partial class DiffieHelmanTestForm : Form
    {
        private BigInteger prime;
        private BigInteger generator;

        private BigInteger privateA = 0;
        private BigInteger privateB;


        private BigInteger publicB;
        private BigInteger publicA;

        public DiffieHelmanTestForm()
        {
            InitializeComponent();
        }


        #region Main Functions

        private void GenerateAndFill_p()
        {
            prime = RandomPrime.Get();
            txtPrime.Text = prime.ToString();
        }

        private void GenerateAndFill_g()
        {
            generator = GenerateRandomG(prime);
            txtGenerator.Text = generator.ToString();
        }

        private void GenerateAndFill_PrivateKeyA()
        {
            privateA = GenerateRandomPrivateKey();
            txtPrivateKeyA.Text = privateA.ToString();
        }

        private void GenerateAndFill_PrivateKeyB()
        {
            privateB = GenerateRandomPrivateKey();
            txtPrivateKeyB.Text = privateB.ToString();
        }

        private void CalculateAndFill_PublicKeyA()
        {
            if (privateA == 0) return;

            publicA = BigInteger.ModPow(generator, privateA, prime);
            txtPublicKeyA.Text = publicA.ToString();
        }

        private void CalculateAndFill_PublicKeyB()
        {
            if (privateB == 0) return;

            publicB = BigInteger.ModPow(generator, privateB, prime);
            txtPublicKeyB.Text = publicB.ToString();
        }

        private BigInteger ComputeSharedSecret(BigInteger privateSelf, BigInteger publicOther, BigInteger prime)
        {
            return BigInteger.ModPow(publicOther, privateSelf, prime);
        }

        private void CalculateAndFill_SharedSecret()
        {
            // Assuming public keys have been computed already
            BigInteger sharedSecretA = ComputeSharedSecret(privateA, publicB, prime);

            // Update shared secret textbox
            txtSharedSecret.Text = sharedSecretA.ToString();
        }

        private void RunHandoff()
        {
            if (BigInteger.TryParse(txtPrime.Text, out BigInteger p))
            {
                // Assuming public keys have been computed already
                Log($"Party A's private key: {privateA}");
                Log($"Party A's public key: {publicA}");
                Log($"Party B's private key: {privateB}");
                Log($"Party B's public key: {publicB}");

                BigInteger sharedSecretA = ComputeSharedSecret(privateA, publicB, p);

                BigInteger sharedSecretB = ComputeSharedSecret(privateB, publicA, p);

                // Log each step
                Log("");
                Log("");
                Log("Handoff:");
                Log("");
                Log($"Computing shared secret between Party A's private key ({privateA}) and Party B's public key ({publicB}) {sharedSecretA}");
                Log("");
                Log($"Computing shared secret between Party B's private key ({privateB}) and Party A's public key ({publicA}) {sharedSecretB}");
                Log("");

                if (sharedSecretA == sharedSecretB)
                    Log($"Secret agreed upon: {sharedSecretA}");
                else
                    Log($"Secret could not be agreed upon. Please ensure you're using valid values for your prime and generator!");

                Log("");
                Log("Handoff complete.");
            }
            else
            {
                LogError("Invalid prime input.");
            }
        }

        private void RunFullHandoff()
        {
            GenerateAndFill_p();
            GenerateAndFill_g();

            GenerateAndFill_PrivateKeyA();
            GenerateAndFill_PrivateKeyB();

            CalculateAndFill_PublicKeyA();
            CalculateAndFill_PublicKeyB();

            CalculateAndFill_SharedSecret();

            RunHandoff();
        }

        #endregion



        #region Field Parsing

        void EnsureLatestInputValues()
        {
            ParseField(txtPrivateKeyA, ref privateA);
            ParseField(txtPrivateKeyB, ref privateB);

            ParseField(txtPrime, ref prime);

            ParseField(txtGenerator, ref generator);
        }

        public void ParseField(TextBox textBox, ref BigInteger output)
        {
            if (BigInteger.TryParse(textBox.Text, out var parsedValue))
            {
                output = parsedValue;
            }
            else if (txtPrivateKeyB.Text != "")
            {
                LogError($"Unable to parse contents of {textBox.Name} to BigInteger");
            }
        }

        #endregion

        #region Buttons

        private void btnGeneratePrime_Click(object sender, EventArgs e)
        {
            GenerateAndFill_p();
        }

        private void btnGenerateG_Click(object sender, EventArgs e)
        {
            GenerateAndFill_g();
        }

        private void btnGeneratePrivateA_Click(object sender, EventArgs e)
        {
            GenerateAndFill_PrivateKeyA();
        }

        private void btnGeneratePrivateB_Click(object sender, EventArgs e)
        {
            GenerateAndFill_PrivateKeyB();
        }

        private void btnCalculatePublicA_Click(object sender, EventArgs e)
        {
            CalculateAndFill_PublicKeyA();
        }

        private void btnCalculatePublicB_Click(object sender, EventArgs e)
        {
            CalculateAndFill_PublicKeyB();
        }

        private void btnComputeSharedSecret_Click(object sender, EventArgs e)
        {
            CalculateAndFill_SharedSecret();
        }

        private void btnRunHandoff_Click(object sender, EventArgs e)
        {
            RunHandoff();
        }

        private void btnRunFullHandoff_Click(object sender, EventArgs e)
        {
            RunFullHandoff();
        }

        private void btnClearOutput_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
        }

        #endregion

        #region Key Generation

        private BigInteger GenerateRandomPrivateKey()
        {
            // Generate a random private key in the range [1, p-1]
            Random rand = new Random();
            return new BigInteger(rand.Next(1, int.MaxValue));
        }

        private BigInteger ComputePublicKey(BigInteger privateKey, BigInteger prime, BigInteger generator)
        {
            return BigInteger.ModPow(generator, privateKey, prime);
        }

        #endregion

        #region Prime Validation

        bool IsPrime(BigInteger number)
        {
            if (number <= 1)
            {
                return false; // 0 and 1 are not prime
            }

            for (int i = 2; i <= Math.Sqrt((int)number); i++)
            {
                if (number % i == 0)
                {
                    return false; // Found a divisor, not a prime number
                }
            }

            return true; // No divisors found, it's a prime number
        }

        #endregion

        #region G Generation

        BigInteger GenerateRandomG(BigInteger p)
        {
            // Ensure p is odd
            if (p % 2 == 0)
            {
                throw new ArgumentException("p must be an odd number.");
            }

            using (var rng = new RNGCryptoServiceProvider())
            {
                BigInteger g;

                do
                {
                    byte[] bytes = new byte[p.ToByteArray().Length];
                    rng.GetBytes(bytes);

                    g = new BigInteger(bytes) % (p - 2) + 2;
                } while (g <= 0 || g >= p - 1);

                return g;
            }
        }

        #endregion

        #region Logging

        private void Log(string message)
        {
            txtOutput.AppendText($"{message}{Environment.NewLine}");
        }

        private void LogError(string message)
        {
            Log($"{Environment.NewLine}Error: {message}");
        }

        #endregion

        #region Text Changed Events

        private void txtPrivateKeyA_TextChanged(object sender, EventArgs e)
        {
            EnsureLatestInputValues();
            CalculateAndFill_PublicKeyA();
            EnsureLatestInputValues();
        }

        private void txtPrivateKeyB_TextChanged(object sender, EventArgs e)
        {
            EnsureLatestInputValues();
            CalculateAndFill_PublicKeyB();
            EnsureLatestInputValues();
        }

        private void txtPrime_TextChanged(object sender, EventArgs e)
        {
            EnsureLatestInputValues();
            ValidatePrime();
        }

        void ValidatePrime()
        {
            if (BigInteger.TryParse(txtPrime.Text, out BigInteger parsedValue))
            {
                if (IsPrime(parsedValue))
                {
                    txtPrime.BackColor = Color.White;
                    prime = parsedValue;
                    return;
                }
            }

            txtPrime.BackColor = Color.Pink;
        }

        private void txtGenerator_TextChanged(object sender, EventArgs e)
        {
            EnsureLatestInputValues();
            CalculateAndFill_PublicKeyA();
            CalculateAndFill_PublicKeyB();
            EnsureLatestInputValues();
        }

        #endregion

    }
}