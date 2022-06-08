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
        public static string MonthName(int num)
        {
            
            return DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName(num);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Tests.MonthName(1));

            Console.ReadKey();
        }

    }

}
