using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Dolphin : Animal, ISwimming
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Bio Bio Biosonar");
        }

        public override void WhatItEats()
        {
            Console.WriteLine("Mangio pesci, crostacei e calamari");
        }
    }
}
