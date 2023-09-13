using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            // istanzio alcuni animali per testare i metodi
            Dog Rex = new Dog();
            Sparrow Titti = new Sparrow();
            Eagle Olympia = new Eagle();
            Dolphin Flipper = new Dolphin();


            // testo i relativi metodi
            Rex.Sleep();
            Rex.AnimalSound();
            Rex.WhatItEats();

            Console.WriteLine();

            Titti.Sleep();
            Titti.AnimalSound();
            Titti.WhatItEats();
            
            Console.WriteLine();

            Olympia.Sleep();
            Olympia.AnimalSound();
            Olympia.WhatItEats();

            Console.WriteLine();

            Flipper.Sleep();
            Flipper.AnimalSound();
            Flipper.WhatItEats();

            Console.WriteLine("-------------------------");
        }
    }
}