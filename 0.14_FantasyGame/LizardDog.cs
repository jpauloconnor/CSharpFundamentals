using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_FantasyGame
{
    class LizardDog : Enemy
    {
        Dictionary<string, int> Attacks = new Dictionary<string, int>
            {
                { "Claw Slash", 5 },
                { "Mallet", 15 },
                { "Running Man", 35 }
            };
        public LizardDog()
        {
            this.PowerLevel = 40;
            this.Name = "Lizard Dog"; 
        }

        public override void Insult()
        {
            int r = rnd.Next(insult.Count);
            Console.WriteLine("I am {0} you {1}", this.Name, insult[r]);
        }

        public void LizardAttack(Player p)
        {
            Attack(p, Attacks, this.Name);
        }
    }
}
