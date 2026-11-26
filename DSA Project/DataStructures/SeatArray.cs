using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace DSA_Project
{
          // 2D seat map per movie.
          public class SeatArray
          {
                    public const int Rows = 5; // عدد الصفوف 
                    public const int Columns = 8;// عدد الكراسي في كل صف 

                    public static Dictionary<string, byte[,]> movieSeats = new Dictionary<string, byte[,]>();

                    public static byte GetStatus(string movied, int row, int column)
                    {
                              return movieSeats[movied][row, column]; //  لو انا عايز الكرسي الموجود في الصف والعمود الي انا محدده 

                    }
                    public static bool IsBooked(string movieId, int row, int column)
                    {
                              return GetStatus(movieId, row, column) == 1;

                    }
                    public static void BookSeat(string movieId, int row, int column)
                    {
                              movieSeats[movieId][row, column] = 1; // 
                    }

          }      
                              
    }
﻿
