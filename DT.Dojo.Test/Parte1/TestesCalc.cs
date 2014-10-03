using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DT.Dojo.Parte1;

namespace DT.Dojo.Test.Parte1
{
    [TestClass]
    public class TestesCalc
    {
        public Calculadora Calculadora { get; set; }

        public int Numero1 { get; set; }

        public int Numero2 { get; set; }

        public int Negativo1 { get; set; }

        public int Negativo2 { get; set; }

        public int Zero { get; set; }

        [TestInitialize]
        public void InicializaCalculadora()
        {
            this.Calculadora = new Calculadora();
            this.Numero1 = 1;
            this.Numero2 = 7;
            this.Negativo1 = -6;
            this.Negativo2 = -1;
            this.Zero = 0;
        }

        [TestMethod]
        public void SomarDoisNumeros()
        {
            int result = this.Calculadora.Soma(Numero1, Numero2);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void SomarDoisNumerosNegativos()
        {
            int result = this.Calculadora.Soma(Negativo1, Negativo2);
            Assert.AreEqual(-7, result);
        }

        [TestMethod]
        public void SomaNegativoComPositivo()
        {
            int result = this.Calculadora.Soma(Negativo2, Numero1);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void DividePorZero()
        {
            int result = this.Calculadora.Divide(Numero2, Zero);
        }
        
        [TestMethod]
        public void DividePorZeroParte2(int a , int b)
        {
            try
            {
                int result = this.Calculadora.Divide(Numero2, Zero);
                Assert.Fail("Exceção esperada!");
            }
            catch (Exception e)
            {
                Assert.AreEqual("Não dividirás por zero!", e.Message);
            }
        }
    }
}
