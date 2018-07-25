using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifth
{
    public class ProgramQ5
    {
        public static void Main()
        {
            Console.Write("Enter a number between 1 and 12:");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i=1; i<=12; i++)
            {
                Console.WriteLine(num + "x" + i + "=" +(num*i));
                

            }
            Console.ReadLine();

        }
    }
}
