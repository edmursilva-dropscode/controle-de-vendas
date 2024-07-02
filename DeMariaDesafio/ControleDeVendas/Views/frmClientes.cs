using ControleDeVendas.BusinessLogicLayer;
using ControleDeVendas.Services;
using ControleDeVendas.Models;

namespace ControleDeVendas.Views
{
    public partial class frmClientes : Form
    {
        #region Variaveis
        //Objetos das classes
        ClienteBLL? vol_NegocioCliente = null;
        FunctionDataDatabase? vol_FunctionData = null;
        //Variáveis Públicas
        public bool vbp_Editar = false;
        public Int32 vip_IdCliente = 0;
        public bool vbp_Movimentacao = false;
        #endregion

        #region Form
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita que o Enter seja processado novamente
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnFechar_Click(sender, e);
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            // Altera a cor de fundo do formulário
            this.BackColor = Color.FromArgb(231, 234, 244);
            // Adiciona o controle label do título e a imagem da barra ao controle pctBarra
            pctBarra.Controls.Add(lblTitulo);
            pctBarra.Controls.Add(pctIcone);

            // Se o formulário estiver em modo de edição (vbp_Editar é verdadeiro)
            if (vbp_Editar)
            {
                // Exibe o label lblIdCliente
                lblIdCliente.Visible = true;
                vbp_Movimentacao = true;

                // Inicializa o objeto de negócios ClienteBLL
                vol_NegocioCliente = new ClienteBLL();
                // Obtém os dados do cliente para edição
                Cliente? vol_Clientes = vol_NegocioCliente.Editar(vip_IdCliente);

                // Verifica se vol_Clientes não é nulo
                if (vol_Clientes != null)
                {
                    // Preenche os campos do formulário com os dados do cliente
                    if (vol_Clientes.Id > 0)
                        lblIdCliente.Text = Convert.ToString(vol_Clientes.Id).PadLeft(3, '0');
                    if (!String.IsNullOrEmpty(vol_Clientes.Nome))
                        txtNome.Text = vol_Clientes.Nome;
                    if (!String.IsNullOrEmpty(vol_Clientes.Endereco))
                        txtEndereco.Text = vol_Clientes.Endereco;
                    if (!String.IsNullOrEmpty(vol_Clientes.Telefone))
                        txtTelefone.Text = vol_Clientes.Telefone;
                    if (!String.IsNullOrEmpty(Convert.ToString(vol_Clientes.Data)))
                        lblDataCadastro.Text = Convert.ToString(vol_Clientes.Data);
                    if (!String.IsNullOrEmpty(vol_Clientes.Email))
                        txtEmail.Text = vol_Clientes.Email;
                    if (vol_Clientes.Ativo.HasValue)
                    {
                        if (vol_Clientes.Ativo.Value)
                        {
                            radAtivo.Checked = true;
                        }
                        else
                        {
                            radNaoAtivo.Checked = true;
                        }
                    }
                }
                else
                {
                    // Lida com o caso onde vol_Clientes é nulo
                    MessageBox.Show("Erro ao carregar os dados do cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Se não estiver em modo de edição, oculta o lblIdCliente e o botão btnExcluir
                lblIdCliente.Visible = false;
                btnExcluir.Visible = false;
                vol_FunctionData = new FunctionDataDatabase();
                lblDataCadastro.Text = Convert.ToString(vol_FunctionData.ObterDataHoraAtual());
            }
        }
        #endregion

        #region Controles
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (FP_ValidarCampos())
            {
                //Inicializa o objeto
                vol_NegocioCliente = new ClienteBLL();

                //Verifica se é alteração
                if (vbp_Editar)
                {
                    if (MessageBox.Show("Confirma a Alteração ?", "Confirme !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Altera os dados da anamnese
                        if (!vol_NegocioCliente.Alterar(Convert.ToInt32(lblIdCliente.Text), txtNome.Text, txtEndereco.Text, txtTelefone.Text, Convert.ToDateTime(lblDataCadastro.Text), txtEmail.Text, radAtivo.Checked))
                        {
                            //aviso de não alterado
                            MessageBox.Show("Não foi possível alterar o Cliente !", "Cadastro de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        //Atualiza variaveis de controle
                        vbp_Movimentacao = true;
                        //
                        this.btnFechar_Click(sender, e);
                    }
                }
                else
                {
                    if (MessageBox.Show("Confirma a Inclusão ?", "Confirme !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Inclui os dados da anamnese
                        if (!vol_NegocioCliente.Gravar(Convert.ToInt32(lblIdCliente.Text), txtNome.Text, txtEndereco.Text, txtTelefone.Text, Convert.ToDateTime(lblDataCadastro.Text), txtEmail.Text, radAtivo.Checked))
                        {
                            //aviso de não inclusao
                            MessageBox.Show("Não foi possível incluir o Cliente !", "Cadastro de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        //Atualiza variavies de controle
                        vip_IdCliente = Convert.ToInt32(lblIdCliente.Text);

                        //Simula click no botao
                        this.btnFechar_Click(sender, e);
                    }
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Inicializa o objeto
            vol_NegocioCliente = new ClienteBLL();

            if (MessageBox.Show("Confirma a Excluir ?", "Confirme !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Altera os dados da anamnese
                if (!vol_NegocioCliente.Excluir(Convert.ToInt32(lblIdCliente.Text)))
                {
                    //aviso de não alterado
                    MessageBox.Show("Não foi possível excluir o Cliente !", "Cadastro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //Atualiza variaveis de controle
                vbp_Movimentacao = false;
                //
                this.btnFechar_Click(sender, e);
            }
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita que o Enter seja processado novamente
                this.SelectNextControl(sender as Control, true, true, true, true);
            }
        }

        private void txtEndereco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita que o Enter seja processado novamente
                this.SelectNextControl(sender as Control, true, true, true, true);
            }
        }

        private void txtTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita que o Enter seja processado novamente
                this.SelectNextControl(sender as Control, true, true, true, true);
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita que o Enter seja processado novamente
                this.SelectNextControl(sender as Control, true, true, true, true);
            }
        }
        #endregion

        #region Métodos Privados
        //Valida campos de entrada do form
        private bool FP_ValidarCampos()
        {
            if (String.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Informe o nome do Cliente !", "Cadastro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtEndereco.Text))
            {
                MessageBox.Show("Informe o endereço do Cliente !", "Cadastro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEndereco.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtTelefone.Text))
            {
                MessageBox.Show("Informe o telefone do Cliente !", "Cadastro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTelefone.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Informe o email do Cliente !", "Cadastro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return false;
            }
            else if (!radAtivo.Checked && !radNaoAtivo.Checked)
            {
                MessageBox.Show("Informe o status do Cliente !", "Cadastro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return false;
            }
            return true;
        }
        #endregion

    }
}
