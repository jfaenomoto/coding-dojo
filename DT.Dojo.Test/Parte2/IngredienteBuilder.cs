using ClassLibrary1.Parte2;
using DT.Dojo.Parte2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.Dojo.Test.Parte2
{
    public class IngredienteBuilder : Builder<Ingrediente>
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public double Peso { get; set; }
        public Builder<Marca> Marca { get; set; }
        public double Caloria { get; set; }
        public DateTime Validade { get; set; }
        public bool EhVerdura { get; set; }
        public bool ContemGluten { get; set; }
        public bool ContemAcucar { get; set; }


        public Ingrediente build()
        {
            Ingrediente ingrediente = new Ingrediente();
            ingrediente.Nome = this.Nome;
            ingrediente.Peso = this.Peso;
            ingrediente.Quantidade = this.Quantidade;
            ingrediente.Validade = this.Validade;
            ingrediente.Marca = this.Marca.build();
            return ingrediente;
        }

        private IngredienteBuilder()
        {
            this.Marca = MarcaBuilder.UmaMarca();
        }

        public IngredienteBuilder DaMarca(Builder<Marca> Marca)
        {
            this.Marca = Marca;
            return this;
        }

        public static IngredienteBuilder UmIngrediente()
        {
            return new IngredienteBuilder();
        }

        public static IngredienteBuilder UmPao()
        {
            return new IngredienteBuilder().Chamado("Pao");
        }

        public IngredienteBuilder Chamado(string nome)
        {
            this.Nome = nome;
            return this;
        }

        public IngredienteBuilder Vencido()
        {
            this.Validade = new DateTime(1970, 2, 2);
            return this;
        }

        public IngredienteBuilder ComValidade(DateTime time)
        {
            this.Validade = time;
            return this;
        }

        public IngredienteBuilder ComPeso(double peso)
        {
            this.Peso = peso;
            return this;
        }
        public IngredienteBuilder ComQuantidade(int quantidade)
        {
            this.Quantidade = quantidade;
            return this;
        }

    }
}
