﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Parte4
{
    // não mexer no paciente, ele é quem você está examinando!
    public sealed class Paciente
    {
        public bool temProblemasRespiratorios { get; set; }

        public bool temProblemasCardiacos { get; set; }

        public void Toma(Remedio remedio)
        {
            Console.WriteLine("Estou curado!");
            if (remedio.Nome == "Viagra")
            {
                this.temProblemasCardiacos = false;
            }
            else if (remedio.Nome == "Bezetacil")
            {
                this.temProblemasCardiacos = false;
                this.temProblemasRespiratorios = false;
            }
            else if (remedio.Nome == "Vick")
            {
                this.temProblemasRespiratorios = false;
            }
            
        }
    }
}
