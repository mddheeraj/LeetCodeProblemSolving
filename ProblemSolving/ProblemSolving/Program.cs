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
            Console.WriteLine(MediumProblems.Convert("paypalishiring", 4));
        }
    }
}
