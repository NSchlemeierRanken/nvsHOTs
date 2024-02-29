using System.Drawing;

namespace Card_Store
{
    public partial class frmCardStore : Form
    {
        decimal MOTHERSDAYCARDCOST = 2.00m;
        decimal FATHERSDAYCARDCOST = 2.50M;
        decimal GRANDPARENTSDAYCARDCOST = 3.0m;
        decimal ENVELOPECOST = 0.25m;
        decimal STAMPCOST = 0.50m;
        decimal CUSTOMMESSAGECOST = 0.30m;

        Dictionary<string, Dictionary<string, decimal>> occasionsToStyles = new Dictionary<string, Dictionary<string, decimal>>();
        public frmCardStore()
        {
            InitializeComponent();
        }

        private void frmCardStore_Load(object sender, EventArgs e)
        {
            occasionsToStyles.Add("Mother's Day", new Dictionary<string, decimal>
           {
               { "Style 1", MOTHERSDAYCARDCOST},
               { "Style 2", MOTHERSDAYCARDCOST + 0.25m },
               { "Style 3", MOTHERSDAYCARDCOST + 0.50m }
           });
            occasionsToStyles.Add("Father's Day", new Dictionary<string, decimal>
            {
                { "Style A", FATHERSDAYCARDCOST },
                { "Style B", FATHERSDAYCARDCOST + 0.35m },
                { "Style C", FATHERSDAYCARDCOST + 0.60m },
            });
            occasionsToStyles.Add("Grandparent's Day", new Dictionary<string, decimal>
            {
                { "Happy", GRANDPARENTSDAYCARDCOST },
                { "Funny", GRANDPARENTSDAYCARDCOST + 0.45m },
                { "Loving", GRANDPARENTSDAYCARDCOST + 0.70M }
            });

            foreach (var occasion in occasionsToStyles.Keys)
            {
                ddlOccasions.Items.Add(occasion);
            }

            txtCustomMessage.Enabled = false;
        }

        private void ddlOccasions_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlStyles.Items.Clear();
            string selectedOcassion = ddlOccasions.SelectedItem.ToString();
            if (occasionsToStyles.TryGetValue(selectedOcassion, out var styles))
            {
                foreach (var style in styles)
                {
                    ddlStyles.Items.Add($"{style.Key} - ${style.Value}");
                }
            }
            UpdateTotalCost();
        }

        private void chkCustomMessage_CheckedChanged(object sender, EventArgs e)
        {
            txtCustomMessage.Enabled = chkCustomMessage.Checked;
            UpdateTotalCost();
        }

        private void UpdateTotalCost()
        {
            decimal totalCost = 0;
            if (ddlStyles.SelectedItem != null)
            {
                string selectedStyle = ddlStyles.SelectedItem.ToString();
                var costString = selectedStyle.Split('$')[1];
                if (decimal.TryParse(costString, out var baseCost))
                {
                    totalCost += baseCost;
                }
            }

            if (chkEnvelope.Checked) totalCost += ENVELOPECOST;
            if (chkStamp.Checked) totalCost += STAMPCOST;
            if (chkCustomMessage.Checked) totalCost += CUSTOMMESSAGECOST;

            lblTotalCost.Text = $"Total Cost: ${totalCost}";
        }

        private void ddlStyles_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotalCost();
            UpdateCardImage();
        }

        private void chkBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalCost();
        }

        private void Control_Enter(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.LightBlue;
        }

        private void Control_Leave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.LightGray;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateCardImage()
        {
            if (ddlStyles.SelectedItem == null || ddlOccasions.SelectedItem == null)
            {
                pbCard.Image = null;
                return;
            }
            string selectedStyle = ddlStyles.SelectedItem.ToString().Split('-')[0].Trim(); // Grabs "Style 1" , "Style B", "Happy" from the name in the dictionary string
            string occasion = ddlOccasions.SelectedItem.ToString().Replace("'", ""); // Removes apostrophes and spaces for occasions
            var imageName = $"{selectedStyle}_{occasion}.jpg".Replace(" ", "").Replace("'", ""); // Converts to match the file name
            string imagePath = Path.Combine(Application.StartupPath, "Images", imageName); // Creates the full path to the image

            try
            {
                if (File.Exists(imagePath))
                {
                    pbCard.Image = Image.FromFile(imagePath);
                }
                else
                {
                    pbCard.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading card image {ex.Message}", "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateImageText(string text)
        {
            if (pbCard.Image == null)
            {
                MessageBox.Show("No image selected.");
                return;
            }

            Bitmap bitmap = new Bitmap(pbCard.Image);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // Text Settings (Font,Location,Color)
                Font font = new Font("Arial", 40, FontStyle.Bold, GraphicsUnit.Pixel);
                PointF point = new Point(50, 50);
                SolidBrush brush = new SolidBrush(Color.White);
                //Background color for text
                SizeF textSize = g.MeasureString(text, font);
                RectangleF textBackground = new RectangleF(point, textSize);
                g.FillRectangle(new SolidBrush(Color.Black), textBackground);
                // Draw the string
                g.DrawString(text, font, brush, point);
            }

            // Dispose of image
            if (pbCard.Image != null)
            {
                pbCard.Image.Dispose();
            }

            pbCard.Image = bitmap;
        }

        private void txtCustomMessage_TextChanged(object sender, EventArgs e)
        {
            UpdateImageText(txtCustomMessage.Text);
        }
    }
}
