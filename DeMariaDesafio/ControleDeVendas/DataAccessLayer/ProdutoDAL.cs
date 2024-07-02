using ControleDeVendas.Models;
using Npgsql;
using NpgsqlTypes;
using System.Data;
using System.Text;

namespace ControleDeVendas.DataAccessLayer
{
    internal class ProdutoDAL : ConexaoDAL
    {
        #region Metodos Públicos
        //Localiza Produtos
        public List<T> LocalizarProdutos<T>(String pLocalizarProduto, Int32 pPesquisar, string pTipo, Boolean pExibirTodos) where T : class
        {
            List<T> vol_ListaProdutos = new List<T>();
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
                sqlCommand.Append("SELECT id, descricao, quantidade, preco, data_cadastro,");
                sqlCommand.Append("CASE WHEN ativo THEN 'Ativo' ELSE 'Não ativo' END AS status ");
                sqlCommand.Append("FROM Produto ");

                // Condição de pesquisa por ID ou Nome
                if (pPesquisar == 0 && pLocalizarProduto == string.Empty)
                {
                    sqlCommand.Append("ORDER BY id;");
                }
                else if (pPesquisar == 1 && pLocalizarProduto == string.Empty)
                {
                    sqlCommand.Append("ORDER BY descricao;");
                }
                else
                {
                    sqlCommand.Append("WHERE descricao ILIKE '%' || @plocalizarProduto || '%' ");
                    sqlCommand.Append("ORDER BY descricao;");
                }

                // Define o comando SQL
                conexao.Command.CommandText = sqlCommand.ToString();

                // Atribui a conexão ao comando
                conexao.Command.Connection = conexao.Conexao;

                // Adiciona os parâmetros necessários
                conexao.Command.Parameters.AddWithValue("@plocalizarproduto", pLocalizarProduto);

                // Obtém um DataReader da execução da consulta
                using (var dataReader = conexao.Command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        // Aqui você pode implementar a lógica para mapear os dados do DataReader para objetos do tipo T
                        // Exemplo de mapeamento para diferentes tipos de produto baseado no parâmetro pTipo
                        if (typeof(T) == typeof(Produto.ProdutoCons) && pTipo == "Cons")
                        {
                            T vol_Produto = Activator.CreateInstance<T>();
                            ((Produto.ProdutoCons)(object)vol_Produto).Id = Convert.ToInt32(dataReader["id"]);
                            ((Produto.ProdutoCons)(object)vol_Produto).Descricao = Convert.ToString(dataReader["descricao"]);
                            vol_ListaProdutos.Add(vol_Produto);
                        }
                        else if (typeof(T) == typeof(Produto.ProdutoGrid) && pTipo == "Grid")
                        {
                            T vol_Produto = Activator.CreateInstance<T>();
                            ((Produto.ProdutoGrid)(object)vol_Produto).Id = Convert.ToInt32(dataReader["id"]);
                            ((Produto.ProdutoGrid)(object)vol_Produto).Descricao = Convert.ToString(dataReader["descricao"]);
                            ((Produto.ProdutoGrid)(object)vol_Produto).Status = Convert.ToString(dataReader["status"]);
                            vol_ListaProdutos.Add(vol_Produto);
                        }
                        else if (typeof(T) == typeof(Produto.ProdutoEdit) && pTipo == "Edit")
                        {
                            T vol_Produto = Activator.CreateInstance<T>();
                            ((Produto.ProdutoEdit)(object)vol_Produto).Id = Convert.ToInt32(dataReader["id"]);
                            ((Produto.ProdutoEdit)(object)vol_Produto).Descricao = Convert.ToString(dataReader["nome"]);
                            ((Produto.ProdutoEdit)(object)vol_Produto).Quantidade = Convert.ToInt32(dataReader["qantidade"]);
                            ((Produto.ProdutoEdit)(object)vol_Produto).Preco = Convert.ToDecimal(dataReader["telefone"]);
                            ((Produto.ProdutoEdit)(object)vol_Produto).Data = Convert.ToDateTime(dataReader["data_cadastro"]);
                            ((Produto.ProdutoEdit)(object)vol_Produto).Ativo = Convert.ToBoolean(dataReader["ativo"]);
                            ((Produto.ProdutoGrid)(object)vol_Produto).Status = Convert.ToString(dataReader["status"]);
                            vol_ListaProdutos.Add(vol_Produto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Trata a exceção
                MessageBox.Show($"Erro ao buscar dados produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Fecha conexão
                conexao.ConectionClose();
            }
            return vol_ListaProdutos;
        }

        //Seleciona Produtos
        public List<T> SelecionarProdutos<T>(Int32 pIdProduto, string pTipo, Boolean pExibirTodos) where T : class
        {
            List<T> vol_ListaProdutos = new List<T>();
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
                sqlCommand.Append("SELECT id, descricao, quantidade, preco, data_cadastro, ativo, ");
                sqlCommand.Append("CASE WHEN ativo THEN 'Ativo' ELSE 'Não ativo' END AS status ");
                sqlCommand.Append("FROM Produto "); // Alterado para buscar diretamente na tabela Produto
                sqlCommand.Append("WHERE id > 0 ");

                // Condição de exibir apenas produtos ativos
                if (!pExibirTodos)
                    sqlCommand.Append("AND ativo = TRUE ");
                // Condição de exibir apenas o produto
                if (pIdProduto != 0)
                    sqlCommand.Append("AND id = " + pIdProduto);

                // Define o comando SQL
                conexao.Command.CommandText = sqlCommand.ToString();

                // Atribui a conexão ao comando
                conexao.Command.Connection = conexao.Conexao;

                // Adiciona os parâmetros necessários
                //conexao.Command.Parameters.AddWithValue("@pidproduto", pIdProduto);

                // Obtém um DataReader da execução da consulta
                using (var dataReader = conexao.Command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        // Aqui você pode implementar a lógica para mapear os dados do DataReader para objetos do tipo T
                        // Exemplo de mapeamento para diferentes tipos de produto baseado no parâmetro pTipo
                        if (typeof(T) == typeof(Produto.ProdutoCons) && pTipo == "Cons")
                        {
                            T vol_Produto = Activator.CreateInstance<T>();
                            ((Produto.ProdutoCons)(object)vol_Produto).Id = Convert.ToInt32(dataReader["id"]);
                            ((Produto.ProdutoCons)(object)vol_Produto).Descricao = Convert.ToString(dataReader["descricao"]);
                            vol_ListaProdutos.Add(vol_Produto);
                        }
                        else if (typeof(T) == typeof(Produto.ProdutoGrid) && pTipo == "Grid")
                        {
                            T vol_Produto = Activator.CreateInstance<T>();
                            ((Produto.ProdutoGrid)(object)vol_Produto).Id = Convert.ToInt32(dataReader["id"]);
                            ((Produto.ProdutoGrid)(object)vol_Produto).Descricao = Convert.ToString(dataReader["descricao"]);
                            ((Produto.ProdutoGrid)(object)vol_Produto).Status = Convert.ToString(dataReader["status"]);
                            vol_ListaProdutos.Add(vol_Produto);
                        }
                        else if (typeof(T) == typeof(Produto.ProdutoEdit) && pTipo == "Edit")
                        {
                            T vol_Produto = Activator.CreateInstance<T>();
                            ((Produto.ProdutoEdit)(object)vol_Produto).Id = Convert.ToInt32(dataReader["id"]);
                            ((Produto.ProdutoEdit)(object)vol_Produto).Descricao = Convert.ToString(dataReader["descricao"]);
                            ((Produto.ProdutoEdit)(object)vol_Produto).Quantidade = Convert.ToInt32(dataReader["quantidade"]);
                            ((Produto.ProdutoEdit)(object)vol_Produto).Preco = Convert.ToDecimal(dataReader["preco"]);
                            ((Produto.ProdutoEdit)(object)vol_Produto).Data = Convert.ToDateTime(dataReader["data_cadastro"]);
                            ((Produto.ProdutoEdit)(object)vol_Produto).Ativo = Convert.ToBoolean(dataReader["ativo"]);
                            ((Produto.ProdutoEdit)(object)vol_Produto).Status = Convert.ToString(dataReader["status"]);
                            vol_ListaProdutos.Add(vol_Produto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Trata a exceção
                MessageBox.Show($"Erro ao buscar dados produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Fecha conexão
                conexao.ConectionClose();
            }
            return vol_ListaProdutos;
        }

        //Gravar 
        public bool Gravar(Int32 pIdProduto, string pDescricao, string pQuantidade, string pPreco, DateTime pDataCadastro, Boolean pAtivo)
        {
            try
            {
                // Abrir conexão
                ConectionOpen(); // Método personalizado para abrir conexão

                using (NpgsqlCommand cmd = new NpgsqlCommand("public.sp_cdv_i_produto", Conexao)) // Supondo que Conexao seja sua conexão Npgsql já aberta
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Definir parâmetros
                    cmd.Parameters.AddWithValue("p_descricao", NpgsqlDbType.Text, pDescricao);
                    cmd.Parameters.AddWithValue("p_quantidade", NpgsqlDbType.Integer, Convert.ToInt32(pQuantidade));
                    cmd.Parameters.AddWithValue("p_preco", NpgsqlDbType.Numeric, Convert.ToDecimal(pPreco)); // Mudança para Numeric
                    cmd.Parameters.AddWithValue("p_data", NpgsqlDbType.Timestamp, pDataCadastro); // Passando a data diretamente
                    cmd.Parameters.AddWithValue("p_ativo", NpgsqlDbType.Boolean, pAtivo);

                    // Executar a stored procedure
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                // Tratar exceção
                MessageBox.Show($"Erro ao gravar item: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                // Fechar conexão
                ConectionClose(); // Método personalizado para fechar conexão
            }
        }


        //Altera 
        public bool Alterar(Int32 pIdProduto, string pDescricao, string pQuantidade, string pPreco, DateTime pDataCadastro, Boolean pAtivo)
        {
            try
            {
                // Abrir conexão
                ConectionOpen(); // Método personalizado para abrir conexão

                using (NpgsqlCommand cmd = new NpgsqlCommand("public.sp_cdv_u_produto", Conexao)) // Supondo que Conexao seja sua conexão Npgsql já aberta
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Definir parâmetros
                    cmd.Parameters.AddWithValue("p_idproduto", NpgsqlDbType.Integer, pIdProduto);
                    cmd.Parameters.AddWithValue("p_descricao", NpgsqlDbType.Text, pDescricao);
                    cmd.Parameters.AddWithValue("p_quantidade", NpgsqlDbType.Integer, Convert.ToInt32(pQuantidade));
                    cmd.Parameters.AddWithValue("p_preco", NpgsqlDbType.Numeric, Convert.ToDecimal(pPreco)); // Mudança para Numeric
                    cmd.Parameters.AddWithValue("p_data", NpgsqlDbType.Timestamp, pDataCadastro); // Passando a data diretamente
                    cmd.Parameters.AddWithValue("p_ativo", NpgsqlDbType.Boolean, pAtivo);

                    // Executar a stored procedure
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                // Tratar exceção
                MessageBox.Show($"Erro ao alterar item: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                // Fechar conexão
                ConectionClose(); // Método personalizado para fechar conexão
            }
        }


        //Excluir
        public bool Excluir(Int32 pIdProduto)
        {
            try
            {
                // Abrir conexão
                ConectionOpen(); // Método personalizado para abrir conexão

                using (NpgsqlCommand cmd = new NpgsqlCommand("public.sp_cdv_d_produto", Conexao)) // Supondo que Conexao seja sua conexão Npgsql já aberta
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Definir parâmetros
                    cmd.Parameters.AddWithValue("p_idproduto", NpgsqlDbType.Integer, pIdProduto);

                    // Executar a stored procedure
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                // Tratar exceção
                MessageBox.Show($"Erro ao excluir produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                // Fechar conexão
                ConectionClose(); // Método personalizado para fechar conexão
            }
        }
        #endregion

    }
}

