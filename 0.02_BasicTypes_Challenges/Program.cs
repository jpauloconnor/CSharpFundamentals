﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypes_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            /*BRONZE CHALLENGE:
              Create a list of value types. (int, string, bool, float, double)
              Create two examples for each type. One is a declaration only.
              The other is a declaration with initializer.
              Print a view of the values in the console.

          SILVER CHALLENGE:
              Use those types to concatenate a string.Any string will do.


         GOLD CHALLENGE:
            Declare the year you were born as a string.
              Convert it to an integer and print it with a message in the console.
              For instance, "I was born in 1976." */

            int luckyNumber;
            int yearGraduatedHighSchool = 1994;

            string fbPost;
            string reTweet = "Yes, I'll retweet that.";

            bool isMarried;
            bool isHappy = true;

            decimal studentLoanAmount;
            decimal bankAccount = 100;  //More expensive than a double.

            float amountOfSnow;
            float temperature = 57.5f;

            double latitude;
            double oneThird = 3.33333333d;

            fbPost = "The Patriots are terrible!";

            Console.WriteLine(temperature);
            Console.WriteLine(oneThird);
        }
    }
}
