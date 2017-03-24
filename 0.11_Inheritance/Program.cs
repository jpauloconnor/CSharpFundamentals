using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Bear barryTHeBear = new Bear();
            barryTHeBear.Weight = 2000;

            Dog spot = new Dog();
            spot.Weight = 250;
            spot.Name = "Clifford the big Gray Dog";
            spot.HasEyes = true;



            barryTHeBear.Walks();
            barryTHeBear.Speak();




            PolarBear cokeACola = new PolarBear();
            Animal theJSWiz = new Animal();
            theJSWiz.NumberOfLegs = 2;
            theJSWiz.HasEyes = false; 
            
            Console.ReadLine();
        }
    }
}
