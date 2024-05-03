namespace FinalProject
{
    partial class FrmMain
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
            btnSearch = new Button();
            txtSearch = new TextBox();
            comboBoxAuthor = new ComboBox();
            dataGridViewBooks = new DataGridView();
            btnPrevious = new Button();
            btnNext = new Button();
            lblPageInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 9);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 0;
            label1.Text = "Search by Name or ISBN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 9);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Author";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(371, 32);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(28, 32);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(176, 23);
            txtSearch.TabIndex = 5;
            // 
            // comboBoxAuthor
            // 
            comboBoxAuthor.FormattingEnabled = true;
            comboBoxAuthor.Location = new Point(210, 32);
            comboBoxAuthor.Name = "comboBoxAuthor";
            comboBoxAuthor.Size = new Size(121, 23);
            comboBoxAuthor.TabIndex = 6;
            comboBoxAuthor.SelectedIndexChanged += comboBoxAuthor_SelectedIndexChanged;
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Location = new Point(27, 88);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.Size = new Size(704, 302);
            dataGridViewBooks.TabIndex = 7;
            dataGridViewBooks.CellClick += dataGridViewBooks_CellClick;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(94, 405);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(98, 23);
            btnPrevious.TabIndex = 8;
            btnPrevious.Text = "Previous Page";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(210, 405);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 9;
            btnNext.Text = "Next Page";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblPageInfo
            // 
            lblPageInfo.AutoSize = true;
            lblPageInfo.Location = new Point(27, 409);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(33, 15);
            lblPageInfo.TabIndex = 10;
            lblPageInfo.Text = "Page";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPageInfo);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(dataGridViewBooks);
            Controls.Add(comboBoxAuthor);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMain";
            Text = "Book Store";
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnSearch;
        private TextBox txtSearch;
        private ComboBox comboBoxAuthor;
        private DataGridView dataGridViewBooks;
        private Button btnPrevious;
        private Button btnNext;
        private Label lblPageInfo;
    }
}
