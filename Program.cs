using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Program
    {
        static int MissingNumber(int[] nums)
        {
            int sum = ((nums.Length )* (nums.Length + 1)) / 2;
            for (int i = 0; i < nums.Length; i++)
            {
                sum -= nums[i];
            }
            return sum;
        }
        public static void Main()
        {
            int[] a = { 3, 0, 1};
            int miss = MissingNumber(a);
            Console.Write(miss);
            Console.ReadKey();
        }
        //static void Main(string[] args)
        //{
        //}
    }
}
