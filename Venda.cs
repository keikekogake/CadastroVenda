using System;

namespace CadastroVendaPOO
{
    public class Venda
    {
        private string cpf;
        private int id;
        private DateTime datavenda;
        /// <summary>
        /// Constroi o Construtor
        /// </summary>
        public Venda()
        {

        }

        /// <summary>
        /// Constroi o objeto Venda e vocẽ tem que passar os dados da Venda
        /// </summary>
        /// <param name="cpf">Recebe o CPF do Cliente como String</param>
        /// <param name="id">Recebe o ID do Produto como Int</param>
        /// <param name="datavenda">Recebe a DATA DA VENDA como DateTime</param>
        public Venda(string cpf, int id, DateTime datavenda)
        {
            this.cpf = cpf;
            this.id = id;
            this.datavenda = datavenda;
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public DateTime DataVenda
        {
            get { return datavenda; }
            set { datavenda = value; }
        }
    }
}