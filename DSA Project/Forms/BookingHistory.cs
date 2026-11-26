using System;
using System.Drawing;
using System.Windows.Forms;

namespace DSA_Project
{
    public partial class BookingHistory : Form
    {
        // TODO (Task 05): Add fields and constructors (e.g., customerView) here.

        public BookingHistory()
        {
            InitializeComponent();
        }

        private void BookingHistory_Load(object sender, EventArgs e)
        {
            // TODO (Task 05): Setup history grid and load bookings.
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // TODO (Task 05): Filter booking history as user types.
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            // TODO (Task 05): Filter booking history on search click.
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            // TODO (Task 05): Navigate back to previous screen.
        }

        // TODO (Task 05): Add helper methods here (e.g., SetupGridStyle, LoadHistory, FilterHistory).
    }
}
