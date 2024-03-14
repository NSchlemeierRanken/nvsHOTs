namespace EX2
{
    partial class Network_Scanner
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
            lblIpHeading = new Label();
            lblComputer = new Label();
            lblServiceHeading = new Label();
            txtAddress = new TextBox();
            btnScan = new Button();
            lblAdress = new Label();
            lblServices = new Label();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblIpHeading
            // 
            lblIpHeading.AutoSize = true;
            lblIpHeading.Location = new Point(19, 30);
            lblIpHeading.Name = "lblIpHeading";
            lblIpHeading.Size = new Size(55, 15);
            lblIpHeading.TabIndex = 0;
            lblIpHeading.Text = "IP Adress";
            // 
            // lblComputer
            // 
            lblComputer.AutoSize = true;
            lblComputer.Font = new Font("Segoe UI", 12F);
            lblComputer.Location = new Point(19, 139);
            lblComputer.Name = "lblComputer";
            lblComputer.Size = new Size(0, 21);
            lblComputer.TabIndex = 1;
            // 
            // lblServiceHeading
            // 
            lblServiceHeading.AutoSize = true;
            lblServiceHeading.Location = new Point(19, 226);
            lblServiceHeading.Name = "lblServiceHeading";
            lblServiceHeading.Size = new Size(0, 15);
            lblServiceHeading.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(21, 59);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(233, 23);
            txtAddress.TabIndex = 3;
            // 
            // btnScan
            // 
            btnScan.Location = new Point(260, 58);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(75, 23);
            btnScan.TabIndex = 4;
            btnScan.Text = "Scan";
            btnScan.UseVisualStyleBackColor = true;
            btnScan.Click += btnScan_Click;
            // 
            // lblAdress
            // 
            lblAdress.AutoSize = true;
            lblAdress.Location = new Point(21, 175);
            lblAdress.Name = "lblAdress";
            lblAdress.Size = new Size(0, 15);
            lblAdress.TabIndex = 5;
            // 
            // lblServices
            // 
            lblServices.AutoSize = true;
            lblServices.Location = new Point(21, 262);
            lblServices.Name = "lblServices";
            lblServices.Size = new Size(0, 15);
            lblServices.TabIndex = 6;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(260, 106);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(260, 152);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Network_Scanner
            // 
            AcceptButton = btnScan;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(355, 411);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(lblServices);
            Controls.Add(lblAdress);
            Controls.Add(btnScan);
            Controls.Add(txtAddress);
            Controls.Add(lblServiceHeading);
            Controls.Add(lblComputer);
            Controls.Add(lblIpHeading);
            Name = "Network_Scanner";
            Text = "Network Scanner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIpHeading;
        private Label lblComputer;
        private Label lblServiceHeading;
        private TextBox txtAddress;
        private Button btnScan;
        private Label lblAdress;
        private Label lblServices;
        private Button btnClear;
        private Button btnExit;
    }
}
