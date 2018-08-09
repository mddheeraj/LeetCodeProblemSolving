using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public static class MediumProblems
    {
        //https://leetcode.com/problems/zigzag-conversion/description/
        //https://www.geeksforgeeks.org/print-concatenation-of-zig-zag-string-form-in-n-rows/
        public static string Convert(string str, int n)
        {
            // Corner Case (Only one row)
            if (n == 1)
            {
                return str;
            }

            // Find length of string
            int len = str.Length;

            // Create an array of strings for all n rows
            string[] arr = new string[n];

            // Initialize index for array of strings arr[]
            int row = 0;
            bool down = true; // True if we are moving down in rows, 
                              // else false

            // Travers through given string
            for (int i = 0; i < len; ++i)
            {
                // append current character to current row
                arr[row] = arr[row] + str[i].ToString();

                // If last row is reached, change direction to 'up'
                if (row == n - 1)
                {
                    down = false;
                }
                // If 1st row is reached, change direction to 'down'
                else if (row == 0)
                {
                    down = true;
                }

                // If direction is down, increment, else decrement
                if (down)
                {
                    row++;
                }
                else
                {
                    row--;
                }
            }

            // Print concatenation of all rows
            string result = "";
            for (int i = 0; i < n; ++i)
            {
                result = result + arr[i];
            }

            return result;
        }
    }
}
