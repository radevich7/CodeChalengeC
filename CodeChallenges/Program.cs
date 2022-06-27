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
    //function add(a)
    //{
    //    return function(b) {
    //        return a + b;
    //    }
    //}
    class Tests
    {

        public static object[] RemoveDups(object[] str)
        {
            return str.Distinct().ToArray();
        }

        class Program
        {

            static void Main(string[] args)
            {

                Console.WriteLine(Tests.RemoveDups(new object[] { "John", "Taylor", "John" }));

                Console.ReadKey();
            }

        }

    }
}
