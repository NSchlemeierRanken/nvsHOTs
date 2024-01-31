namespace HOT2_03
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
            txtLength = new TextBox();
            txtWidth = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblArea = new Label();
            lblWeeklyFee = new Label();
            lblSeasonLength = new Label();
            lblTotal = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 5);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Length (ft)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 5);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Width (ft)";
            // 
            // txtLength
            // 
            txtLength.Location = new Point(7, 23);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(79, 23);
            txtLength.TabIndex = 2;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(104, 23);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(77, 23);
            txtWidth.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(8, 68);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(89, 68);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(73, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(168, 68);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(57, 23);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(7, 109);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(0, 15);
            lblArea.TabIndex = 7;
            // 
            // lblWeeklyFee
            // 
            lblWeeklyFee.AutoSize = true;
            lblWeeklyFee.Location = new Point(7, 142);
            lblWeeklyFee.Name = "lblWeeklyFee";
            lblWeeklyFee.Size = new Size(0, 15);
            lblWeeklyFee.TabIndex = 8;
            // 
            // lblSeasonLength
            // 
            lblSeasonLength.AutoSize = true;
            lblSeasonLength.Location = new Point(7, 174);
            lblSeasonLength.Name = "lblSeasonLength";
            lblSeasonLength.Size = new Size(0, 15);
            lblSeasonLength.TabIndex = 9;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(7, 204);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 15);
            lblTotal.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(237, 228);
            Controls.Add(lblTotal);
            Controls.Add(lblSeasonLength);
            Controls.Add(lblWeeklyFee);
            Controls.Add(lblArea);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtWidth);
            Controls.Add(txtLength);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Greg's Lawncare";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtLength;
        private TextBox txtWidth;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private Label lblArea;
        private Label lblWeeklyFee;
        private Label lblSeasonLength;
        private Label lblTotal;
    }
}
