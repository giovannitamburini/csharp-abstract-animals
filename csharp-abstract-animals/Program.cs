using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_abstract_animals
{
    public class Program
    {

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