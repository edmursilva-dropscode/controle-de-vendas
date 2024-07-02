using ControleDeVendas.BusinessLogicLayer;
using ControleDeVendas.Services;
using ControleDeVendas.Models;
using ControleDeVendas.DataAccessLayer;
using Npgsql.Replication;

namespace ControleDeVendas.Views
{
    public partial class frmItemVendas : Form
    {
        #region Variaveis
        //Objetos das classes
        ItemVendaBLL? vol_NegocioItemVenda = null;
        ProdutoDAL? vol_DadosProdutos = null;
        FunctionClearControls? vol_FunctionClear = null;
        //Variáveis Públicas
        public bool vbp_Editar = false;
        public Int32 vip_IdItemVenda = 0;
        public bool vbp_Movimentacao = false;
        public List<ItemVenda> vol_ItemSelecionadoVenda;
        #endregion

        #region Form
        public frmItemVendas(List<ItemVenda> itemSelecionadoVenda)
        {
            InitializeComponent();
            this.vol_ItemSelecionadoVenda = itemSelecionadoVenda;

        }

        private void frmItemVendas_KeyDown(object sender, KeyEventArgs e)
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

        private void frmItemVendas_Load(object sender, EventArgs e)
        {
            // Altera a cor de fundo do formulário
            this.BackColor = Color.FromArgb(231, 234, 244);
            // Adiciona o controle label do título e a imagem da barra ao controle pctBarra
            pctBarra.Controls.Add(lblTitulo);
            pctBarra.Controls.Add(pctIcone);

            //Valida controle de editar ou incluir licenca
            if (vbp_Editar)
            {
                //Inicializa objeto
                vol_NegocioItemVenda = new ItemVendaBLL();
                ItemVenda? vol_ItemVenda = vol_NegocioItemVenda.Editar(vip_IdItemVenda);
                //Preenche campos da tela
                if (vol_ItemVenda != null)
                {

                    //Preenche campos da tela
                    if (vol_ItemVenda.Id > 0)
                    {
                        txtIdItemVenda.Text = Convert.ToString(vol_ItemVenda.Id);
                        lblIdVenda.Text = Convert.ToString(vol_ItemVenda.VendaId);
                    }
                    if (vol_ItemVenda.ProdutoId > 0)
                    {
                        txtIdProduto.Text = Convert.ToString(vol_ItemVenda.ProdutoId).PadLeft(3, '0');
                    }
                    if (vol_ItemVenda.Quantidade > 0)
                        txtQtde.Text = Convert.ToString(vol_ItemVenda.Quantidade);

                    if (vol_ItemVenda.PrecoUnitario > 0)
                        txtValorUnitario.Text = Convert.ToString(vol_ItemVenda.PrecoUnitario);

                    //Variável de acesso a classe
                    vol_DadosProdutos = new ProdutoDAL();
                    //Seleciona o Produto
                    List<Produto.ProdutoCons> vol_ListaProdutos = vol_DadosProdutos.SelecionarProdutos<Produto.ProdutoCons>(Convert.ToInt32(txtIdProduto.Text), "Cons", true);
                    Produto? vol_Produtos = null; // Inicializa como nullable
                    foreach (Produto.ProdutoCons vol_Item in vol_ListaProdutos)
                    {
                        vol_Produtos = new Produto
                        {
                            Id = vol_Item.Id,
                            Descricao = vol_Item.Descricao
                        };
                        //
                        if (vol_Produtos.Id > 0)
                            txtIdProduto.Text = Convert.ToString(vol_Produtos.Id).PadLeft(3, '0');
                        if (!String.IsNullOrEmpty(vol_Produtos.Descricao))
                            lblDescricaoProduto.Text = vol_Produtos.Descricao;
                        break; // Seleciona apenas o primeiro item encontrado
                    }

                }

                //Indica o foco habilidato
                txtIdProduto.Focus();
            }
            else
            {
                //Preparando atualizacao
                vol_FunctionClear = new FunctionClearControls();
                vol_FunctionClear.LimparControles(this.Controls, 0);

                //Atualiza variaveis de controle
                txtIdItemVenda.Text = Convert.ToString(vip_IdItemVenda);
                //Indica o foco habilidato
                txtIdProduto.Focus();
            }


        }
        #endregion

        #region Controles
        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (FP_ValidarCampos())
            {
                if (MessageBox.Show("Confirma a Inclusão ?", "Confirme !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    // Criando ou modificando um item de venda selecionado
                    ItemVenda itemVenda = new ItemVenda
                    {
                        Id = Convert.ToInt32(txtIdItemVenda.Text.Replace("R$", "").Replace(",", "").Trim()),
                        VendaId = Convert.ToInt32(lblIdVenda.Text.Replace("R$", "").Replace(",", "").Trim()),
                        ProdutoId = Convert.ToInt32(txtIdProduto.Text.Replace("R$", "").Replace(",", "").Trim()),
                        Quantidade = Convert.ToInt32(txtQtde.Text.Replace("R$", "").Replace(",", "").Trim()),
                        PrecoUnitario = Convert.ToDecimal(txtValorUnitario.Text),
                        PrecoTotal = Convert.ToDecimal(txtValorUnitario.Text) * Convert.ToInt32(txtQtde.Text)
                    };

                    // Adicionando o item de venda à lista de itens selecionados (ou atualizando um existente, se necessário)
                    if (vol_ItemSelecionadoVenda == null)
                    {
                        vol_ItemSelecionadoVenda = new List<ItemVenda>();
                    }

                    // Verifica se o item já existe na lista pelo Id, se sim, atualiza, se não, adiciona
                    var existingItem = vol_ItemSelecionadoVenda.FirstOrDefault(iv => iv.ProdutoId == itemVenda.ProdutoId);
                    if (existingItem != null)
                    {
                        //aviso de não alterado
                        MessageBox.Show("Produto já incluído na lista de Venda !", "Cadastro de Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        // Adiciona o novo item à lista
                        vol_ItemSelecionadoVenda.Add(itemVenda);
                    }

                    // Fecha o formulário
                    this.Close();
                    this.Dispose();
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            frmPesquisar vol_Pesquisar = new frmPesquisar()
            {
                vcg_Pesquisa = "Produtos"
            };
            vol_Pesquisar.ShowDialog();
            vol_Pesquisar.Dispose();
            //Preenche itens da tela
            txtIdProduto.Text = (vol_Pesquisar.vig_Codigo > 0 ? Convert.ToString(Convert.ToInt16(vol_Pesquisar.vig_Codigo)) : String.Empty).PadLeft(3, '0');
            lblDescricaoProduto.Text = vol_Pesquisar.vcg_Descricao;

            //Indica o foco habilidato
            txtIdProduto.Focus();
        }

        private void txtIdProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnPesquisarProduto_Click(sender, e);
            }
        }

        private void txtIdProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Digita apenas numeros
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtIdProduto_Leave(object sender, EventArgs e)
        {
            if (txtIdProduto.Text.Length < 1) return;
            if (txtIdProduto.Text != String.Empty)
            {
                //Variável de acesso a classe
                vol_DadosProdutos = new ProdutoDAL();
                //Seleciona o Produto
                List<Produto.ProdutoCons> vol_ListaProdutos = vol_DadosProdutos.SelecionarProdutos<Produto.ProdutoCons>(Convert.ToInt32(txtIdProduto.Text), "Cons", true);
                Produto? vol_Produtos = null; // Inicializa como nullable
                foreach (Produto.ProdutoCons vol_Item in vol_ListaProdutos)
                {
                    vol_Produtos = new Produto
                    {
                        Id = vol_Item.Id,
                        Descricao = vol_Item.Descricao
                    };
                    //
                    if (vol_Produtos.Id > 0)
                        txtIdProduto.Text = Convert.ToString(vol_Produtos.Id).PadLeft(3, '0');
                    if (!String.IsNullOrEmpty(vol_Produtos.Descricao))
                        lblDescricaoProduto.Text = vol_Produtos.Descricao;
                    break; // Seleciona apenas o primeiro item encontrado
                }
                if (vol_Produtos == null)
                {
                    MessageBox.Show("Produto não encontrado !", "Cadastro de Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Atualiza variaveis de controle
                    lblDescricaoProduto.Text = String.Empty;
                    txtIdProduto.Text = String.Empty;

                    //Indica o foco habilidato
                    txtIdProduto.Focus();
                }
            }
        }

        private void txtIdProduto_TextChanged(object sender, EventArgs e)
        {
            if (txtIdProduto.Text.Trim() == String.Empty)
            {
                lblDescricaoProduto.Text = String.Empty;
            }
        }

        private void txtQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Digita apenas numeros
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }        

        private void txtValorUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se o sender não é nulo e se é um TextBox
            if (sender is TextBox textBox && textBox.Text != null)
            {
                // Verifica se o caractere inserido é um dígito, ponto decimal ou tecla de controle
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.') && (e.KeyChar != ','))
                {
                    e.Handled = true;  // Ignora o caractere inserido
                }

                // Verifica se já há um ponto decimal ou vírgula presente
                if ((e.KeyChar == '.' && textBox.Text.Contains('.')) ||
                    (e.KeyChar == ',' && textBox.Text.Contains(',')))
                {
                    e.Handled = true;  // Ignora o caractere inserido se já houver ponto decimal ou vírgula
                }
            }
        }
        #endregion

        #region Métodos Privados
        //Valida campos de entrada do form
        private bool FP_ValidarCampos()
        {
            if (String.IsNullOrEmpty(txtIdProduto.Text))
            {
                MessageBox.Show("Informe o produto da venda !", "Cadastro de Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdProduto.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtQtde.Text))
            {
                MessageBox.Show("Informe a quantidade do produto da venda !", "Cadastro de Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQtde.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtValorUnitario.Text))
            {
                MessageBox.Show("Informe o valor unitário do produto da venda !", "Cadastro de Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValorUnitario.Focus();
                return false;
            }
            return true;
        }
        #endregion
    }
}
