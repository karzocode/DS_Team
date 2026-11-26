using System;
using System.Drawing;
using System.Windows.Forms;

namespace DSA_Project
{
    public partial class MovieDetailsForm : Form
    {
        // TODO (Task 01): Add fields and constructors accepting Movie details here.

        public MovieDetailsForm()
        {
            InitializeComponent();
        }

        private void MovieDetailsForm_Load(object sender, EventArgs e)
        {
            // TODO (Task 01): Display movie title, info, description, and showtime.
        }

        private void picChooseSeats_Click(object sender, EventArgs e)
        {
            // TODO (Task 01): Store selected movie and open SeatSelection.
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            // TODO (Task 01): Close MovieDetailsForm.
        }
    }
}
