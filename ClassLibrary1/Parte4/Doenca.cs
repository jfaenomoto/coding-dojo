using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1.Parte4
{
    public class Doenca : Exception
    {
        public Doenca(string message)
            : base(message)
        {
        }
    }
}
