﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public interface ISwimming
    {
        public void Swim()
        {
            Console.WriteLine("Sto nuotando");
        }
    }
}