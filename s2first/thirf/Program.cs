﻿using System;

namespace third
{
    public class ProgramQ3
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to multiply calculator. Please enter your first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int product = num1 * num2;

            Console.WriteLine($"{num1} x {num2} = " + product);
            Console.ReadLine();
        }
    }
}
