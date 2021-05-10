using System;
using System.Collections;

namespace c__data_structures
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[]{0,1,2,3,4,5};
            Array numsArray = nums;
            ArrayList numsList = new ArrayList(nums);

            Console.WriteLine("Hello World!");

            Hashtable table = new Hashtable();

            Console.WriteLine(table);

            table.Add("key", "value");

            Console.WriteLine(table["key"]);

            for (int i = 0; i < nums.Length; i++) {
                Console.WriteLine(nums[i]);
                nums[i] = nums[i] * 2;
            }

            Console.WriteLine(nums.ToString());
            string.Join(" ", numsArray);
            Console.WriteLine(numsList[2]);
        }
    }
}
