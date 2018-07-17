using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class EasyProblems
    {
        //https://leetcode.com/problems/count-and-say
        public string CountAndSay(int n)
        {
            string result = "1";
            StringBuilder builder = new StringBuilder();

            int i = 1;
            while (i <= n - 1)
            {
                int resultCount = result.Length;
                char track = result[0];
                int count = 0;
                for (int j = 0; j < resultCount; j++)
                {
                    if (track == result[j])
                    {
                        count++;
                    }
                    else
                    {
                        builder.Append(count.ToString());
                        builder.Append(track.ToString());
                        track = result[j];
                        count = 1;
                    }
                }

                builder.Append(count.ToString());
                builder.Append(track.ToString());
                result = builder.ToString();
                builder.Clear();
                i++;
            }

            return result;
        }
    }
}
