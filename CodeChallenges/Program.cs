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

namespace CodeChallenges
{
    class Tests
    {

        static public int LengthOfLongestSubstring(string s)
        {
            if (s == null || s == String.Empty)
                return 0;

            HashSet<char> set = new HashSet<char>();
            int currentMax = 0,
                i = 0,
                j = 0;

            while (j < s.Length)
                if (!set.Contains(s[j]))
                {
                    set.Add(s[j++]);
                    currentMax = Math.Max(currentMax, j - i);
                }
                else
                    set.Remove(s[i++]);

            return currentMax;

        }

    }




}
class Program
{

    static void Main(string[] args)
    {




        Console.WriteLine(Tests.LengthOfLongestSubstring("abcbbcbb"));

        Console.ReadKey();
    }

}

