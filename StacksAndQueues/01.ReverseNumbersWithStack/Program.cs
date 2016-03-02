namespace _01.ReverseNumbersWithStack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                string[] nums = input.Split(' ');
                var stack = new Stack<string>();

                for (int i = 0; i < nums.Length; i++)
                {
                    stack.Push(nums[i]);
                }

                for (int i = 0; i < nums.Length; i++)
                {
                    var currStr = string.Format("{0} ", stack.Pop());
                    Console.Write(currStr);
                }
            }
            else
            {
                Console.WriteLine("(empty)");
            }
        }
    }
}
