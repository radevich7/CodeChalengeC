using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CodeChallenges
{
    //function add(a)
    //{
    //    return function(b) {
    //        return a + b;
    //    }
    //}
    class Tests
    {
 
            public static string ReplaceVowels(string str, string ch)
            {
            return Regex.Replace(str, "[aeuio]",ch);

            }
        
        class Program
        {

            static void Main(string[] args)
            {

                Console.WriteLine(Tests.ReplaceVowels("https://www.reddit.com/r/relationships/", "*"));

                Console.ReadKey();
            }

        }

    }
}
