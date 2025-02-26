using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProgram
{
    public class LeetCode_Array
    {
        public static void Main(string[] args)
        {

            int[] nums = { 1, 2, 3, 4 };
            int k = 2;
            Solution.Rotate(nums, k);
        }
    }
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int[] tempArr = nums;
            int k = 1;
            int prev = tempArr[0];
            nums[0] = tempArr[0];
            for (int i = 1; i < tempArr.Length; i++)
            {
                if (prev != tempArr[i])
                {
                    nums[k] = tempArr[i];
                    prev = tempArr[i];
                    k++;
                }
            }
            return k;
        }
        public static void Rotate(int[] nums, int k)
        {
            int[] tempArr = nums.ToArray();
            int len = nums.Length;
            if (k > len) k %= len;
            int counter = 0;
            int counter1 = len - k;
            for (int i = 0; i < len; i++)
            {
                if (i < k) nums[i] = nums[counter1++];
                else nums[i] = tempArr[counter++];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);
            }
            Console.WriteLine();

            // OR

            Array.Reverse(nums);
            Array.Reverse(nums, 0, k);
            Array.Reverse(nums, k, len - k);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);
            }

            GC.Collect(GC.MaxGeneration, GCCollectionMode.Aggressive);
        }
    }
}
