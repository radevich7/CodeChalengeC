using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
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
        public static string SubReddit(string link)
        {
            string[] splitted = link.Split('/');
            return splitted[splitted.Length-2];
        }
        class Program
        {

            static void Main(string[] args)
            {

                Console.WriteLine(Tests.SubReddit("https://www.reddit.com/r/relationships/"));

                Console.ReadKey();
            }

        }

    }
}
