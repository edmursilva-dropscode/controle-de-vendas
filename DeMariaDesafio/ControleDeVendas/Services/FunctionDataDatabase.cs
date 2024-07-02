using ControleDeVendas.DataAccessLayer;
using Npgsql;
using System;
using System.Data;

namespace ControleDeVendas.Services
{
    internal class FunctionDataDatabase : ConexaoDAL
    {
        public DateTime ObterDataHoraAtual()
        {
            DateTime dataHoraAtual = DateTime.MinValue; // Valor padrão ou tratamento de erro, caso necessário

            try
            {
                // Abrir conexão usando método da classe base
                if (!ConectionOpen())
                    return dataHoraAtual;

                // Criar novo comando associado à conexão
                using (NpgsqlCommand command = new NpgsqlCommand("SELECT current_timestamp as DataHoraAtual", Conexao))
                {
                    // Executar a consulta
                    using (NpgsqlDataReader dataReader = command.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                            // Exemplo: Lendo o valor retornado pela função
                            dataHoraAtual = dataReader.GetDateTime(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Tratar a exceção de acordo com sua lógica de tratamento de erros
                Console.WriteLine($"Erro ao obter data e hora atual do banco de dados: {ex.Message}");
            }
            finally
            {
                // Fechar conexão usando método da classe base
                ConectionClose();
            }

            return dataHoraAtual;
        }
    }
}
