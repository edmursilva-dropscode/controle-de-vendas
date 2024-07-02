using ControleDeVendas.Models;
using Npgsql;
using NpgsqlTypes;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Transactions;

namespace ControleDeVendas.DataAccessLayer
{
    internal class VendaDAL : ConexaoDAL
    {
        #region Metodos Públicos
        //Localiza Vendas
        public List<T> LocalizarVendas<T>(String pLocalizarVenda, Int32 pPesquisar, string pTipo) where T : class
        {
            List<T> vol_ListaVendas = new List<T>();
            ConexaoDAL conexao = new ConexaoDAL(); // Instancia a classe de conexão
            try
            {
                // Abre conexão
                conexao.ConectionOpen();

                // Limpa os parâmetros
                conexao.Command.Parameters.Clear();
                conexao.Command.CommandType = CommandType.Text;

                // Monta o comando SQL baseado nos parâmetros
                StringBuilder sqlCommand = new StringBuilder();
                sqlCommand.Append("SELECT v.id, v.data, c.nome AS nomecliente, v.total, ");
                sqlCommand.Append("CASE WHEN v.id_status = 0 THEN 'Pendente' ELSE 'Concluído' END AS status, ");
                sqlCommand.Append("v.observacao, v.id_status AS idstatus, c.id AS clienteid ");
                sqlCommand.Append("FROM venda v ");
                sqlCommand.Append("JOIN cliente c ON v.id_cliente = c.id ");

                // Condição de pesquisa por ID ou Nome
                if (pPesquisar == 0 && pLocalizarVenda == string.Empty)
                {
                    sqlCommand.Append("ORDER BY id;");
                }
                else if (pPesquisar == 1 && pLocalizarVenda == string.Empty)
                {
                    sqlCommand.Append("ORDER BY nomecliente;");
                }
                else if (pPesquisar == 2 && pLocalizarVenda == string.Empty)
                {
                    sqlCommand.Append("ORDER BY data;");
                }
                else
                {
                    sqlCommand.Append("WHERE nome ILIKE '%' || @plocalizarVenda || '%' ");
                    sqlCommand.Append("ORDER BY nome;");
                }

                // Define o comando SQL
                conexao.Command.CommandText = sqlCommand.ToString();

                // Atribui a conexão ao comando
                conexao.Command.Connection = conexao.Conexao;

                // Adiciona os parâmetros necessários
                conexao.Command.Parameters.AddWithValue("@plocalizarvenda", pLocalizarVenda);

                // Obtém um DataReader da execução da consulta
                using (var dataReader = conexao.Command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        // Aqui você pode implementar a lógica para mapear os dados do DataReader para objetos do tipo T
                        // Exemplo de mapeamento para diferentes tipos de venda baseado no parâmetro pTipo
                        if (typeof(T) == typeof(Venda.VendaGrid) && pTipo == "Grid")
                        {
                            T vol_Venda = Activator.CreateInstance<T>();
                            ((Venda.VendaGrid)(object)vol_Venda).Id = Convert.ToInt32(dataReader["id"]);
                            ((Venda.VendaGrid)(object)vol_Venda).Data = Convert.ToDateTime(dataReader["data"]);
                            ((Venda.VendaGrid)(object)vol_Venda).NomeCliente = Convert.ToString(dataReader["nomecliente"]);                            
                            ((Venda.VendaGrid)(object)vol_Venda).Total = Convert.ToDecimal(dataReader["total"]);
                            ((Venda.VendaGrid)(object)vol_Venda).Status = Convert.ToString(dataReader["status"]);
                            vol_ListaVendas.Add(vol_Venda);
                        }
                        else if (typeof(T) == typeof(Venda.VendaEdit) && pTipo == "Edit")
                        {
                            T vol_Venda = Activator.CreateInstance<T>();
                            ((Venda.VendaEdit)(object)vol_Venda).Id = Convert.ToInt32(dataReader["id"]);
                            ((Venda.VendaEdit)(object)vol_Venda).Data = Convert.ToDateTime(dataReader["data"]);
                            ((Venda.VendaEdit)(object)vol_Venda).NomeCliente = Convert.ToString(dataReader["nomecliente"]);                            
                            ((Venda.VendaEdit)(object)vol_Venda).Total = Convert.ToDecimal(dataReader["total"]);
                            ((Venda.VendaEdit)(object)vol_Venda).ClienteId = Convert.ToInt32(dataReader["clienteid"]);
                            ((Venda.VendaEdit)(object)vol_Venda).IdStatus = Convert.ToInt32(dataReader["idstatus"]);
                            ((Venda.VendaEdit)(object)vol_Venda).Observacao = Convert.ToString(dataReader["observacao"]);
                            vol_ListaVendas.Add(vol_Venda);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Trata a exceção
                MessageBox.Show($"Erro ao buscar dados Venda: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Fecha conexão
                conexao.ConectionClose();
            }
            return vol_ListaVendas;
        }

        //Seleciona Vendas
        public List<T> SelecionarVendas<T>(Int32 pIdVenda, string pTipo) where T : class
        {
            List<T> vol_ListaVendas = new List<T>();
            ConexaoDAL conexao = new ConexaoDAL(); // Instancia a classe de conexão
            try
            {
                // Abre conexão
                conexao.ConectionOpen();

                // Limpa os parâmetros
                conexao.Command.Parameters.Clear();
                conexao.Command.CommandType = CommandType.Text;

                // Monta o comando SQL baseado no parâmetro pExibirTodos
                StringBuilder sqlCommand = new StringBuilder();
                sqlCommand.Append("SELECT v.id, v.data, c.nome AS nomecliente, v.total, ");
                sqlCommand.Append("CASE WHEN v.id_status = 0 THEN 'Pendente' ELSE 'Concluído' END AS status, ");
                sqlCommand.Append("v.observacao, v.id_status AS idstatus, c.id AS clienteid ");
                sqlCommand.Append("FROM venda v ");
                sqlCommand.Append("JOIN cliente c ON v.id_cliente = c.id ");
                sqlCommand.Append("WHERE v.id > 0 ");

                // Condição de exibir apenas o venda
                if (pIdVenda != 0)
                    sqlCommand.Append("AND v.id = " + pIdVenda);

                // Define o comando SQL
                conexao.Command.CommandText = sqlCommand.ToString();

                // Atribui a conexão ao comando
                conexao.Command.Connection = conexao.Conexao;

                // Adiciona os parâmetros necessários
                //conexao.Command.Parameters.AddWithValue("@pidvenda", pIdVenda);

                // Obtém um DataReader da execução da consulta
                using (var dataReader = conexao.Command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        // Aqui você pode implementar a lógica para mapear os dados do DataReader para objetos do tipo T
                        // Exemplo de mapeamento para diferentes tipos de venda baseado no parâmetro pTipo
                        if (typeof(T) == typeof(Venda.VendaGrid) && pTipo == "Grid")
                        {
                            T vol_Venda = Activator.CreateInstance<T>();
                            ((Venda.VendaGrid)(object)vol_Venda).Id = Convert.ToInt32(dataReader["id"]);
                            ((Venda.VendaGrid)(object)vol_Venda).Data = Convert.ToDateTime(dataReader["data"]);
                            ((Venda.VendaGrid)(object)vol_Venda).NomeCliente = Convert.ToString(dataReader["nomecliente"]);
                            ((Venda.VendaGrid)(object)vol_Venda).Total = Convert.ToDecimal(dataReader["total"]);
                            ((Venda.VendaGrid)(object)vol_Venda).Status = Convert.ToString(dataReader["status"]);
                            vol_ListaVendas.Add(vol_Venda);
                        }
                        else if (typeof(T) == typeof(Venda.VendaEdit) && pTipo == "Edit")
                        {
                            T vol_Venda = Activator.CreateInstance<T>();
                            ((Venda.VendaEdit)(object)vol_Venda).Id = Convert.ToInt32(dataReader["id"]);
                            ((Venda.VendaEdit)(object)vol_Venda).Data = Convert.ToDateTime(dataReader["data"]);
                            ((Venda.VendaEdit)(object)vol_Venda).NomeCliente = Convert.ToString(dataReader["nomecliente"]);
                            ((Venda.VendaEdit)(object)vol_Venda).Total = Convert.ToDecimal(dataReader["total"]);
                            ((Venda.VendaEdit)(object)vol_Venda).ClienteId = Convert.ToInt32(dataReader["clienteid"]);
                            ((Venda.VendaEdit)(object)vol_Venda).IdStatus = Convert.ToInt32(dataReader["idstatus"]);
                            ((Venda.VendaEdit)(object)vol_Venda).Observacao = Convert.ToString(dataReader["observacao"]);
                            vol_ListaVendas.Add(vol_Venda);
                        }
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
            return vol_ListaVendas;
        }

        public bool Gravar(out Int32 pIdVenda, DateTime pDtVenda, String pTotalVenda, Int32 pStatus, String pObservacao, Int32 pIdCliente, ListView pItensVenda)
        {
            pIdVenda = 0; // Inicializa a variável pIdVenda
            bool vbl_ExecuteProc = true; // Inicializa variável de controle

            // Abrir conexão
            ConectionOpen(); // Suponho que ConectionOpen seja seu método para abrir a conexão

            // Inicializar a transação
            NpgsqlTransaction? transaction = null;

            try
            {
                // Iniciar a transação
                transaction = Conexao.BeginTransaction();

                using (NpgsqlCommand Command = new NpgsqlCommand("public.sp_cdv_i_venda", Conexao, transaction))
                {
                    Command.CommandType = CommandType.StoredProcedure;

                    // Definir parâmetros da stored procedure
                    Command.Parameters.AddWithValue("p_id_cliente", NpgsqlDbType.Integer, pIdCliente);
                    Command.Parameters.AddWithValue("p_data", NpgsqlDbType.Timestamp, pDtVenda);
                    Command.Parameters.AddWithValue("p_total", NpgsqlDbType.Numeric, Convert.ToDecimal(pTotalVenda));
                    Command.Parameters.AddWithValue("p_id_status", NpgsqlDbType.Integer, pStatus);
                    Command.Parameters.AddWithValue("p_observacao", NpgsqlDbType.Text, pObservacao);

                    // Parâmetro de saída para capturar o ID da venda inserida
                    Command.Parameters.Add(new NpgsqlParameter("p_id_venda", NpgsqlDbType.Integer)).Direction = ParameterDirection.Output;

                    // Executar a stored procedure
                    Command.ExecuteNonQuery();

                    // Capturar o ID da venda inserida
                    pIdVenda = Convert.ToInt32(Command.Parameters["p_id_venda"].Value);

                    if (pIdVenda != 0)
                    {
                        // Executar método para gravar itens de venda
                        foreach (ListViewItem item in pItensVenda.Items)
                        {
                            try
                            {
                                int idProduto = Convert.ToInt32(item.SubItems[1].Text);
                                int Quantidade = Convert.ToInt32(item.SubItems[3].Text);
                                decimal PrecoUnitario = Convert.ToDecimal(item.SubItems[4].Text);
                                decimal PrecoTotal = Convert.ToDecimal(item.SubItems[5].Text);

                                if (!GravarItensVenda(pIdVenda, idProduto, Quantidade, PrecoUnitario, PrecoTotal, transaction))
                                {
                                    // Se houver um erro ao gravar um item, reverta a transação e retorne false
                                    vbl_ExecuteProc = false;
                                    break;
                                }
                            }
                            catch (Exception ex)
                            {
                                // Trate a exceção ou registre-a de alguma forma
                                MessageBox.Show($"Erro ao gravar item: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                vbl_ExecuteProc = false;
                                break;
                            }
                        }
                    }
                    else
                    {
                        // Trate a exceção ou registre-a de alguma forma
                        vbl_ExecuteProc = false;
                    }

                }

                // Se tudo ocorrer bem, commit da transação
                if (vbl_ExecuteProc)
                {
                    transaction.Commit();
                }
                else
                {
                    // Se houver falha, rollback da transação
                    transaction.Rollback();
                }
            }
            catch (Exception ex)
            {
                // Trate a exceção ou registre-a de alguma forma
                MessageBox.Show($"Erro ao gravar venda: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                vbl_ExecuteProc = false;

                // Em caso de exceção, rollback da transação se estiver aberta
                if (transaction != null)
                {
                    transaction.Rollback();
                }
            }
            finally
            {
                // Certifique-se de fechar a conexão no bloco finally
                ConectionClose(); // Suponho que ConectionClose seja seu método para fechar a conexão
            }

            return vbl_ExecuteProc;
        }

        //Altera 
        public bool Alterar(Int32 pIdVenda, DateTime pDtVenda, String pTotalVenda, Int32 pStatus, String pObservacao, Int32 pIdCliente, ListView pItensVenda, ListView pItemVendaExcluir)
        {
            bool vbl_ExecuteProc = true; // Inicializa variável de controle

            // Abrir conexão
            ConectionOpen(); // Suponho que ConectionOpen seja seu método para abrir a conexão

            // Inicializar a transação
            NpgsqlTransaction? transaction = null;

            try
            {
                // Iniciar a transação
                transaction = Conexao.BeginTransaction();

                using (NpgsqlCommand Command = new NpgsqlCommand("public.sp_cdv_u_venda", Conexao, transaction))
                {
                    Command.CommandType = CommandType.StoredProcedure;

                    // Definir parâmetros da stored procedure
                    Command.Parameters.AddWithValue("p_id_venda", NpgsqlDbType.Integer, pIdVenda);
                    Command.Parameters.AddWithValue("p_id_cliente", NpgsqlDbType.Integer, pIdCliente);
                    Command.Parameters.AddWithValue("p_data", NpgsqlDbType.Timestamp, pDtVenda);
                    Command.Parameters.AddWithValue("p_total", NpgsqlDbType.Numeric, Convert.ToDecimal(pTotalVenda));
                    Command.Parameters.AddWithValue("p_id_status", NpgsqlDbType.Integer, pStatus);
                    Command.Parameters.AddWithValue("p_observacao", NpgsqlDbType.Text, pObservacao);

                    // Executar a stored procedure
                    Command.ExecuteNonQuery();

                    if (pIdVenda != 0)
                    {
                        //Executa método excluir itens do Venda
                        foreach (ListViewItem item in pItemVendaExcluir.Items)
                        {
                            try
                            {
                                int idItemVenda = Convert.ToInt32(item.SubItems[1].Text);

                                if (!ExcluirItensVenda(idItemVenda, transaction))
                                {
                                    // Se houver um erro ao excluir um item, reverta a transação e retorne false
                                    vbl_ExecuteProc = false;
                                    break;
                                }
                            }
                            catch (Exception ex)
                            {
                                // Trate a exceção ou registre-a de alguma forma
                                MessageBox.Show($"Erro ao excluir item: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                vbl_ExecuteProc = false;
                                break;
                            }
                        }

                        // Executar método para gravar itens de venda
                        if (vbl_ExecuteProc)
                        {
                            foreach (ListViewItem item in pItensVenda.Items)
                            {
                                try
                                {
                                    int idProduto = Convert.ToInt32(item.SubItems[1].Text);
                                    int Quantidade = Convert.ToInt32(item.SubItems[3].Text);
                                    decimal PrecoUnitario = Convert.ToDecimal(item.SubItems[4].Text);
                                    decimal PrecoTotal = Convert.ToDecimal(item.SubItems[5].Text);
                                    int idItemVenda = Convert.ToInt32(item.SubItems[7].Text);

                                    if (idItemVenda != 0)
                                    {
                                        if (!AlterarItensVenda(idItemVenda, pIdVenda, idProduto, Quantidade, PrecoUnitario, PrecoTotal, transaction))
                                        {
                                            // Se houver um erro ao gravar um item, reverta a transação e retorne false
                                            vbl_ExecuteProc = false;
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        if (!GravarItensVenda(pIdVenda, idProduto, Quantidade, PrecoUnitario, PrecoTotal, transaction))
                                        {
                                            // Se houver um erro ao gravar um item, reverta a transação e retorne false
                                            vbl_ExecuteProc = false;
                                            break;
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    // Trate a exceção ou registre-a de alguma forma
                                    MessageBox.Show($"Erro ao gravar item: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    vbl_ExecuteProc = false;
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        // Trate a exceção ou registre-a de alguma forma
                        vbl_ExecuteProc = false;
                    }

                }

                // Se tudo ocorrer bem, commit da transação
                if (vbl_ExecuteProc)
                {
                    transaction.Commit();
                }
                else
                {
                    // Se houver falha, rollback da transação
                    transaction.Rollback();
                }
            }
            catch (Exception ex)
            {
                // Trate a exceção ou registre-a de alguma forma
                MessageBox.Show($"Erro ao gravar venda: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                vbl_ExecuteProc = false;

                // Em caso de exceção, rollback da transação se estiver aberta
                if (transaction != null)
                {
                    transaction.Rollback();
                }
            }
            finally
            {
                // Certifique-se de fechar a conexão no bloco finally
                ConectionClose(); // Suponho que ConectionClose seja seu método para fechar a conexão
            }

            return vbl_ExecuteProc;

        }

        //Gravar 
        public bool GravarItensVenda(Int32 pIdVenda, Int32 pIdProduto, Int32 pQtde, decimal pValorUnitario, decimal pPrecoTotal, NpgsqlTransaction transaction)
        {
            bool sucesso = true;

            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand("public.sp_cdv_i_itemvenda", Conexao, transaction))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("p_id_venda", pIdVenda);
                    command.Parameters.AddWithValue("p_id_produto", pIdProduto);
                    command.Parameters.AddWithValue("p_quantidade", pQtde);
                    command.Parameters.AddWithValue("p_preco_unitario", pValorUnitario);
                    command.Parameters.AddWithValue("p_preco_total", pPrecoTotal);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar item de venda: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sucesso = false;
            }
            return sucesso;
        }

        //Excluir
        public bool Excluir(Int32 pIdVenda)
        {

            // Abrir conexão
            ConectionOpen(); // Suponho que ConectionOpen seja seu método para abrir a conexão

            try
            {
                using (NpgsqlCommand Command = new NpgsqlCommand("sp_cdv_d_venda", Conexao))
                {
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@p_id_venda", NpgsqlDbType.Integer, pIdVenda);

                    Command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir venda: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                // Certifique-se de fechar a conexão no bloco finally
                ConectionClose(); // Suponho que ConectionClose seja seu método para fechar a conexão
            }
        }

        //Alterar
        public bool AlterarItensVenda(Int32 pIdItemVenda, Int32 pIdVenda, Int32 pIdProduto, Int32 pQtde, decimal pValorUnitario, decimal pPrecoTotal, NpgsqlTransaction transaction)
        {
            try
            {
                using (NpgsqlCommand Command = new NpgsqlCommand("sp_cdv_u_itemvenda", Conexao, transaction))
                {
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@p_id_item_venda", NpgsqlDbType.Integer, pIdItemVenda);
                    Command.Parameters.AddWithValue("@p_id_venda", NpgsqlDbType.Integer, pIdVenda);
                    Command.Parameters.AddWithValue("@p_id_produto", NpgsqlDbType.Integer, pIdProduto);
                    Command.Parameters.AddWithValue("@p_quantidade", NpgsqlDbType.Integer, pQtde);
                    Command.Parameters.AddWithValue("@p_preco_unitario", NpgsqlDbType.Numeric, pValorUnitario);
                    Command.Parameters.AddWithValue("@p_preco_total", NpgsqlDbType.Numeric, pPrecoTotal);

                    Command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao alterar item de venda: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //Excluir
        public bool ExcluirItensVenda(Int32 pIdItensVenda, NpgsqlTransaction transaction)
        {
            try
            {
                using (NpgsqlCommand Command = new NpgsqlCommand("sp_cdv_d_itemvenda", Conexao, transaction))
                {
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@p_id_item_venda", NpgsqlDbType.Integer, pIdItensVenda);

                    Command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir item de venda: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //Totalizar
        public Int32 Totalizar(string pTipo)
        {
            Int32 total = 0;

            // Abrir conexão
            ConectionOpen(); // Suponho que ConectionOpen seja seu método para abrir a conexão

            try
            {
                using (NpgsqlCommand Command = new NpgsqlCommand())
                {
                    Command.Connection = Conexao;
                    Command.CommandType = CommandType.Text;

                    // Monta o comando SQL baseado nos parâmetros
                    StringBuilder sqlCommand = new StringBuilder();

                    // Consulta para contar clientes, produtos e vendas
                    sqlCommand.Append("SELECT ");
                    sqlCommand.Append("(SELECT COUNT(*) FROM cliente) AS total_clientes, ");
                    sqlCommand.Append("(SELECT COUNT(*) FROM produto) AS total_produtos, ");
                    sqlCommand.Append("(SELECT COUNT(*) FROM venda) AS total_vendas ");

                    // Define o comando SQL
                    Command.CommandText = sqlCommand.ToString();

                    using (NpgsqlDataReader reader = Command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Obtém os totais de clientes, produtos e vendas
                            Int32 totalClientes = Convert.ToInt32(reader["total_clientes"]);
                            Int32 totalProdutos = Convert.ToInt32(reader["total_produtos"]);
                            Int32 totalVendas = Convert.ToInt32(reader["total_vendas"]);

                            // Decide o total baseado no tipo
                            switch (pTipo)
                            {
                                case "C": // Total de clientes
                                    total = totalClientes;
                                    break;
                                case "P": // Total de produtos
                                    total = totalProdutos;
                                    break;
                                case "V": // Total de vendas
                                    total = totalVendas;
                                    break;
                                default:
                                    // Caso de tipo inválido
                                    throw new ArgumentException("Tipo inválido. Use 1 para clientes, 2 para produtos ou 3 para vendas.");
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                // Trata a exceção
                MessageBox.Show($"Erro ao totalizar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                total = 0;
            }
            finally
            {
                // Fecha a conexão no bloco finally
                ConectionClose(); // Suponho que ConectionClose seja seu método para fechar a conexão
            }

            return total;
        }


        #endregion
    }
}

