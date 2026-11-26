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
            SetupGridStyle();
            LoadMovies();
        }

        private void SetupGridStyle()
        {
            dgvMovies.AllowUserToAddRows = false;
            dgvMovies.AllowUserToDeleteRows = false;
            dgvMovies.ReadOnly = true;
            dgvMovies.RowHeadersVisible = false;
            dgvMovies.MultiSelect = false;
            dgvMovies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMovies.RowTemplate.Height = 40;

            dgvMovies.BackgroundColor = Color.FromArgb(40, 30, 38);
            dgvMovies.BorderStyle = BorderStyle.None;
            dgvMovies.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMovies.EnableHeadersVisualStyles = false;
            dgvMovies.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(108, 64, 70);
            dgvMovies.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMovies.DefaultCellStyle.BackColor = Color.FromArgb(40, 30, 38);
            dgvMovies.DefaultCellStyle.ForeColor = Color.White;
            dgvMovies.DefaultCellStyle.SelectionBackColor = Color.FromArgb(108, 64, 70);
            dgvMovies.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvMovies.Columns.Clear();
            dgvMovies.Columns.Add("Title", "Title");
            dgvMovies.Columns.Add("Genre", "Genre");
            dgvMovies.Columns.Add("Duration", "Duration");
            dgvMovies.Columns.Add("ShowTime", "ShowTime");
            dgvMovies.Columns.Add("Price", "Price");
            dgvMovies.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat
            });

            foreach (DataGridViewColumn column in dgvMovies.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void LoadMovies()
        {
            dgvMovies.Rows.Clear();
            foreach (Movie movie in MovieService.Search(txtSearch.Text))
            {
                int index = dgvMovies.Rows.Add(movie.Title, movie.Genre, movie.Duration + " min",
                                               movie.Showtimes, movie.TicketPrice.ToString("0.00"));
                dgvMovies.Rows[index].Tag = movie;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadMovies();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picAddMovie_Click(object sender, EventArgs e)
        {
            using (AddMovie form = new AddMovie())
            {
                while (form.ShowDialog(this) == DialogResult.OK)
                {
                    Movie movie = new Movie
                    {
                        Title = form.MovieTitle,
                        Description = form.MovieDescription,
                        Genre = form.MovieGenre,
                        Duration = form.MovieDuration,
                        Rating = form.MovieRating,
                        TicketPrice = form.TicketPrice,
                        Showtimes = form.MovieShowtimes
                    };

                    try
                    {
                        MovieService.Add(movie);
                        LoadMovies();
                        break;
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(this, ex.Message, "Duplicate title",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void dgvMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || dgvMovies.Columns[e.ColumnIndex].Name != "Delete")
                return;

            Movie movie = (Movie)dgvMovies.Rows[e.RowIndex].Tag;
            DialogResult answer = MessageBox.Show(this, "Delete \"" + movie.Title + "\"?", "Confirm delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (answer != DialogResult.Yes)
                return;

            MovieService.Remove(movie.Id);
            LoadMovies();
        }
    }
}
