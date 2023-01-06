using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Collections;
using CodeChallenges;
using System.ComponentModel;

namespace CodeChallenges
{
    class Tests
    {

        static public string LongestPalindrome(string s)
        {
            if (s.Length <= 1 && String.IsNullOrEmpty(s)) return s;
            int start = 0;
            int end = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int length1 = Expand(s, i, i);
                int length2 = Expand(s, i, i + 1);

                int length = Math.Max(length1, length2);

                if (length > end - start)
                {
                    start = i - ((length - 1) / 2);
                    end = i + (length / 2);
                }


            }
            return s.Substring(start, end + 1);


        }
        static public int Expand(string s, int left, int right)
        {
            if (s == null || left > right) return 0;

            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }

            return right - left - 1;


        }
    }




}
class Program
{

    static void Main(string[] args)
    {




        Console.WriteLine(Tests.LongestPalindrome("babad"));

        Console.ReadKey();
    }

}

