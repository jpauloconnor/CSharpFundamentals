using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_FantasyGame
{
    abstract class Enemy
    {
        protected ArrayList insult = new ArrayList { "buck-o", "wimp", "window licker", "noob", "nerd cakes", "buster" };
        protected Random rnd = new Random();
        public string Name { get; set; }
        public int PowerLevel { get; set; }

        //create an insult method with a few insults
        public virtual void Insult()
        {   
            int r = rnd.Next(insult.Count);

            Console.WriteLine("You're on the wrong side of the forest {0}", insult[r]);
        }

        public void Attack(Player player, Dictionary<string, int> dict, Object enemyName)
        {
            var singleAttack = dict.ElementAt(rnd.Next(dict.Count));
            int attackVal = singleAttack.Value;
            string attackName = singleAttack.Key;
            
            Console.WriteLine("{2} is attacking with {0} and deals {1}", attackName, attackVal, enemyName);



            Console.WriteLine("{0} power is at {1}%",player.PlayerName, player.CurrentPower);
            player.CurrentPower -= attackVal; // player.CurrentPower = player.CurrentPower  - 15

        } 
    }
}
