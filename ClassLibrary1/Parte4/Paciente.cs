﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Parte4
{
    public class Paciente
    {
        public bool temProblemasRespiratorios { get; set; }

        public bool temProblemasCardiacos { get; set; }

        public void Toma(Remedio remedio)
        {
            Console.WriteLine("Estou curado!");
        }
    }
}