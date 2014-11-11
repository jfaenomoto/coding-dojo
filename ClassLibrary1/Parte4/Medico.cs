using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Parte4
{
    public class Medico
    {
        private Estetoscopio estetoscopio { get; set; }
        private Remedio remedio { get; set; }

        public Medico(Estetoscopio estetoscopio, Remedio remediosagrado)
        {
            this.estetoscopio = estetoscopio;
            this.remedio = remediosagrado;
        }

        public void Atende(Paciente paciente)
        {
            try
            {
                this.estetoscopio.auscuta(paciente);
            } 
            catch (Doenca)
            {   
                paciente.Toma(remedio);
            }
        }
    }
}
