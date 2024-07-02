using ControleDeVendas.BusinessLogicLayer;

namespace ControleDeVendas.Views
{
    public partial class frmClientesLista : Form
    {
        #region Variaveis
        //Objetos das classes        
        ClienteBLL? vol_NegocioCliente = null;
        //Variáveis de uso comum
        private Int32 vil_IdCliente;                                //identificador do cliente               
        #endregion

        #region Form
        public frmClientesLista()
        {
            InitializeComponent();
        }

        private void frmClientesLista_KeyDown(object sender, KeyEventArgs e)
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

        private void frmClientesLista_Load(object sender, EventArgs e)
        {
            //Altera a cor de fundo do form
            this.BackColor = Color.FromArgb(231, 234, 244);
            // Adiciona o controle label do título e a imagem da barra ao controle pctBarra
            pctBarra.Controls.Add(lblTitulo);
            pctBarra.Controls.Add(pctIcone);
            //Seleciona o tipo
            cmbTipo.SelectedIndex = 0;
            //Carrega o grid
            vol_NegocioCliente = new ClienteBLL();
            vol_NegocioCliente.CarregarGridClientes(dgvClientes, vil_IdCliente, true);
            dgvClientes.AllowUserToOrderColumns = true;
            dgvClientes.Refresh();
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
            vil_IdCliente = 0;
            frmClientes vol_Clientes = new frmClientes();
            vol_Clientes.vip_IdCliente = vil_IdCliente;
            vol_Clientes.vbp_Editar = false;
            vol_Clientes.ShowDialog();
            vol_Clientes.Dispose();
            //Carrega o grid            
            vol_NegocioCliente = new ClienteBLL();
            vol_NegocioCliente.CarregarGridClientes(dgvClientes, vil_IdCliente, true);
            dgvClientes.AllowUserToOrderColumns = true;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //
        }

        private void txtLocalizar_TextChanged(object sender, EventArgs e)
        {
            //Carrega o grid
            vol_NegocioCliente = new ClienteBLL();
            vol_NegocioCliente.CarregarGridLocalizarClientes(dgvClientes, txtLocalizar.Text, (cmbTipo.SelectedIndex == 0 ? 0 : 1), true);
            dgvClientes.Refresh();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Carrega o grid
            vol_NegocioCliente = new ClienteBLL();
            vol_NegocioCliente.CarregarGridLocalizarClientes(dgvClientes, txtLocalizar.Text, (cmbTipo.SelectedIndex == 0 ? 0 : 1), true);
            dgvClientes.Refresh();
        }

        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {

            // Guarda linha selecionada do
            int currentPositionScroll = dgvClientes.FirstDisplayedScrollingRowIndex;
            int indiceClienteGrid = dgvClientes.CurrentCell.RowIndex;

            // Conteúdo da primeira coluna da linha selecionada
            var conteudoSelecionado = dgvClientes.Rows[indiceClienteGrid].Cells[0].Value?.ToString();

            // Objeto de acesso ao form
            frmClientes vol_Clientes = new frmClientes();
            vol_Clientes.vip_IdCliente = vil_IdCliente;
            vol_Clientes.vbp_Editar = true;
            vol_Clientes.ShowDialog();
            vol_Clientes.Dispose();

            // Atualiza o grid
            vil_IdCliente = 0;
            vol_NegocioCliente = new ClienteBLL();
            vol_NegocioCliente.CarregarGridLocalizarClientes(dgvClientes, txtLocalizar.Text, (cmbTipo.SelectedIndex == 0 ? 0 : 1), true);
            dgvClientes.Refresh();

            // Posiciona o cursor na linha com o mesmo conteúdo na primeira coluna
            DataGridViewRow? row = dgvClientes.Rows
                                    .OfType<DataGridViewRow>()
                                    .FirstOrDefault(r => r.Cells[0].Value?.ToString() == conteudoSelecionado);

            if (dgvClientes.Rows.Count > 0 && indiceClienteGrid >= 0 && indiceClienteGrid < dgvClientes.Rows.Count)
            {
                dgvClientes.ClearSelection();
                dgvClientes.Rows[indiceClienteGrid].Selected = true;
                dgvClientes.FirstDisplayedScrollingRowIndex = currentPositionScroll;
            }
            else
            {
                // Caso não encontre a linha ou o índice seja inválido, limpa a seleção
                dgvClientes.ClearSelection();
            }
        }

        private void dgvClientes_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                DataGridView.HitTestInfo hit = dgvClientes.HitTest(e.X, e.Y);
                if (hit.Type == DataGridViewHitTestType.Cell)
                {
                    vil_IdCliente = Convert.ToInt32(dgvClientes.Rows[hit.RowIndex].Cells[0].Value);
                }
            }
        }
        #endregion

    }
}
