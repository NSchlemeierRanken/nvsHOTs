namespace HOT3_01
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblTotal = new Label();
            lblDrawers = new Label();
            lblWood = new Label();
            btnEstimate = new Button();
            btnExit = new Button();
            btnClear = new Button();
            txtWood = new TextBox();
            txtDrawers = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 16);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Type of Wood";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 16);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 1;
            label2.Text = "Number of Drawers";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 161);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 2;
            label3.Text = "Cost of Wood";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 161);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 3;
            label4.Text = "Cost of Drawers";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(245, 161);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 4;
            label5.Text = "Total Cost";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(245, 208);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 15);
            lblTotal.TabIndex = 5;
            // 
            // lblDrawers
            // 
            lblDrawers.AutoSize = true;
            lblDrawers.Location = new Point(121, 208);
            lblDrawers.Name = "lblDrawers";
            lblDrawers.Size = new Size(0, 15);
            lblDrawers.TabIndex = 6;
            // 
            // lblWood
            // 
            lblWood.AutoSize = true;
            lblWood.Location = new Point(9, 208);
            lblWood.Name = "lblWood";
            lblWood.Size = new Size(0, 15);
            lblWood.TabIndex = 7;
            // 
            // btnEstimate
            // 
            btnEstimate.Location = new Point(14, 81);
            btnEstimate.Name = "btnEstimate";
            btnEstimate.Size = new Size(75, 23);
            btnEstimate.TabIndex = 8;
            btnEstimate.Text = "Estimate";
            btnEstimate.UseVisualStyleBackColor = true;
            btnEstimate.Click += btnEstimate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(245, 81);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(136, 81);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtWood
            // 
            txtWood.Location = new Point(11, 34);
            txtWood.Name = "txtWood";
            txtWood.Size = new Size(100, 23);
            txtWood.TabIndex = 11;
            // 
            // txtDrawers
            // 
            txtDrawers.Location = new Point(142, 34);
            txtDrawers.Name = "txtDrawers";
            txtDrawers.Size = new Size(110, 23);
            txtDrawers.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 275);
            Controls.Add(txtDrawers);
            Controls.Add(txtWood);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            Controls.Add(btnEstimate);
            Controls.Add(lblWood);
            Controls.Add(lblDrawers);
            Controls.Add(lblTotal);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblTotal;
        private Label lblDrawers;
        private Label lblWood;
        private Button btnEstimate;
        private Button btnExit;
        private Button btnClear;
        private TextBox txtWood;
        private TextBox txtDrawers;
    }
}
