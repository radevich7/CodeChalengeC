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
        public static string AlphabetSoup(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Sort(arr);
            return new string(arr);
        }
        class Program
        {

            static void Main(string[] args)
            {

                Console.WriteLine(Tests.AlphabetSoup("something"));

                Console.ReadKey();
            }

        }

    }
