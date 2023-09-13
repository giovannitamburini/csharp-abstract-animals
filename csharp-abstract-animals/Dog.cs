using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Bau");
        }

        public override void WhatItEats()
        {
            Console.WriteLine("Mangio le crocchette di carne e pesce e le scatolette di umido");
        }
    }
}
