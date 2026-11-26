using System;
using System.Drawing;
using System.Windows.Forms;

namespace DSA_Project
{
    public partial class AdminMovieManagement : Form
    {
        public AdminMovieManagement()
        {
            InitializeComponent();
        }

        private void AdminMovieManagement_Load(object sender, EventArgs e)
        {
            // TODO (Task 02): Setup movies grid and load movies.
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // TODO (Task 02): Filter movies list by search text.
        }

        private void dgvMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // TODO (Task 02): Handle movie row actions (e.g., Delete).
        }

        private void picAddMovie_Click(object sender, EventArgs e)
        {
            // TODO (Task 02): Open AddMovie form and add new movie.
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            // TODO (Task 02): Return to AdminDashboard.
        }

        // TODO (Task 02): Add helper methods here (e.g., SetupGridStyle, LoadMovies).
    }
}
