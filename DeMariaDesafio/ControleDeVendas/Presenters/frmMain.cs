
using ControleDeVendas.BusinessLogicLayer;
using ControleDeVendas.DataAccessLayer;
using ControleDeVendas.Models;
using ControleDeVendas.Views;

namespace ControleDeVendas.Presenters
{
    public partial class frmMain : Form
    {
        #region Variaveis
        //Objetos de classe
        private VendaBLL? vol_NegociosVendas = null;
        //Variaveis private
        private Int32 vil_IdVendaMain = 0;
        #endregion

        #region Ações
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //Obter o nome do botão clicado
            string nomeBotao = ((Button)sender).Text.Trim();
            //Carrega o grid
            FP_CarregarGrid(nomeBotao);
            //Redimensiona tela do frmMain
            FP_Redimensionar(nomeBotao);
            //Totalizar estaisticas
            FP_TotalizarEstatistica();

        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            //Obter o nome do botão clicado
            string nomeBotao = ((Button)sender).Text.Trim();
            //Carrega o grid
            FP_CarregarGrid(nomeBotao);
            //Redimensiona tela do frmMain
            FP_Redimensionar(nomeBotao);
        }

        private void ptbMenuVendas_Click(object sender, EventArgs e)
        {
            // Cast seguro para o PictureBox para acessar suas propriedades de posição
            if (sender is PictureBox pictureBox)
            {
                // Obtém as coordenadas do mouse em relação ao PictureBox
                Point mousePosition = pictureBox.PointToClient(Cursor.Position);

                // Define a posição onde o menu deve aparecer (10 pixels abaixo e centralizado)
                int menuX = pnlMenuVendas.Left - 46;
                int menuY = pnlMenuVendas.Height - 3;

                // Mostra o menu contextual na posição onde o mouse estava quando o clicaram
                pictureBox.ContextMenuStrip?.Show(pictureBox, new Point(menuX, menuY));
            }
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Objeto de acesso ao form
            frmProdutosLista vol_ProdutosLista = new frmProdutosLista
            {
                //Exibe a lista de produtos
            };
            vol_ProdutosLista.ShowDialog();
            vol_ProdutosLista.Dispose();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Objeto de acesso ao form
            frmClientesLista vol_ClientesLista = new frmClientesLista
            {
                //Exibe a lista de clientes
            };
            vol_ClientesLista.ShowDialog();
            vol_ClientesLista.Dispose();
        }
        private void novaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exibe o filtro 
            lblFiltroVenda.Text = novaToolStripMenuItem.Text;

            //Objeto de acesso ao form
            frmVendas vol_Vendas = new frmVendas
            {
                //Exibe a venda 
            };
            vol_Vendas.ShowDialog();
            vol_Vendas.Dispose();

            //Carrega o grid
            vol_NegociosVendas = new VendaBLL();
            vol_NegociosVendas.CarregarGridVendas(dgvVendas, 0);
            dgvVendas.AllowUserToOrderColumns = true;
            dgvVendas.Refresh();

        }

        private void cmbTipoVenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Carrega o grid
            vol_NegociosVendas = new VendaBLL();
            vol_NegociosVendas.CarregarGridLocalizarVendas(dgvVendas, txtLocalizarVenda.Text, (cmbTipoVenda.SelectedIndex == 0 ? 0 : (cmbTipoVenda.SelectedIndex == 1 ? 1 : 2)));
            dgvVendas.Refresh();
        }

        private void dgvVendas_DoubleClick(object sender, EventArgs e)
        {
            //Guarda linha selecionada do grid
            int indiceVendaGrid = dgvVendas.CurrentCell.RowIndex;
            int currentPositionScroll = dgvVendas.FirstDisplayedScrollingRowIndex;

            //Objeto de acesso ao form
            frmVendas vol_Vendas = new frmVendas();
            vol_Vendas.vip_IdVenda = vil_IdVendaMain;
            vol_Vendas.vbp_Editar = true;
            vol_Vendas.ShowDialog();
            vol_Vendas.Dispose();

            //Carrega o grid
            vil_IdVendaMain = 0;

            //Carrega o grid
            vol_NegociosVendas = new VendaBLL();
            vol_NegociosVendas.CarregarGridVendas(dgvVendas, 0);
            dgvVendas.AllowUserToOrderColumns = true;
            dgvVendas.Refresh();

            //Posiciona o cursor na linha selecionada
            if (vol_Vendas.vbp_Movimentacao == true)
            {
                dgvVendas.ClearSelection();
                dgvVendas.Rows[indiceVendaGrid].Selected = true;
                dgvVendas.FirstDisplayedScrollingRowIndex = currentPositionScroll;
            }
        }

        private void dgvVendas_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvVendas.SelectedRows.Count > 0)
            {
                DataGridView.HitTestInfo hit = dgvVendas.HitTest(e.X, e.Y);
                if (hit.Type == DataGridViewHitTestType.Cell)
                {
                    vil_IdVendaMain = Convert.ToInt32(dgvVendas.Rows[hit.RowIndex].Cells[0].Value);
                }
            }
        }
        #endregion

        #region Métodos
        private void FP_TotalizarEstatistica()
        {
            // Inicializa objeto se não estiver inicializado
            if (vol_NegociosVendas == null)
                vol_NegociosVendas = new VendaBLL();

            // Obtém os totais de acordo com os tipos desejados
            lblTVenda.Text = Convert.ToString(vol_NegociosVendas.Totalizar("V").ToString());
            lblTCliente.Text = Convert.ToString(vol_NegociosVendas.Totalizar("C").ToString());
            lblTProduto.Text = Convert.ToString(vol_NegociosVendas.Totalizar("P").ToString());
        }

        private void FP_Redimensionar(string pNomeNode)
        {
            switch (pNomeNode)
            {
                case "Home":
                    //Desabilida painel
                    pnlHome.Visible = false;
                    pnlVendas.Visible = false;
                    //Redimenciona painel
                    pnlHome.Dock = DockStyle.Fill;
                    pnlHome.Visible = true;
                    //
                    break;
                case "Vendas":
                    //Desabilida painel
                    pnlHome.Visible = false;
                    pnlVendas.Visible = false;
                    //Redimenciona painel
                    pnlVendas.Dock = DockStyle.Fill;
                    pnlVendas.Visible = true;
                    //
                    break;
                default:
                    //Desabilida painel
                    pnlHome.Visible = false;
                    pnlVendas.Visible = false;
                    //Redimenciona painel
                    pnlHome.Dock = DockStyle.Fill;
                    pnlHome.Visible = true;
                    //
                    break;
            }
        }

        private void FP_CarregarGrid(string pNomeNode)
        {
            //Atualiza vaiaveis de controle
            vil_IdVendaMain = 0;

            switch (pNomeNode)
            {
                case "Vendas":
                    //Seleciona o tipo
                    cmbTipoVenda.SelectedIndex = 0;
                    //Carrega o grid
                    vol_NegociosVendas = new VendaBLL();
                    vol_NegociosVendas.CarregarGridVendas(dgvVendas, vil_IdVendaMain);
                    dgvVendas.AllowUserToOrderColumns = true;
                    dgvVendas.Refresh();
                    //Recupera o numero do Venda 
                    if (dgvVendas.RowCount != 0)
                    {
                        if (vil_IdVendaMain == 0)
                            vil_IdVendaMain = Convert.ToInt32(dgvVendas.Rows[0].Cells[0].Value);
                    }
                    break;
                case "Estatisticas":

                    //
                    break;
                default:
                    //
                    break;
            }
        }
        #endregion

    }
}
