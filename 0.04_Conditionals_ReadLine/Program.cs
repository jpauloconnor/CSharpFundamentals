using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How are you feeling today from 1-5?");
            string feelingNumber = Console.ReadLine();

            if(feelingNumber == "5")
            {
                Console.WriteLine("Wowie zowie, man. That's great to hear.");
            }
            else if(feelingNumber == "4")
            {
                Console.WriteLine("That's pretty good, bro.");
            }
            else if(feelingNumber == "3")
            {
                Console.WriteLine("Alright.");
            }
            else if(feelingNumber == "2")
            {
                Console.WriteLine("Ok");
            }
            else if (feelingNumber == "1")
            {
                Console.WriteLine("Lame");
            }
            else
            {
                Console.WriteLine("Sorry, didn't catch that, man.");
            }
            Console.ReadLine();
        }
    }
}
