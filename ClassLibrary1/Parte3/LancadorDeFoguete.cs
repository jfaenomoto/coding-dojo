using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Parte3
{
    public class LancadorDeFoguete
    {
        public IFabricaDeFoguete Fabrica { get; set; }

        public IEquipeDeManutencao Equipe { get; set; }

        public Foguete LancaFoguete()
        {
            try
            {
                var foguete = Fabrica.FabricaFoguete();
                Equipe.VerificaSeFogueteOK(foguete);
                Console.WriteLine("Foguete no ar...");
                return foguete;
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
    }
}
