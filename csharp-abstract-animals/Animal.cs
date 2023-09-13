using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public abstract class Animal
    {
        //public string[] FoodArray { get; }

        //public Animal(string[] foodArray)
        //{
        //    this.FoodArray = foodArray;
        //}


        // metodo per stampare a video "Zzz"
        public void Sleep()
        {
            Console.WriteLine("Zzz");
        }

        // metodo generico astratto che utilizzerò per mostrare a video il verso dello specifico animale
        public abstract void AnimalSound();

        // metodo generico per stampare a schermo l'array dei cibi mangiati dall'animale
        public abstract void WhatItEats();




        //public void WhatItEats(string[] foodArray)
        //{
        //    Console.WriteLine("Questo è l'array dei cibi mangiati: ");

        //    for (int i = 0; i < foodArray.Length; i++)
        //    {
        //        Console.WriteLine("- " + foodArray[i]);
        //    }
        //}

        //public abstract void WhatItEats();
    }
}
