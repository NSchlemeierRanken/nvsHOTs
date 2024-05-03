using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class FrmDetails : Form
    {
        private Book currentBook;
        public FrmDetails(Book book)
        {
            InitializeComponent();
            currentBook = book;
            DisplayBookDetails();
            PopulateReviews();
            SetupControls();
        }

        private void SetupControls()
        {
            // Set up the Numeric UpDown for ratings
            nudRating.Minimum = 1;
            nudRating.Maximum = 10;
            nudRating.Value = 1;
        }

        private void DisplayBookDetails()
        {
            lblTitle.Text = currentBook.Title;
            lblYear.Text = $"Published: {currentBook.Year.ToString()}";
            lblISBN.Text = $"ISBN: {currentBook.ISBN}";
            lblAuthor.Text = $"By: {currentBook.Author}";

            try
            {
                pictureBoxBook.ImageLocation = currentBook.ImageUrl;
                pictureBoxBook.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch
            {
                MessageBox.Show("Failed to load book image.", "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateReviews()
        {
            dataGridViewReviews.DataSource = currentBook.Reviews
                            .Select(r => new { Username = r.Username, Comment = r.Comment, Rating = r.Rating })
                            .ToList();
            dataGridViewReviews.Refresh();
        }

        private void btnAddReview_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string comment = txtComment.Text.Trim();
            int rating = (int)nudRating.Value;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(comment))
            {
                MessageBox.Show("Username and comment fields cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            currentBook.Reviews.Add(new Review(username, comment, rating));
            PopulateReviews();
            ClearReviewInputFields();
            MessageBox.Show("Review added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearReviewInputFields()
        {
            txtUsername.Clear();
            txtComment.Clear();
            nudRating.Value = nudRating.Minimum;
        }
    }
}
