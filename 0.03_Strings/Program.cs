﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simple Demo
            string firstName;
            string lastName;
            string occupation;

            firstName = "Charlie";
            lastName = "Brown";
            occupation = "Stuntman";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);


            //String Interpolation
            Console.WriteLine("Name: {0}"+"\n"+"Occupation: {1}", fullName, occupation);
            Console.WriteLine("{0:C}", 100.736);
            
            //Write the previous silver challenge using string interpolation

            Console.ReadLine();
        }
    }
}
