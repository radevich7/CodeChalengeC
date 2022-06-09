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
        public static string DoubleChar(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {

                result += str[i] + ""+str[i];
            }
            return result;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine(Tests.DoubleChar("String"));

            Console.ReadKey();
        }

    }

}
