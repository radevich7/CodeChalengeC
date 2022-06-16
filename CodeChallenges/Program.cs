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
        public static string ImposterFormula(int i, int p)
        {
            //double res = i / p;
            double abs = (double)i / p;
            Console.WriteLine(abs);
            return (Math.Round(100 * (double)i / p)).ToString() + "%";
        }
        class Program
        {

            static void Main(string[] args)
            {

                Console.WriteLine(Tests.ImposterFormula(3, 7));

                Console.ReadKey();
            }

        }

    }
