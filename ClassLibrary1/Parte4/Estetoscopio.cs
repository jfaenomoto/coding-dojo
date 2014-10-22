using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Parte4
{
    // não mexer no estetoscópio, ele foi dado pela industria
    public sealed class Estetoscopio
    {
        public void auscuta(Paciente paciente)
        {
            if (paciente.temProblemasRespiratorios)
            {
                throw new Doenca("Paciente tem problemas cardíacos");
            }
            if (paciente.temProblemasCardiacos)
            {
                throw new Doenca("Paciente tem problemas respiratórios");
            }
        }
    }
}
