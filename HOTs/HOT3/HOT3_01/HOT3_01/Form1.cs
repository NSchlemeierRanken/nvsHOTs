namespace HOT3_01
{
    public partial class Form1 : Form
    {
        private const decimal cherryCost = 125m;
        private const decimal mapleCost = 150m;
        private const decimal oakCost = 140m;
        private const decimal pineCost = 100m;
        private const decimal drawerCharge = 30m;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEstimate_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                string woodType = GetWood();
                if (woodType != "")
                {
                    int drawers = GetDrawers();
                    decimal woodCost = CalculateWoodCost(woodType);
                    decimal drawerCost = CalculateDrawerCost(drawers);
                    decimal totalCost = CalculateTotalCost(woodCost, drawerCost);

                    lblWood.Text = $"${woodCost.ToString("F2")}";
                    lblDrawers.Text = $"${drawerCost.ToString("F2")}";
                    lblTotal.Text = $"${totalCost.ToString("F2")}";
                }
                else
                {
                    MessageBox.Show("Invalid wood type. Please enter 'c' for cherry, 'm' for maple, 'o' for oak, or 'p' for pine.", "Input Error");
                }
            }
        }
        private bool IsPresent(string value, string fieldName)
        {
            if (string.IsNullOrEmpty(value))
            {
                MessageBox.Show($"{fieldName} is required.", "Input Error");
                return false;
            }
            return true;
        }
        private bool IsWithinRange(string value, string fieldName, int minValue, int maxValue)
        {
            if (int.TryParse(value, out int numberValue))
            {
                if (numberValue < minValue || numberValue > maxValue)
                {
                    MessageBox.Show($"{fieldName} must be between {minValue} and {maxValue}.", "Input Error");
                    return false;
                }
                return true;
            }
            MessageBox.Show($"{fieldName} must be an integer.", "Input Error");
            return false;
        }
        private bool IsValidData()
        {
            return IsPresent(txtWood.Text, "Wood Type") &&
                IsWoodTypeValid(txtWood.Text) &&
                IsInt(txtDrawers.Text, "Drawers") &&
                IsWithinRange(txtDrawers.Text, "Drawers", 1, 9);
        }
        private string GetWood()
        {
            string input = txtWood.Text.ToLower();
            if (input.Length > 0)
            {
                char firstChar = input[0];
                switch (firstChar)
                {
                    case 'c': return "cherry";
                    case 'm': return "maple";
                    case 'o': return "oak";
                    case 'p': return "pine";
                    default: return "";
                }
            }
            return "";
        }
        private bool IsWoodTypeValid(string woodType)
        {
            if (woodType.Length > 0)
            {
                char firstChar = woodType.ToLower()[0];
                return firstChar == 'c' || firstChar == 'm' || firstChar == 'o' || firstChar == 'p';
            }
            return false;
        }

        private int GetDrawers()
        {
            return int.TryParse(txtDrawers.Text, out int drawers) ? drawers : 0;
        }

        private bool IsInt(string value, string fieldName)
        {
            if (int.TryParse(value, out _))
            {
                return true;
            }
            else
            {
                MessageBox.Show($"{fieldName} must be an integer.", "Input Error");
                return false;
            }
        }
        private decimal CalculateWoodCost(string woodType)
        {
            switch (woodType)
            {
                case "cherry": return cherryCost;
                case "maple": return mapleCost;
                case "oak": return oakCost;
                case "pine": return pineCost;
                default: return 0;
            }
        }
        private decimal CalculateDrawerCost(int drawers)
        {
            return drawerCharge * drawers;
        }

        private decimal CalculateTotalCost(decimal woodCost, decimal drawerCost)
        {
            return woodCost + drawerCost;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtWood.Clear();
            txtDrawers.Clear();
            lblTotal.Text = string.Empty;
            lblWood.Text = string.Empty;
            lblDrawers.Text = string.Empty;
        }
    }
}
