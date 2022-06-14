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
        public static string FormatPhoneNumber(int[] numbers)
        {
            string result = string.Join("", numbers);
            return result.Insert(0, "(").Insert(4, ")").Insert(5, " ").Insert(9, "-");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine(Tests.FormatPhoneNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));

            Console.ReadKey();
        }

    }

}
