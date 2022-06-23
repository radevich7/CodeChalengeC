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
        public static string[] isFourLetters(string[] arr)
        {
            List<string> words = new List<string>();
            words.AddRange(arr);
            IEnumerable<string> query = words.Where(word => word.Length <= 4);

            return
         }
        class Program
        {

            static void Main(string[] args)
            {

                Console.WriteLine(Tests.isFourLetters(new string[] { "Ryan", "Kieran", "Jason", "Matt" }));

                Console.ReadKey();
            }

        }

    }
