using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1.Parte4;

namespace DT.Dojo.Test.Parte4
{
    [TestClass]
    public class MedicoDeve
    {
        private Medico medico;
        private Paciente paciente;
        private Estetoscopio estetoscopio;
        private Remedio remedio;

        [TestInitialize]
        public void IniciarTudo()
        {
            remedio = new Remedio();
            estetoscopio = new Estetoscopio();
            medico = new Medico(estetoscopio, remedio);
            paciente = new Paciente();
            
        }

        [TestMethod]
        public void CurarPaciente()
        {
            medico.Atende(paciente);
        }

        [TestMethod]
        public void CurarPacienteComProblemaRespiratorio()
        {
            paciente.temProblemasRespiratorios = true;
            medico.Atende(paciente);

            Assert.IsFalse(paciente.temProblemasRespiratorios);
        }
    }
}
