namespace Diffie_Hellman_Test
{
    partial class DiffieHelmanTestForm
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
            txtPrime = new TextBox();
            txtGenerator = new TextBox();
            txtPrivateKeyA = new TextBox();
            txtPrivateKeyB = new TextBox();
            lblPrime = new Label();
            lblGenerator = new Label();
            lblPrivateKeyA = new Label();
            lblPrivateKeyB = new Label();
            txtOutput = new TextBox();
            btnComputeSharedSecret = new Button();
            btnGeneratePrivateA = new Button();
            lblPublicKeyA = new Label();
            lblPublicKeyB = new Label();
            txtPublicKeyA = new TextBox();
            txtPublicKeyB = new TextBox();
            label1 = new Label();
            txtSharedSecret = new TextBox();
            btnGeneratePrivateB = new Button();
            btnCalculatePublicA = new Button();
            btnCalculatePublicB = new Button();
            btnRunHandoff = new Button();
            btnRunFullHandoff = new Button();
            btnGenerateG = new Button();
            btnGeneratePrime = new Button();
            btnClearOutput = new Button();
            SuspendLayout();
            // 
            // txtPrime
            // 
            txtPrime.Location = new Point(470, 12);
            txtPrime.Name = "txtPrime";
            txtPrime.Size = new Size(100, 23);
            txtPrime.TabIndex = 0;
            txtPrime.Text = "179";
            txtPrime.TextChanged += txtPrime_TextChanged;
            // 
            // txtGenerator
            // 
            txtGenerator.Location = new Point(471, 40);
            txtGenerator.Name = "txtGenerator";
            txtGenerator.Size = new Size(100, 23);
            txtGenerator.TabIndex = 1;
            txtGenerator.Text = "2";
            txtGenerator.TextChanged += txtGenerator_TextChanged;
            // 
            // txtPrivateKeyA
            // 
            txtPrivateKeyA.Location = new Point(471, 108);
            txtPrivateKeyA.Name = "txtPrivateKeyA";
            txtPrivateKeyA.Size = new Size(100, 23);
            txtPrivateKeyA.TabIndex = 2;
            txtPrivateKeyA.TextChanged += txtPrivateKeyA_TextChanged;
            // 
            // txtPrivateKeyB
            // 
            txtPrivateKeyB.Location = new Point(471, 174);
            txtPrivateKeyB.Name = "txtPrivateKeyB";
            txtPrivateKeyB.Size = new Size(100, 23);
            txtPrivateKeyB.TabIndex = 3;
            txtPrivateKeyB.TextChanged += txtPrivateKeyB_TextChanged;
            // 
            // lblPrime
            // 
            lblPrime.AutoSize = true;
            lblPrime.Location = new Point(426, 16);
            lblPrime.Name = "lblPrime";
            lblPrime.Size = new Size(38, 15);
            lblPrime.TabIndex = 4;
            lblPrime.Text = "Prime";
            // 
            // lblGenerator
            // 
            lblGenerator.AutoSize = true;
            lblGenerator.Location = new Point(412, 44);
            lblGenerator.Name = "lblGenerator";
            lblGenerator.Size = new Size(59, 15);
            lblGenerator.TabIndex = 5;
            lblGenerator.Text = "Generator";
            // 
            // lblPrivateKeyA
            // 
            lblPrivateKeyA.AutoSize = true;
            lblPrivateKeyA.Location = new Point(392, 112);
            lblPrivateKeyA.Name = "lblPrivateKeyA";
            lblPrivateKeyA.Size = new Size(76, 15);
            lblPrivateKeyA.TabIndex = 6;
            lblPrivateKeyA.Text = "Private Key A";
            // 
            // lblPrivateKeyB
            // 
            lblPrivateKeyB.AutoSize = true;
            lblPrivateKeyB.Location = new Point(393, 178);
            lblPrivateKeyB.Name = "lblPrivateKeyB";
            lblPrivateKeyB.Size = new Size(75, 15);
            lblPrivateKeyB.TabIndex = 7;
            lblPrivateKeyB.Text = "Private Key B";
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(12, 16);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(272, 390);
            txtOutput.TabIndex = 8;
            // 
            // btnComputeSharedSecret
            // 
            btnComputeSharedSecret.Location = new Point(503, 306);
            btnComputeSharedSecret.Name = "btnComputeSharedSecret";
            btnComputeSharedSecret.Size = new Size(175, 23);
            btnComputeSharedSecret.TabIndex = 9;
            btnComputeSharedSecret.Text = "Compute Shared Secret";
            btnComputeSharedSecret.UseVisualStyleBackColor = true;
            btnComputeSharedSecret.Click += btnComputeSharedSecret_Click;
            // 
            // btnGeneratePrivateA
            // 
            btnGeneratePrivateA.Location = new Point(579, 108);
            btnGeneratePrivateA.Name = "btnGeneratePrivateA";
            btnGeneratePrivateA.Size = new Size(95, 23);
            btnGeneratePrivateA.TabIndex = 10;
            btnGeneratePrivateA.Text = "Generate";
            btnGeneratePrivateA.UseVisualStyleBackColor = true;
            btnGeneratePrivateA.Click += btnGeneratePrivateA_Click;
            // 
            // lblPublicKeyA
            // 
            lblPublicKeyA.AutoSize = true;
            lblPublicKeyA.Location = new Point(394, 146);
            lblPublicKeyA.Name = "lblPublicKeyA";
            lblPublicKeyA.Size = new Size(73, 15);
            lblPublicKeyA.TabIndex = 11;
            lblPublicKeyA.Text = "Public Key A";
            // 
            // lblPublicKeyB
            // 
            lblPublicKeyB.AutoSize = true;
            lblPublicKeyB.Location = new Point(394, 213);
            lblPublicKeyB.Name = "lblPublicKeyB";
            lblPublicKeyB.Size = new Size(72, 15);
            lblPublicKeyB.TabIndex = 12;
            lblPublicKeyB.Text = "Public Key B";
            // 
            // txtPublicKeyA
            // 
            txtPublicKeyA.Location = new Point(471, 142);
            txtPublicKeyA.Name = "txtPublicKeyA";
            txtPublicKeyA.ReadOnly = true;
            txtPublicKeyA.Size = new Size(100, 23);
            txtPublicKeyA.TabIndex = 13;
            // 
            // txtPublicKeyB
            // 
            txtPublicKeyB.Location = new Point(471, 209);
            txtPublicKeyB.Name = "txtPublicKeyB";
            txtPublicKeyB.ReadOnly = true;
            txtPublicKeyB.Size = new Size(100, 23);
            txtPublicKeyB.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(446, 279);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 15;
            label1.Text = "Shared Secret:";
            // 
            // txtSharedSecret
            // 
            txtSharedSecret.Location = new Point(533, 276);
            txtSharedSecret.Name = "txtSharedSecret";
            txtSharedSecret.ReadOnly = true;
            txtSharedSecret.Size = new Size(144, 23);
            txtSharedSecret.TabIndex = 16;
            // 
            // btnGeneratePrivateB
            // 
            btnGeneratePrivateB.Location = new Point(580, 174);
            btnGeneratePrivateB.Name = "btnGeneratePrivateB";
            btnGeneratePrivateB.Size = new Size(95, 23);
            btnGeneratePrivateB.TabIndex = 17;
            btnGeneratePrivateB.Text = "Generate";
            btnGeneratePrivateB.UseVisualStyleBackColor = true;
            btnGeneratePrivateB.Click += btnGeneratePrivateB_Click;
            // 
            // btnCalculatePublicA
            // 
            btnCalculatePublicA.Location = new Point(580, 142);
            btnCalculatePublicA.Name = "btnCalculatePublicA";
            btnCalculatePublicA.Size = new Size(95, 23);
            btnCalculatePublicA.TabIndex = 18;
            btnCalculatePublicA.Text = "Calculate";
            btnCalculatePublicA.UseVisualStyleBackColor = true;
            btnCalculatePublicA.Click += btnCalculatePublicA_Click;
            // 
            // btnCalculatePublicB
            // 
            btnCalculatePublicB.Location = new Point(581, 209);
            btnCalculatePublicB.Name = "btnCalculatePublicB";
            btnCalculatePublicB.Size = new Size(95, 23);
            btnCalculatePublicB.TabIndex = 19;
            btnCalculatePublicB.Text = "Calculate";
            btnCalculatePublicB.UseVisualStyleBackColor = true;
            btnCalculatePublicB.Click += btnCalculatePublicB_Click;
            // 
            // btnRunHandoff
            // 
            btnRunHandoff.Location = new Point(304, 365);
            btnRunHandoff.Name = "btnRunHandoff";
            btnRunHandoff.Size = new Size(372, 41);
            btnRunHandoff.TabIndex = 20;
            btnRunHandoff.Text = "Run Diffie-Hellman Hand-off";
            btnRunHandoff.UseVisualStyleBackColor = true;
            btnRunHandoff.Click += btnRunHandoff_Click;
            // 
            // btnRunFullHandoff
            // 
            btnRunFullHandoff.Location = new Point(302, 412);
            btnRunFullHandoff.Name = "btnRunFullHandoff";
            btnRunFullHandoff.Size = new Size(372, 26);
            btnRunFullHandoff.TabIndex = 21;
            btnRunFullHandoff.Text = "Generate all values and perform handoff";
            btnRunFullHandoff.UseVisualStyleBackColor = true;
            btnRunFullHandoff.Click += btnRunFullHandoff_Click;
            // 
            // btnGenerateG
            // 
            btnGenerateG.Location = new Point(577, 40);
            btnGenerateG.Name = "btnGenerateG";
            btnGenerateG.Size = new Size(95, 23);
            btnGenerateG.TabIndex = 22;
            btnGenerateG.Text = "Generate";
            btnGenerateG.UseVisualStyleBackColor = true;
            btnGenerateG.Click += btnGenerateG_Click;
            // 
            // btnGeneratePrime
            // 
            btnGeneratePrime.Location = new Point(576, 12);
            btnGeneratePrime.Name = "btnGeneratePrime";
            btnGeneratePrime.Size = new Size(95, 23);
            btnGeneratePrime.TabIndex = 23;
            btnGeneratePrime.Text = "Generate";
            btnGeneratePrime.UseVisualStyleBackColor = true;
            btnGeneratePrime.Click += btnGeneratePrime_Click;
            // 
            // btnClearOutput
            // 
            btnClearOutput.Location = new Point(76, 412);
            btnClearOutput.Name = "btnClearOutput";
            btnClearOutput.Size = new Size(145, 26);
            btnClearOutput.TabIndex = 24;
            btnClearOutput.Text = "Clear";
            btnClearOutput.UseVisualStyleBackColor = true;
            btnClearOutput.Click += btnClearOutput_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 450);
            Controls.Add(btnClearOutput);
            Controls.Add(btnGeneratePrime);
            Controls.Add(btnGenerateG);
            Controls.Add(btnRunFullHandoff);
            Controls.Add(btnRunHandoff);
            Controls.Add(btnCalculatePublicB);
            Controls.Add(btnCalculatePublicA);
            Controls.Add(btnGeneratePrivateB);
            Controls.Add(txtSharedSecret);
            Controls.Add(label1);
            Controls.Add(txtPublicKeyB);
            Controls.Add(txtPublicKeyA);
            Controls.Add(lblPublicKeyB);
            Controls.Add(lblPublicKeyA);
            Controls.Add(btnGeneratePrivateA);
            Controls.Add(btnComputeSharedSecret);
            Controls.Add(txtOutput);
            Controls.Add(lblPrivateKeyB);
            Controls.Add(lblPrivateKeyA);
            Controls.Add(lblGenerator);
            Controls.Add(lblPrime);
            Controls.Add(txtPrivateKeyB);
            Controls.Add(txtPrivateKeyA);
            Controls.Add(txtGenerator);
            Controls.Add(txtPrime);
            Name = "Form1";
            Text = "Diffie-Hellman Test";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrime;
        private TextBox txtGenerator;
        private TextBox txtPrivateKeyA;
        private TextBox txtPrivateKeyB;
        private Label lblPrime;
        private Label lblGenerator;
        private Label lblPrivateKeyA;
        private Label lblPrivateKeyB;
        private TextBox txtOutput;
        private Button btnComputeSharedSecret;
        private Button btnGeneratePrivateA;
        private Label lblPublicKeyA;
        private Label lblPublicKeyB;
        private TextBox txtPublicKeyA;
        private TextBox txtPublicKeyB;
        private Label label1;
        private TextBox txtSharedSecret;
        private Button btnGeneratePrivateB;
        private Button btnCalculatePublicA;
        private Button btnCalculatePublicB;
        private Button btnRunHandoff;
        private Button btnRunFullHandoff;
        private Button btnGenerateG;
        private Button btnGeneratePrime;
        private Button btnClearOutput;
    }
}