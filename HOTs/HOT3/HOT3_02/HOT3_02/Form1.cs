using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HOT3_02
{
    public partial class Form1 : Form
    {
        private List<int> scores = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            try
            {
                int score = int.Parse(txtScore.Text);
                if (score >= 0 && score <= 100)
                {
                    scores.Add(score);
                    UpdateStatistics();
                }
                else
                {
                    lblError.Text = "Score must be between 0 and 100";
                    lblError.Visible = true;
                }
            }
            catch (FormatException)
            {
                lblError.Text = "Please enter a numeric score.";
                lblError.Visible = true;
            }
            catch (Exception ex)
            {
                lblError.Text = $"Unexpected error: {ex.Message}";
                lblError.Visible = true;
            }

            txtScore.Clear();
        }

        private void UpdateStatistics()
        {
            lblNumScores.Text = $"Number of Scores: {scores.Count}";
            lblSum.Text = $"Sum: {scores.Sum():F1}";
            lblAverage.Text = $"Average: {(scores.Count > 0 ? scores.Average().ToString("F1") : "N/A")}";
            lblLow.Text = $"Min: {(scores.Count > 0 ? scores.Min().ToString("F1") : "N/A")}";
            lblHigh.Text = $"Max: {(scores.Count > 0 ? scores.Max().ToString("F1") : "N/A")}";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScore.Clear();
            lblError.Visible = false;
            scores.Clear();
            lblNumScores.Text = "Number of Scores: 0";
            lblSum.Text = "Sum: 0";
            lblAverage.Text = "Average: N/A";
            lblLow.Text = "Min: N/A";
            lblHigh.Text = "Max: N/A";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

