namespace EX1
{
    public partial class Password_Cracker : Form
    {
        private Dictionary<string, string> knownHashes = new Dictionary<string, string>
        {
            { "e10adc3949ba59abbe56e057f20f883e", "123456" },
            { "25f9e794323b453885f5181f1b624d0b", "123456789" },
            { "d8578edf8458ce06fbc5bb76a58c5ca4", "qwerty" },
            { "96e79218965eb72c92a549dd5a330112", "111111" },
            { "5f4dcc3b5aa765d61d8327deb882cf99", "password" },
            { "6eea9b7ef19179a06954edd0f6c05ceb", "qwertyuiop" },
            { "c8837b23ff8aaa8a2dde915473ce0991", "123321" },
            { "c822c1b63853ed273b89687ac505f9fa", "google" },
            { "161ebd7d45089b3446ee4e0d86dbcf92", "P@ssw0rd" },
            { "4ece57a61323b52ccffdbef021956754", "Tr0ub4dor&3" }
        };
        public Password_Cracker()
        {
            InitializeComponent();
        }

        private void btnCrack_Click(object sender, EventArgs e)
        {
            string inputHash = txtHash.Text.Trim();
            string result = CrackPassword(inputHash);
            lblResult.Text = result ?? "* FAIL *";
        }

        private string CrackPassword(string hash)
        {
            if (knownHashes.TryGetValue(hash, out string password))
            {
                return password;
            }

            return null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHash.Text = "";
            lblResult.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
