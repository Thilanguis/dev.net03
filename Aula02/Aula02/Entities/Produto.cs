using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02.Entities
{
    public class Produto
    {
        #region Atributos
        private int idProduto;
        private string nome;
        private decimal preco;
        private int quantidade;
        #endregion

        #region Métodos
        public int IdProduto { get => idProduto; set => idProduto = value; }
        public string Nome { get => nome; set => nome = value; }
        public decimal Preco { get => preco; set => preco = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }

        //Construtor default
        //atalho para criar construtor default: ctor + tab 2x
        public Produto() //Se não criar o construtor default vc perde a possibilidade de instanciar
        {

        }

        public Produto(int idProduto, string nome, decimal preco, int quantidade) //São variáveis e não atributos
        {
            IdProduto = idProduto;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        #endregion
    }
}
