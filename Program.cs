using System;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Created by Jake Magri

            int rows = 10, columns = 10; // declare variables
            int row_count, col_count;

            // Pattern A

            for (row_count = 1; row_count <= rows; row_count++) // begin with 1 stars and incrementally increase to 10 stars
            {
                // print out stars
                for (col_count = 1; col_count <= row_count; col_count++)
                {
                    Write("*");
                }
                WriteLine();
            }
            WriteLine();

            // Pattern B

            for (row_count = rows; row_count >= 1; row_count--) // begin with 10 stars and incrementally decrease to 1 stars
            {
                // print out stars
                for (col_count = 1; col_count <= row_count; col_count++)
                {
                    Write("*");
                }
                WriteLine();
            }
            WriteLine();

            // Pattern C

            for (row_count = rows; row_count >= 1; row_count--) // begin with 10 stars and incrementally decrease to 1 stars
            {
                // print out spaces
                for (col_count = columns; col_count > row_count; col_count--) // print out spaces left aligned in an increasing increment from none to 10
                {
                    Write(" ");
                }

                // print out stars
                for (col_count = 1; col_count <= row_count; col_count++)
                {
                    Write("*");
                }
                WriteLine();
            }
            WriteLine();

            // Pattern D

            for (row_count = 1; row_count <= rows; row_count++) // begin with 1 stars and incrementally increase to 10 stars
            {
                // print out spaces
                for (col_count = columns; col_count > row_count; col_count--) // print out spaces left aligned in a decreasing increment from 10 to none
                {
                    Write(" ");
                }

                // print out stars
                for (col_count = 1; col_count <= row_count; col_count++)
                {
                    Write("*");
                }
                WriteLine();
            }
            WriteLine();
        }
    }
}
