using ClassLibrary1.Parte3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.Dojo.Test.Parte3
{
    public class FabricaFogueteiraFalsa: IFabricaDeFoguete
    {

        public Foguete FabricaFoguete()
        {
            return new Foguete();
        }
    }
}
