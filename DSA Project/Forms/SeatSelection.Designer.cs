namespace DSA_Project
{
    partial class SeatSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeatSelection));
            this.picBack = new System.Windows.Forms.PictureBox();
            this.pnlSeats = new System.Windows.Forms.Panel();
            this.lblSummary = new System.Windows.Forms.Label();
            this.picUndo = new System.Windows.Forms.PictureBox();
            this.picCheckout = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUndo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckout)).BeginInit();
            this.SuspendLayout();
            // 
            // picBack
            // 
            this.picBack.BackColor = System.Drawing.Color.Transparent;
            this.picBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBack.Image = ((System.Drawing.Image)(resources.GetObject("picBack.Image")));
            this.picBack.Location = new System.Drawing.Point(-4, 13);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(103, 55);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBack.TabIndex = 0;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.picBack_Click);
            // 
            // pnlSeats
            // 
            this.pnlSeats.BackColor = System.Drawing.Color.Transparent;
            this.pnlSeats.Location = new System.Drawing.Point(52, 126);
            this.pnlSeats.Name = "pnlSeats";
            this.pnlSeats.Size = new System.Drawing.Size(1186, 394);
            this.pnlSeats.TabIndex = 1;
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.BackColor = System.Drawing.Color.Transparent;
            this.lblSummary.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSummary.Location = new System.Drawing.Point(141, 558);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(76, 31);
            this.lblSummary.TabIndex = 2;
            this.lblSummary.Text = "label1";
            // 
            // picUndo
            // 
            this.picUndo.BackColor = System.Drawing.Color.Transparent;
            this.picUndo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picUndo.Image = ((System.Drawing.Image)(resources.GetObject("picUndo.Image")));
            this.picUndo.Location = new System.Drawing.Point(705, 541);
            this.picUndo.Name = "picUndo";
            this.picUndo.Size = new System.Drawing.Size(245, 93);
            this.picUndo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUndo.TabIndex = 3;
            this.picUndo.TabStop = false;
            this.picUndo.Click += new System.EventHandler(this.picUndo_Click);
            // 
            // picCheckout
            // 
            this.picCheckout.BackColor = System.Drawing.Color.Transparent;
            this.picCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCheckout.Image = ((System.Drawing.Image)(resources.GetObject("picCheckout.Image")));
            this.picCheckout.Location = new System.Drawing.Point(956, 514);
            this.picCheckout.Name = "picCheckout";
            this.picCheckout.Size = new System.Drawing.Size(312, 149);
            this.picCheckout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCheckout.TabIndex = 4;
            this.picCheckout.TabStop = false;
            this.picCheckout.Click += new System.EventHandler(this.picCheckout_Click);
            // 
            // SeatSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.picCheckout);
            this.Controls.Add(this.picUndo);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.pnlSeats);
            this.Controls.Add(this.picBack);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeatSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeatSelection";
            this.Load += new System.EventHandler(this.SeatSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUndo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.Panel pnlSeats;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.PictureBox picUndo;
        private System.Windows.Forms.PictureBox picCheckout;
    }
}