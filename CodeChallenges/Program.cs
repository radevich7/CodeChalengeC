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
   
    class Tests
    {

        public static double[] UniqueSort(double[] arr)
        {
               double[] uniqueNumbers= arr.Distinct().ToArray();

            return 
        }

        class Program
        {

            static void Main(string[] args)
            {

                Console.WriteLine(Tests.UniqueSort(new double[] { 1, 5, 8, 2, 3, 4, 4, 4, 10 }));

                Console.ReadKey();
            }

        }

    }
}
