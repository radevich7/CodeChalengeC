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
        public static string HackerSpeak(string str)
        {
            //a=>4  e=>3    i=>1    o=>0   s=>5

            return str.Replace('a', '4').Replace('e','3').Replace('i','1').Replace('o','0').Replace('s','5');

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Tests.HackerSpeak("javascript is cool"));

            Console.ReadKey();
        }

    }

}
