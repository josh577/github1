using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using s2first;
using second;
using third;
using fourth;
using fifth;
using sixth;
using Seventh;
using eighth;
using Ninth;

namespace menu
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number between 1 and 9 to run a program");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    ProgramQ1.Main();
                    break;
                case "2":
                    ProgramQ2.Main();
                    break;
                case "3":
                    ProgramQ3.Main();
                    break;
                case "4":
                    ProgramQ4.Main();
                    break;
                case "5":
                    ProgramQ5.Main();
                    break;
                case "6":
                    ProgramQ6.Main();
                    break;
                case "7":
                    ProgramQ7.Main();
                    break;
                case "8":
                    ProgramQ8.Main();
                    break;
                case "9":
                    ProgramQ9.Main();
                    break;
            }
        }
    }
}
