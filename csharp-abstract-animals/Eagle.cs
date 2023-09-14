using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Eagle : Animal, IFlying
    {
        public override void AnimalSound()
        {
            Console.WriteLine("salve a tutti");
        }

        public override void WhatItEats()
        {
            Console.WriteLine("Mangio principalmente volpi, lepri, marmotte, conigli selvatici e faine");
        }
        public void Fly()
        {
            Console.WriteLine("Sto volando");
        }
    }
}
