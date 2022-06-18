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
        public static int[] HashPlusCount(string s)
        {

            int[] result = new int[2] {0,0 };
            foreach (var item in s)
            {
                if (item == '#')
                    result[0]++;
                if (item == '+')
                    result[1]++;

            }

            return result;

        }
        class Program
        {

            static void Main(string[] args)
            {

                Console.WriteLine(Tests.HashPlusCount("+++++++"));

                Console.ReadKey();
            }

        }

    }
