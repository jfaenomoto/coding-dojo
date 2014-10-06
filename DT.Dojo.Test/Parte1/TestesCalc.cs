using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DT.Dojo.Parte1;

namespace DT.Dojo.Test.Parte1
{
    [TestClass]
    public class CalculadoraDeve
    {
        public Calculadora Calculadora { get; set; }

        public int Numero1 { get; set; }

        public int Numero7 { get; set; }

        public int Negativo1 { get; set; }

        public int Negativo2 { get; set; }

        public int Zero { get; set; }

        [TestInitialize]
        public void InicializaCalculadora()
        {
            this.Calculadora = new Calculadora();
            this.Numero1 = 1;
            this.Numero7 = 7;
            this.Negativo1 = -6;
            this.Negativo2 = -1;
            this.Zero = 0;
        }

        [TestMethod]
        public void SomarDoisNumerosPositivos()
        {
            int result = this.Calculadora.Soma(Numero1, Numero7);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void SomarDoisNumerosNegativos()
        {
            int result = this.Calculadora.Soma(Negativo1, Negativo2);
            Assert.AreEqual(-7, result);
        }

        [TestMethod]
        public void SomarNumeroNegativoComPositivo()
        {
            int result = this.Calculadora.Soma(Negativo2, Numero1);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void DarErroAoDividirPorZero()
        {
            int result = this.Calculadora.Divide(Numero7, Zero);
        }
        
        [TestMethod]
        public void InformarImpossibilidadeDeDivisaoPorZero()
        {
            try
            {
                int result = this.Calculadora.Divide(Numero7, Zero);
                Assert.Fail("Exceção esperada!");
            }
            catch (Exception e)
            {
                Assert.AreEqual("Não dividirás por zero!", e.Message);
            }
        }

        [TestMethod]
        public void SubtrairNumeroPositivoComNegativo()
        {
            int result = Calculadora.Subtrai(Numero7, Negativo1);
            Assert.AreEqual(13, result);
        }

        [TestMethod]
        public void SubtrairZeroDeNumeroPositivo()
        {
            int result = Calculadora.Subtrai(Numero7, Zero);
            Assert.AreEqual(Numero7, result);
        }

        [TestMethod]
        public void MultiplicarDoisNumerosPositivos()
        {
            int result = Calculadora.Multiplica(5, 6);
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void MultiplicarNumeroPorZero()
        {
            int result = Calculadora.Multiplica(9, 0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MultiplicarZeroPorNumero()
        {
            int result = Calculadora.Multiplica(0,3);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MultiplicarNumeroPositivoPorNumeroNegativo()
        {
            int result = Calculadora.Multiplica(1,-1);
            Assert.AreEqual(-1, result);
        }   
    }
}
