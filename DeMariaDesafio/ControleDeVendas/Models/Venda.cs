namespace ControleDeVendas.Models
{
    // Classe que representa uma venda realizada no sistema
    public class Venda
    {
        // Propriedades da Venda
        public int Id { get; set; }               // ID da venda
        public int ClienteId { get; set; }        // ID do cliente
        public string? NomeCliente { get; set; }      // Nome do cliente
        public DateTime Data { get; set; }        // Data da venda
        public decimal Total { get; set; }        // Total da venda
        public int IdStatus { get; set; }         // IdStatus da venda
        public string? Status { get; set; }       // Status da venda 1 - 'pendente', 2 - 'concluída'
        public string? Observacao { get; set; }   // Observacao da venda

        // Navegação
        public List<ItemVenda> ItensVenda { get; set; }  // Lista de itens da venda


        // Construtor
        public Venda()
        {
            ItensVenda = new List<ItemVenda>();  // Inicializa a lista de itens de venda
        }

        // Classes internas para representar diferentes tipos de cliente
        public class VendaGrid
        {
            public int Id { get; set; }
            public DateTime Data { get; set; }
            public string? NomeCliente { get; set; }            
            public decimal Total { get; set; }
            public string? Status { get; set; }
        }

        public class VendaEdit
        {
            public int Id { get; set; }               
            public int ClienteId { get; set; }
            public string? NomeCliente { get; set; }
            public DateTime Data { get; set; }       
            public decimal Total { get; set; }        
            public int IdStatus { get; set; }          
            public string? Observacao { get; set; }   
        }
    }
}

