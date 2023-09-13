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

        /*
            Esercizio 1 : classi astratte

            Dobbiamo realizzare un programma che rappresenti il regno animale.

            Creiamo quindi una classe astratta Animale e delle classi che la estendono : Cane, Passerotto, Aquila, Delfino

            Vogliamo che gli animali abbiano i seguenti metodi
            - void Dormi() (mostra a video “Zzz”)
            - void Verso() (mostra a video il verso fatto dall'animale specifico)
            - void CosaMangi() (mostra a video quello che mangia: erba, carne, ...?)

            Quali di questi metodi devono essere implementati nella classe astratta e quali devono essere lasciati astratti e
            implementati dalle classi che la estendono?

            Una volta create le classi, nel programma istanziare alcuni animali e utilizzare i metodi implementati.
            */

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
