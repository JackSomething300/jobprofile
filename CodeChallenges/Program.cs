// See https://aka.ms/new-console-template for more information
using System.Text;

namespace String_Builder
{
    public class Solution
    {
        static void Main(string[] strs)
        {
            Console.WriteLine("Hello, World!");

            string[] array = new string[3] { "flower", "flow", "flight" };
            int[] nums = new int[] { 3, 2, 2, 3 };
            var val = 3;
            int k = RemoveElement(nums, val);
        }
        public static int RemoveElement(int[] nums, int val)
        {
            int i = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != val)
                {
                    nums[i] = nums[j];
                    i++;
                }
                
            }

            return i;
        }

    }
}