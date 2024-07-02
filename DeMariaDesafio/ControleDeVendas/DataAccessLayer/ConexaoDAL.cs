using System.Data;
using System.Text;
using Npgsql;

namespace ControleDeVendas.DataAccessLayer
{
    internal class ConexaoDAL
    {
        #region Variáveis
        // Variáveis públicas para configuração da conexão PostgreSQL
        public String vsl_ServerName = "localhost";
        public String vsl_UserID = "postgres";
        public String vsl_Password = "admin";
        public String vsl_Database = "DeMariaDesafio";

        // Variáveis dos objetos do ADO.NET
        public NpgsqlCommand vol_Command = new NpgsqlCommand();           // Objeto Command para executar comandos SQL
        public NpgsqlConnection vol_Conexao = new NpgsqlConnection();     // Objeto Connection para a conexão com o banco de dados
        #endregion

        #region Conexao
        // Método para abrir a conexão com o banco de dados PostgreSQL
        public bool ConectionOpen()
        {
            try
            {
                // Verifica se a conexão está fechada
                if (vol_Conexao.State == ConnectionState.Closed)
                {
                    // String de conexão com o banco de dados PostgreSQL
                    String vsl_Conexao = String.Format("Server={0}; User Id={1}; Password={2}; Database={3};", vsl_ServerName, vsl_UserID, vsl_Password, vsl_Database);
                    vol_Conexao = new NpgsqlConnection(vsl_Conexao);
                    // Abre a conexão com o banco de dados
                    vol_Conexao.Open();
                }
                return true;
            }
            catch (NpgsqlException Error)
            {
                // Limpa o conteúdo da StringBuilder
                SqlCommand.Remove(0, SqlCommand.Length);
                // Exibe mensagem de erro
                MessageBox.Show("Erro: " + Error.Message, "Controle de Vendas - DeMaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Método para fechar a conexão com o banco de dados PostgreSQL
        public bool ConectionClose()
        {
            try
            {
                // Verifica se a conexão está aberta
                if (vol_Conexao.State == ConnectionState.Open)
                {
                    // Fecha a conexão com o banco de dados
                    vol_Conexao.Close();
                    vol_Conexao.Dispose();
                }
                return true;
            }
            catch (Exception Error)
            {
                // Limpa o conteúdo da StringBuilder
                SqlCommand.Remove(0, SqlCommand.Length);
                // Exibe mensagem de erro
                MessageBox.Show("Erro: " + Error.Message, "Controle de Vendas - DeMaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        #region Propriedades
        // Variável para armazenar comandos SQL em formato de string
        private StringBuilder vcl_SqlCommand = new StringBuilder();

        // Propriedade para acessar e definir comandos SQL
        public StringBuilder SqlCommand
        {
            get { return vcl_SqlCommand; }
            set { vcl_SqlCommand = value; }
        }

        // Propriedade para acessar a conexão com o banco de dados
        public NpgsqlConnection Conexao
        {
            get { return vol_Conexao; }
        }

        // Propriedade para acessar o objeto Command
        public NpgsqlCommand Command
        {
            get { return vol_Command; }
        }
        #endregion

        #region Métodos Públicos
        // Método para executar comandos SQL no banco de dados PostgreSQL
        public bool Execute()
        {
            try
            {
                // Associa a conexão ao Command
                vol_Command.Connection = Conexao;
                // Define o comando SQL que será executado
                vol_Command.CommandText = SqlCommand.ToString();
                // Define o tipo do comando como texto SQL
                vol_Command.CommandType = CommandType.Text;
                // Executa o comando
                vol_Command.ExecuteNonQuery();
                // Limpa o conteúdo da StringBuilder
                SqlCommand.Remove(0, SqlCommand.Length);
                return true;
            }
            catch (Exception Error)
            {
                // Limpa o conteúdo da StringBuilder
                SqlCommand.Remove(0, SqlCommand.Length);
                // Exibe mensagem de erro
                MessageBox.Show("Erro: " + Error.Message, "Controle de Vendas - DeMaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Método para executar procedures no banco de dados PostgreSQL usando o objeto NpgsqlCommand
        public bool ExecuteProcUsing()
        {
            try
            {
                // Associa a conexão ao Command dentro do escopo usando
                using (vol_Command.Connection = Conexao)
                {
                    // Define o comando SQL que será executado
                    vol_Command.CommandText = SqlCommand.ToString();
                    // Define o tipo do comando como procedure
                    vol_Command.CommandType = CommandType.StoredProcedure;
                    // Executa o comando
                    vol_Command.ExecuteNonQuery();
                    // Limpa o conteúdo da StringBuilder
                    SqlCommand.Remove(0, SqlCommand.Length);
                    return true;
                }
            }
            catch (Exception Error)
            {
                // Exibe mensagem de erro
                MessageBox.Show("Erro: " + Error.Message, "Controle de Vendas - DeMaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SqlCommand.Remove(0, SqlCommand.Length);
                return false;
            }
        }

        // Método para executar procedures no banco de dados PostgreSQL
        public bool ExecuteProc()
        {
            try
            {
                // Associa a conexão ao Command
                vol_Command.Connection = Conexao;

                // Define o comando SQL que será executado
                vol_Command.CommandText = SqlCommand.ToString();
                // Define o tipo do comando como procedure
                vol_Command.CommandType = CommandType.StoredProcedure;
                // Executa o comando
                vol_Command.ExecuteNonQuery();
                // Limpa o conteúdo da StringBuilder
                SqlCommand.Remove(0, SqlCommand.Length);
                return true;
            }
            catch (Exception Error)
            {
                // Limpa o conteúdo da StringBuilder
                SqlCommand.Remove(0, SqlCommand.Length);
                // Exibe mensagem de erro
                MessageBox.Show("Erro: " + Error.Message, "Controle de Vendas - DeMaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Método que retorna um objeto NpgsqlDataReader ao executar comandos SQL
        public NpgsqlDataReader GetDataReader()
        {
            try
            {
                // Define o comando SQL que será executado
                vol_Command.CommandText = SqlCommand.ToString();
                // Define o tipo do comando como texto SQL
                vol_Command.CommandType = CommandType.Text;
                // Associa a conexão ao Command
                vol_Command.Connection = Conexao;
                // Limpa o conteúdo da StringBuilder
                SqlCommand.Remove(0, SqlCommand.Length);
            }
            catch (Exception Error)
            {
                // Exibe mensagem de erro
                MessageBox.Show("Erro: " + Error.Message, "Controle de Vendas - DeMaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Limpa o conteúdo da StringBuilder
                SqlCommand.Remove(0, SqlCommand.Length);
            }
            // Retorna o DataReader
            return vol_Command.ExecuteReader();
        }
        // Método que retorna um objeto NpgsqlDataReader ao executar uma consulta SQL
        public NpgsqlDataReader GetDataReader(string query)
        {
            try
            {
                // Define o comando SQL que será executado
                vol_Command.CommandText = query;
                // Define o tipo do comando como texto SQL
                vol_Command.CommandType = CommandType.Text;
                // Associa a conexão ao Command
                vol_Command.Connection = vol_Conexao;
                // Limpa o conteúdo da StringBuilder
                SqlCommand.Remove(0, SqlCommand.Length);
            }
            catch (Exception Error)
            {
                // Exibe mensagem de erro
                MessageBox.Show("Erro: " + Error.Message, "Controle de Vendas - DeMaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Limpa o conteúdo da StringBuilder
                SqlCommand.Remove(0, SqlCommand.Length);
            }
            // Retorna o DataReader
            return vol_Command.ExecuteReader();
        }


        // Método que retorna um objeto NpgsqlDataReader ao executar uma procedure
        public NpgsqlDataReader GetDataReaderProc()
        {
            try
            {
                // Associa a conexão ao Command
                vol_Command.Connection = Conexao;
                // Define o comando SQL que será executado
                vol_Command.CommandText = SqlCommand.ToString();
                // Define o tipo do comando como procedure
                vol_Command.CommandType = CommandType.StoredProcedure;
                // Limpa o conteúdo da StringBuilder
                SqlCommand.Remove(0, SqlCommand.Length);
            }
            catch (Exception Error)
            {
                // Exibe mensagem de erro
                MessageBox.Show("Erro: " + Error.Message, "Controle de Vendas - DeMaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Limpa o conteúdo da StringBuilder
                SqlCommand.Remove(0, SqlCommand.Length);
            }
            // Retorna o DataReader
            return vol_Command.ExecuteReader();
        }

        // Método que retorna um objeto DataSet ao executar comandos SQL
        public DataSet GetDataSet()
        {
            // Cria um DataSet
            DataSet vol_DataSet = new DataSet();
            try
            {
                // Define o comando SQL que será executado
                vol_Command.CommandText = SqlCommand.ToString();
                // Define o tipo do comando como texto SQL
                vol_Command.CommandType = CommandType.Text;
                // Associa a conexão ao Command
                vol_Command.Connection = Conexao;
                // Executa o comando
                vol_Command.ExecuteNonQuery();
                // Cria um DataAdapter
                NpgsqlDataAdapter vol_DataAdapter = new NpgsqlDataAdapter();
                // Associa o comando ao DataAdapter
                vol_DataAdapter.SelectCommand = vol_Command;
                // Carrega os registros no DataSet
                vol_DataAdapter.Fill(vol_DataSet);
                // Limpa o conteúdo da StringBuilder
                SqlCommand.Remove(0, SqlCommand.Length);
            }
            catch (Exception Error)
            {
                // Exibe mensagem de erro
                MessageBox.Show("Erro: " + Error.Message, "Controle de Vendas - DeMaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Limpa o conteúdo da StringBuilder
                SqlCommand.Remove(0, SqlCommand.Length);
            }
            // Retorna o DataSet
            return vol_DataSet;
        }

        // Método que retorna um objeto DataSet ao executar uma procedure
        public DataSet GetDataSetProc()
        {
            // Cria um DataSet
            DataSet vol_DataSet = new DataSet();
            try
            {
                // Associa a conexão ao Command
                vol_Command.Connection = Conexao;
                // Define o comando SQL que será executado
                vol_Command.CommandText = SqlCommand.ToString();
                // Define o tipo do comando como procedure
                vol_Command.CommandType = CommandType.StoredProcedure;
                // Executa o comando
                vol_Command.ExecuteNonQuery();
                // Cria um DataAdapter
                NpgsqlDataAdapter vol_DataAdapter = new NpgsqlDataAdapter();
                // Associa o comando ao DataAdapter
                vol_DataAdapter.SelectCommand = vol_Command;
                // Carrega os registros no DataSet
                vol_DataAdapter.Fill(vol_DataSet);
                // Limpa o conteúdo da StringBuilder
                SqlCommand.Remove(0, SqlCommand.Length);

            }
            catch (Exception Error)
            {
                // Exibe mensagem de erro
                MessageBox.Show("Erro: " + Error.Message, "Controle de Vendas - DeMaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Limpa o conteúdo da StringBuilder
                SqlCommand.Remove(0, SqlCommand.Length);
                // Limpa os parâmetros do Command
                Command.Parameters.Clear();
            }
            // Retorna o DataSet
            return vol_DataSet;
        }
        #endregion
    }
}
