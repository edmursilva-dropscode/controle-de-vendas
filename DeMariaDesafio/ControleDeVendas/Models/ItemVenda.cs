namespace ControleDeVendas.Models
{
    // Classe que representa um item vendido em uma venda
    public class ItemVenda
    {
        // Propriedades do ItemVenda
        public int Id { get; set; }                    // ID do item vendido
        public int Quantidade { get; set; }            // Quantidade do produto vendido
        public decimal PrecoUnitario { get; set; }     // Preço unitário do item venda
        public decimal PrecoTotal { get; set; }        // Preço total do item (quantidade * preço_unitario)
        public int VendaId { get; set; }               // ID da Venda à qual o item pertence
        public int ProdutoId { get; set; }             // ID do Produto 

        // Navegação
        public List<Venda> Vendas { get; set; }        // Lista de vendas associadas ao cliente

        // Construtor
        public ItemVenda()
        {
            Vendas = new List<Venda>();                // Inicializa a lista de vendas
        }

    }

}

