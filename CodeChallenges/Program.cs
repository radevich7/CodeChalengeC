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
        public static string Reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);

            return new String(charArray);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine(Tests.Reverse("Hello World"));

            Console.ReadKey();
        }

    }

}
