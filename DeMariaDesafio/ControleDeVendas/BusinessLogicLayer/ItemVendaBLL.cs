using ControleDeVendas.DataAccessLayer;
using ControleDeVendas.Models;
using ControleDeVendas.Services;
using System.Windows.Forms;
using static ControleDeVendas.Models.Produto;
using static ControleDeVendas.Models.Venda;

namespace ControleDeVendas.BusinessLogicLayer
{
    internal class ItemVendaBLL : FunctionsListView
    {
        #region Variáveis
        //Objetos de classe
        ItemVendaDAL? vol_DadosItemVenda = null;              //Objeto da classe ItemVendaDAL
        ProdutoDAL? vol_DadosProdutos = null;
        #endregion

        //Selecionar
        public ItemVenda? SelecionarVendas(Int32 pIdItemVenda)
        {
            //Inicialização da classe de ItemVendaDAL
            vol_DadosItemVenda = new ItemVendaDAL();

            try
            {
                //Carrega lista Vendas
                List<ItemVenda> vol_ListaItemVendas = vol_DadosItemVenda.SelecionarItemVenda(pIdItemVenda);
                //Objeto da classe Vendas
                ItemVenda? vol_ItemVenda = null;
                //
                foreach (ItemVenda vol_Item in vol_ListaItemVendas)
                {
                    vol_ItemVenda = new ItemVenda
                    {
                        Id = vol_Item.Id,
                        VendaId = vol_Item.VendaId,
                        ProdutoId = vol_Item.ProdutoId,
                        Quantidade = vol_Item.Quantidade,
                        PrecoUnitario = vol_Item.PrecoUnitario,
                        PrecoTotal = vol_Item.PrecoTotal
                    };
                    break;
                }
                return vol_ItemVenda;
            }
            catch
            {
                return null;
            }
        }

        //Médodo Editar 
        public ItemVenda? Editar(Int32 pIdItemVenda)
        {
            //Variável de acesso a classe
            vol_DadosItemVenda = new ItemVendaDAL();

            try
            {
                //Seleciona o Venda
                List<ItemVenda> vol_ListaVendas = vol_DadosItemVenda.SelecionarItemVenda(pIdItemVenda);
                //Objeto da classe Vendas
                ItemVenda? vol_ItemVenda = null;

                foreach (ItemVenda vol_Item in vol_ListaVendas)
                {
                    vol_ItemVenda = new ItemVenda
                    {
                        Id = vol_Item.Id,
                        VendaId = vol_Item.VendaId,
                        ProdutoId = vol_Item.ProdutoId,
                        Quantidade = vol_Item.Quantidade,
                        PrecoUnitario = vol_Item.PrecoUnitario,
                        PrecoTotal = vol_Item.PrecoTotal
                    };
                    break; // Seleciona apenas o primeiro item encontrado
                }

                // Retorna o venda selecionado (pode ser null se nenhum venda for encontrado)
                return vol_ItemVenda;
            }
            catch
            {
                return null; // Retorna null em caso de exceção
            }

        }

        //Listar
        public void ListarItensVenda(ListView pLista, Int32 pIdVenda)
        {
            //Inicialização da classe de DAL_ItensVenda
            vol_DadosItemVenda = new ItemVendaDAL();

            try
            {
                List<ItemVenda> vol_ListaItensVenda = vol_DadosItemVenda.SelecionarItensVenda(pIdVenda);
                //Percorre a lista
                foreach (ItemVenda vol_Item in vol_ListaItensVenda)
                {
                    ListViewItem vol_ListViewItem = new ListViewItem("");
                    vol_ListViewItem.SubItems.Add(Convert.ToString(vol_Item.ProdutoId).PadLeft(3, '0'));
                    //
                    //Variável de acesso a classe
                    vol_DadosProdutos = new ProdutoDAL();
                    string DescricaoProduto = string.Empty;
                    //Seleciona o Produto
                    List<Produto.ProdutoCons> vol_ListaProdutos = vol_DadosProdutos.SelecionarProdutos<Produto.ProdutoCons>(Convert.ToInt32(vol_Item.ProdutoId), "Cons", true);
                    Produto? vol_Produtos = null; // Inicializa como nullable
                    foreach (Produto.ProdutoCons vol_ItemVenda in vol_ListaProdutos)
                    {
                        vol_Produtos = new Produto
                        {
                            Id = vol_ItemVenda.Id,
                            Descricao = vol_ItemVenda.Descricao
                        };
                        //
                        if (!String.IsNullOrEmpty(vol_Produtos.Descricao))
                            DescricaoProduto = vol_Produtos.Descricao;
                        break; // Seleciona apenas o primeiro item encontrado
                    }
                    //
                    vol_ListViewItem.SubItems.Add(Convert.ToString(DescricaoProduto));
                    //
                    vol_ListViewItem.SubItems.Add(Convert.ToString(vol_Item.Quantidade));
                    vol_ListViewItem.SubItems.Add(Convert.ToString(String.Format("{0:N2}", vol_Item.PrecoUnitario)));
                    vol_ListViewItem.SubItems.Add(Convert.ToString(String.Format("{0:N2}", vol_Item.PrecoTotal)));
                    vol_ListViewItem.SubItems.Add(Convert.ToString(vol_Item.VendaId));
                    vol_ListViewItem.SubItems.Add(Convert.ToString(vol_Item.Id));

                    // Adiciona o ListViewItem ao ListView
                    pLista.Items.Add(vol_ListViewItem);
                }
            }
            catch
            {
                return;
            }
        }

    }
}
