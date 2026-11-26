using System;
using System.Drawing;
using System.Windows.Forms;

namespace DSA_Project
{
    public partial class SearchMovieForm : Form
    {
        public SearchMovieForm()
        {
            InitializeComponent();
            // TODO (Task 02): Wire picSearch.Click and dgvMovies.CellDoubleClick if needed.
        }

        private void SearchMovieForm_Load(object sender, EventArgs e)
        {
            // TODO (Task 02): Setup grid columns/style and load movies.
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // TODO (Task 02): Filter movies dynamically by search query.
        }

        private void dgvMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // TODO (Task 02): Handle Book button click to open SeatSelection.
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            // TODO (Task 02): Return to Home screen.
        }

        // TODO (Task 02): Add helper methods here (e.g., SetupGridStyle, LoadMovies, FilterMovies).
    }
}
