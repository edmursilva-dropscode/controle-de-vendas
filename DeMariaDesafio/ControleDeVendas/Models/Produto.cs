namespace ControleDeVendas.Models
{
    // Classe que representa um produto disponível para venda
    public class Produto
    {
        // Propriedades do Produto
        public int Id { get; set; }                 // ID do produto
        public string? Descricao { get; set; }      // Descricao do produto
        public decimal Preco { get; set; }          // Preco do produto
        public int Quantidade { get; set; }         // Quantidade do produto
        public DateTime Data { get; set; }          // Data de cadastro do produto
        public bool? Ativo { get; set; }             // Se esta Ativo o produto
        public string? Status { get; set; }        // Status do produto - "Ativo" ou "Não ativo"

        // Navegação
        public List<ItemVenda> ItensVenda { get; set; }  // Lista de itens de venda associados ao produto

        // Construtor
        public Produto()
        {
            ItensVenda = new List<ItemVenda>();  // Inicializa a lista de itens de venda
        }

        // Classes internas para representar diferentes tipos de produtos
        public class ProdutoCons
        {
            public int Id { get; set; }
            public string? Descricao { get; set; }
        }

        public class ProdutoGrid
        {
            public int Id { get; set; }
            public string? Descricao { get; set; }
            public string? Status { get; set; }
        }

        public class ProdutoEdit
        {
            public int Id { get; set; }
            public string? Descricao { get; set; }
            public decimal Preco { get; set; }         
            public int Quantidade { get; set; }
            public DateTime Data { get; set; }          
            public bool Ativo { get; set; }             
            public string? Status { get; set; }        
        }
    }

}

