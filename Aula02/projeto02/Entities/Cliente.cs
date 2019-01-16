using System;
using System.Collections.Generic;
using System.Text;


namespace projeto02
{
    public class Cliente
    {
        #region Atributos
        private int idCliente;
        private string nome;
        private string email;
        #endregion

        #region Encapsulamento
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        #endregion

        #region Construtor
        //Construtor Default
        public Cliente()
        {

        }

        public Cliente (int idCliente, string nome, string email)
        {
            IdCliente = idCliente;
            Nome = nome;
            Email = email;
            
        }
        #endregion
    }

}
