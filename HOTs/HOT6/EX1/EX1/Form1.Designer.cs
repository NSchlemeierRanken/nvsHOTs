namespace EX1
{
    partial class Password_Cracker
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
            lblResult = new Label();
            txtHash = new TextBox();
            btnCrack = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 18);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "MD5 Hash";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(11, 101);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 1;
            // 
            // txtHash
            // 
            txtHash.Location = new Point(11, 36);
            txtHash.Name = "txtHash";
            txtHash.Size = new Size(285, 23);
            txtHash.TabIndex = 2;
            // 
            // btnCrack
            // 
            btnCrack.Location = new Point(302, 36);
            btnCrack.Name = "btnCrack";
            btnCrack.Size = new Size(75, 23);
            btnCrack.TabIndex = 3;
            btnCrack.Text = "Crack";
            btnCrack.UseVisualStyleBackColor = true;
            btnCrack.Click += btnCrack_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(394, 36);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(485, 36);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Password_Cracker
            // 
            AcceptButton = btnCrack;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(631, 210);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCrack);
            Controls.Add(txtHash);
            Controls.Add(lblResult);
            Controls.Add(label1);
            Name = "Password_Cracker";
            Text = "Password Cracker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblResult;
        private TextBox txtHash;
        private Button btnCrack;
        private Button btnClear;
        private Button btnExit;
    }
}
