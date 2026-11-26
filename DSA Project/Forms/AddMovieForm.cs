using System;
using System.Globalization;
using System.Windows.Forms;

namespace DSA_Project
{
    public partial class AddMovie : Form
    {
        public string MovieTitle { get; private set; }
        public string MovieDescription { get; private set; }
        public string MovieGenre { get; private set; }
        public int MovieDuration { get; private set; }
        public double MovieRating { get; private set; }
        public decimal TicketPrice { get; private set; }
        public string MovieShowtimes { get; private set; }

        public AddMovie()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int duration;
            decimal price;
            double rating;

            if (String.IsNullOrWhiteSpace(txtTitle.Text))
            {
                Invalid(txtTitle, "Title is required.");
                return;
            }
            if (String.IsNullOrWhiteSpace(txtGenre.Text))
            {
                Invalid(txtGenre, "Genre is required.");
                return;
            }
            if (!int.TryParse(txtDuration.Text.Trim(), out duration) || duration <= 0)
            {
                Invalid(txtDuration, "Duration must be a whole number greater than 0.");
                return;
            }
            if (!decimal.TryParse(txtPrice.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out price)
                || price <= 0)
            {
                Invalid(txtPrice, "Price must be a number greater than 0.");
                return;
            }
            if (!double.TryParse(txtRating.Text.Trim(), NumberStyles.Float, CultureInfo.CurrentCulture, out rating)
                || !(rating >= 0 && rating <= 10))
            {
                Invalid(txtRating, "Rating must be between 0 and 10.");
                return;
            }

            MovieTitle = txtTitle.Text.Trim();
            MovieGenre = txtGenre.Text.Trim();
            MovieDuration = duration;
            TicketPrice = price;
            MovieRating = rating;
            MovieShowtimes = txtShowtimes.Text.Trim();
            MovieDescription = txtDescription.Text.Trim();

            DialogResult = DialogResult.OK;
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Invalid(TextBox box, string message)
        {
            MessageBox.Show(this, message, "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            box.Focus();
        }
    }
}
