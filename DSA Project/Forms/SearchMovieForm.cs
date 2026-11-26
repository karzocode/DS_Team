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
            picSearch.Click += picSearch_Click;
            dgvMovies.CellDoubleClick += dgvMovies_CellDoubleClick;
        }

        private void SearchMovieForm_Load(object sender, EventArgs e)
        {
            SetupGridStyle();
            FilterMovies();
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
                Name = "Book",
                HeaderText = "Book",
                Text = "Book",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat
            });

            foreach (DataGridViewColumn column in dgvMovies.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void LoadMovies(string query)
        {
            dgvMovies.Rows.Clear();
            foreach (Movie movie in MovieService.Search(query))
            {
                int index = dgvMovies.Rows.Add(movie.Title, movie.Genre, movie.Duration + " min",
                                               movie.Showtimes, movie.TicketPrice.ToString("0.00"));
                dgvMovies.Rows[index].Tag = movie;
            }
        }

        private void FilterMovies()
        {
            LoadMovies(txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterMovies();
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            FilterMovies();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvMovies_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || dgvMovies.Columns[e.ColumnIndex].Name == "Book")
                return;

            Movie movie = (Movie)dgvMovies.Rows[e.RowIndex].Tag;
            MovieService.SelectedMovie = movie;
            using (MovieDetailsForm details = new MovieDetailsForm())
                details.ShowDialog(this);
            FilterMovies();
        }

        private void dgvMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || dgvMovies.Columns[e.ColumnIndex].Name != "Book")
                return;

            Movie movie = (Movie)dgvMovies.Rows[e.RowIndex].Tag;
            MovieService.SelectedMovie = movie;
            using (SeatSelection seats = new SeatSelection())
                seats.ShowDialog(this);
        }
    }
}
