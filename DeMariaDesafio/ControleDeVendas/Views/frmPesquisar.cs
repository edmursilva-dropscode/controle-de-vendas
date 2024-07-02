using ControleDeVendas.BusinessLogicLayer;
using ControleDeVendas.Services;

namespace ControleDeVendas.Views
{
    public partial class frmPesquisar : Form
    {
        #region Variáveis
        //Variáveis públicas
        public string vcg_Pesquisa = String.Empty;
        public Int32 vig_Codigo = 0;
        public string vcg_Descricao = String.Empty;
        public int vig_sortColumn = -1;
        //Objetos de classe
        PesquisarBLL? vol_NegocioPesquisar = null;
        #endregion

        #region Form
        public frmPesquisar()
        {
            InitializeComponent();
        }

        private void frmPesquisar_Load(object sender, EventArgs e)
        {
            //Altera a cor de fundo do form
            this.BackColor = Color.FromArgb(231, 234, 244);
            //Adiciona o controle label do título a da imagem da barra
            pctBarra.Controls.Add(lblTitulo);
            //Adiciona o controle imagem do icone a da imagem da barra
            pctBarra.Controls.Add(pctIcone);
            //Seleciona o radCodigo
            radCodigo.Checked = true;
            //Realiza pesquisa conforme parâmetro
            this.FP_Editar(vcg_Pesquisa);
        }

        private void frmPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.btnFechar_Click(sender, e);
            }
        }

        private void frmPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Digita somente letras ou números
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                return;
            }
        }
        #endregion

        #region Controles
        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (lvwPesquisa.Items.Count > 0 && lvwPesquisa.SelectedItems.Count > 0)
            {
                vig_Codigo = Convert.ToInt32(lvwPesquisa.SelectedItems[0].SubItems[0].Text);
                vcg_Descricao = Convert.ToString(lvwPesquisa.SelectedItems[0].SubItems[1].Text);
                this.btnFechar_Click(sender, e);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnSelecionar_Click(sender, e);
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.btnFechar_Click(sender, e);
            }
        }
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Digita apenas numeros
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && radCodigo.Checked)
            {
                e.Handled = true;
            }
            //Digita apenas letras
            else if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)32 && e.KeyChar != (char)8 && radDescricao.Checked)
            {
                e.Handled = true;
            }
        }
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNome.Text))
            {
                return;
            }

            if (radDescricao.Checked && Char.IsLetter(txtNome.Text, txtNome.Text.Length - 1))
            {
                //Variáveis private
                String vcl_Descricao;

                for (int vil_Count = 0; vil_Count < lvwPesquisa.Items.Count; vil_Count++)
                {
                    Int32 vil_ItemLength = (txtNome.Text.Length > lvwPesquisa.Items[vil_Count].SubItems[1].Text.Length ? lvwPesquisa.Items[vil_Count].SubItems[1].Text.Length : txtNome.Text.Length);
                    vcl_Descricao = lvwPesquisa.Items[vil_Count].SubItems[1].Text.Substring(0, vil_ItemLength);
                    if (txtNome.Text.ToUpper() == vcl_Descricao.ToUpper())
                    {
                        //Focaliza a lista e o item encontrado
                        lvwPesquisa.Items[vil_Count].Selected = true;
                        //Define o foco no controle Listview
                        lvwPesquisa.Focus();
                        //Assegura que se o item estiver em uma parte não visível ele será exibido
                        lvwPesquisa.EnsureVisible(vil_Count);
                        return;
                    }
                }
            }
            else if (radCodigo.Checked && Char.IsDigit(txtNome.Text, txtNome.Text.Length - 1))
            {
                //Variaveis private
                String vcl_Codigo;
                for (int vil_Count = 0; vil_Count < lvwPesquisa.Items.Count; vil_Count++)
                {
                    vcl_Codigo = Convert.ToString(lvwPesquisa.Items[vil_Count].SubItems[0].Text);
                    if (Convert.ToString(txtNome.Text) == vcl_Codigo)
                    {
                        //Focaliza a lista e o item encontrado
                        lvwPesquisa.Items[vil_Count].Selected = true;
                        //Define o foco no controle Listview
                        lvwPesquisa.Focus();
                        //Assegura que se o item estiver em uma parte não visível ele será exibido
                        lvwPesquisa.EnsureVisible(vil_Count);
                        return;
                    }
                }
            }
        }

        private void radCodigo_CheckedChanged(object sender, EventArgs e)
        {
            lblMensagem.Text = "Digite o código a ser localizado";
            txtNome.Focus();
            //
            vig_sortColumn = 0;
            lvwPesquisa.Sorting = SortOrder.Ascending;
            lvwPesquisa.Sort();
            lvwPesquisa.ListViewItemSorter = new ListViewItemComparer(vig_sortColumn, lvwPesquisa.Sorting);
        }
        private void radDescricao_CheckedChanged(object sender, EventArgs e)
        {
            lblMensagem.Text = "Digite parte da descrição a ser localizado";
            txtNome.Focus();
            //
            vig_sortColumn = 1;
            lvwPesquisa.Sorting = SortOrder.Ascending;
            lvwPesquisa.Sort();
            lvwPesquisa.ListViewItemSorter = new ListViewItemComparer(vig_sortColumn, lvwPesquisa.Sorting);
        }
                private void lvwPesquisa_DoubleClick(object sender, EventArgs e)
        {
            btnSelecionar_Click(sender, e);
        }

        private void lvwPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.btnFechar_Click(sender, e);
            }
        }
        #endregion

        #region Métodos Privados
        private void FP_Editar(string pPesquisa)
        {
            try
            {
                //Inicializa objeto
                vol_NegocioPesquisar = new PesquisarBLL();
                //Seleciona tipo de pesquisa
                switch (pPesquisa)
                {
                    case "Produtos":
                        lblTitulo.Text = pPesquisa;
                        lvwPesquisa.Columns[1].Text = pPesquisa;
                        this.Text = "Pesquisa de Produtos";
                        vol_NegocioPesquisar.ListarProdutos(lvwPesquisa);
                        break;
                    case "Clientes":
                        lblTitulo.Text = pPesquisa;
                        lvwPesquisa.Columns[1].Text = pPesquisa;
                        this.Text = "Pesquisa de Clientes";
                        vol_NegocioPesquisar.ListarClientes(lvwPesquisa);
                        break;
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
