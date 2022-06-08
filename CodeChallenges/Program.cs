using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
namespace CodeChallenges
{
    class Tests
    {
        public static bool isIdentical(string str)
        {
            for (int i = 1; i < str.Length; i++)
            {
                if (str[0] != str[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Tests.isIdentical("kkkk"));

            Console.ReadKey();
        }

    }

}
