using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_abstract_animals
{
    public class Program
    {
        /*
        Esercizio 1 : classi astratte
        Dobbiamo realizzare un programma che rappresenti il regno animale.
        Creiamo quindi una classe astratta Animale e delle classi che la estendono : Cane, Passerotto, Aquila, Delfino
        Vogliamo che gli animali abbiano i seguenti metodi
        - void Dormi() (mostra a video “Zzz”)
        - void Verso() (mostra a video il verso fatto dall'animale specifico)
        - void CosaMangi() (mostra a video quello che mangia : erba, carne, ...?)
        Quali di questi metodi devono essere implementati nella classe astratta e quali devono essere lasciati astratti e implementati dalle classi che la estendono?
        Una volta create le classi, nel programma istanziare alcuni animali e utilizzare i metodi implementati.

        Esercizio 2 : interfacce
        Alcuni degli animali che abbiamo creato volano, altri nuotano.
        Gli animali che volano hanno il seguente metodo :
        - void Vola() (mostra a video “Sto volando!!!”)
        Gli animali che nuotano hanno il seguente metodo :
        - void Nuota() (mostra a video “Sto nuotando!!!”)
        Scrivere un programma avente 2 metodi :
        - void FaiVolare(IVolante animale)
        - void FaiNuotare(INuotante animale)
        Questi metodi prendono come parametro un animale che può o volare / nuotare e richiamano il corrispondente metodo Vola() / Nuota().
        Scrivere un programma che istanzi animali che volano o nuotano e richiamare i metodi FaiVolare / FaiNuotare passandoglieli come parametro l'animale corretto.
         */

        // creo due metodi che accettano come parametri solo animali con interfaccia IFlying o ISwimming e che richiamano i corrispondenti metodi
        static void MakeFly(IFlying flyingAnimal)
        {
            flyingAnimal.Fly();
        }

        static void MakeSwim(ISwimming swimmingAnimal)
        {
            swimmingAnimal.Swim();
        }

        static void Main(string[] args)
        {

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

            // ESERCIZIO 2
            MakeFly(Titti);

            MakeFly(Olympia);

            MakeSwim(Flipper);
        }
    }
}