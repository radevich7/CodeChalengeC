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
        public static bool IsAvgWhole(int[] arr)
        {

            return arr.Average() % 1 == 0;

        }
    }
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine(Tests.IsAvgWhole(new int[] { 3, 5, 9, 1 }));

            Console.ReadKey();
        }

    }

}
