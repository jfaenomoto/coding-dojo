using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1.Parte3;

namespace DT.Dojo.Test.Parte3
{
    [TestClass]
    public class LancadorDeFogueteDeve
    {
        public LancadorDeFoguete meuLancadorDeFoguete { get; set; }

        private EquipeTabajara MinhaEquipe { get; set; }

        [TestInitialize]
        public void IniciarLancamento()
        {
            meuLancadorDeFoguete = new LancadorDeFoguete();
            MinhaEquipe = new EquipeTabajara();
            meuLancadorDeFoguete.Equipe = MinhaEquipe;
            meuLancadorDeFoguete.Fabrica = new FabricaFogueteiraFalsa();
            
        }

        [TestMethod]
        public void LancarFoguete()
        {
            var foguete = meuLancadorDeFoguete.LancaFoguete();

            Assert.IsNotNull(foguete);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void FalharAoLancarFogueteInvalido()
        {
            this.MinhaEquipe.DeveInvalidarFoguetes = true;
            meuLancadorDeFoguete.LancaFoguete();
        }

    }
}
