﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Collections_ArraysOfObject
{
    class Country
    {
        //Constructors
        public Country(string name, string capital)
        {
            Name = name;
            Capital = capital;
        }
        //Properties
        public string Name { get; set; }
        public string Capital { get; set; }

        //METHOD
        public void PrintCountryDetails()
        {
            Console.WriteLine("The capital of {0} is {1}.", this.Name, this.Capital);
        }




    }
}
