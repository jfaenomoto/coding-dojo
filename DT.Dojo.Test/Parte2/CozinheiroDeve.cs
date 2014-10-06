using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DT.Dojo.Parte2;

namespace DT.Dojo.Test.Parte2
{
    [TestClass]
    public class CozinheiroDeve
    {
        private Cozinheiro cozinheiro;
        private Ingrediente pao;
        private Ingrediente carne;
        private Ingrediente macarrao;
        private Ingrediente molho;

        [TestInitialize]
        public void PreparaCozinha()
        {
            cozinheiro = new Cozinheiro();
            pao = new Ingrediente("Pao");
            carne = new Ingrediente("Carne");
            macarrao = new Ingrediente("Macarrao");
            molho = new Ingrediente("Molho");

        }
        [TestMethod]
        public void CozinharUmHamburguer()
        {
            var prato = cozinheiro.Cozinha(pao, carne);

            Assert.AreEqual("Hamburguer", prato.Nome);
        }

        [TestMethod]
        public void CozinharUmaMacarronada()
        {
            var prato = cozinheiro.Cozinha(macarrao, molho);

            Assert.AreEqual("Macarronada", prato.Nome);
        }

        [TestMethod]
        public void CozinharUmaCarneComPao()
        {
            var prato = cozinheiro.Cozinha(carne, pao);

            Assert.AreEqual("Hamburguer", prato.Nome);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RejeitarIngredientesDesconhecidos()
        {
            var prato = cozinheiro.Cozinha(pao, macarrao);
        }
    }
}
