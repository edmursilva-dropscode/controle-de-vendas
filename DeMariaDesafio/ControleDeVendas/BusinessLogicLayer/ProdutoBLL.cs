using ControleDeVendas.DataAccessLayer;
using ControleDeVendas.Models;
using ControleDeVendas.Services;

namespace ControleDeVendas.BusinessLogicLayer
{
    internal class ProdutoBLL : FunctionsListView
    {
        #region Variáveis
        //Objetos de classe
        ProdutoDAL? vol_DadosProdutos = null;              //Objeto da classe ProdutoDAL
        #endregion

        #region Metodos Públicos
        //Carregar grid
        public void CarregarGridLocalizarProdutos(DataGridView pGrid, String pLocalizarProduto, Int32 pPesquisar, Boolean pExibirTodos)
        {
            //Inicialização da classe de ProdutoDAL
            vol_DadosProdutos = new ProdutoDAL();

            try
            {
                //Limpar grid
                pGrid.Columns.Clear();
                pGrid.DataSource = null;
                //Carrega os registros do grid
                pGrid.DataSource = vol_DadosProdutos.LocalizarProdutos<Produto.ProdutoGrid>(pLocalizarProduto, pPesquisar, "Grid", pExibirTodos);
                //Define estrutura do grid
                pGrid.Columns[0].HeaderText = "Código";
                pGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                pGrid.Columns[0].ReadOnly = true;
                pGrid.Columns[0].Width = 100;
                //pGrid.Columns[0].DefaultCellStyle.Format = "000";
                pGrid.Columns[1].HeaderText = "Descrição";
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
        public void CarregarGridProdutos(DataGridView pGrid, Int32 pIdProduto, Boolean pExibirTodos)
        {
            //Inicialização da classe de ProdutoDAL
            vol_DadosProdutos = new ProdutoDAL();

            try
            {
                //Limpar grid
                pGrid.Columns.Clear();
                pGrid.DataSource = null;
                //Carrega os registros do grid
                pGrid.DataSource = vol_DadosProdutos.SelecionarProdutos<Produto.ProdutoGrid>(pIdProduto, "Grid", pExibirTodos);
                //Define estrutura do grid
                pGrid.Columns[0].HeaderText = "Código";
                pGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                pGrid.Columns[0].ReadOnly = true;
                pGrid.Columns[0].Width = 100;
                //pGrid.Columns[0].DefaultCellStyle.Format = "000";
                pGrid.Columns[1].HeaderText = "Descrição";
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
        public Produto? SelecionarProdutos(Int32 pIdProduto, string pTipo, Boolean pExibirTodos)
        {
            //Inicialização da classe de ProdutoDAL
            vol_DadosProdutos = new ProdutoDAL();

            try
            {
                //Carrega lista Produtos
                List<Produto.ProdutoCons> vol_ListaProdutos = vol_DadosProdutos.SelecionarProdutos<Produto.ProdutoCons>(pIdProduto, pTipo, pExibirTodos);
                //Objeto da classe Produtos
                Produto? vol_Produtos = null;

                foreach (Produto.ProdutoCons vol_Item in vol_ListaProdutos)
                {
                    vol_Produtos = new Produto
                    {
                        Id = vol_Item.Id,
                        Descricao = vol_Item.Descricao
                    };
                    break;
                }
                return vol_Produtos;
            }
            catch
            {
                return null;
            }

        }

        //Médodo Editar 
        public Produto? Editar(Int32 pIdProduto)
        {
            //Variável de acesso a classe
            vol_DadosProdutos = new ProdutoDAL();

            try
            {
                //Seleciona o Produto
                List<Produto.ProdutoEdit> vol_ListaProdutos = vol_DadosProdutos.SelecionarProdutos<Produto.ProdutoEdit>(pIdProduto, "Edit", true);

                Produto? vol_Produtos = null; // Inicializa como nullable

                foreach (Produto.ProdutoEdit vol_Item in vol_ListaProdutos)
                {
                    vol_Produtos = new Produto
                    {
                        Id = vol_Item.Id,
                        Descricao = vol_Item.Descricao,
                        Quantidade = vol_Item.Quantidade,
                        Preco = vol_Item.Preco,
                        Data = vol_Item.Data,
                        Ativo = vol_Item.Ativo
                    };
                    break; // Seleciona apenas o primeiro item encontrado
                }

                // Retorna o produto selecionado (pode ser null se nenhum produto for encontrado)
                return vol_Produtos;
            }
            catch
            {
                return null; // Retorna null em caso de exceção
            }
        }

        //Gravar 
        public bool Gravar(Int32 pIdProduto, string pDescricao, string pQuantidade, string pPreco, DateTime pDataCadastro, Boolean pAtivo)
        {
            //Inicialização da classe de ProdutoDAL
            vol_DadosProdutos = new ProdutoDAL();
            //Executa método para gravar
            return vol_DadosProdutos.Gravar(pIdProduto, pDescricao, pQuantidade, pPreco, pDataCadastro, pAtivo);
        }

        //Alterar 
        public bool Alterar(Int32 pIdProduto, string pDescricao, string pQuantidade, string pPreco, DateTime pDataCadastro, Boolean pAtivo)
        {
            //Inicialização da classe de ProdutoDAL
            vol_DadosProdutos = new ProdutoDAL();
            //Executa método para alterar
            return vol_DadosProdutos.Alterar(pIdProduto, pDescricao, pQuantidade, pPreco, pDataCadastro, pAtivo);
        }

        //Excluir
        public bool Excluir(Int32 pIdProduto)
        {
            //Inicialização da classe de ProdutoDAL
            vol_DadosProdutos = new ProdutoDAL();
            //Verifica se possui registros
            if (vol_DadosProdutos.SelecionarProdutos<Produto.ProdutoCons>(pIdProduto, "Cons", true).Count != 0)
            {
                //Executa método para excluir
                return vol_DadosProdutos.Excluir(pIdProduto);
            }
            else
            {
                return false;
            }
        }

        //Carrega lista de produtos
        public void ListarProdutos(ListView pLista)
        {
            pLista.Items.Clear();
            //Inicialização da classe de ProdutoDAL
            vol_DadosProdutos = new ProdutoDAL();
            //Contador
            int vil_Count = 0;
            try
            {
                List<Produto.ProdutoCons> vol_ListarProdutos = vol_DadosProdutos.SelecionarProdutos<Produto.ProdutoCons>(0, "Cons", true);

                foreach (Produto.ProdutoCons vol_Item in vol_ListarProdutos)
                {
                    ListViewItem vol_ListViewItem = new ListViewItem(Convert.ToString(vol_Item.Id).PadLeft(3, '0'));
                    vol_ListViewItem.SubItems.Add(vol_Item.Descricao);
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
