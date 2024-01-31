namespace HOT2_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            const double INCHES_PER_YD = 36.0;
            if (double.TryParse(txtInches.Text, out double inches))
            {
                double yards = inches / INCHES_PER_YD;
                lblResult.Text = $"{inches:F2} inches = {yards:F2} yards";
            }
            else
            {
                lblResult.Text = "Please enter a number.";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInches.Clear();
            lblResult.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
