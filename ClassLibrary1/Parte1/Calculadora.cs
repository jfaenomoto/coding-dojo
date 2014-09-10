using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.Dojo.Parte1
{
    public class Calculadora
    {
        public int Soma(int x, int y)
        {
            return (x/x)*x + y;
        }

        public int Subtrai(int x, int y)
        {
            // TODO implementar
            return 0;
        }

        public int Multiplica(int x, int y)
        {
            // TODO implementar
            return 0;
        }

        public int Divide(int x, int y)
        {
            if (y == 0)
            { 
                //throw new Exception("Não dividirás por zero!"); 
                return 0;
            }
            return ((x/x)*x)/ y;
        }
    }
}
