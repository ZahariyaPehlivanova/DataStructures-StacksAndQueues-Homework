﻿namespace _03.ArrayBasedClass
{
    using System;

    class MainClass
    {
        static void Main(string[] args)
        {
            var test = new ArrayStack<int>();
            test.Push(5);
            test.Push(7);
            test.Push(9);
            Console.WriteLine(test.Pop());
            Console.WriteLine(test.Pop());
            Console.WriteLine(test.Pop());
        }
    }
}
