using Accessibility;
using Microsoft.VisualBasic.Devices;
using System.Net;

namespace EX2
{
    public partial class Network_Scanner : Form
    {
        private List<ComputerInfo> knownComputers = new List<ComputerInfo>
        {
            new ComputerInfo
            {
                Name = "My-Desktop", IpAddress = "127.0.0.1",
                Services = new Dictionary<int, string>
                {
                    { 20, "FTP_DATA" },
                    { 21, "FTP_CONTROL" },
                    { 23, "TELNET" },
                    { 25, "SMTP" },
                    { 53, "DNS" },
                    { 80, "HTTP" },
                    { 123, "NTP" },
                    { 389, "LDAP" },
                    { 443, "HTTPS" },
                }
            },
            new ComputerInfo
            {
                Name = "google-public-dns-a", IpAddress = "8.8.8.8",
                Services = new Dictionary<int, string>
                {
                    { 53, "DNS" }
                }
            },
            new ComputerInfo
            {
                Name = "ranken.edu", IpAddress = "47.44.246.80",
                Services = new Dictionary<int, string>
                {
                    { 25, "SMTP" },
                    { 80, "HTTP" },
                    { 443, "HTTPS" }
                }
            }

        };

        public Network_Scanner()
        {
            InitializeComponent();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            var result = ScanIpAddress(txtAddress.Text.Trim());
            ShowComputer(result);
        }

        private ComputerInfo ScanIpAddress(string ipAddress)
        {
            return knownComputers.FirstOrDefault(computer => computer.IpAddress == ipAddress);
        }

        private void ShowComputer(ComputerInfo computer)
        {
            if (computer != null)
            {
                string servicesInfo = string.Join(Environment.NewLine, computer.Services.Select(s => $"{s.Key}: {s.Value}"));
                lblComputer.Text = computer.Name;
                lblServices.Text = servicesInfo;
                lblAdress.Text = computer.IpAddress;
                lblServiceHeading.Text = "Services";
            }
            else
            {
                lblComputer.Text = "Request Timed Out";
                lblServices.Text = "NONE";
                lblAdress.Text = "";
                lblServiceHeading.Text = "Services";
            }
        }

        public class ComputerInfo
        {
            public string Name { get; set; }
            public string IpAddress { get; set; }
            public Dictionary<int, string> Services { get; set; }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";
            lblComputer.Text = "";
            lblAdress.Text = "";
            lblServices.Text = "";
            lblServiceHeading.Text = "";
            txtAddress.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
