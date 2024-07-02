using ControleDeVendas.BusinessLogicLayer;

namespace ControleDeVendas.Views
{
    public partial class frmProdutosLista : Form
    {
        #region Variaveis
        //Objetos das classes        
        ProdutoBLL? vol_NegocioProduto = null;
        //Variáveis de uso comum
        private Int32 vil_IdProduto;                                //identificador do produto              
        #endregion

        #region Form
        public frmProdutosLista()
        {
            InitializeComponent();
        }

        private void frmProdutosListacs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            if (e.KeyCode == Keys.Escape)
            {
                //simula o pressionar a tecla ESC
                btnFechar_Click(sender, e);
            }
        }

        private void frmProdutosListacs_Load(object sender, EventArgs e)
        {
            // Altera a cor de fundo do formulário
            this.BackColor = Color.FromArgb(231, 234, 244);
            // Adiciona o controle label do título e a imagem da barra ao controle pctBarra
            pctBarra.Controls.Add(lblTitulo);
            pctBarra.Controls.Add(pctIcone);
            //Seleciona o tipo
            cmbTipo.SelectedIndex = 0;
            //Carrega o grid
            vol_NegocioProduto = new ProdutoBLL();
            vol_NegocioProduto.CarregarGridProdutos(dgvProdutos, vil_IdProduto, true);
            dgvProdutos.AllowUserToOrderColumns = true;
            dgvProdutos.Refresh();
        }
        #endregion

        #region Controles
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //Objeto de acesso ao form
            vil_IdProduto = 0;
            frmProdutos vol_Produtos = new frmProdutos();
            vol_Produtos.vip_IdProduto = vil_IdProduto;
            vol_Produtos.vbp_Editar = false;
            vol_Produtos.ShowDialog();
            vol_Produtos.Dispose();
            //Carrega o grid            
            vol_NegocioProduto = new ProdutoBLL();
            vol_NegocioProduto.CarregarGridProdutos(dgvProdutos, vil_IdProduto, true);
            dgvProdutos.AllowUserToOrderColumns = true;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //
        }

        private void txtLocalizar_TextChanged(object sender, EventArgs e)
        {
            //Carrega o grid
            vol_NegocioProduto = new ProdutoBLL();
            vol_NegocioProduto.CarregarGridLocalizarProdutos(dgvProdutos, txtLocalizar.Text, (cmbTipo.SelectedIndex == 0 ? 0 : 1), true);
            dgvProdutos.Refresh();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Carrega o grid
            vol_NegocioProduto = new ProdutoBLL();
            vol_NegocioProduto.CarregarGridLocalizarProdutos(dgvProdutos, txtLocalizar.Text, (cmbTipo.SelectedIndex == 0 ? 0 : 1), true);
            dgvProdutos.Refresh();
        }

        private void dgvProdutos_DoubleClick(object sender, EventArgs e)
        {
            // Guarda linha selecionada do
            int currentPositionScroll = dgvProdutos.FirstDisplayedScrollingRowIndex;
            int indiceClienteGrid = dgvProdutos.CurrentCell.RowIndex;

            // Conteúdo da primeira coluna da linha selecionada
            var conteudoSelecionado = dgvProdutos.Rows[indiceClienteGrid].Cells[0].Value?.ToString();

            // Objeto de acesso ao form
            frmProdutos vol_Clientes = new frmProdutos();
            vol_Clientes.vip_IdProduto = vil_IdProduto;
            vol_Clientes.vbp_Editar = true;
            vol_Clientes.ShowDialog();
            vol_Clientes.Dispose();

            // Atualiza o grid
            vil_IdProduto = 0;
            vol_NegocioProduto = new ProdutoBLL();
            vol_NegocioProduto.CarregarGridLocalizarProdutos(dgvProdutos, txtLocalizar.Text, (cmbTipo.SelectedIndex == 0 ? 0 : 1), true);
            dgvProdutos.Refresh();

            // Posiciona o cursor na linha com o mesmo conteúdo na primeira coluna
            DataGridViewRow? row = dgvProdutos.Rows
                                    .OfType<DataGridViewRow>()
                                    .FirstOrDefault(r => r.Cells[0].Value?.ToString() == conteudoSelecionado);

            if (dgvProdutos.Rows.Count > 0 && indiceClienteGrid >= 0 && indiceClienteGrid < dgvProdutos.Rows.Count)
            {
                dgvProdutos.ClearSelection();
                dgvProdutos.Rows[indiceClienteGrid].Selected = true;
                dgvProdutos.FirstDisplayedScrollingRowIndex = currentPositionScroll;
            }
            else
            {
                // Caso não encontre a linha ou o índice seja inválido, limpa a seleção
                dgvProdutos.ClearSelection();
            }

        }

        private void dgvProdutos_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                DataGridView.HitTestInfo hit = dgvProdutos.HitTest(e.X, e.Y);
                if (hit.Type == DataGridViewHitTestType.Cell)
                {
                    vil_IdProduto = Convert.ToInt32(dgvProdutos.Rows[hit.RowIndex].Cells[0].Value);
                }
            }
        }
        #endregion
    }
}
