using System;
using System.Collections.Generic;

using System.Collections.Generic;

namespace DSA_project
{
          public class SeatService
          {
                    private Dictionary<string, byte[,]> seatMaps =
                        new Dictionary<string, byte[,]>();

                    // Add Movie
                    public void AddMovie(string movieId)
                    {
                              if (!seatMaps.ContainsKey(movieId))
                              {
                                        seatMaps[movieId] = new byte[5, 8];

                                        if (movieId == "Interstellar")
                                        {
                                                  seatMaps[movieId][0, 2] = 1;
                                                  seatMaps[movieId][0, 3] = 1;
                                                  seatMaps[movieId][1, 4] = 1;
                                                  seatMaps[movieId][2, 1] = 1;
                                                  seatMaps[movieId][3, 5] = 1;
                                        }
                              }
                    }

                    // Remove Movie
                    public void RemoveMovie(string movieId)
                    {
                              seatMaps.Remove(movieId);
                    }

                    // Is Booked
                    public bool IsBooked(string movieId, string seatName)
                    {
                              int row;
                              int column;

                              if (!TryGetPosition(seatName, out row, out column))
                                        return false;

                              if (!seatMaps.ContainsKey(movieId))
                                        return false;

                              return seatMaps[movieId][row, column] == 1;
                    }

                    // Are Seats Available
                    public bool AreSeatsAvailable(string movieId, string seatNames)
                    {
                              if (!seatMaps.ContainsKey(movieId))
                                        return false;

                              List<string> seats = SplitSeatNames(seatNames);

                              if (seats.Count == 0)
                                        return false;

                              foreach (string seat in seats)
                              {
                                        int row;
                                        int column;

                                        if (!TryGetPosition(seat, out row, out column))
                                                  return false;

                                        if (seatMaps[movieId][row, column] == 1)
                                                  return false;
                              }

                              return true;
                    }

                    // Book Seats
                    public bool BookSeats(string movieId, string seatNames)
                    {
                              if (!AreSeatsAvailable(movieId, seatNames))
                                        return false;

                              List<string> seats = SplitSeatNames(seatNames);

                              foreach (string seat in seats)
                              {
                                        int row;
                                        int column;

                                        TryGetPosition(seat, out row, out column);

                                        seatMaps[movieId][row, column] = 1;
                              }

                              return true;
                    }

                    // Split Seat Names
                    public List<string> SplitSeatNames(string seatNames)
                    {
                              List<string> seats = new List<string>();

                              if (string.IsNullOrWhiteSpace(seatNames))
                                        return seats;

                              string[] parts = seatNames.Split(',');

                              foreach (string seat in parts)
                              {
                                        string name = seat.Trim().ToUpper();

                                        if (name != "")
                                                  seats.Add(name);
                              }

                              return seats;
                    }

                    // Try Get Position
                    public bool TryGetPosition(
                        string seatName, out int row, out int column)
                    {
                              row = -1;
                              column = -1;

                              if (string.IsNullOrWhiteSpace(seatName))
                                        return false;

                              seatName = seatName.Trim().ToUpper();

                              if (seatName.Length < 2 || seatName.Length > 2)
                                        return false;

                              char rowLetter = seatName[0];

                              if (rowLetter < 'A' || rowLetter > 'E')
                                        return false;

                              int seatNumber;

                              if (!int.TryParse(seatName.Substring(1), out seatNumber))
                                        return false;

                              if (seatNumber < 1 || seatNumber > 8)
                                        return false;

                              row = rowLetter - 'A';
                              column = seatNumber - 1;

                              return true;
                    }
          }
}


