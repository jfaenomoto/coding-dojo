﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.Dojo.Parte2
{
    public class Ingrediente
    {
        public Ingrediente(string nome)
        {
            this.Nome = nome;
        }

        public string Nome { get; private set; }
    }
}
