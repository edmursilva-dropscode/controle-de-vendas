using ControleDeVendas.Models;
using System.Data;
using System.Text;

namespace ControleDeVendas.DataAccessLayer
{
    internal class ItemVendaDAL : ConexaoDAL
    {
 
        //Seleciona ItemVenda
        public List<ItemVenda> SelecionarItemVenda(int pIdItemVenda)
        {

            ConexaoDAL conexao = new ConexaoDAL(); // Instancia a classe de conexão
            List<ItemVenda> vol_ListaItensVenda = new List<ItemVenda>();
            try
            {
                // Abre conexão
                conexao.ConectionOpen();

                // Limpa os parâmetros
                conexao.Command.Parameters.Clear();
                conexao.Command.CommandType = CommandType.Text;

                // Monta o comando SQL baseado no parâmetro pExibirTodos
                StringBuilder sqlCommand = new StringBuilder();
                sqlCommand.Append("SELECT iv.id AS item_venda_id, iv.id_venda, iv.id_produto, ");
                sqlCommand.Append("iv.quantidade, iv.preco_unitario, iv.preco_total, ");
                sqlCommand.Append("v.observacao, v.id_status AS idstatus, c.id AS clienteid, ");
                sqlCommand.Append("c.nome AS nome_cliente, p.descricao AS descricao_produto ");
                sqlCommand.Append("FROM public.item_venda iv ");
                sqlCommand.Append("JOIN public.venda v ON iv.id_venda = v.id ");
                sqlCommand.Append("JOIN public.cliente c ON v.id_cliente = c.id ");
                sqlCommand.Append("JOIN public.produto p ON iv.id_produto = p.id ");

                // Condição de exibir apenas o venda
                if (pIdItemVenda != 0)
                    sqlCommand.Append("AND id = " + pIdItemVenda);

                // Define o comando SQL
                conexao.Command.CommandText = sqlCommand.ToString();

                // Atribui a conexão ao comando
                conexao.Command.Connection = conexao.Conexao;

                // Obtém um DataReader da execução da consulta
                using (var dataReader = conexao.Command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        ItemVenda vol_ItemVenda = new ItemVenda
                        {
                            Id = Convert.ToInt32(dataReader["item_venda_id"]),
                            VendaId = Convert.ToInt32(dataReader["id_venda"]),
                            ProdutoId = Convert.ToInt32(dataReader["id_produto"]),
                            Quantidade = Convert.ToInt32(dataReader["quantidade"]),
                            PrecoUnitario = Convert.ToDecimal(dataReader["preco_unitario"]),
                            PrecoTotal = Convert.ToDecimal(dataReader["preco_total"])
                        };
                        //Adiciona item a lista
                        vol_ListaItensVenda.Add(vol_ItemVenda);
                    }
                }
            }
            catch (Exception ex)
            {
                // Trata a exceção
                MessageBox.Show($"Erro ao buscar dados venda: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Fecha conexão
                conexao.ConectionClose();
            }
            return vol_ListaItensVenda;
        }

        public List<ItemVenda> SelecionarItensVenda(int pIdVenda)
        {

            ConexaoDAL conexao = new ConexaoDAL(); // Instancia a classe de conexão
            List<ItemVenda> vol_ListaItensVenda = new List<ItemVenda>();
            try
            {
                // Abre conexão
                conexao.ConectionOpen();

                // Limpa os parâmetros
                conexao.Command.Parameters.Clear();
                conexao.Command.CommandType = CommandType.Text;

                // Monta o comando SQL baseado no parâmetro pExibirTodos
                StringBuilder sqlCommand = new StringBuilder();
                sqlCommand.Append("SELECT iv.id AS item_venda_id, iv.id_venda, iv.id_produto, ");
                sqlCommand.Append("iv.quantidade, iv.preco_unitario, iv.preco_total, ");
                sqlCommand.Append("v.observacao, v.id_status AS idstatus, c.id AS clienteid, ");
                sqlCommand.Append("c.nome AS nomecliente, p.descricao AS descricaoproduto ");
                sqlCommand.Append("FROM public.item_venda iv ");
                sqlCommand.Append("JOIN public.venda v ON iv.id_venda = v.id ");
                sqlCommand.Append("JOIN public.cliente c ON v.id_cliente = c.id ");
                sqlCommand.Append("JOIN public.produto p ON iv.id_produto = p.id ");

                // Condição de exibir apenas o venda
                if (pIdVenda != 0)
                    sqlCommand.Append("AND iv.id_venda = " + pIdVenda);

                // Define o comando SQL
                conexao.Command.CommandText = sqlCommand.ToString();

                // Atribui a conexão ao comando
                conexao.Command.Connection = conexao.Conexao;

                // Obtém um DataReader da execução da consulta
                using (var dataReader = conexao.Command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        ItemVenda vol_ItemVenda = new ItemVenda
                        {
                            Id = Convert.ToInt32(dataReader["item_venda_id"]),
                            VendaId = Convert.ToInt32(dataReader["id_venda"]),
                            ProdutoId = Convert.ToInt32(dataReader["id_produto"]),
                            Quantidade = Convert.ToInt32(dataReader["quantidade"]),
                            PrecoUnitario = Convert.ToDecimal(dataReader["preco_unitario"]),
                            PrecoTotal = Convert.ToDecimal(dataReader["preco_total"])
                        };
                        //Adiciona item a lista
                        vol_ListaItensVenda.Add(vol_ItemVenda);
                    }
                }
            }
            catch (Exception ex)
            {
                // Trata a exceção
                MessageBox.Show($"Erro ao buscar dados venda: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Fecha conexão
                conexao.ConectionClose();
            }
            return vol_ListaItensVenda;
        }


    }
}
