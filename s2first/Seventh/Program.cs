using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seventh
{
    public class ProgramQ7
    {
        public static void Main()
        {
            Console.WriteLine("Enter Number 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 3");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1>num2 && num1>num3)
            {
                Console.WriteLine("the largest number is " +num1);
                Console.ReadLine();
            }

            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("the largest number is " + num2);
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("the largest number is " + num3);
                Console.ReadLine();
            }
        }
    }
}
