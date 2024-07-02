using ControleDeVendas.Models;
using Npgsql;
using NpgsqlTypes;
using System.Data;
using System.Text;

namespace ControleDeVendas.DataAccessLayer
{
    internal class ClienteDAL : ConexaoDAL
    {
        #region Metodos Públicos
        //Localiza Clientes
        public List<T> LocalizarClientes<T>(String pLocalizarCliente, Int32 pPesquisar, string pTipo, Boolean pExibirTodos) where T : class
        {
            List<T> vol_ListaClientes = new List<T>();
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
                sqlCommand.Append("SELECT id, nome, endereco, telefone, email, data_cadastro,");
                sqlCommand.Append("CASE WHEN ativo THEN 'Ativo' ELSE 'Não ativo' END AS status ");
                sqlCommand.Append("FROM Cliente ");

                // Condição de pesquisa por ID ou Nome
                if (pPesquisar == 0 && pLocalizarCliente == string.Empty)
                {
                    sqlCommand.Append("ORDER BY id;");
                }
                else if(pPesquisar == 1 && pLocalizarCliente == string.Empty)
                {
                    sqlCommand.Append("ORDER BY nome;");
                }
                else
                {
                    sqlCommand.Append("WHERE nome ILIKE '%' || @plocalizarcliente || '%' ");
                    sqlCommand.Append("ORDER BY nome;");
                }

                // Define o comando SQL
                conexao.Command.CommandText = sqlCommand.ToString();

                // Atribui a conexão ao comando
                conexao.Command.Connection = conexao.Conexao;

                // Adiciona os parâmetros necessários
                conexao.Command.Parameters.AddWithValue("@plocalizarcliente", pLocalizarCliente);

                // Obtém um DataReader da execução da consulta
                using (var dataReader = conexao.Command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        // Aqui você pode implementar a lógica para mapear os dados do DataReader para objetos do tipo T
                        // Exemplo de mapeamento para diferentes tipos de cliente baseado no parâmetro pTipo
                        if (typeof(T) == typeof(Cliente.ClienteCons) && pTipo == "Cons")
                        {
                            T vol_Cliente = Activator.CreateInstance<T>();
                            ((Cliente.ClienteCons)(object)vol_Cliente).Id = Convert.ToInt32(dataReader["id"]);
                            ((Cliente.ClienteCons)(object)vol_Cliente).Nome = Convert.ToString(dataReader["nome"]);
                            vol_ListaClientes.Add(vol_Cliente);
                        }
                        else if (typeof(T) == typeof(Cliente.ClienteGrid) && pTipo == "Grid")
                        {
                            T vol_Cliente = Activator.CreateInstance<T>();
                            ((Cliente.ClienteGrid)(object)vol_Cliente).Id = Convert.ToInt32(dataReader["id"]);
                            ((Cliente.ClienteGrid)(object)vol_Cliente).Nome = Convert.ToString(dataReader["nome"]);
                            ((Cliente.ClienteGrid)(object)vol_Cliente).Status = Convert.ToString(dataReader["status"]);
                            vol_ListaClientes.Add(vol_Cliente);
                        }
                        else if (typeof(T) == typeof(Cliente.ClienteEdit) && pTipo == "Edit")
                        {
                            T vol_Cliente = Activator.CreateInstance<T>();
                            ((Cliente.ClienteEdit)(object)vol_Cliente).Id = Convert.ToInt32(dataReader["id"]);
                            ((Cliente.ClienteEdit)(object)vol_Cliente).Nome = Convert.ToString(dataReader["nome"]);
                            ((Cliente.ClienteEdit)(object)vol_Cliente).Endereco = Convert.ToString(dataReader["endereco"]);
                            ((Cliente.ClienteEdit)(object)vol_Cliente).Telefone = Convert.ToString(dataReader["telefone"]);
                            ((Cliente.ClienteEdit)(object)vol_Cliente).Email = Convert.ToString(dataReader["email"]);
                            ((Cliente.ClienteEdit)(object)vol_Cliente).Data = Convert.ToDateTime(dataReader["data_cadastro"]);
                            ((Cliente.ClienteEdit)(object)vol_Cliente).Ativo = Convert.ToBoolean(dataReader["ativo"]);
                            ((Cliente.ClienteGrid)(object)vol_Cliente).Status = Convert.ToString(dataReader["status"]);
                            vol_ListaClientes.Add(vol_Cliente);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Trata a exceção
                MessageBox.Show($"Erro ao buscar dados cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Fecha conexão
                conexao.ConectionClose();
            }
            return vol_ListaClientes;
        }

        //Seleciona Clientes
        public List<T> SelecionarClientes<T>(Int32 pIdCliente, string pTipo, Boolean pExibirTodos) where T : class
        {
            List<T> vol_ListaClientes = new List<T>();
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
                sqlCommand.Append("SELECT id, nome, endereco, telefone, email, data_cadastro, ativo, ");
                sqlCommand.Append("CASE WHEN ativo THEN 'Ativo' ELSE 'Não ativo' END AS status ");
                sqlCommand.Append("FROM Cliente "); // Alterado para buscar diretamente na tabela cliente
                sqlCommand.Append("WHERE id > 0 ");

                // Condição de exibir apenas clientes ativos
                if (!pExibirTodos)
                    sqlCommand.Append("AND ativo = TRUE ");
                // Condição de exibir apenas o cliente
                if (pIdCliente != 0)
                    sqlCommand.Append("AND id = " + pIdCliente);

                // Define o comando SQL
                conexao.Command.CommandText = sqlCommand.ToString();

                // Atribui a conexão ao comando
                conexao.Command.Connection = conexao.Conexao;

                // Adiciona os parâmetros necessários
                //conexao.Command.Parameters.AddWithValue("@pidcliente", pIdCliente);

                // Obtém um DataReader da execução da consulta
                using (var dataReader = conexao.Command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        // Aqui você pode implementar a lógica para mapear os dados do DataReader para objetos do tipo T
                        // Exemplo de mapeamento para diferentes tipos de cliente baseado no parâmetro pTipo
                        if (typeof(T) == typeof(Cliente.ClienteCons) && pTipo == "Cons")
                        {
                            T vol_Cliente = Activator.CreateInstance<T>();
                            ((Cliente.ClienteCons)(object)vol_Cliente).Id = Convert.ToInt32(dataReader["id"]);
                            ((Cliente.ClienteCons)(object)vol_Cliente).Nome = Convert.ToString(dataReader["nome"]);
                            vol_ListaClientes.Add(vol_Cliente);
                        }
                        else if (typeof(T) == typeof(Cliente.ClienteGrid) && pTipo == "Grid")
                        {
                            T vol_Cliente = Activator.CreateInstance<T>();
                            ((Cliente.ClienteGrid)(object)vol_Cliente).Id = Convert.ToInt32(dataReader["id"]);
                            ((Cliente.ClienteGrid)(object)vol_Cliente).Nome = Convert.ToString(dataReader["nome"]);
                            ((Cliente.ClienteGrid)(object)vol_Cliente).Status = Convert.ToString(dataReader["status"]);
                            vol_ListaClientes.Add(vol_Cliente);
                        }
                        else if (typeof(T) == typeof(Cliente.ClienteEdit) && pTipo == "Edit")
                        {
                            T vol_Cliente = Activator.CreateInstance<T>();
                            ((Cliente.ClienteEdit)(object)vol_Cliente).Id = Convert.ToInt32(dataReader["id"]);
                            ((Cliente.ClienteEdit)(object)vol_Cliente).Nome = Convert.ToString(dataReader["nome"]);
                            ((Cliente.ClienteEdit)(object)vol_Cliente).Endereco = Convert.ToString(dataReader["endereco"]);
                            ((Cliente.ClienteEdit)(object)vol_Cliente).Telefone = Convert.ToString(dataReader["telefone"]);
                            ((Cliente.ClienteEdit)(object)vol_Cliente).Email = Convert.ToString(dataReader["email"]);
                            ((Cliente.ClienteEdit)(object)vol_Cliente).Data = Convert.ToDateTime(dataReader["data_cadastro"]);
                            ((Cliente.ClienteEdit)(object)vol_Cliente).Ativo = Convert.ToBoolean(dataReader["ativo"]);
                            ((Cliente.ClienteEdit)(object)vol_Cliente).Status = Convert.ToString(dataReader["status"]);
                            vol_ListaClientes.Add(vol_Cliente);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Trata a exceção
                MessageBox.Show($"Erro ao buscar dados cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Fecha conexão
                conexao.ConectionClose();
            }
            return vol_ListaClientes;
        }

        //Gravar 
        public bool Gravar(Int32 pIdCliente, string pNome, string pEndereco, string pTelefone, DateTime pDataCadastro, string pEmail, bool pAtivo)
        {
            try
            {
                // Abrir conexão
                ConectionOpen(); // Método personalizado para abrir conexão

                using (NpgsqlCommand cmd = new NpgsqlCommand("public.sp_cdv_i_cliente", Conexao)) // Supondo que Conexao seja sua conexão Npgsql já aberta
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Definir parâmetros
                    cmd.Parameters.AddWithValue("p_nome", NpgsqlDbType.Text, pNome);
                    cmd.Parameters.AddWithValue("p_endereco", NpgsqlDbType.Text, pEndereco);
                    cmd.Parameters.AddWithValue("p_telefone", NpgsqlDbType.Text, pTelefone);
                    cmd.Parameters.AddWithValue("p_email", NpgsqlDbType.Text, pEmail);
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
        // Altera um cliente
        public bool Alterar(Int32 pIdCliente, string pNome, string pEndereco, string pTelefone, DateTime pDataCadastro, string pEmail, bool pAtivo)
        {
            try
            {
                // Abrir conexão
                ConectionOpen(); // Método personalizado para abrir conexão

                using (NpgsqlCommand cmd = new NpgsqlCommand("public.sp_cdv_u_cliente", Conexao)) // Supondo que Conexao seja sua conexão Npgsql já aberta
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Definir parâmetros da stored procedure
                    cmd.Parameters.AddWithValue("p_idcliente", NpgsqlDbType.Integer, pIdCliente);
                    cmd.Parameters.AddWithValue("p_nome", NpgsqlDbType.Text, pNome);
                    cmd.Parameters.AddWithValue("p_endereco", NpgsqlDbType.Text, pEndereco);
                    cmd.Parameters.AddWithValue("p_telefone", NpgsqlDbType.Text, pTelefone);
                    cmd.Parameters.AddWithValue("p_datacadastro", NpgsqlDbType.Timestamp, pDataCadastro);
                    cmd.Parameters.AddWithValue("p_email", NpgsqlDbType.Text, pEmail);
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
        public bool Excluir(Int32 pIdCliente)
        {
            try
            {
                // Abrir conexão
                ConectionOpen(); // Método personalizado para abrir conexão

                using (NpgsqlCommand cmd = new NpgsqlCommand("public.sp_cdv_d_cliente", Conexao)) // Supondo que Conexao seja sua conexão Npgsql já aberta
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Definir parâmetros
                    cmd.Parameters.AddWithValue("p_idcliente", NpgsqlDbType.Integer, pIdCliente);

                    // Executar a stored procedure
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                // Tratar exceção
                MessageBox.Show($"Erro ao excluir cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

