using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayProblemsSolutions();
            MediumProblemsSolutions();
            Console.ReadLine();
        }

        static void ArrayProblemsSolutions()
        {
            //ArrayProblems.PrintResult(new int[] { 2, 7, 11, 15 }, 9, ArrayProblems.TwoSum);
            //ArrayProblems.PrintResult(new int[] { 2, 7, 11, 15 }, 9, ArrayProblems.TwoSum2);
            //ArrayProblems.MaxArea(new int[] { 2,1 });
            ArrayProblems.PrintResult(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, ArrayProblems.MaxArea);
        }

        static void MediumProblemsSolutions()
        {
            MediumProblems mp = new MediumProblems();
            Console.WriteLine(mp.Convert("paypalishiring", 4));
            Console.WriteLine(mp.MyAtoi("   -42"));
            Console.WriteLine(mp.LongestPalindrome("aaaaaaaabba"));
            var resultOfLetterCombinations = mp.LetterCombinations("23");
            foreach(string val in resultOfLetterCombinations)
            {
                Console.WriteLine(val);
            }
        }
    }
}
