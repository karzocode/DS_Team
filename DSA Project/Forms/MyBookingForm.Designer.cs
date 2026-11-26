namespace DSA_Project
{
    partial class MyBookingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyBookingForm));
            this.picBackTop = new System.Windows.Forms.PictureBox();
            this.picBackToSeats = new System.Windows.Forms.PictureBox();
            this.picConfirmBooking = new System.Windows.Forms.PictureBox();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.lblShowTime = new System.Windows.Forms.Label();
            this.lblSeats = new System.Windows.Forms.Label();
            this.lblTicketsCount = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBackTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackToSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConfirmBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // picBackTop
            // 
            this.picBackTop.BackColor = System.Drawing.Color.Transparent;
            this.picBackTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBackTop.Image = ((System.Drawing.Image)(resources.GetObject("picBackTop.Image")));
            this.picBackTop.Location = new System.Drawing.Point(-5, 14);
            this.picBackTop.Name = "picBackTop";
            this.picBackTop.Size = new System.Drawing.Size(104, 53);
            this.picBackTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBackTop.TabIndex = 0;
            this.picBackTop.TabStop = false;
            this.picBackTop.Click += new System.EventHandler(this.picBack_Click);
            // 
            // picBackToSeats
            // 
            this.picBackToSeats.BackColor = System.Drawing.Color.Transparent;
            this.picBackToSeats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBackToSeats.Image = ((System.Drawing.Image)(resources.GetObject("picBackToSeats.Image")));
            this.picBackToSeats.Location = new System.Drawing.Point(707, 542);
            this.picBackToSeats.Name = "picBackToSeats";
            this.picBackToSeats.Size = new System.Drawing.Size(234, 164);
            this.picBackToSeats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBackToSeats.TabIndex = 1;
            this.picBackToSeats.TabStop = false;
            this.picBackToSeats.Click += new System.EventHandler(this.picBackToSeats_Click);
            // 
            // picConfirmBooking
            // 
            this.picConfirmBooking.BackColor = System.Drawing.Color.Transparent;
            this.picConfirmBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picConfirmBooking.Image = ((System.Drawing.Image)(resources.GetObject("picConfirmBooking.Image")));
            this.picConfirmBooking.Location = new System.Drawing.Point(959, 545);
            this.picConfirmBooking.Name = "picConfirmBooking";
            this.picConfirmBooking.Size = new System.Drawing.Size(236, 158);
            this.picConfirmBooking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picConfirmBooking.TabIndex = 2;
            this.picConfirmBooking.TabStop = false;
            this.picConfirmBooking.Click += new System.EventHandler(this.picConfirm_Click);
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.Location = new System.Drawing.Point(415, 202);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(91, 38);
            this.lblMovieName.TabIndex = 4;
            this.lblMovieName.Text = "label1";
            // 
            // lblShowTime
            // 
            this.lblShowTime.AutoSize = true;
            this.lblShowTime.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowTime.Location = new System.Drawing.Point(415, 283);
            this.lblShowTime.Name = "lblShowTime";
            this.lblShowTime.Size = new System.Drawing.Size(91, 38);
            this.lblShowTime.TabIndex = 5;
            this.lblShowTime.Text = "label2";
            // 
            // lblSeats
            // 
            this.lblSeats.AutoSize = true;
            this.lblSeats.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeats.Location = new System.Drawing.Point(415, 378);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(91, 38);
            this.lblSeats.TabIndex = 6;
            this.lblSeats.Text = "label3";
            // 
            // lblTicketsCount
            // 
            this.lblTicketsCount.AutoSize = true;
            this.lblTicketsCount.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketsCount.Location = new System.Drawing.Point(841, 202);
            this.lblTicketsCount.Name = "lblTicketsCount";
            this.lblTicketsCount.Size = new System.Drawing.Size(91, 38);
            this.lblTicketsCount.TabIndex = 7;
            this.lblTicketsCount.Text = "label4";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(841, 283);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(91, 38);
            this.lblTotalPrice.TabIndex = 8;
            this.lblTotalPrice.Text = "label5";
            // 
            // MyBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblTicketsCount);
            this.Controls.Add(this.lblSeats);
            this.Controls.Add(this.lblShowTime);
            this.Controls.Add(this.lblMovieName);
            this.Controls.Add(this.picConfirmBooking);
            this.Controls.Add(this.picBackToSeats);
            this.Controls.Add(this.picBackTop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyBookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyBookingForm";
            this.Load += new System.EventHandler(this.MyBookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBackTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackToSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConfirmBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBackTop;
        private System.Windows.Forms.PictureBox picBackToSeats;
        private System.Windows.Forms.PictureBox picConfirmBooking;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.Label lblShowTime;
        private System.Windows.Forms.Label lblSeats;
        private System.Windows.Forms.Label lblTicketsCount;
        private System.Windows.Forms.Label lblTotalPrice;
    }
}