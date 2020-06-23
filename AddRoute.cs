using System;
using System.Windows.Forms;

namespace BRS
{
    public partial class AddRoute : Form
    {
        public AddRoute()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_DASHBOARD dashboard = new ADMIN_DASHBOARD();
            dashboard.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DestinationTextBox.Text)
                || string.IsNullOrEmpty(OriginTextBox.Text))
            {
                MessageBox.Show("Please fill in all the fields!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Route route = new Route(OriginTextBox.Text, DestinationTextBox.Text);

                string message = "Route added Successfully";
                bool isAdded = route.addRecord();

                if (isAdded)
                {
                    OriginTextBox.Text = "";
                    DestinationTextBox.Text = "";
                    MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cencel_Click(object sender, EventArgs e)
        {
            
            ADMIN_DASHBOARD dashboard = new ADMIN_DASHBOARD();
            dashboard.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            ADMIN_DASHBOARD DB = new ADMIN_DASHBOARD();
            DB.Show();
            this.Hide();
        }
    }
}
