namespace HOT4_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            string name = txtNameInput.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name cannot be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (ListViewItem item in lvNames.Items)
            {
                if (item.Text.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("This name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            lvNames.Items.Add(new ListViewItem(name));
            txtNameInput.Clear();
        }

        private void btnUpdateName_Click(object sender, EventArgs e)
        {
            if (lvNames.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a name to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string newName = txtNameInput.Text.Trim();

            if (string.IsNullOrEmpty(newName))
            {
                MessageBox.Show("Name cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (ListViewItem item in lvNames.Items)
            {
                if (item.Text.Equals(newName, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("This name already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            lvNames.SelectedItems[0].Text = newName;
            txtNameInput.Clear();
        }

        private void btnDeleteName_Click(object sender, EventArgs e)
        {
            if (lvNames.SelectedItems.Count > 0 && MessageBox.Show("Are you sure you want to delete this name?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lvNames.Items.Remove(lvNames.SelectedItems[0]);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lvNames.Items.Clear();
            txtNameInput.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
