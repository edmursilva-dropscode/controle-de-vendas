using ControleDeVendas.DataAccessLayer;
using ControleDeVendas.Models;
using ControleDeVendas.Services;

namespace ControleDeVendas.BusinessLogicLayer
{
    internal class ClienteBLL : FunctionsListView
    {
        #region Variáveis
        //Objetos de classe        
        ClienteDAL? vol_DadosClientes = null;              //Objeto da classe ClienteDAL
        #endregion

        #region Metodos Públicos
        //Carregar grid
        public void CarregarGridLocalizarClientes(DataGridView pGrid, String pLocalizarCliente, Int32 pPesquisar, Boolean pExibirTodos)
        {
            //Inicialização da classe de ClienteDAL
            vol_DadosClientes = new ClienteDAL();

            try
            {
                //Limpar grid
                pGrid.Columns.Clear();
                pGrid.DataSource = null;
                //Carrega os registros do grid
                pGrid.DataSource = vol_DadosClientes.LocalizarClientes<Cliente.ClienteGrid>(pLocalizarCliente, pPesquisar, "Grid", pExibirTodos);
                //Define estrutura do grid
                pGrid.Columns[0].HeaderText = "Código";
                pGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                pGrid.Columns[0].ReadOnly = true;
                pGrid.Columns[0].Width = 100;
                //pGrid.Columns[0].DefaultCellStyle.Format = "000";
                pGrid.Columns[1].HeaderText = "Nome";
                pGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                pGrid.Columns[1].ReadOnly = true;
                pGrid.Columns[1].Width = 366;
                pGrid.Columns[2].HeaderText = "Status";
                pGrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                pGrid.Columns[2].ReadOnly = true;
                pGrid.Columns[2].Width = 200;
                //Redimensionar as colunas de DataGridView para caber o conteúdo recém-carregado.
                //pGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                pGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                pGrid.AllowUserToResizeColumns = false;
                pGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                pGrid.AllowUserToResizeRows = false;
                pGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                //Atualiliza o grid
                pGrid.Refresh();

            }
            catch
            {
                return;
            }
        }

        //Carregar grid
        public void CarregarGridClientes(DataGridView pGrid, Int32 pIdCliente, Boolean pExibirTodos)
        {
            //Inicialização da classe de ClienteDAL
            vol_DadosClientes = new ClienteDAL();

            try
            {
                //Limpar grid
                pGrid.Columns.Clear();
                pGrid.DataSource = null;
                //Carrega os registros do grid
                pGrid.DataSource = vol_DadosClientes.SelecionarClientes<Cliente.ClienteGrid>(pIdCliente, "Grid", pExibirTodos);
                //Define estrutura do grid
                pGrid.Columns[0].HeaderText = "Código";
                pGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                pGrid.Columns[0].ReadOnly = true;
                pGrid.Columns[0].Width = 100;
                //pGrid.Columns[0].DefaultCellStyle.Format = "000";
                pGrid.Columns[1].HeaderText = "Nome";
                pGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                pGrid.Columns[1].ReadOnly = true;
                pGrid.Columns[1].Width = 373;
                pGrid.Columns[2].HeaderText = "Status";
                pGrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                pGrid.Columns[2].ReadOnly = true;
                pGrid.Columns[2].Width = 100;
                //Redimensionar as colunas de DataGridView para caber o conteúdo recém-carregado.
                //pGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                pGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                pGrid.AllowUserToResizeColumns = false;
                pGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                pGrid.AllowUserToResizeRows = false;
                pGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                //Atualiliza o grid
                pGrid.Refresh();

            }
            catch
            {
                return;
            }
        }

        //Selecionar
        public Cliente? SelecionarClientes(Int32 pIdCliente, string pTipo, Boolean pExibirTodos)
        {
            //Inicialização da classe de ClienteDAL
            vol_DadosClientes = new ClienteDAL();

            try
            {
                //Carrega lista Clientes
                List<Cliente.ClienteCons> vol_ListaClientes = vol_DadosClientes.SelecionarClientes<Cliente.ClienteCons>(pIdCliente, pTipo, pExibirTodos);
                //Objeto da classe Clientes
                Cliente? vol_Clientes = null;

                foreach (Cliente.ClienteCons vol_Item in vol_ListaClientes)
                {
                    vol_Clientes = new Cliente
                    {
                        Id = vol_Item.Id,
                        Nome = vol_Item.Nome
                    };
                    break;
                }
                return vol_Clientes;
            }
            catch
            {
                return null;
            }
        }

         //Médodo Editar 
        public Cliente? Editar(Int32 pIdCliente)
        {
            //Variável de acesso a classe
            vol_DadosClientes = new ClienteDAL();

            try
            {
                //Seleciona o Cliente
                List<Cliente.ClienteEdit> vol_ListaClientes = vol_DadosClientes.SelecionarClientes<Cliente.ClienteEdit>(pIdCliente, "Edit", true);

                Cliente? vol_Clientes = null; // Inicializa como nullable

                foreach (Cliente.ClienteEdit vol_Item in vol_ListaClientes)
                {
                    vol_Clientes = new Cliente
                    {
                        Id = vol_Item.Id,
                        Nome = vol_Item.Nome,
                        Endereco = vol_Item.Endereco,
                        Telefone = vol_Item.Telefone,
                        Email = vol_Item.Email,
                        Data = vol_Item.Data,
                        Ativo = vol_Item.Ativo
                    };
                    break; // Seleciona apenas o primeiro item encontrado
                }

                // Retorna o cliente selecionado (pode ser null se nenhum cliente for encontrado)
                return vol_Clientes;
            }
            catch
            {
                return null; // Retorna null em caso de exceção
            }

        }

        //Gravar 
        public bool Gravar(Int32 pIdCliente, string pNome, string pEndereco, string pTelefone, DateTime pDataCadastro, string pEmail, Boolean pAtivo)
        {
            //Inicialização da classe de ClienteDAL
            vol_DadosClientes = new ClienteDAL();
            //Executa método para gravar
            return vol_DadosClientes.Gravar(pIdCliente, pNome, pEndereco, pTelefone, pDataCadastro, pEmail, pAtivo);
        }

        //Alterar 
        public bool Alterar(Int32 pIdCliente, string pNome, string pEndereco, string pTelefone, DateTime pDataCadastro, string pEmail, Boolean pAtivo)
        {
            //Inicialização da classe de ClienteDAL
            vol_DadosClientes = new ClienteDAL();
            //Executa método para alterar
            return vol_DadosClientes.Alterar(pIdCliente, pNome, pEndereco, pTelefone, pDataCadastro, pEmail, pAtivo);
        }

        //Excluir
        public bool Excluir(Int32 pIdCliente)
        {
            //Inicialização da classe de ClienteDAL
            vol_DadosClientes = new ClienteDAL();
            //Verifica se possui registros
            if (vol_DadosClientes.SelecionarClientes<Cliente.ClienteCons>(pIdCliente, "Cons", true).Count != 0)
            {
                //Executa método para excluir
                return vol_DadosClientes.Excluir(pIdCliente);
            }
            else
            {
                return false;
            }
        }

        //Carrega lista de Clientes
        public void ListarClientes(ListView pLista)
        {
            pLista.Items.Clear();
            //Inicialização da classe de ClienteDAL
            vol_DadosClientes = new ClienteDAL();
            //Contador
            int vil_Count = 0;
            try
            {
                List<Cliente.ClienteCons> vol_ListarClientes = vol_DadosClientes.SelecionarClientes<Cliente.ClienteCons>(0, "Cons", true);

                foreach (Cliente.ClienteCons vol_Item in vol_ListarClientes)
                {
                    ListViewItem vol_ListViewItem = new ListViewItem(Convert.ToString(vol_Item.Id).PadLeft(3, '0'));
                    vol_ListViewItem.SubItems.Add(vol_Item.Nome);
                    pLista.Items.Add(vol_ListViewItem);
                    vil_Count++;
                    AplicarCorLista(vol_ListViewItem, vil_Count);
                }
            }
            catch
            {
                return;
            }
        }
        #endregion

    }
}
