using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Collections_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>
            {
                { "cat", "annoying creature" },
                { "dog", "man's best friend" }
            };
            foreach (KeyValuePair<string, string> pair in dictionary)
            {
                Console.WriteLine("{0} is a {1}", pair.Key, pair.Value);
            }



            //BRONZE:
            //Create a Dictionary that has all of the academy award winners for best picture from 2000-2005.
            //Iterate over that dictionary and print it to the console.

            Dictionary<string, string> movies = new Dictionary<string, string>();
            movies.Add("2000", "Gladiator");
            movies.Add("2001", "A Beautiful Mind");
            movies.Add("2002", "Chicago");
            movies.Add("2003", "Lord of the Rings: Return of the King");
            movies.Add("2004", "Million Dollar Baby");
            movies.Add("2005", "Crash");
            

            foreach (KeyValuePair<string, string> movie in movies)
            {
                Console.WriteLine("The winner of Best Picture in {0} was {1}.", movie.Key, movie.Value);
            }

            //SILVER: 
            //Create a Dictionary of Best Picture Nominees that has the year as the key and an array of movies as the values for the same years.
            //Iterate over that Dictionary and print the values to the console.

            Dictionary<string, string[]> bestPictureNoms = new Dictionary<string, string[]>();

            bestPictureNoms.Add("2000", new string[] { "Gladiator", "Chocolat", "Crouching Tiger Hidden Dragon" });
            bestPictureNoms.Add("2001", new string[] { "Beautiful Mind", "Gosford Park", "In the Bedroom" });
            bestPictureNoms.Add("2002", new string[] { "Chicago", "Gangs of New York", "Harry Potter CS" });

            foreach(KeyValuePair<string, string[]> bestPictureNom in bestPictureNoms)
            {
                Console.WriteLine("{0}: {1}, {2}, {3}", bestPictureNom.Key, bestPictureNom.Value[0], bestPictureNom.Value[1], bestPictureNom.Value[2]);
            }
            //GOLD:
            //Create two Readline prompts in the console.The first one should say this:
            //    Please type a year in the space below to show the movie that won:
            //	>
            //Then after entering a number, you should be able to enter another number and list out all the nominees for a year.
            //    Please type a year to show the movies that were up for an award that year:
            //	>
            Console.WriteLine(movies["2002"]);
            Console.WriteLine("Please type a year to show the movie that won:");
            string input1 = Console.ReadLine();

            if (movies.ContainsKey(input1))
            {
                string valueForKey = movies[input1];
                Console.WriteLine("The best picture in " + input1 + " was " + valueForKey);
            }

            Console.WriteLine("Please type the year to show the movies that were up for an award that year:");
            string input2 = Console.ReadLine();

            if (bestPictureNoms.ContainsKey(input2))
            {
                string[] valueForKey = bestPictureNoms[input2];
                string nomineeString = string.Join(", ", valueForKey);
                Console.WriteLine("The best nominees in " + input2 + " were " + nomineeString);
            }
            





            Console.ReadLine();
        }
    }
}
//BRONZE:
//Create a Dictionary that has all of the academy award winners for best picture from 2000-2005.
//Iterate over that dictionary and print it to the console.



//SILVER: 
//Create a Dictionary of Best Picture Nominees that has the year as the key and an array of movies as the values for the same years.
//Iterate over that Dictionary and print the values to the console.

//GOLD:
//Create two Readline prompts in the console.The first one should say this:
//    Please type a year in the space below to show the movie that won:
//	>
//Then after entering a number, you should be able to enter another number and list out all the nominees for a year.
//    Please type a year to show the movies that were up for an award that year:
//	>

    