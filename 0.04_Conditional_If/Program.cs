using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditional_If
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOn = false;
            bool isHot = false;

            /*
             Comparison Operators

            == isEqual to 
            >= GreaterThan or Equal to 
            <= LessThan or Equal to 
            != NotEqual
            > GreaterThan
            < Lessthan
            ! Not
            && And
            || Or

             */


            if (isOn)
            {
                Console.WriteLine("The light is on.");
            }
            //Create a isAdmin bool , write a if statement that says 
            // if a user is a admin "Welcome to the site Admin"
            bool isAdmin = true;
            bool isLoggedIn = true;
            //if (isAdmin)
            //{
            //    Console.WriteLine("Welcome to the site!");
            //}
            //if (!isAdmin)
            //{
            //    Console.WriteLine("Hey you aren't an Admin");
            //}
            //Using a comparison operator for "and" using the isAdmin, and a new bool for 
            //isLoggedIn create an If statement that prints out "Your logged in! and your an Admin"
            if (isAdmin && isLoggedIn)
            {
                Console.WriteLine("You're logged in! You are also an Admin!");
            }
            

            Console.ReadLine();
        }
    }
}
