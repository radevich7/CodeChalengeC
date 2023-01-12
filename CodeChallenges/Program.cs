using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Collections;
using CodeChallenges;
using System.ComponentModel;

namespace CodeChallenges
{
    class Tests
    {

      static  public int MaxProfit(int[] prices)
        {
            int minprice = int.MaxValue;
            int maxprofit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minprice)
                {
                    minprice = prices[i];
                }
                else if (prices[i] - minprice > maxprofit)
                {
                    maxprofit = prices[i] - minprice;
                }
            }

            return maxprofit;
        }



    }

   

    class Program
    {

        static void Main(string[] args)
        {
         
          




            Console.WriteLine(Tests.MaxProfit(new int[] {7, 1, 5, 3, 6, 4}));

            Console.ReadKey();
        }

    }
}

