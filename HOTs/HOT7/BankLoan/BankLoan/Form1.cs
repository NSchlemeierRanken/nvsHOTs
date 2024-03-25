namespace BankLoan
{
    public partial class Form1 : Form
    {
        private ILoan currentLoan;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            if (!double.TryParse(txtAmount.Text, out double amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid, positive loan amount.");
                return;
            }

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
                MessageBox.Show("Please select a loan type.");
                return;
            }

            UpdateLoanDetails();
            btnPayment.Enabled = true;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            currentLoan?.MakePayment();
            currentLoan?.ApplyInterest();
            UpdateLoanDetails();
        }

        private void UpdateLoanDetails()
        {
            if (currentLoan != null)
            {
                lblName.Text = currentLoan.Name;
                lblLoanType.Text = $"{currentLoan.Type} loan of {currentLoan.InitialAmount:C2}";
                lblPayment.Text = $"After the last payment the loan is down to {currentLoan.PreInterestBalance:C2}";
                lblTotal.Text = $"After the last interest accumulation the loan is now {currentLoan.Balance:C2}";
            }
        }

        public interface ILoan
        {
            string Name { get; }
            string Type { get; }
            double Balance { get; }
            double InitialAmount { get; }
            public double PreInterestBalance { get; }
            void MakePayment();
            void ApplyInterest();
        }

        public class LongTermLoan : ILoan
        {
            public string Name { get; private set; }
            public string Type { get; private set; } = "Long-Term";
            public double Balance { get; private set; }
            public double InitialAmount { get; private set; }
            public double PreInterestBalance { get; private set; }
            private double payment = 200.0;
            private double interestRate = 0.05;

            public LongTermLoan(string name, double amount)
            {
                Name = name;
                Balance = amount;
                InitialAmount = amount;
            }

            public void MakePayment()
            {
                Balance -= payment;
                PreInterestBalance = Balance;
            }

            public void ApplyInterest()
            {
                Balance += Balance * interestRate;
            }
        }

        public class ShortTermLoan : ILoan
        {
            public string Name { get; private set; }
            public string Type { get; private set; } = "Short-Term";
            public double Balance { get; private set; }
            public double InitialAmount { get; private set; }
            public double PreInterestBalance { get; private set; }
            private double payment = 450.0;
            private double interestRate = 0.10;

            public ShortTermLoan(string name, double amount)
            {
                Name = name;
                Balance = amount;
                InitialAmount = amount;
            }

            public void MakePayment()
            {
                Balance -= payment;
                PreInterestBalance = Balance;
            }

            public void ApplyInterest()
            {
                Balance += Balance * interestRate;
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
            txtName.Focus();

            shortTermRadioButton.Checked = false;
            longTermRadioButton.Checked = false;
            btnPayment.Enabled = false;
            currentLoan = null;

            lblName.Text = "";
            lblLoanType.Text = "";
            lblPayment.Text = "";
            lblTotal.Text = "";
        }
    }
}
