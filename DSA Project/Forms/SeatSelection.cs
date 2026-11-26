using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DSA_Project
{
          public partial class SeatSelection : Form
          {
                    // 0 = Free
                    // 1 = Booked
                    // 2 = Selected
                    private byte[,] seatMap = new byte[5, 8];

                    private Dictionary<string, Button> seatButtons =
                        new Dictionary<string, Button>();

                    private List<string> selectedSeatNames =
                        new List<string>();

                    private UndoStack<Seat> selectedSeats =
                        new UndoStack<Seat>();

                    public SeatSelection()
                    {
                              InitializeComponent();
                    }

                    private void SeatSelection_Load(object sender, EventArgs e)
                    {
                              GenerateSeats();
                              UpdateSummaryLabel();
                    }

                    // Generate the 40 seats: A1 -> E8
                    private void GenerateSeats()
                    {
                              seatButtons.Clear();
                              pnlSeats.Controls.Clear();

                              // Clear seat map
                              for (int row = 0; row < 5; row++)
                              {
                                        for (int column = 0; column < 8; column++)
                                        {
                                                  seatMap[row, column] = 0;
                                        }
                              }

                              // Pre-booked seats
                              seatMap[0, 2] = 1; // A3
                              seatMap[0, 3] = 1; // A4
                              seatMap[1, 4] = 1; // B5
                              seatMap[2, 1] = 1; // C2
                              seatMap[3, 5] = 1; // D6

                              int buttonWidth = 70;
                              int buttonHeight = 45;
                              int horizontalGap = 10;
                              int verticalGap = 10;

                              for (int row = 0; row < 5; row++)
                              {
                                        for (int column = 0; column < 8; column++)
                                        {
                                                  string seatName =
                                                      ((char)('A' + row)).ToString() +
                                                      (column + 1).ToString();

                                                  Button button = new Button();

                                                  button.Name = "btn" + seatName;
                                                  button.Text = seatName;
                                                  button.Tag = seatName;

                                                  button.Width = buttonWidth;
                                                  button.Height = buttonHeight;

                                                  button.Left = column * (buttonWidth + horizontalGap);
                                                  button.Top = row * (buttonHeight + verticalGap);

                                                  button.Click += Seat_Click;

                                                  seatButtons.Add(seatName, button);

                                                  UpdateSeatButton(button, seatMap[row, column]);

                                                  pnlSeats.Controls.Add(button);
                                        }
                              }
                    }

                    // Handle seat selection
                    private void Seat_Click(object sender, EventArgs e)
                    {
                              Button button = sender as Button;

                              if (button == null)
                                        return;

                              string seatName = button.Tag.ToString();

                              int row;
                              int column;

                              if (!TryGetPosition(seatName, out row, out column))
                                        return;

                              // Already booked
                              if (seatMap[row, column] == 1)
                              {
                                        return;
                              }

                              // Free -> Selected
                              if (seatMap[row, column] == 0)
                              {
                                        seatMap[row, column] = 2;

                                        if (!selectedSeatNames.Contains(seatName))
                                        {
                                                  selectedSeatNames.Add(seatName);
                                        }

                                        selectedSeats.Push(
                                            new Seat(seatName, row, column)
                                        );
                              }
                              // Selected -> Free
                              else if (seatMap[row, column] == 2)
                              {
                                        seatMap[row, column] = 0;

                                        selectedSeatNames.Remove(seatName);

                                        RebuildUndoStack();
                              }

                              UpdateSeatButton(button, seatMap[row, column]);
                              UpdateSummaryLabel();
                    }

                    // Undo the last selected seat
                    private void picUndo_Click(object sender, EventArgs e)
                    {
                              if (selectedSeats.count == 0)
                                        return;

                              Seat lastSeat = selectedSeats.Pop();

                              seatMap[lastSeat.Row, lastSeat.Column] = 0;

                              selectedSeatNames.Remove(lastSeat.Name);

                              if (seatButtons.ContainsKey(lastSeat.Name))
                              {
                                        UpdateSeatButton(
                                            seatButtons[lastSeat.Name],
                                            0
                                        );
                              }

                              UpdateSummaryLabel();
                    }

                    // Rebuild the undo stack from current selected seats
                    private void RebuildUndoStack()
                    {
                              selectedSeats.Clear();

                              foreach (string seatName in selectedSeatNames)
                              {
                                        int row;
                                        int column;

                                        if (TryGetPosition(
                                            seatName,
                                            out row,
                                            out column))
                                        {
                                                  selectedSeats.Push(
                                                      new Seat(
                                                          seatName,
                                                          row,
                                                          column
                                                      )
                                                  );
                                        }
                              }
                    }

                    // Update summary label
                    private void UpdateSummaryLabel()
                    {
                              if (selectedSeatNames.Count == 0)
                              {
                                        lblSummary.Text = "Selected Seats: None";
                                        return;
                              }

                              string seatsText = string.Join(
                                  ", ",
                                  selectedSeatNames
                              );

                              lblSummary.Text =
                                  "Selected Seats: " +
                                  seatsText +
                                  "   |   Count: " +
                                  selectedSeatNames.Count;
                    }

                    // Continue to checkout
                    private void picCheckout_Click(object sender, EventArgs e)
                    {
                              if (selectedSeatNames.Count == 0)
                              {
                                        MessageBox.Show(
                                            "Please select at least one seat.",
                                            "Seat Selection",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning
                                        );

                                        return;
                              }

                              MyBookingForm bookingForm =
                                  new MyBookingForm();

                              bookingForm.ShowDialog();
                    }

                    // Back button
                    private void picBack_Click(object sender, EventArgs e)
                    {
                              Close();
                    }

                    // Convert A3 -> row 0, column 2
                    private bool TryGetPosition(
                        string seatName,
                        out int row,
                        out int column)
                    {
                              row = -1;
                              column = -1;

                              if (string.IsNullOrWhiteSpace(seatName))
                                        return false;

                              seatName = seatName.Trim().ToUpper();

                              if (seatName.Length != 2)
                                        return false;

                              char rowLetter = seatName[0];

                              if (rowLetter < 'A' || rowLetter > 'E')
                                        return false;

                              int seatNumber;

                              if (!int.TryParse(
                                  seatName.Substring(1),
                                  out seatNumber))
                              {
                                        return false;
                              }

                              if (seatNumber < 1 || seatNumber > 8)
                                        return false;

                              row = rowLetter - 'A';
                              column = seatNumber - 1;

                              return true;
                    }

                    // Update button according to seat status
                    private void UpdateSeatButton(
                        Button button,
                        byte status)
                    {
                              if (status == 0)
                              {
                                        button.Text = button.Tag.ToString();
                                        button.Enabled = true;
                              }
                              else if (status == 1)
                              {
                                        button.Text =
                                            button.Tag.ToString() +
                                            Environment.NewLine +
                                            "Booked";

                                        button.Enabled = false;
                              }
                              else if (status == 2)
                              {
                                        button.Text =
                                            button.Tag.ToString() +
                                            Environment.NewLine +
                                            "Selected";

                                        button.Enabled = true;
                              }
                    }

                    // Simple Seat object for UndoStack
                    private class Seat
                    {
                              public string Name { get; private set; }

                              public int Row { get; private set; }

                              public int Column { get; private set; }

                              public Seat(
                                  string name,
                                  int row,
                                  int column)
                              {
                                        Name = name;
                                        Row = row;
                                        Column = column;
                              }
                    }
          }
}

