using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.Dojo.Parte2
{
    public class Cozinheiro
    {
        public Prato Cozinha(
            params Ingrediente[] ingredientes)
        {
            if (ingredientes.Count() == 2 &&
                ingredientes.Select(x => x.Nome).Contains("Carne") &&
                ingredientes.Select(x => x.Nome).Contains("Pao"))
            {
                var hamburger = new Prato();
                hamburger.Nome = "Hamburguer";
                return hamburger;
            }
            else if (ingredientes.Count() == 2 &&
                ingredientes.Select(x => x.Nome).Contains("Macarrao") &&
                ingredientes.Select(x => x.Nome).Contains("Molho"))
            {
                return new Prato("Macarronada");
            }
            throw new ArgumentException("Panela");
        }
    }
}
