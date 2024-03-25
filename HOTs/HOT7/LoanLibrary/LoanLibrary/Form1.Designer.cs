namespace LoanLibrary
{
    partial class frmBankLoan
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblName = new Label();
            lblAmount = new Label();
            lblPayment = new Label();
            lblTotal = new Label();
            txtName = new TextBox();
            txtAmount = new TextBox();
            shortTermRadioButton = new RadioButton();
            longTermRadioButton = new RadioButton();
            btnCreate = new Button();
            btnClear = new Button();
            btnPayment = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "CreateLoan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 37);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 82);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Amount:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 140);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 3;
            label4.Text = "Type:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 214);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 4;
            label5.Text = "ManageLoan";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(65, 254);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 5;
            lblName.Text = "Name";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(65, 299);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(64, 15);
            lblAmount.TabIndex = 6;
            lblAmount.Text = "lblAmount";
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Location = new Point(65, 344);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(67, 15);
            lblPayment.TabIndex = 7;
            lblPayment.Text = "lblPayment";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(65, 386);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(38, 15);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "label9";
            // 
            // txtName
            // 
            txtName.Location = new Point(145, 37);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 9;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(145, 82);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(100, 23);
            txtAmount.TabIndex = 10;
            // 
            // shortTermRadioButton
            // 
            shortTermRadioButton.AutoSize = true;
            shortTermRadioButton.Location = new Point(145, 140);
            shortTermRadioButton.Name = "shortTermRadioButton";
            shortTermRadioButton.Size = new Size(111, 19);
            shortTermRadioButton.TabIndex = 11;
            shortTermRadioButton.TabStop = true;
            shortTermRadioButton.Text = "Short Term Loan";
            shortTermRadioButton.UseVisualStyleBackColor = true;
            // 
            // longTermRadioButton
            // 
            longTermRadioButton.AutoSize = true;
            longTermRadioButton.Location = new Point(145, 187);
            longTermRadioButton.Name = "longTermRadioButton";
            longTermRadioButton.Size = new Size(110, 19);
            longTermRadioButton.TabIndex = 12;
            longTermRadioButton.TabStop = true;
            longTermRadioButton.Text = "Long Term Loan";
            longTermRadioButton.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(342, 37);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(105, 23);
            btnCreate.TabIndex = 13;
            btnCreate.Text = "Create Loan";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(342, 82);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(105, 23);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnPayment
            // 
            btnPayment.Enabled = false;
            btnPayment.Location = new Point(342, 246);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(105, 23);
            btnPayment.TabIndex = 15;
            btnPayment.Text = "Make Payment";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(342, 295);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(105, 23);
            btnExit.TabIndex = 16;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmBankLoan
            // 
            AcceptButton = btnCreate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(647, 450);
            Controls.Add(btnExit);
            Controls.Add(btnPayment);
            Controls.Add(btnClear);
            Controls.Add(btnCreate);
            Controls.Add(longTermRadioButton);
            Controls.Add(shortTermRadioButton);
            Controls.Add(txtAmount);
            Controls.Add(txtName);
            Controls.Add(lblTotal);
            Controls.Add(lblPayment);
            Controls.Add(lblAmount);
            Controls.Add(lblName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmBankLoan";
            Text = "Bank Loan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblName;
        private Label lblAmount;
        private Label lblPayment;
        private Label lblTotal;
        private TextBox txtName;
        private TextBox txtAmount;
        private RadioButton shortTermRadioButton;
        private RadioButton longTermRadioButton;
        private Button btnCreate;
        private Button btnClear;
        private Button btnPayment;
        private Button btnExit;
    }
}
