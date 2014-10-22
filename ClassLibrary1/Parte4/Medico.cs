using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Parte4
{
    public class Medico
    {
        public void Atende(Paciente paciente)
        {
            Estetoscopio estetoscopio = new Estetoscopio();
            try
            {
                estetoscopio.auscuta(paciente);
            } catch (Doenca)
            {
                Remedio remedio = new Remedio();
                paciente.Toma(remedio);
            }
        }
    }
}
