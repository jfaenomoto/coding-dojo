using ClassLibrary1.Parte1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.Dojo.Test.Parte3.Moq
{
    public class CalculadoraMockDeve
    {
        private ICalculadora calculadora;

        private bool dividiu;

        [TestInitialize]
        public void SetUp()
        {
            var mock = new Mock<ICalculadora>();

            // posso simular situações
            mock.Setup(c => c.Soma(1, 2)).Returns(6);

            // posso simular erros
            mock.Setup(c => c.Soma(2, 1)).Throws(new Exception("Deu ruim!"));

            // posso manipular estados
            this.dividiu = false;
            mock.Setup(c => c.Divide(It.IsAny<int>(), It.IsAny<int>()))
                .Callback(() => dividiu = true);

            this.calculadora = mock.Object;
        }

        [TestMethod]
        public void Somar()
        {
            Assert.AreEqual(6, this.calculadora.Soma(1, 2));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void DarRuim()
        {
            Assert.AreEqual(6, this.calculadora.Soma(2, 1));
        }

        [TestMethod]
        public void ChecarSeDividiu()
        {
            this.calculadora.Divide(0, 0);
            Assert.IsTrue(this.dividiu);
        }
    }
}
