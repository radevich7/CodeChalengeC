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
        public static int[] NoOdds(int[] arr)
        {
            return Array.FindAll(arr, x => x % 2 == 0);

        }
    }
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine(Tests.NoOdds(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }));

            Console.ReadKey();
        }

    }

}
