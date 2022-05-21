using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CodeChallenges
{
    class Tests
    {
        public static int Sum(int n)
        {

            int sum = 0;
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n+Sum(n - 1);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Tests.Sum(5));

            Console.ReadKey();
        }

    }

}
