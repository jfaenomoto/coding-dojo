using ClassLibrary1.Parte3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.Dojo.Test.Parte3
{
    public class EquipeTabajara : IEquipeDeManutencao
    {
        public bool DeveInvalidarFoguetes { get; set; }

        public void VerificaSeFogueteOK(Foguete foguete)
        {
            if (this.DeveInvalidarFoguetes)
            {
                throw new Exception("fogueteChinês");
            }
            //Seu foguete esta ok, confie.
        }
    }
}
