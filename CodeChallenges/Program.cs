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
        public static string GetWord(string left, string right)
        {


            return left.Substring(0,1).ToUpper() +("")+ left.Substring(1)+ "" + right;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine(Tests.GetWord("seas", "onal"));

            Console.ReadKey();
        }

    }

}
