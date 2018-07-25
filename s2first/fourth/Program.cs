using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourth
{
    public class ProgramQ4
    {
        public static void Main()
        {
            Console.WriteLine("Hey there stranger. To make me stop calling you stranger, enter in your first name:");
            string fName = Console.ReadLine();

            Console.WriteLine("Now enter in your last name:");
            string lName = Console.ReadLine();

            Console.WriteLine("Hey there " + fName + " " + lName);
            Console.ReadLine();
        }
    }
}

