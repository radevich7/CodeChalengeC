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
            if(s.Length)
            {
                return 1;
            }
            Dictionary<char, int> map = new Dictionary<char, int>();

            char[] array = s.ToCharArray();
            int maximumChar = 0;

            for (int i = 0; i < array.Length; i++)
            {
                try
                {
                    map.Add(array[i], 0);
                    maximumChar++;

                }
                catch (Exception)
                {
                maximumChar=maximumChar>map.Count ? maximumChar : map.Count;
                    i--;

                    map.Clear();
                }
            }
            return maximumChar;

        }

    }




}
class Program
{

    static void Main(string[] args)
    {




        Console.WriteLine(Tests.LengthOfLongestSubstring("pwwkew"));

        Console.ReadKey();
    }

}

