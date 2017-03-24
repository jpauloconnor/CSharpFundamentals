using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors_Challenge
{
    class MobilePhone
    {
        //CONSTRUCTOR
        public MobilePhone(string make, string model, string owner)
        {
            Make = make;
            Model = model;
            Owner = owner;
        }

        //PROPERTIES
        public int MobilePhoneID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Owner { get; set; }

        //METHODS
        public void PrintToScreen()
        {
            Console.WriteLine("I own an " + Make + " " + Model);
        }









    }
}
