namespace LoanLibrary
{
    public partial class frmBankLoan : Form
    {
        public frmBankLoan()
        {
            InitializeComponent();
        }


        private ILoan currentLoan;
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            if (!Validator.IsPresent(name))
            {
                MessageBox.Show("Please enter a loan name.", "Input Error");
                return;
            }

            if (!Validator.IsDecimal(txtAmount.Text) || !Validator.IsWithinRange(Convert.ToDecimal(txtAmount.Text), 1, decimal.MaxValue))
            {
                MessageBox.Show("Please enter a valid positive loan amount.", "Input Error");
                return;
            }

            decimal amount = Convert.ToDecimal(txtAmount.Text);

            if (shortTermRadioButton.Checked)
            {
                currentLoan = new ShortTermLoan(name, amount);
            }
            else if (longTermRadioButton.Checked)
            {
                currentLoan = new LongTermLoan(name, amount);
            }
            else
            {
                MessageBox.Show("Please select a loan type.", "Input Error");
                return;
            }

            btnPayment.Enabled = true;
            UpdateDisplay();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            currentLoan.MakePayment();
            currentLoan.ApplyInterest();
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            lblName.Text = currentLoan.Name;
            lblAmount.Text = $"{currentLoan.LoanType} loan of {currentLoan.InitialAmount:C2}";
            lblPayment.Text = $"After the last payment the loan is down to {currentLoan.PreInterestAmount:C2}";
            lblTotal.Text = $"After the last interest accumulation is now {currentLoan.Balance:C2}";
            if (currentLoan.Balance <= 0)
            {
                MessageBox.Show("Congratulations! Your loan is fully paid off.", "Loan Paid Off");
                btnPayment.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAmount.Text = "";
            lblName.Text = "";
            lblAmount.Text = "";
            lblPayment.Text = "";
            lblTotal.Text = "";
            txtName.Focus();
        }
    }
    public class ShortTermLoan : Loan
    {
        private const decimal MonthlyPayment = 450m;
        private const decimal InterestRate = 0.10m;

        public ShortTermLoan(string name, decimal balance)
        {
            Name = name;
            Balance = balance;
            InitialAmount = balance;
            PreInterestAmount = balance;
            LoanType = "Short-Term";
        }

        public override void MakePayment()
        {
            Balance = Math.Max(0, Balance - MonthlyPayment);
            PreInterestAmount = Balance;
        }

        public override void ApplyInterest()
        {
            Balance += Balance * InterestRate;
        }
    }

    public class LongTermLoan : Loan
    {
        private const decimal MonthlyPayment = 200m;
        private const decimal InterestRate = 0.05m;

        public LongTermLoan(string name, decimal balance)
        {
            Name = name;
            Balance = balance;
            InitialAmount = balance;
            PreInterestAmount = balance;
            LoanType = "Long-Term";
        }

        public override void MakePayment()
        {
            Balance = Math.Max(0, Balance - MonthlyPayment);
            PreInterestAmount = Balance;
        }

        public override void ApplyInterest()
        {
            Balance += Balance * InterestRate;
        }
    }

    public static class Validator
    {
        public static bool IsPresent(string value) => !string.IsNullOrWhiteSpace(value);
        public static bool IsDecimal(string value) => decimal.TryParse(value, out _);
        public static bool IsInt32(string value) => int.TryParse(value, out _);
        public static bool IsWithinRange(decimal value, decimal min, decimal max) => (value >= min && value <= max);
    }

    public interface ILoan
    {
        string Name { get; set; }
        decimal Balance { get; set; }
        string LoanType { get; set; }
        public decimal InitialAmount { get; set; }
        public decimal PreInterestAmount { get; set; }
        void MakePayment();
        void ApplyInterest();
    }

    public abstract class Loan : ILoan
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public string LoanType { get; set; }
        public decimal InitialAmount { get; set; }
        public decimal PreInterestAmount { get; set; }

        public abstract void MakePayment();
        public abstract void ApplyInterest();
    }
}

