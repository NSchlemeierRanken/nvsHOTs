namespace HOT4_02
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
            txtNameInput = new TextBox();
            btnAddName = new Button();
            btnUpdateName = new Button();
            btnDeleteName = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lvNames = new ListView();
            columnHeader1 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 21);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter A Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 21);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Name List";
            // 
            // txtNameInput
            // 
            txtNameInput.Location = new Point(25, 55);
            txtNameInput.Name = "txtNameInput";
            txtNameInput.Size = new Size(100, 23);
            txtNameInput.TabIndex = 2;
            // 
            // btnAddName
            // 
            btnAddName.Location = new Point(25, 93);
            btnAddName.Name = "btnAddName";
            btnAddName.Size = new Size(100, 23);
            btnAddName.TabIndex = 3;
            btnAddName.Text = "Add Name";
            btnAddName.UseVisualStyleBackColor = true;
            btnAddName.Click += btnAddName_Click;
            // 
            // btnUpdateName
            // 
            btnUpdateName.Location = new Point(25, 126);
            btnUpdateName.Name = "btnUpdateName";
            btnUpdateName.Size = new Size(100, 23);
            btnUpdateName.TabIndex = 4;
            btnUpdateName.Text = "Update Name";
            btnUpdateName.UseVisualStyleBackColor = true;
            btnUpdateName.Click += btnUpdateName_Click;
            // 
            // btnDeleteName
            // 
            btnDeleteName.Location = new Point(25, 155);
            btnDeleteName.Name = "btnDeleteName";
            btnDeleteName.Size = new Size(100, 23);
            btnDeleteName.TabIndex = 5;
            btnDeleteName.Text = "Delete Name";
            btnDeleteName.UseVisualStyleBackColor = true;
            btnDeleteName.Click += btnDeleteName_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(147, 155);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 23);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(147, 184);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(120, 23);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lvNames
            // 
            lvNames.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            lvNames.Location = new Point(146, 52);
            lvNames.Name = "lvNames";
            lvNames.Size = new Size(121, 97);
            lvNames.TabIndex = 8;
            lvNames.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Names";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 228);
            Controls.Add(lvNames);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnDeleteName);
            Controls.Add(btnUpdateName);
            Controls.Add(btnAddName);
            Controls.Add(txtNameInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "First Names List";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNameInput;
        private Button btnAddName;
        private Button btnUpdateName;
        private Button btnDeleteName;
        private Button btnClear;
        private Button btnExit;
        private ListView lvNames;
        private ColumnHeader columnHeader1;
    }
}
