namespace HOT2_01
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
            txtInches = new TextBox();
            btnClear = new Button();
            btnExit = new Button();
            btnConvert = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Distance in inches";
            // 
            // txtInches
            // 
            txtInches.Location = new Point(15, 27);
            txtInches.Name = "txtInches";
            txtInches.Size = new Size(100, 23);
            txtInches.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(155, 27);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(155, 77);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnConvert
            // 
            btnConvert.Font = new Font("Segoe UI", 8F);
            btnConvert.Location = new Point(15, 77);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(98, 23);
            btnConvert.TabIndex = 4;
            btnConvert.Text = "Convert to Yards";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 12F);
            lblResult.Location = new Point(15, 134);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 21);
            lblResult.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 180);
            Controls.Add(lblResult);
            Controls.Add(btnConvert);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(txtInches);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Distance Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtInches;
        private Button btnClear;
        private Button btnExit;
        private Button btnConvert;
        private Label lblResult;
    }
}
