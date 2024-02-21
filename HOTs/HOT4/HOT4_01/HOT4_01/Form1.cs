namespace HOT4_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> firstName = new List<string>() { "Markel", "Luiza", "Bryony", "Giraldo", "Lowri" };
        List<string> lastName = new List<string>() { "Diggory", "Gunnar", "Hester", "Addy", "Hari" };
        List<string> phoneNumber = new List<string>() { "555-8390", "555-4618", "555-4440", "555-1687", "555-7763" };

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.ToLower();
            bool found = false;

            for (int i = 0; i < firstName.Count; i++)
            {
                if (firstName[i].ToLower().Contains(searchTerm) || lastName[i].ToLower().Contains(searchTerm))
                {
                    DisplayUserInfo(i);
                    found = true;
                    break;
                    
                }
            }

            if (!found)
            {
                lblFirstName.Text = "error";
                lblLastName.Text = "error";
                lblNumber.Text = "error";
                lblError.Text = "USER NOT FOUND";
            }
        }

        private void DisplayUserInfo(int index)
        {
            lblFirstName.Text = firstName[index];
            lblLastName.Text = lastName[index];
            lblNumber.Text = phoneNumber[index];
            lblError.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            lblFirstName.Text = "";
            lblLastName.Text = "";
            lblNumber.Text = "";
            lblError.Text = "";
        }
    }
}
