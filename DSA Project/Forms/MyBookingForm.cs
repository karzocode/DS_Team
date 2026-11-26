
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DSA_Project
{
          public partial class MyBookingForm : Form
          {
                    private string movieName;
                    private string showTime;
                    private string seats;
                    private int ticketsCount;
                    private decimal ticketPrice;
                    private bool canConfirm;

                    public MyBookingForm()
                    {
                              InitializeComponent();

                              movieName = "";
                              showTime = "";
                              seats = "";
                              ticketsCount = 0;
                              ticketPrice = 0;
                              canConfirm = false;
                    }

                    public MyBookingForm(
                        string movieName,
                        string showTime,
                        string seats,
                        int ticketsCount,
                        decimal ticketPrice)
                    {
                              InitializeComponent();

                              this.movieName = movieName;
                              this.showTime = showTime;
                              this.seats = seats;
                              this.ticketsCount = ticketsCount;
                              this.ticketPrice = ticketPrice;

                              canConfirm =
                                  ticketsCount > 0 &&
                                  !string.IsNullOrWhiteSpace(seats);
                    }

                    private void MyBookingForm_Load(object sender, EventArgs e)
                    {
                              lblMovieName.Text = movieName;
                              lblShowTime.Text = showTime;
                              lblSeats.Text = seats;
                              lblTicketsCount.Text =
                                  ticketsCount.ToString();

                              decimal totalPrice =
                                  ticketPrice * ticketsCount;

                              lblTotalPrice.Text =
                                  totalPrice.ToString("C2");

                              picConfirmBooking.Enabled =
                                  canConfirm;
                    }

                    private void picConfirm_Click(object sender, EventArgs e)
                    {
                              if (!canConfirm)
                              {
                                        MessageBox.Show(
                                            "Booking cannot be confirmed.",
                                            "Booking",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);

                                        return;
                              }

                              MessageBox.Show(
                                  "Booking confirmed successfully!",
                                  "Electronic Ticket",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);

                              DialogResult = DialogResult.OK;
                              Close();
                    }

                    private void picBackToSeats_Click(object sender, EventArgs e)
                    {
                              DialogResult = DialogResult.Cancel;
                              Close();
                    }

                    private void picBack_Click(object sender, EventArgs e)
                    {
                              Close();
                    }
          }
}﻿
