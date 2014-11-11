using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.Dojo.Parte1
{
    public class Calculadora : ClassLibrary1.Parte1.ICalculadora
    {
        public int Soma(int x, int y)
        {
            return x + y;
        }

        public int Subtrai(int x, int y)
        {
            // TODO implementar
            return Soma(x, -y);
        }

        public int Multiplica(int x, int y)
        {
            return x * y;
        }

        public int Divide(int x, int y)
        {
            if (y == 0)
            { 
                throw new Exception("Não dividirás por zero!"); 
        }
            return ((x/x)*x)/ y;
        }
    }
}
