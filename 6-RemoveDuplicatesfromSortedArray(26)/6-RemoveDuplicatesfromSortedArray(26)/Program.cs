using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_RemoveDuplicatesfromSortedArray_26_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] y = { 1, 1, 2 };
            RemoveDuplicates(y);
            Console.ReadKey();

        }
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            else if (nums.Length == 1)
                return 1;

            int index1 = 0,
                index2 = 1;

            while (index2 <= nums.Length - 1)
                if (nums[index1] == nums[index2])
                    index2++;
                else
                    nums[++index1] = nums[index2++];
            //++i means that when your code is executing it will first do i = i + 1 and then read it.
            //i++ means that when your code is executing it will first read it and do the i = i + 1 after it has been read.

            return ++index1;
        }
    }
}

//if (nums == null || nums.Length == 0)
//    return 0;
//int[] x = new int[nums.Length];
//int j = 0;
//for (int i = 0; i < nums.Length - 1; i++)
//{
//    if (nums[i] == nums[i + 1])
//    {
//        continue;
//    }
//    else
//    {
//        x[j] = nums[i];
//        j++;
//    }
//}
//if (nums[nums.Length - 1] != nums[nums.Length - 2])
//{
//    x[j] = nums[nums.Length - 1];
//    j++;
//}
//return j;
