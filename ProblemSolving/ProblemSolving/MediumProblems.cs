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

        //https://leetcode.com/problems/string-to-integer-atoi/description/
        public static int MyAtoi(string str)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
            {
                return 0;
            }
            int result = 0;
            str = str.TrimEnd(' ');
            str = str.TrimStart(' ');
            char firstCharacter = str[0];
            bool negative = false;
            bool haveSymbol = false;
            if (firstCharacter == 43)
            {
                negative = false;
                haveSymbol = true;
            }
            else if (firstCharacter == 45)
            {
                negative = true;
                haveSymbol = true;
            }
            else if ((firstCharacter >= 65 && firstCharacter <= 90) || (firstCharacter >= 97 && firstCharacter <= 122))
            {
                return 0;
            }

            int i = 0;
            if (haveSymbol)
            {
                i = 1;
            }

            StringBuilder temp = new StringBuilder();
            for (; i < str.Length; i++)
            {
                if (!(str[i] >= 65 && str[i] <= 90) &&
                    !(str[i] >= 97 && str[i] <= 122) &&
                    !(str[i] == 46) &&
                    !(str[i] == 45) &&
                    !(str[i] == 43) &&
                    !(str[i] == ' '))
                {
                    temp.Append(str[i]);
                }
                else
                {
                    break;
                }
            }

            try
            {
                if (string.IsNullOrEmpty(temp.ToString()))
                    return 0;
                result = int.Parse(temp.ToString());
            }
            catch
            {
                if (negative)
                {
                    return int.MinValue;
                }
                else return int.MaxValue;
            }

            if (negative)
                return result * -1;

            return result;
        }

        //https://leetcode.com/problems/3sum/description/
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> results = new List<IList<int>>();
            if (nums.Length == 0)
            {
                return results;
            }

            Array.Sort(nums);

            if (nums.Length >= 3)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    int l = i + 1;
                    int r = nums.Length - 1;
                    int x = nums[i];
                    while (l < r)
                    {
                        int sum = x + nums[r] + nums[l];
                        if (sum == 0)
                        {
                            results.Add(new List<int>() { x, nums[r], nums[l] });
                            l++;
                            r--;
                        }
                        else if (sum < 0)
                        {
                            l++;
                        }
                        else if (sum > 0)
                        {
                            r--;
                        }
                    }
                }
            }

            return results;
        }

        //https://leetcode.com/problems/longest-palindromic-substring/description/
        //https://gist.github.com/riyadparvez/6058526
        //https://www.geeksforgeeks.org/longest-palindrome-substring-set-1/
        public static string LongestPalindrome(string s)
        {
            int start = 0;
            int maxLength = 0;
            if(string.IsNullOrEmpty(s))
            {
                return "";
            }
            bool[,] dp = new bool[s.Length, s.Length];

            for(int i=0; i<s.Length; i++)
            {
                dp[i, i] = true;
            }
            maxLength = 1;

            for(int i=0; i<s.Length-1; i++)
            {
                if(s[i] == s[i+1])
                {
                    start = i;
                    maxLength = 2;
                }
            }

            for(int length=3; length<s.Length; length++)
            {
                for(int i=0; i<s.Length-length; i++)
                {
                    int j = s.Length - length - 1;
                    if(s[i] == s[j] && dp[i+1, j-1])
                    {
                        dp[i, j] = true;
                        if(j-i >= maxLength)
                        {
                            start = i;
                            maxLength = j - i + 1;
                        }
                    }
                }
            }

            return s.Substring(start, maxLength);
        }
    }
}
