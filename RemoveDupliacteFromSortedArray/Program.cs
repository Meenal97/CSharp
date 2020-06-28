using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDupliacteFromSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {0, 0, 1, 1, 1, 2, 2, 3, 3, 4};
            if (nums.Length == 0) return 0;
            int i = 0;
            for (int j = 1; j < nums.length; j++)
            {
                if (nums[j] != nums[i])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }

            Console.ReadKey();
        }
    }
}
