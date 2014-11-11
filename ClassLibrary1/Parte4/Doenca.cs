using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1.Parte4
{
    // não mexer na doença, você não é Deus!= Rueda
    public sealed class Doenca : Exception
    {
        public Doenca(string message)
            : base(message)
        {
        }
    }
}
