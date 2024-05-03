namespace FinalProject
{
    partial class FrmDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxBook = new PictureBox();
            lblTitle = new Label();
            lblISBN = new Label();
            lblYear = new Label();
            lblAuthor = new Label();
            dataGridViewReviews = new DataGridView();
            label1 = new Label();
            txtUsername = new TextBox();
            btnAddReview = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtComment = new TextBox();
            nudRating = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReviews).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRating).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxBook
            // 
            pictureBoxBook.Location = new Point(12, 12);
            pictureBoxBook.Name = "pictureBoxBook";
            pictureBoxBook.Size = new Size(147, 174);
            pictureBoxBook.TabIndex = 0;
            pictureBoxBook.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F);
            lblTitle.Location = new Point(196, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(49, 28);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(196, 78);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(35, 15);
            lblISBN.TabIndex = 2;
            lblISBN.Text = "ISBN:";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(196, 52);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(32, 15);
            lblYear.TabIndex = 3;
            lblYear.Text = "Year:";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(196, 107);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(23, 15);
            lblAuthor.TabIndex = 4;
            lblAuthor.Text = "By:";
            // 
            // dataGridViewReviews
            // 
            dataGridViewReviews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReviews.Location = new Point(12, 331);
            dataGridViewReviews.Name = "dataGridViewReviews";
            dataGridViewReviews.Size = new Size(556, 112);
            dataGridViewReviews.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 204);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 6;
            label1.Text = "Review This Book!";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(95, 229);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(196, 23);
            txtUsername.TabIndex = 7;
            // 
            // btnAddReview
            // 
            btnAddReview.Location = new Point(340, 278);
            btnAddReview.Name = "btnAddReview";
            btnAddReview.Size = new Size(136, 47);
            btnAddReview.TabIndex = 8;
            btnAddReview.Text = "Add Review";
            btnAddReview.UseVisualStyleBackColor = true;
            btnAddReview.Click += btnAddReview_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 229);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 9;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 264);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 10;
            label3.Text = "Comment";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 302);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 11;
            label4.Text = "Rating";
            // 
            // txtComment
            // 
            txtComment.Location = new Point(95, 264);
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(196, 23);
            txtComment.TabIndex = 12;
            // 
            // nudRating
            // 
            nudRating.Location = new Point(95, 302);
            nudRating.Name = "nudRating";
            nudRating.Size = new Size(120, 23);
            nudRating.TabIndex = 13;
            // 
            // FrmDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 455);
            Controls.Add(nudRating);
            Controls.Add(txtComment);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAddReview);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(dataGridViewReviews);
            Controls.Add(lblAuthor);
            Controls.Add(lblYear);
            Controls.Add(lblISBN);
            Controls.Add(lblTitle);
            Controls.Add(pictureBoxBook);
            Name = "FrmDetails";
            Text = "FrmDetails";
            ((System.ComponentModel.ISupportInitialize)pictureBoxBook).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReviews).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxBook;
        private Label lblTitle;
        private Label lblISBN;
        private Label lblYear;
        private Label lblAuthor;
        private DataGridView dataGridViewReviews;
        private Label label1;
        private TextBox txtUsername;
        private Button btnAddReview;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtComment;
        private NumericUpDown nudRating;
    }
}