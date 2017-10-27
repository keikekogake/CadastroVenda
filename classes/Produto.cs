namespace CadastroVendaPOO
{
    public class Produto
    {
        private int id;
        private string nomeproduto;
        private string descricao;
        private double preco;

        /// <summary>
        /// Constroi o Construtor Produto
        /// </summary>
        public Produto()
        {

        }

        /// <summary>
        /// Constroi o objeto Produto e você precisa passar os dados do Produto
        /// </summary>
        /// <param name="id">Recebe o ID do produto como inteiro</param>
        /// <param name="nomeproduto">Recebe o NOME do produto como String</param>
        /// <param name="descricao">Recebe a DESCRICAO do produto como String</param>
        /// <param name="preco">Recebe o PRECO do produto como Double</param>
        public Produto(int id, string nomeproduto, string descricao, double preco)
        {
            this.id = id;
            this.nomeproduto = nomeproduto;
            this.descricao = descricao;
            this.preco = preco;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string NomeProduto
        {
            get { return nomeproduto; }
            set { nomeproduto = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
    }
}