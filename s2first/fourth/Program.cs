using System;

namespace fourth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey there stranger. To make me stop calling you stranger, enter in your first name:");
            string fName = Console.ReadLine();

            Console.WriteLine("Now enter in your last name:");
            string lName = Console.ReadLine();

            Console.WriteLine("Hey there " +fName + " " +lName);
            Console.ReadLine();
        }
    }
}
