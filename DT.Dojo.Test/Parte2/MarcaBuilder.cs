using ClassLibrary1.Parte2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DT.Dojo.Test.Parte2
{
    public class MarcaBuilder: Builder<Marca>
    {
        private string Nome;
        private MarcaBuilder()
        {

        }
        public static MarcaBuilder UmaMarca()
        {
            return new MarcaBuilder();
        }
        public MarcaBuilder ComNome(string Nome)
        {
            this.Nome = Nome;
            return this;
        }

        public Marca build()
        {
            Marca _marca = new Marca();
            _marca.Nome = this.Nome;
            return _marca;
        }
    }
}
