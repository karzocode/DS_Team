using System;
using System.Windows.Forms;

namespace DSA_Project
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.OverViewPic = new System.Windows.Forms.PictureBox();
            this.LogoutPic = new System.Windows.Forms.PictureBox();
            this.BookingPic = new System.Windows.Forms.PictureBox();
            this.MovieManagePic = new System.Windows.Forms.PictureBox();
            this.lblMoviesCount = new System.Windows.Forms.Label();
            this.lblBookingsCount = new System.Windows.Forms.Label();
            this.lblAvailableCount = new System.Windows.Forms.Label();
            this.lblTicketsSold = new System.Windows.Forms.Label();
            this.dgvRecentBookings = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.OverViewPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookingPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieManagePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // OverViewPic
            // 
            this.OverViewPic.BackColor = System.Drawing.Color.Transparent;
            this.OverViewPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OverViewPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OverViewPic.Image = ((System.Drawing.Image)(resources.GetObject("OverViewPic.Image")));
            this.OverViewPic.Location = new System.Drawing.Point(30, 11);
            this.OverViewPic.Name = "OverViewPic";
            this.OverViewPic.Size = new System.Drawing.Size(196, 72);
            this.OverViewPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OverViewPic.TabIndex = 0;
            this.OverViewPic.TabStop = false;
            this.OverViewPic.Click += new System.EventHandler(this.OverViewPic_Click);
            // 
            // LogoutPic
            // 
            this.LogoutPic.BackColor = System.Drawing.Color.Transparent;
            this.LogoutPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutPic.Image = ((System.Drawing.Image)(resources.GetObject("LogoutPic.Image")));
            this.LogoutPic.Location = new System.Drawing.Point(980, 10);
            this.LogoutPic.Name = "LogoutPic";
            this.LogoutPic.Size = new System.Drawing.Size(179, 73);
            this.LogoutPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoutPic.TabIndex = 1;
            this.LogoutPic.TabStop = false;
            this.LogoutPic.Click += new System.EventHandler(this.LogoutPic_Click);
            // 
            // BookingPic
            // 
            this.BookingPic.BackColor = System.Drawing.Color.Transparent;
            this.BookingPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookingPic.Image = ((System.Drawing.Image)(resources.GetObject("BookingPic.Image")));
            this.BookingPic.Location = new System.Drawing.Point(534, 14);
            this.BookingPic.Name = "BookingPic";
            this.BookingPic.Size = new System.Drawing.Size(282, 69);
            this.BookingPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BookingPic.TabIndex = 2;
            this.BookingPic.TabStop = false;
            this.BookingPic.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // MovieManagePic
            // 
            this.MovieManagePic.BackColor = System.Drawing.Color.Transparent;
            this.MovieManagePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MovieManagePic.Image = ((System.Drawing.Image)(resources.GetObject("MovieManagePic.Image")));
            this.MovieManagePic.Location = new System.Drawing.Point(224, 13);
            this.MovieManagePic.Name = "MovieManagePic";
            this.MovieManagePic.Size = new System.Drawing.Size(324, 70);
            this.MovieManagePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MovieManagePic.TabIndex = 3;
            this.MovieManagePic.TabStop = false;
            this.MovieManagePic.Click += new System.EventHandler(this.MovieManagePic_Click);
            // 
            // lblMoviesCount
            // 
            this.lblMoviesCount.AutoSize = true;
            this.lblMoviesCount.BackColor = System.Drawing.Color.Transparent;
            this.lblMoviesCount.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.lblMoviesCount.ForeColor = System.Drawing.Color.White;
            this.lblMoviesCount.Location = new System.Drawing.Point(78, 278);
            this.lblMoviesCount.Name = "lblMoviesCount";
            this.lblMoviesCount.Size = new System.Drawing.Size(130, 54);
            this.lblMoviesCount.TabIndex = 4;
            this.lblMoviesCount.Text = "label1";
            // 
            // lblBookingsCount
            // 
            this.lblBookingsCount.AutoSize = true;
            this.lblBookingsCount.BackColor = System.Drawing.Color.Transparent;
            this.lblBookingsCount.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.lblBookingsCount.ForeColor = System.Drawing.Color.White;
            this.lblBookingsCount.Location = new System.Drawing.Point(382, 278);
            this.lblBookingsCount.Name = "lblBookingsCount";
            this.lblBookingsCount.Size = new System.Drawing.Size(130, 54);
            this.lblBookingsCount.TabIndex = 5;
            this.lblBookingsCount.Text = "label2";
            // 
            // lblAvailableCount
            // 
            this.lblAvailableCount.AutoSize = true;
            this.lblAvailableCount.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailableCount.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.lblAvailableCount.ForeColor = System.Drawing.Color.White;
            this.lblAvailableCount.Location = new System.Drawing.Point(686, 278);
            this.lblAvailableCount.Name = "lblAvailableCount";
            this.lblAvailableCount.Size = new System.Drawing.Size(130, 54);
            this.lblAvailableCount.TabIndex = 6;
            this.lblAvailableCount.Text = "label3";
            // 
            // lblTicketsSold
            // 
            this.lblTicketsSold.AutoSize = true;
            this.lblTicketsSold.BackColor = System.Drawing.Color.Transparent;
            this.lblTicketsSold.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.lblTicketsSold.ForeColor = System.Drawing.Color.White;
            this.lblTicketsSold.Location = new System.Drawing.Point(991, 278);
            this.lblTicketsSold.Name = "lblTicketsSold";
            this.lblTicketsSold.Size = new System.Drawing.Size(130, 54);
            this.lblTicketsSold.TabIndex = 7;
            this.lblTicketsSold.Text = "label4";
            // 
            // dgvRecentBookings
            // 
            this.dgvRecentBookings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecentBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentBookings.Location = new System.Drawing.Point(73, 450);
            this.dgvRecentBookings.Name = "dgvRecentBookings";
            this.dgvRecentBookings.RowHeadersWidth = 51;
            this.dgvRecentBookings.RowTemplate.Height = 24;
            this.dgvRecentBookings.Size = new System.Drawing.Size(1142, 229);
            this.dgvRecentBookings.TabIndex = 8;
            // 
            // AdminDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.dgvRecentBookings);
            this.Controls.Add(this.lblTicketsSold);
            this.Controls.Add(this.lblAvailableCount);
            this.Controls.Add(this.lblBookingsCount);
            this.Controls.Add(this.lblMoviesCount);
            this.Controls.Add(this.MovieManagePic);
            this.Controls.Add(this.BookingPic);
            this.Controls.Add(this.LogoutPic);
            this.Controls.Add(this.OverViewPic);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashBoard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OverViewPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookingPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieManagePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox OverViewPic;
        private System.Windows.Forms.PictureBox LogoutPic;
        private System.Windows.Forms.PictureBox BookingPic;
        private System.Windows.Forms.PictureBox MovieManagePic;
        private System.Windows.Forms.Label lblMoviesCount;
        private System.Windows.Forms.Label lblBookingsCount;
        private System.Windows.Forms.Label lblAvailableCount;
        private System.Windows.Forms.Label lblTicketsSold;
        private System.Windows.Forms.DataGridView dgvRecentBookings;
    }
}