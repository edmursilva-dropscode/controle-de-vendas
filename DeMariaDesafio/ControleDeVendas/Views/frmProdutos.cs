using ControleDeVendas.BusinessLogicLayer;
using ControleDeVendas.Services;
using ControleDeVendas.Models;

namespace ControleDeVendas.Views
{
    public partial class frmProdutos : Form
    {
        #region Variaveis
        //Objetos das classes
        ProdutoBLL? vol_NegocioProduto = null;
        FunctionDataDatabase? vol_FunctionData = null;
        //Variáveis Públicas
        public bool vbp_Editar = false;
        public Int32 vip_IdProduto = 0;
        public bool vbp_Movimentacao = false;
        #endregion

        #region Form
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void frmProdutos_KeyDown(object sender, KeyEventArgs e)
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

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            // Altera a cor de fundo do formulário
            this.BackColor = Color.FromArgb(231, 234, 244);

            // Adiciona o controle label do título e a imagem da barra ao controle pctBarra
            pctBarra.Controls.Add(lblTitulo);
            pctBarra.Controls.Add(pctIcone);

            // Se o formulário estiver em modo de edição (vbp_Editar é verdadeiro)
            if (vbp_Editar)
            {
                // Exibe o label lblIdProduto
                lblIdProduto.Visible = true;
                vbp_Movimentacao = true;

                // Inicializa o objeto de negócios ProdutoBLL
                vol_NegocioProduto = new ProdutoBLL();
                // Obtém os dados do produto para edição
                Produto? vol_Produtos = vol_NegocioProduto.Editar(vip_IdProduto);

                // Verifica se vol_Produtos não é nulo
                if (vol_Produtos != null)
                {
                    // Preenche os campos do formulário com os dados do produto
                    if (vol_Produtos.Id > 0)
                        lblIdProduto.Text = Convert.ToString(vol_Produtos.Id).PadLeft(3, '0');
                    if (!String.IsNullOrEmpty(vol_Produtos.Descricao))
                        txtDescricao.Text = vol_Produtos.Descricao;
                    if (vol_Produtos.Quantidade != 0)
                        txtQuantidade.Text = Convert.ToString(vol_Produtos.Quantidade);
                    if (vol_Produtos.Preco != 0)
                        txtPreco.Text = Convert.ToString(vol_Produtos.Preco);
                    if (!String.IsNullOrEmpty(Convert.ToString(vol_Produtos.Data)))
                        lblDataCadastro.Text = Convert.ToString(vol_Produtos.Data);
                    if (vol_Produtos.Ativo.HasValue)
                    {
                        if (vol_Produtos.Ativo.Value)
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
                    // Lida com o caso onde vol_Produtos é nulo
                    MessageBox.Show("Erro ao carregar os dados do produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Se não estiver em modo de edição, oculta o lblIdProduto e o botão btnExcluir
                lblIdProduto.Visible = false;
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
                vol_NegocioProduto = new ProdutoBLL();

                //Verifica se é alteração
                if (vbp_Editar)
                {
                    if (MessageBox.Show("Confirma a Alteração ?", "Confirme !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Altera os dados da anamnese
                        if (!vol_NegocioProduto.Alterar(Convert.ToInt32(lblIdProduto.Text), txtDescricao.Text, txtQuantidade.Text, txtPreco.Text, Convert.ToDateTime(lblDataCadastro.Text), radAtivo.Checked))
                        {
                            //aviso de não alterado
                            MessageBox.Show("Não foi possível alterar o Produto !", "Cadastro de Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        if (!vol_NegocioProduto.Gravar(Convert.ToInt32(lblIdProduto.Text), txtDescricao.Text, txtQuantidade.Text, txtPreco.Text, Convert.ToDateTime(lblDataCadastro.Text), radAtivo.Checked))
                        {
                            //aviso de não inclusao
                            MessageBox.Show("Não foi possível incluir o Produto !", "Cadastro de Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        //Atualiza variavies de controle
                        vip_IdProduto = Convert.ToInt32(lblIdProduto.Text);

                        //Simula click no botao
                        this.btnFechar_Click(sender, e);
                    }
                }
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Inicializa o objeto
            vol_NegocioProduto = new ProdutoBLL();

            if (MessageBox.Show("Confirma a Excluir ?", "Confirme !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Altera os dados da anamnese
                if (!vol_NegocioProduto.Excluir(Convert.ToInt32(lblIdProduto.Text)))
                {
                    //aviso de não alterado
                    MessageBox.Show("Não foi possível excluir o Produto !", "Cadastro de produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //Atualiza variaveis de controle
                vbp_Movimentacao = false;
                //
                this.btnFechar_Click(sender, e);
            }
        }

        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita que o Enter seja processado novamente
                this.SelectNextControl(sender as Control, true, true, true, true);
            }
        }

        private void txtQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita que o Enter seja processado novamente
                this.SelectNextControl(sender as Control, true, true, true, true);
            }
        }

        private void txtPreco_KeyDown(object sender, KeyEventArgs e)
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
            if (String.IsNullOrEmpty(txtDescricao.Text))
            {
                MessageBox.Show("Informe a descrição do Produto !", "Cadastro de produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescricao.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtQuantidade.Text))
            {
                MessageBox.Show("Informe a quantidade do Produto !", "Cadastro de produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuantidade.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtPreco.Text))
            {
                MessageBox.Show("Informe o preço do Produto !", "Cadastro de produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPreco.Focus();
                return false;
            }
            else if (!radAtivo.Checked && !radNaoAtivo.Checked)
            {
                MessageBox.Show("Informe o status do Produto !", "Cadastro de produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radAtivo.Focus();
                return false;
            }
            return true;
        }
        #endregion

    }
}