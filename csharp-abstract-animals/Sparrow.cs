﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Sparrow : Animal, IFlying
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Cip Cip");
        }

        public override void WhatItEats()
        {
            Console.WriteLine("Mangio i vermi, fiocchi d'avena, noci, nocciole");
        }
        public void Fly()
        {
            Console.WriteLine("Sto volando");
        }
    }
}
