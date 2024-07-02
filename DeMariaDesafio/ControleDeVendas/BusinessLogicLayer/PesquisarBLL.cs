using ControleDeVendas.Services;

namespace ControleDeVendas.BusinessLogicLayer
{
    internal class PesquisarBLL : FunctionsListView
    {
        #region Variáveis
        //Objetos de classe
        ProdutoBLL? vol_NegociosProdutos = null;       //Objeto da classe BLL_Produtos
        ClienteBLL? vol_NegociosClientes = null;       //Objeto da classe BLL_Clientes
        #endregion

        #region Métodos Públicos
        public void ListarProdutos(ListView pLista)
        {
            vol_NegociosProdutos = new ProdutoBLL();
            vol_NegociosProdutos.ListarProdutos(pLista);
        }

        public void ListarClientes(ListView pLista)
        {
            vol_NegociosClientes = new ClienteBLL();
            vol_NegociosClientes.ListarClientes(pLista);
        }
        #endregion
    }
}
