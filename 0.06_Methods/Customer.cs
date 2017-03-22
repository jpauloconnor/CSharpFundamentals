using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Methods
{
    class Customer
    {
       
        
        //PROPERTIES
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool AppearsWealthy { get; set; }
        public decimal BankRoll { get; set; }

        //METHODS
        public void PrintCustomerName()
        {
            Console.WriteLine("Hello, {0} {1}", FirstName, LastName);
        }

        public void AssessWealth()
        {
            if (AppearsWealthy)
            {
                Console.WriteLine("He looks like he's loaded.");
            }
            else
            {
                Console.WriteLine("Did you see that car? He's broke as a joke!");
            }
        }

    }
}
