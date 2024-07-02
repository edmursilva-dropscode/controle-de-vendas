using ControleDeVendas.BusinessLogicLayer;
using ControleDeVendas.DataAccessLayer;
using ControleDeVendas.Models;
using ControleDeVendas.Services;
using static ControleDeVendas.Models.Produto;
using static ControleDeVendas.Models.Venda;

namespace ControleDeVendas.Views
{
    public partial class frmVendas : Form
    {
        #region Variaveis
        //Objetos das classes
        VendaBLL? vol_NegocioVenda = null;
        ItemVendaBLL? vol_NegocioItensVenda = null;
        ClienteDAL? vol_DadosClientes = null;
        FunctionDataDatabase? vol_FunctionData = null;
        FunctionClearControls? vol_FunctionClear = null;
        FunctionsListView? vol_FunctionListView = null;
        //Variáveis Públicas
        public bool vbp_Editar = false;
        public Int32 vip_IdVenda = 0;
        public bool vbp_Movimentacao = false;
        public Int32 vip_ItemLista = 0;
        #endregion

        #region Form
        public frmVendas()
        {
            InitializeComponent();
        }

        private void frmVendas_KeyDown(object sender, KeyEventArgs e)
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

        private void frmVendas_Load(object sender, EventArgs e)
        {
            // Altera a cor de fundo do formulário
            this.BackColor = Color.FromArgb(231, 234, 244);

            // Adiciona o controle label do título e a imagem da barra ao controle pctBarra
            pctBarra.Controls.Add(lblTitulo);
            pctBarra.Controls.Add(pctIcone);

            //Inicializa objeto
            vol_FunctionListView = new FunctionsListView();
            vol_FunctionListView.ColorListView(lvwItensVenda, false);
            lvwItensVenda.Items.Clear();

            // Se o formulário estiver em modo de edição (vbp_Editar é verdadeiro)
            if (vbp_Editar)
            {
                //Inicializa objeto
                vol_NegocioVenda = new VendaBLL();
                Venda? vol_Vendas = vol_NegocioVenda.Editar(vip_IdVenda);
                //Preenche campos da tela
                if (vol_Vendas != null)
                {
                    //Atualiza controle do form
                    lblIdVenda.Visible = true;
                    vbp_Movimentacao = true;

                    //Preenche campos da tela
                    if (vol_Vendas.Id > 0)
                    {
                        vip_IdVenda = Convert.ToInt32(vol_Vendas.Id);
                        lblIdVenda.Text = Convert.ToString(vol_Vendas.Id);
                    }
                    if (vol_Vendas.ClienteId > 0)
                    {
                        txtIdCliente.Text = Convert.ToString(vol_Vendas.ClienteId).PadLeft(3, '0');
                    }
                    if (vol_Vendas.Data != DateTime.MinValue)
                    {
                        dtpDataVenda.Text = Convert.ToString(vol_Vendas.Data);
                    }
                    if (vol_Vendas.Total > 0)
                    {
                        lblTotalVenda.Text = Convert.ToString(vol_Vendas.Total);
                    }

                    //Variável de acesso a classe
                    vol_DadosClientes = new ClienteDAL();
                    //Seleciona o Cliente
                    List<Cliente.ClienteCons> vol_ListaClientes = vol_DadosClientes.SelecionarClientes<Cliente.ClienteCons>(Convert.ToInt32(txtIdCliente.Text), "Cons", true);
                    Cliente? vol_Clientes = null; // Inicializa como nullable
                    foreach (Cliente.ClienteCons vol_Item in vol_ListaClientes)
                    {
                        vol_Clientes = new Cliente
                        {
                            Id = vol_Item.Id,
                            Nome = vol_Item.Nome
                        };
                        //
                        if (vol_Clientes.Id > 0)
                            txtIdCliente.Text = Convert.ToString(vol_Clientes.Id).PadLeft(3, '0');
                        if (!String.IsNullOrEmpty(vol_Clientes.Nome))
                            lblNomeCliente.Text = vol_Clientes.Nome;
                        break; // Seleciona apenas o primeiro item encontrado
                    }

                    if (vol_Vendas.Observacao != string.Empty)
                    {
                        txtObservacao.Text = Convert.ToString(vol_Vendas.Observacao);
                    }
                }

                //Exibe dados dos itens do venda
                vol_NegocioItensVenda = new ItemVendaBLL();
                vol_NegocioItensVenda.ListarItensVenda(lvwItensVenda, vip_IdVenda);

                //Indica o foco habilidato
                dtpDataVenda.Focus();
            }
            else
            {
                //Preparando atualizacao
                vol_FunctionClear = new FunctionClearControls();
                vol_FunctionClear.LimparControles(this.Controls, 0);

                //Atualiza controle do form
                lblIdVenda.Visible = false;
                btnExcluir.Visible = false;

                //Indica o foco habilidato
                vol_FunctionData = new FunctionDataDatabase();
                dtpDataVenda.Text = Convert.ToString(vol_FunctionData.ObterDataHoraAtual());
                dtpDataVenda.Focus();
            }
        }
        #endregion

        #region Controles
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Inicializa o objeto
            vol_NegocioVenda = new VendaBLL();

            if (MessageBox.Show("Confirma a Excluir ?", "Confirme !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Altera os dados 
                if (!vol_NegocioVenda.Excluir(Convert.ToInt32(lblIdVenda.Text)))
                {
                    //aviso de não alterado
                    MessageBox.Show("Não foi possível excluir o pedido !", "Cadastro de pedidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //Atualiza variaveis de controle
                vbp_Movimentacao = false;
                //
                this.btnFechar_Click(sender, e);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (FP_ValidarCampos())
            {
                //Inicializa o objeto
                vol_NegocioVenda = new VendaBLL();

                //Verifica se é alteração
                if (vbp_Editar)
                {
                    if (MessageBox.Show("Confirma a Alteração ?", "Confirme !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Altera os dados da anamnese
                        if (!vol_NegocioVenda.Alterar(Convert.ToInt32(lblIdVenda.Text), dtpDataVenda.Value, lblTotalVenda.Text, 0, txtObservacao.Text, Convert.ToInt32(txtIdCliente.Text), lvwItensVenda, lvwItemVendaExcluir))
                        {
                            //aviso de não alterado
                            MessageBox.Show("Não foi possível alterar a venda !", "Cadastro de venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        if (!vol_NegocioVenda.Gravar(Convert.ToInt32(lblIdVenda.Text), dtpDataVenda.Value, lblTotalVenda.Text, 0, txtObservacao.Text, Convert.ToInt32(txtIdCliente.Text), lvwItensVenda))
                        {
                            //aviso de não inclusao
                            MessageBox.Show("Não foi possível incluir a venda !", "Cadastro de venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        //Atualiza variavies de controle
                        vip_IdVenda = Convert.ToInt32(lblIdVenda.Text);

                        //Simula click no botao
                        this.btnFechar_Click(sender, e);
                    }
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void txtIdCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnPesquisarCliente_Click(sender, e);
            }
        }

        private void txtIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Digita apenas numeros
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtIdCliente_Leave(object sender, EventArgs e)
        {
            if (txtIdCliente.Text.Length < 1) return;
            if (txtIdCliente.Text != String.Empty)
            {
                //Variável de acesso a classe
                vol_DadosClientes = new ClienteDAL();
                //Seleciona o Cliente
                List<Cliente.ClienteCons> vol_ListaClientes = vol_DadosClientes.SelecionarClientes<Cliente.ClienteCons>(Convert.ToInt32(txtIdCliente.Text), "Cons", true);
                Cliente? vol_Clientes = null; // Inicializa como nullable
                foreach (Cliente.ClienteCons vol_Item in vol_ListaClientes)
                {
                    vol_Clientes = new Cliente
                    {
                        Id = vol_Item.Id,
                        Nome = vol_Item.Nome
                    };
                    //
                    if (vol_Clientes.Id > 0)
                        txtIdCliente.Text = Convert.ToString(vol_Clientes.Id).PadLeft(3, '0');
                    if (!String.IsNullOrEmpty(vol_Clientes.Nome))
                        lblNomeCliente.Text = vol_Clientes.Nome;
                    break; // Seleciona apenas o primeiro item encontrado
                }
                if (vol_Clientes == null)
                {
                    MessageBox.Show("Cliente não encontrado !", "Cadastro de venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Atualiza variaveis de controle
                    lblNomeCliente.Text = String.Empty;
                    txtIdCliente.Text = String.Empty;

                    //Indica o foco habilidato
                    txtIdCliente.Focus();
                }
            }
        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtIdCliente.Text.Trim() == String.Empty)
            {
                lblNomeCliente.Text = String.Empty;
            }
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            frmPesquisar vol_Pesquisar = new frmPesquisar()
            {
                vcg_Pesquisa = "Clientes"
            };
            vol_Pesquisar.ShowDialog();
            vol_Pesquisar.Dispose();
            //Preenche itens da tela
            txtIdCliente.Text = (vol_Pesquisar.vig_Codigo > 0 ? Convert.ToString(Convert.ToInt16(vol_Pesquisar.vig_Codigo)) : String.Empty).PadLeft(3, '0');
            lblNomeCliente.Text = vol_Pesquisar.vcg_Descricao;

        }

        private void btnIncluirItem_Click(object sender, EventArgs e)
        {
            // Criando uma lista vazia de ItemVenda para passar para frmItemVendas
            List<ItemVenda> vol_ItemSelecionadoVenda = new List<ItemVenda>();

            //Preencher a lista vol_ItemSelecionadoVenda com os dados da ListView
            foreach (ListViewItem item in lvwItensVenda.Items)
            {
                ItemVenda itemVenda = new ItemVenda
                {
                    ProdutoId = Convert.ToInt32(item.SubItems[1].Text.Replace("R$", "").Replace(",", "").Trim()),          // ProdutoId
                    Quantidade = Convert.ToInt32(item.SubItems[3].Text.Replace("R$", "").Replace(",", "").Trim()),         // Quantidade
                    PrecoUnitario = Convert.ToDecimal(item.SubItems[4].Text),    // PrecoUnitario
                    PrecoTotal = Convert.ToDecimal(item.SubItems[5].Text),       // PrecoTotal
                    VendaId = Convert.ToInt32(item.SubItems[6].Text.Replace("R$", "").Replace(",", "").Trim()),            // VendaId
                    Id = Convert.ToInt32(item.SubItems[7].Text.Replace("R$", "").Replace(",", "").Trim()),                 // Id
                };

                vol_ItemSelecionadoVenda.Add(itemVenda);
            }

            //Objeto de acesso ao form
            frmItemVendas vol_ItemVendas = new frmItemVendas(vol_ItemSelecionadoVenda)
            {
                //Exibe a lista de produtos
            };
            vol_ItemVendas.ShowDialog();

            //Lista de ItemVenda selecionado
            List<ItemVenda> vol_ItemVenda = vol_ItemVendas.vol_ItemSelecionadoVenda;

            // Adiciona o ListViewItem ao ListView
            foreach (var item in vol_ItemVenda)
            {
                // Verifica se o ProdutoId já existe no ListView
                bool produtoIdExiste = false;
                foreach (ListViewItem listViewItemExistente in lvwItensVenda.Items)
                {
                    if (listViewItemExistente.SubItems[1].Text.PadLeft(3, '0') == item.ProdutoId.ToString("D3"))
                    {
                        produtoIdExiste = true;
                        break;
                    }
                }

                // Se o ProdutoId já existir, pular a adição
                if (produtoIdExiste)
                {
                    continue;
                }

                // Cria um ListViewItem para adicionar ao ListView
                ListViewItem listViewItem = new ListViewItem("");
                listViewItem.SubItems.Add(item.ProdutoId.ToString("D3")); // Coluna do ProdutoId 
                //
                // Variável de acesso a classe
                ProdutoDAL vol_DadosProdutos = new ProdutoDAL();
                // Seleciona o Produto
                List<Produto.ProdutoCons> vol_ListaProdutos = vol_DadosProdutos.SelecionarProdutos<Produto.ProdutoCons>(item.ProdutoId, "Cons", true);
                Produto? vol_Produtos = null; // Inicializa como nullable
                foreach (Produto.ProdutoCons vol_Item in vol_ListaProdutos)
                {
                    vol_Produtos = new Produto
                    {
                        Id = vol_Item.Id,
                        Descricao = vol_Item.Descricao
                    };
                    if (!String.IsNullOrEmpty(vol_Produtos.Descricao))
                        listViewItem.SubItems.Add(vol_Produtos.Descricao);
                    break; 
                }
                //
                listViewItem.SubItems.Add(item.Quantidade.ToString().Replace("R$", "").Replace(",", "").Trim());
                listViewItem.SubItems.Add(item.PrecoUnitario.ToString("F2")); 
                listViewItem.SubItems.Add(item.PrecoTotal.ToString("F2")); 
                listViewItem.SubItems.Add(item.VendaId.ToString("C").Replace("R$", "").Replace(",", "").Trim()); 
                listViewItem.SubItems.Add(item.Id.ToString("C").Replace("R$", "").Replace(",", "").Trim()); 

                // Adiciona o ListViewItem ao ListView
                lvwItensVenda.Items.Add(listViewItem);
            }

            // Calcula o Total da Venda
            decimal totalVenda = lvwItensVenda.Items.Cast<ListViewItem>().Sum(item => Convert.ToDecimal(item.SubItems[5].Text));

            // Define o texto formatado com duas casas decimais no lblTotalVenda
            lblTotalVenda.Text = totalVenda.ToString("F2");

            //Fechar form
            vol_ItemVendas.Dispose();

        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Excluir do produto da lista ?", "Confirme !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (vip_ItemLista >= 0 )
                {
                    // Obtém o ListViewItem selecionado na lvwItensVenda pelo índice
                    ListViewItem itemSelecionado = lvwItensVenda.Items[vip_ItemLista];

                    // Cria um novo ListViewItem para adicionar na lvwItemVendaExcluir
                    ListViewItem novoItem = new ListViewItem("");
                    novoItem.SubItems.Add(itemSelecionado.SubItems[7].Text); 

                    // Adiciona o novo item à lvwItemVendaExcluir
                    lvwItemVendaExcluir.Items.Add(novoItem);
                }

                vip_ItemLista = 0;
                //Remove da lista o item escolhido
                ListView.SelectedListViewItemCollection vil_items = lvwItensVenda.SelectedItems;
                foreach (ListViewItem item in vil_items) item.Remove();

                // Calcula o Total da Venda
                decimal totalVenda = lvwItensVenda.Items.Cast<ListViewItem>().Sum(item => Convert.ToDecimal(item.SubItems[5].Text));

                // Define o texto formatado com duas casas decimais no lblTotalVenda
                lblTotalVenda.Text = totalVenda.ToString("F2");

            }
        }

        private void lvwItensVenda_Click(object sender, EventArgs e)
        {
            //Guarda qual o item da lista a ser excluido
            vip_ItemLista = lvwItensVenda.SelectedIndices[0];
        }
        #endregion

        #region Métodos Privados
        //Valida campos de entrada do form
        private bool FP_ValidarCampos()
        {
            if (String.IsNullOrEmpty(txtIdCliente.Text))
            {
                MessageBox.Show("Informe o cliente da venda !", "Cadastro de Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdCliente.Focus();
                return false;
            }
            else if (lvwItensVenda.Items.Count <= 0)
            {
                MessageBox.Show("Informe um produto para a venda !", "Cadastro de Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lvwItensVenda.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtObservacao.Text))
            {
                MessageBox.Show("Informe uma observação para a venda !", "Cadastro de Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtObservacao.Focus();
                return false;
            }
            return true;
        }
        #endregion

    }
}