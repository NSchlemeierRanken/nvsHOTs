namespace HOT2_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double MAX_GPA = 4.0;
            double MIN_GPA = 0.0;
            if (double.TryParse(txtGrade.Text, out double GPA) && GPA >= MIN_GPA && GPA <= MAX_GPA)
            {
                string txtGrade = convertGPA(GPA);
                lblResult.Text = $"GPA: {GPA:F2}  Letter Grade: {txtGrade}";
            }
            else
            {
                lblResult.Text = "Please enter a GPA between 0.0 and 4.0.";
            }
        }

        private string convertGPA(double GPA)
        {
            if (GPA > 3.0) return "A";
            if (GPA > 2.0) return "B";
            if (GPA > 1.0) return "C";
            if (GPA > 0.0) return "D";
            return "F";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGrade.Clear();
            lblResult.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
