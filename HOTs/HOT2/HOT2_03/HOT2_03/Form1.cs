using System.Drawing.Text;

namespace HOT2_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            const double SEASON_LENGTH = 20;
            const double LARGE_LOT_FEE = 50.0;
            const double MEDIUM_LOT_FEE = 35.0;
            const double SMALL_LOT_FEE = 25.0;
            if (double.TryParse(txtLength.Text, out double length) && double.TryParse(txtWidth.Text, out double width) && length > 0 && width > 0)
            {
                double area = length * width;
                double weeklyFee = mowingFee(area);
                double total = weeklyFee * SEASON_LENGTH;
                lblArea.Text = $"Total Area: {area} sq ft";
                lblWeeklyFee.Text = $"Weekly Fee: ${weeklyFee:F2}";
                lblSeasonLength.Text = $"Season Length: {SEASON_LENGTH} weeks";
                lblTotal.Text = $"Total Cost: ${total:F2}";
            }
            else
            {
                lblArea.Text = "Please enter valid NUMBERS.";
            }

            double mowingFee(double area)
            {
                if (area >= 600) return LARGE_LOT_FEE;
                if (area >= 400) return MEDIUM_LOT_FEE;
                return SMALL_LOT_FEE;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLength.Clear();
            txtWidth.Clear();
            lblArea.Text = "";
            lblWeeklyFee.Text = "";
            lblSeasonLength.Text = "";
            lblTotal.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
