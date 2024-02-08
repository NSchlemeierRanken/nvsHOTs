namespace HOT3_02
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
            lblNumScores = new Label();
            lblSum = new Label();
            lblAverage = new Label();
            lblLow = new Label();
            lblHigh = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            Exit = new Button();
            txtScore = new TextBox();
            lblError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 0;
            label1.Text = "Please Enter a test score";
            // 
            // lblNumScores
            // 
            lblNumScores.AutoSize = true;
            lblNumScores.Location = new Point(9, 123);
            lblNumScores.Name = "lblNumScores";
            lblNumScores.Size = new Size(0, 15);
            lblNumScores.TabIndex = 1;
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.Location = new Point(9, 158);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(0, 15);
            lblSum.TabIndex = 2;
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.Location = new Point(9, 188);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(0, 15);
            lblAverage.TabIndex = 3;
            // 
            // lblLow
            // 
            lblLow.AutoSize = true;
            lblLow.Location = new Point(9, 220);
            lblLow.Name = "lblLow";
            lblLow.Size = new Size(0, 15);
            lblLow.TabIndex = 4;
            // 
            // lblHigh
            // 
            lblHigh.AutoSize = true;
            lblHigh.Location = new Point(9, 257);
            lblHigh.Name = "lblHigh";
            lblHigh.Size = new Size(0, 15);
            lblHigh.TabIndex = 5;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(9, 87);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(116, 87);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(224, 87);
            Exit.Name = "Exit";
            Exit.Size = new Size(75, 23);
            Exit.TabIndex = 8;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(9, 28);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(132, 23);
            txtScore.TabIndex = 9;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(9, 69);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 322);
            Controls.Add(lblError);
            Controls.Add(txtScore);
            Controls.Add(Exit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(lblHigh);
            Controls.Add(lblLow);
            Controls.Add(lblAverage);
            Controls.Add(lblSum);
            Controls.Add(lblNumScores);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Test Scores";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNumScores;
        private Label lblSum;
        private Label lblAverage;
        private Label lblLow;
        private Label lblHigh;
        private Button btnCalculate;
        private Button btnClear;
        private Button Exit;
        private TextBox txtScore;
        private Label lblError;
    }
}
