using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninth
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] classmates = {"Fred", "Bob", "Dylan", "Eli", "Josh"};
            foreach (string value in classmates)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
