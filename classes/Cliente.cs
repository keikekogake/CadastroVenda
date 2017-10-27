using System;

namespace CadastroVendaPOO
{
    public class Cliente
    {
        private string nome;
        private string email;
        private string cpf;
        private DateTime datacadastro;

        /// <summary>
        /// Constroi o Construtor Cliente;
        /// </summary>
        public Cliente()
        {

        }

        /// <summary>
        /// Constroi o objeto Cliente e você precisa passar os dados do cliente
        /// </summary>
        /// <param name="nome">Recebe o NOME do Cliente como String</param>
        /// <param name="email">Recebe o EMAIL do Cliente como String</param>
        /// <param name="cpf">Recebe o CPF do Cliente como String</param>
        /// <param name="datacadastro">Recebe a DATA DE CADASTRO do Cliente como DateTime</param>
        public Cliente(string nome, string email, string cpf, DateTime datacadastro)
        {
            this.nome = nome;
            this.email = email;
            this.cpf = cpf;
            this.datacadastro = datacadastro;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public DateTime DataCadastro
        {
            get { return datacadastro; }
            set { datacadastro = value; }
        }
    }
}