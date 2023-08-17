using Domain.Enums;

namespace Domain.Entities
{
    public class Produto
    {
        public Produto(int? id, string nome, string descricao, ProdutoCategoria produtoCategoriaId, decimal preco, string imagem)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            ProdutoCategoriaId = produtoCategoriaId;
            Preco = preco;
            Imagem = imagem;
        }

        public Produto() { }

        public int? Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Enums.ProdutoCategoria ProdutoCategoriaId { get; set; }
        public decimal Preco { get; set; }
        public string Imagem { get; set; }


    }
}
