using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend = "L";

            switch (friend)
            {
                case "Fred":
                    Console.WriteLine("Hey Fred");
                    break;
                case "Kenn":
                    Console.WriteLine("Hey Kenn");
                    break;
                case "Jenn":
                    Console.WriteLine("Hey Jenn");
                    break;
                case "Paul":
                    Console.WriteLine("Hey Paul");
                    break;
                case "James":
                    Console.WriteLine("Hey James");
                    break;
                default:
                    Console.WriteLine("You hit the default.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
