using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Methods_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Netflix tcats = new Netflix();
            tcats.Name = "Thundercats";
            tcats.Rating = 5.0;
            tcats.Genre = "Cartoon Action";
            tcats.TotalMinutes = 22;
            tcats.GetSuggestions();
            tcats.ShowRuntime();
            Console.WriteLine(tcats.ShowWhoViewed("Ava", "4"));



            tcats.ShowNumberOfMinutesLeft(7);
            tcats.ShowNumberOfMinutesLeft(8);
            tcats.ShowNumberOfMinutesLeft(9);
            tcats.ShowNumberOfMinutesLeft(10);
            tcats.ShowNumberOfMinutesLeft(11);










            Netflix houseOfCards = new Netflix();
            houseOfCards.Name = "House of Cards";
            houseOfCards.Genre = "Political Drama";
            houseOfCards.Rating = 4.2;

            Netflix ironFist = new Netflix();
            ironFist.Name = "Iron Fist";
            ironFist.Genre = "Cheesy Kung Fu";
            ironFist.Rating = 3.7;

            Console.ReadLine();
        }
    }
}
