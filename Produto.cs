namespace CadastroVendaPOO
{
    public class Produto
    {
        private int id;
        private string nomeproduto;
        private string descricao;
        private double preco;

        public Produto()
        {

        }

        public Produto (int id, string nomeproduto, string descricao, double preco)
        {
            this.id = id;
            this.nomeproduto = nomeproduto;
            this.descricao = descricao;
            this.preco = preco;
        }

        
    }
}