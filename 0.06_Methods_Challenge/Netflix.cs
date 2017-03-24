using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Methods_Challenge
{
    class Netflix
    {
        //PROPERTIES
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
        public int TotalMinutes { get; set; }


        //METHODS

       /// <summary>
       /// Methods with no return.
       /// </summary>
        public void GetSuggestions()
        {
            if (Rating >= 4)
                Console.WriteLine("You've gotta see this show!");
            else
                Console.WriteLine("Don't waste your life on this thing.");
        }


        /// <summary>
        /// Methods that return a value
        /// </summary>
        /// <returns></returns>
        public int ShowRuntime()
        {
            Console.WriteLine(this.Name + " is " + this.TotalMinutes + " minutes long");
            return this.TotalMinutes;
        }


        ///METHODS that have parameters 
        public string ShowWhoViewed(string username, string time)
        {
            string details = username + " watched this at " + time;
            Console.WriteLine(details);
            return details;
        }

        //Takes in a parameter of num minutes watched.
        //Returns number of minutes left.

        public int ShowNumberOfMinutesLeft(int minutesViewed)
        {
            int numMinutesLeft = this.TotalMinutes - minutesViewed;
            Console.WriteLine("There are " + numMinutesLeft + " minutes left in " + this.Name);
            return numMinutesLeft;
        }



    }
}
