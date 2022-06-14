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
        public static string SpaceMeOut(string str)
        {
            char[] charArr = str.ToCharArray();
            return string.Join(" ", charArr);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine(Tests.SpaceMeOut("space"));

            Console.ReadKey();
        }

    }

}
