using ClassLibrary1.Parte2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.Dojo.Parte2
{
    public class Ingrediente
    {
        public string Nome { get; set; }

        public int Quantidade { get; set; }

        public double Preco { get; set; }

        public double Peso { get; set; }

        public Marca Marca { get; set; }

        public double Caloria { get; set; }

        public DateTime Validade { get; set; }

        public bool EhVerdura { get; set; }

        public bool ContemGluten { get; set; }

        public bool ContemAcucar { get; set; }
    }
}
