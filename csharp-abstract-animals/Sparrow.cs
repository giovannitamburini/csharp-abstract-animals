using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Sparrow : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Cip Cip");
        }

        public override void WhatItEats()
        {
            Console.WriteLine("Mangio i vermi, fiocchi d'avena, noci, nocciole");
        }
    }
}
