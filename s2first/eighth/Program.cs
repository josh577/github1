using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eighth
{
    public class ProgramQ8
    {
        public static void Main()
        {
            Console.Write("Enter your final course mark (%):");
            int mark = Convert.ToInt32(Console.ReadLine());

            if (mark>=0 && mark<50)
            {
                Console.Write("You Failed.");
                Console.ReadLine();
            }

            else if (mark>=50 && mark<=100)
            {
                Console.Write("You Passed!");
                Console.ReadLine();
            }

            else
            {
                Console.Write("Invalid Input.");
                Console.ReadLine();
            }

            
        }
    }
}
