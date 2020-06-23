using BRS.SupportClasses;
using System;
using System.Windows.Forms;

namespace BRS
{
    public partial class ShowRecords : Form
    {
        string queryToShowTable;

        public ShowRecords(string query)
        {
            queryToShowTable = query;
            InitializeComponent();
        }

        private void SHOW_BOOKING_Load(object sender, EventArgs e)
        {
            Database.ShowRecords(queryToShowTable, bookingDataGridView);
        }

        private void back_Click(object sender, EventArgs e)
        {
            
            ADMIN_DASHBOARD dashboard = new ADMIN_DASHBOARD();
            dashboard.Show();
            this.Hide();
        }
    }
}
