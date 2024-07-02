using ControleDeVendas.DataAccessLayer;
using ControleDeVendas.Models;
using ControleDeVendas.Services;

namespace ControleDeVendas.BusinessLogicLayer
{
    internal class VendaBLL : FunctionsListView
    {
        #region Variáveis
        //Objetos de classe
        VendaDAL? vol_DadosVendas = null;
        #endregion

        #region Metodos Públicos
        //Carregar grid
        public void CarregarGridLocalizarVendas(DataGridView pGrid, String pLocalizarVenda, Int32 pPesquisar)
        {
            //Inicialização da classe de VendaDAL
            vol_DadosVendas = new VendaDAL();

            try
            {
                //Limpar grid
                pGrid.Columns.Clear();
                pGrid.DataSource = null;
                //Carrega os registros do grid
                pGrid.DataSource = vol_DadosVendas.LocalizarVendas<Venda.VendaGrid>(pLocalizarVenda, pPesquisar, "Grid");
                //Define estrutura do grid
                pGrid.Columns[0].HeaderText = "Venda";
                pGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                pGrid.Columns[0].ReadOnly = true;
                pGrid.Columns[0].Width = 100;
                //pGrid.Columns[0].DefaultCellStyle.Format = "000000";
                pGrid.Columns[1].HeaderText = "Data";
                pGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                pGrid.Columns[1].ReadOnly = true;
                pGrid.Columns[1].Width = 150;
                pGrid.Columns[2].HeaderText = "Cliente";
                pGrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                pGrid.Columns[2].ReadOnly = true;
                pGrid.Columns[2].Width = 366;
                pGrid.Columns[3].HeaderText = "Total";
                pGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                pGrid.Columns[3].ReadOnly = true;
                pGrid.Columns[3].Width = 200;
                pGrid.Columns[4].HeaderText = "Status";
                pGrid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                pGrid.Columns[4].ReadOnly = true;
                pGrid.Columns[4].Width = 200;
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
        public void CarregarGridVendas(DataGridView pGrid, Int32 pIdVenda)
        {
            //Inicialização da classe de VendaDAL
            vol_DadosVendas = new VendaDAL();

            try
            {
                //Limpar grid
                pGrid.Columns.Clear();
                pGrid.DataSource = null;
                //Carrega os registros do grid
                pGrid.DataSource = vol_DadosVendas.SelecionarVendas<Venda.VendaGrid>(pIdVenda, "Grid");
                //Define estrutura do grid
                pGrid.Columns[0].HeaderText = "Venda";
                pGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                pGrid.Columns[0].ReadOnly = true;
                pGrid.Columns[0].Width = 100;
                //pGrid.Columns[0].DefaultCellStyle.Format = "000000";
                pGrid.Columns[1].HeaderText = "Data";
                pGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                pGrid.Columns[1].ReadOnly = true;
                pGrid.Columns[1].Width = 150;
                pGrid.Columns[2].HeaderText = "Cliente";
                pGrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                pGrid.Columns[2].ReadOnly = true;
                pGrid.Columns[2].Width = 366;
                pGrid.Columns[3].HeaderText = "Total";
                pGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                pGrid.Columns[3].ReadOnly = true;
                pGrid.Columns[3].Width = 200;
                pGrid.Columns[4].HeaderText = "Status";
                pGrid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                pGrid.Columns[4].ReadOnly = true;
                pGrid.Columns[4].Width = 200;
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
        public Venda? SelecionarVendas(Int32 pIdVenda, string pTipo)
        {
            //Inicialização da classe de VendaDAL
            vol_DadosVendas = new VendaDAL();

            try
            {
                //Carrega lista Vendas
                List<Venda.VendaGrid> vol_ListaVendas = vol_DadosVendas.SelecionarVendas<Venda.VendaGrid>(pIdVenda, pTipo);
                //Objeto da classe Vendas
                Venda? vol_Vendas = null;

                foreach (Venda.VendaGrid vol_Item in vol_ListaVendas)
                {
                    vol_Vendas = new Venda
                    {
                        Id = vol_Item.Id,                        
                        NomeCliente = vol_Item.NomeCliente,
                        Data = vol_Item.Data,
                        Total  = vol_Item.Total,
                        Status  = vol_Item.Status
                    };
                    break;
                }
                return vol_Vendas;
            }
            catch
            {
                return null;
            }
        }

        //Médodo Editar 
        public Venda? Editar(Int32 pIdVenda)
        {
            //Variável de acesso a classe
            vol_DadosVendas = new VendaDAL();

            try
            {
                //Seleciona o Venda
                List<Venda.VendaEdit> vol_ListaVendas = vol_DadosVendas.SelecionarVendas<Venda.VendaEdit>(pIdVenda, "Edit");

                Venda? vol_Vendas = null; // Inicializa como nullable

                foreach (Venda.VendaEdit vol_Item in vol_ListaVendas)
                {
                    vol_Vendas = new Venda
                    {
                        Id = vol_Item.Id,
                        Data = vol_Item.Data,
                        NomeCliente = vol_Item.NomeCliente,
                        Total = vol_Item.Total,
                        ClienteId = vol_Item.ClienteId,
                        IdStatus = vol_Item.IdStatus,
                        Observacao = vol_Item.Observacao
                    };
                    break; // Seleciona apenas o primeiro item encontrado
                }

                // Retorna o venda selecionado (pode ser null se nenhum venda for encontrado)
                return vol_Vendas;
            }
            catch
            {
                return null; // Retorna null em caso de exceção
            }

        }

        //Gravar 
        public bool Gravar(Int32 pIdVenda, DateTime pDtVenda, String pTotalVenda, Int32 pStatus, String pObservacao, Int32 pIdCliente, ListView pItensVenda)
        {
            //Inicialização da classe
            vol_DadosVendas = new VendaDAL();

            //Executa método para gravar
            if (!vol_DadosVendas.Gravar(out pIdVenda, pDtVenda, pTotalVenda, pStatus, pObservacao, pIdCliente, pItensVenda))
            {
                return false;
            }
            return true;
        }

        //Alterar 
        public bool Alterar(Int32 pIdVenda, DateTime pDtVenda, String pTotalVenda, Int32 pStatus, String pObservacao, Int32 pIdCliente, ListView pItensVenda, ListView pItemVendaExcluir)
        {
            //Inicialização da classe de VendaDAL
            vol_DadosVendas = new VendaDAL();

            //Executa método para alterar
            if (!vol_DadosVendas.Alterar(pIdVenda, pDtVenda, pTotalVenda, pStatus, pObservacao, pIdCliente, pItensVenda, pItemVendaExcluir))
            {
                return false;
            }
            return true;
        }

        //Excluir
        public bool Excluir(Int32 pIdVenda)
        {
            //Inicialização da classe de VendaDAL
            vol_DadosVendas = new VendaDAL();
            //Verifica se possui registros
            List<Venda.VendaEdit> vol_ListaVendas = vol_DadosVendas.SelecionarVendas<Venda.VendaEdit>(pIdVenda, "Edit");
            if (vol_ListaVendas != null )
            {
                //Executa método para excluir
                return vol_DadosVendas.Excluir(pIdVenda);
            }
            else
            {
                return false;
            }
        }

        public Int32 Totalizar(string pTipo)
        {
            //Inicialização da classe de DAL_ItensVenda
            vol_DadosVendas = new VendaDAL();
            return vol_DadosVendas.Totalizar(pTipo);
        }
        #endregion
    }
}

