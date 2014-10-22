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
        private Ingrediente carnevencida;
        private Ingrediente macarrao;
        private Ingrediente molho;

        [TestInitialize]
        public void PreparaCozinha()
        {
            cozinheiro = new Cozinheiro();
            pao = IngredienteBuilder.UmPao()
                .ComValidade(DateTime.MaxValue)
                .DaMarca(MarcaBuilder.UmaMarca().ComNome("Pullman"))
                .build();
            carne = IngredienteBuilder.UmIngrediente()
                .Chamado("Carne")
                .ComQuantidade(20)
                .ComPeso(100)
                .ComValidade(DateTime.MaxValue)
                .build();
            carnevencida = IngredienteBuilder.UmIngrediente()
                .Chamado("Carne")
                .ComQuantidade(20)
                .ComPeso(100)
                .Vencido()
                .build();
            macarrao = IngredienteBuilder.UmIngrediente()
                .Chamado("Macarrao")
                .ComQuantidade(7)
                .ComPeso(77)
                .ComValidade(DateTime.MaxValue)
                .build();
            molho = IngredienteBuilder.UmIngrediente()
                .Chamado("Molho")
                .ComPeso(27)
                .ComQuantidade(47)
                .ComValidade(DateTime.MaxValue)
                .build();

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
        [ExpectedException(typeof(NaoSeiCozinharException))]
        public void RejeitarIngredientesDesconhecidos()
        {
            var prato = cozinheiro.Cozinha(pao, macarrao);
        }

        [TestMethod]
        [ExpectedException(typeof(IngredienteVencidoException))]
        public void RejeitarIngredientesVencidos()
        {
            var prato = cozinheiro.Cozinha(pao, carnevencida);
        }
    }
}
