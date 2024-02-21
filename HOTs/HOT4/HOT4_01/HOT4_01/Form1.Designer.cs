namespace HOT4_01
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
            lblFirstName = new Label();
            lblLastName = new Label();
            lblNumber = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnSearch2 = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 8);
            label1.Name = "label1";
            label1.Size = new Size(137, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name or Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 87);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 120);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 148);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 3;
            label4.Text = "Phone #";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(109, 87);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(0, 15);
            lblFirstName.TabIndex = 4;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(109, 120);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(0, 15);
            lblLastName.TabIndex = 5;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(109, 148);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(0, 15);
            lblNumber.TabIndex = 6;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(19, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(137, 23);
            txtSearch.TabIndex = 7;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(174, 25);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSearch2
            // 
            btnSearch2.Location = new Point(12, 214);
            btnSearch2.Name = "btnSearch2";
            btnSearch2.Size = new Size(75, 23);
            btnSearch2.TabIndex = 9;
            btnSearch2.Text = "Search";
            btnSearch2.UseVisualStyleBackColor = true;
            btnSearch2.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(93, 214);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(174, 214);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 12F);
            lblError.Location = new Point(93, 251);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 21);
            lblError.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 281);
            Controls.Add(lblError);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnSearch2);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblNumber);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Address Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblNumber;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnSearch2;
        private Button btnClear;
        private Button btnExit;
        private Label lblError;
    }
}
