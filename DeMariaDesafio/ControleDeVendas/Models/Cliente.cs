namespace ControleDeVendas.Models
{
    // Classe que representa um cliente disponível para venda
    public class Cliente
    {
        // Propriedades do Cliente
        public int Id { get; set; }                // ID do cliente
        public string? Nome { get; set; }          // Nome do cliente
        public string? Endereco { get; set; }      // Endereço do cliente
        public string? Telefone { get; set; }      // Número de telefone do cliente
        public string? Email { get; set; }         // Endereço de email do cliente
        public DateTime? Data { get; set; }        // Data de cadastro do cliente
        public bool? Ativo { get; set; }           // Se está ativo o cliente
        public string? Status { get; set; }        // Status do cliente - "Ativo" ou "Não ativo"

        // Navegação
        public List<Venda> Vendas { get; set; }    // Lista de vendas associadas ao cliente

        // Construtor
        public Cliente()
        {
            Vendas = new List<Venda>();            // Inicializa a lista de vendas
        }

        // Classes internas para representar diferentes tipos de cliente
        public class ClienteCons
        {
            public int Id { get; set; }
            public string? Nome { get; set; }
        }

        public class ClienteGrid
        {
            public int Id { get; set; }
            public string? Nome { get; set; }
            public string? Status { get; set; }
        }

        public class ClienteEdit
        {
            public int Id { get; set; }
            public string? Nome { get; set; }
            public string? Endereco { get; set; }
            public string? Telefone { get; set; }
            public string? Email { get; set; }
            public DateTime? Data { get; set; }
            public bool? Ativo { get; set; }
            public string? Status { get; set; }
        }
    }
}
