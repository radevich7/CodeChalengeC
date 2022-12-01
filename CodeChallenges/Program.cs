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
 
    class Tests
    {
   

        static int RemoveElement(int[] nums, int val)
        {
            if (nums.Length == 0)
                return 0;

            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    nums[i] = int.MaxValue;
                    counter++;
                }

            }

            Array.Sort(nums);


            foreach (var item in nums)
            {
                Console.WriteLine(item) ;
            }
            return nums.Length-counter;

        }
        class Program
        {

            static void Main(string[] args)
            {


                Console.WriteLine(Tests.RemoveElement( new int[] { 3,2,2,3}, 2));

                Console.ReadKey();
            }

        }

    }
}
