namespace ControleDeVendas.Presenters
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            mnsMain = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            configurarImpressoraToolStripMenuItem = new ToolStripMenuItem();
            encerrarSistemaToolStripMenuItem = new ToolStripMenuItem();
            tabelasToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            sspMain = new StatusStrip();
            pnlMenu = new Panel();
            btnVendas = new Button();
            btnHome = new Button();
            mnsSubMainVenda = new ContextMenuStrip(components);
            novaToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            pnlHome = new Panel();
            lblTProduto = new Label();
            lblTCliente = new Label();
            lblTVenda = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            lblTotalProdutos = new Label();
            lblTotalClientes = new Label();
            lblTotalVendas = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pnlVendas = new Panel();
            dgvVendas = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            data = new DataGridViewTextBoxColumn();
            cliente = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            pnlLocalizarVendas = new Panel();
            lblTipoVenda = new Label();
            cmbTipoVenda = new ComboBox();
            lblLocalizarVendas = new Label();
            txtLocalizarVenda = new TextBox();
            pnlMenuVendas = new Panel();
            lblFiltroVenda = new Label();
            lblVenda = new Label();
            ptbMenuVendas = new PictureBox();
            mnsMain.SuspendLayout();
            pnlMenu.SuspendLayout();
            mnsSubMainVenda.SuspendLayout();
            pnlHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVendas).BeginInit();
            pnlLocalizarVendas.SuspendLayout();
            pnlMenuVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbMenuVendas).BeginInit();
            SuspendLayout();
            // 
            // mnsMain
            // 
            mnsMain.BackColor = SystemColors.ControlLight;
            mnsMain.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, tabelasToolStripMenuItem });
            mnsMain.Location = new Point(0, 0);
            mnsMain.Name = "mnsMain";
            mnsMain.Size = new Size(1370, 24);
            mnsMain.TabIndex = 2;
            mnsMain.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { configurarImpressoraToolStripMenuItem, encerrarSistemaToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // configurarImpressoraToolStripMenuItem
            // 
            configurarImpressoraToolStripMenuItem.Name = "configurarImpressoraToolStripMenuItem";
            configurarImpressoraToolStripMenuItem.Size = new Size(192, 22);
            configurarImpressoraToolStripMenuItem.Text = "Configurar Impressora";
            // 
            // encerrarSistemaToolStripMenuItem
            // 
            encerrarSistemaToolStripMenuItem.Name = "encerrarSistemaToolStripMenuItem";
            encerrarSistemaToolStripMenuItem.Size = new Size(192, 22);
            encerrarSistemaToolStripMenuItem.Text = "Encerrar Sistema";
            // 
            // tabelasToolStripMenuItem
            // 
            tabelasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { produtosToolStripMenuItem, clientesToolStripMenuItem });
            tabelasToolStripMenuItem.Name = "tabelasToolStripMenuItem";
            tabelasToolStripMenuItem.Size = new Size(57, 20);
            tabelasToolStripMenuItem.Text = "Tabelas";
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(122, 22);
            produtosToolStripMenuItem.Text = "Produtos";
            produtosToolStripMenuItem.Click += produtosToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(122, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // sspMain
            // 
            sspMain.Location = new Point(0, 589);
            sspMain.Name = "sspMain";
            sspMain.Size = new Size(1370, 22);
            sspMain.TabIndex = 4;
            sspMain.Text = "statusStrip1";
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = SystemColors.ControlDark;
            pnlMenu.Controls.Add(btnVendas);
            pnlMenu.Controls.Add(btnHome);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 24);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(200, 565);
            pnlMenu.TabIndex = 5;
            // 
            // btnVendas
            // 
            btnVendas.Dock = DockStyle.Top;
            btnVendas.FlatAppearance.BorderColor = Color.Indigo;
            btnVendas.FlatAppearance.BorderSize = 0;
            btnVendas.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnVendas.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnVendas.FlatStyle = FlatStyle.Flat;
            btnVendas.Font = new Font("Verdana", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnVendas.ForeColor = Color.White;
            btnVendas.Image = (Image)resources.GetObject("btnVendas.Image");
            btnVendas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVendas.Location = new Point(0, 62);
            btnVendas.Name = "btnVendas";
            btnVendas.Padding = new Padding(10, 0, 0, 0);
            btnVendas.Size = new Size(200, 62);
            btnVendas.TabIndex = 2;
            btnVendas.Text = " Vendas";
            btnVendas.TextAlign = ContentAlignment.MiddleLeft;
            btnVendas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVendas.UseVisualStyleBackColor = false;
            btnVendas.Click += btnVendas_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderColor = Color.Indigo;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnHome.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Verdana", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(10, 0, 0, 0);
            btnHome.Size = new Size(200, 62);
            btnHome.TabIndex = 1;
            btnHome.Text = " Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // mnsSubMainVenda
            // 
            mnsSubMainVenda.Items.AddRange(new ToolStripItem[] { novaToolStripMenuItem, toolStripSeparator1 });
            mnsSubMainVenda.Name = "mnsSubMainVenda";
            mnsSubMainVenda.Size = new Size(136, 32);
            // 
            // novaToolStripMenuItem
            // 
            novaToolStripMenuItem.Name = "novaToolStripMenuItem";
            novaToolStripMenuItem.Size = new Size(135, 22);
            novaToolStripMenuItem.Text = "Venda nova";
            novaToolStripMenuItem.Click += novaToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(132, 6);
            // 
            // pnlHome
            // 
            pnlHome.Controls.Add(lblTProduto);
            pnlHome.Controls.Add(lblTCliente);
            pnlHome.Controls.Add(lblTVenda);
            pnlHome.Controls.Add(pictureBox4);
            pnlHome.Controls.Add(pictureBox3);
            pnlHome.Controls.Add(lblTotalProdutos);
            pnlHome.Controls.Add(lblTotalClientes);
            pnlHome.Controls.Add(lblTotalVendas);
            pnlHome.Controls.Add(pictureBox2);
            pnlHome.Controls.Add(pictureBox1);
            pnlHome.Controls.Add(label7);
            pnlHome.Controls.Add(label6);
            pnlHome.Controls.Add(label5);
            pnlHome.Controls.Add(label4);
            pnlHome.Controls.Add(label3);
            pnlHome.Controls.Add(label2);
            pnlHome.Controls.Add(label1);
            pnlHome.Location = new Point(239, 45);
            pnlHome.Name = "pnlHome";
            pnlHome.Size = new Size(671, 528);
            pnlHome.TabIndex = 7;
            pnlHome.Visible = false;
            // 
            // lblTProduto
            // 
            lblTProduto.AutoSize = true;
            lblTProduto.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTProduto.ForeColor = SystemColors.ControlDarkDark;
            lblTProduto.Location = new Point(543, 221);
            lblTProduto.Name = "lblTProduto";
            lblTProduto.Size = new Size(19, 18);
            lblTProduto.TabIndex = 21;
            lblTProduto.Text = "0";
            lblTProduto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTCliente
            // 
            lblTCliente.AutoSize = true;
            lblTCliente.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTCliente.ForeColor = SystemColors.ControlDarkDark;
            lblTCliente.Location = new Point(543, 165);
            lblTCliente.Name = "lblTCliente";
            lblTCliente.Size = new Size(19, 18);
            lblTCliente.TabIndex = 20;
            lblTCliente.Text = "0";
            lblTCliente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTVenda
            // 
            lblTVenda.AutoSize = true;
            lblTVenda.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTVenda.ForeColor = SystemColors.ControlDarkDark;
            lblTVenda.Location = new Point(543, 104);
            lblTVenda.Name = "lblTVenda";
            lblTVenda.Size = new Size(19, 18);
            lblTVenda.TabIndex = 19;
            lblTVenda.Text = "0";
            lblTVenda.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(316, 217);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(38, 26);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(316, 161);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // lblTotalProdutos
            // 
            lblTotalProdutos.AutoSize = true;
            lblTotalProdutos.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalProdutos.ForeColor = SystemColors.ControlDarkDark;
            lblTotalProdutos.Location = new Point(357, 221);
            lblTotalProdutos.Name = "lblTotalProdutos";
            lblTotalProdutos.Size = new Size(164, 18);
            lblTotalProdutos.TabIndex = 16;
            lblTotalProdutos.Text = "Total de produtos";
            // 
            // lblTotalClientes
            // 
            lblTotalClientes.AutoSize = true;
            lblTotalClientes.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalClientes.ForeColor = SystemColors.ControlDarkDark;
            lblTotalClientes.Location = new Point(357, 165);
            lblTotalClientes.Name = "lblTotalClientes";
            lblTotalClientes.Size = new Size(151, 18);
            lblTotalClientes.TabIndex = 15;
            lblTotalClientes.Text = "Total de clientes";
            // 
            // lblTotalVendas
            // 
            lblTotalVendas.AutoSize = true;
            lblTotalVendas.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalVendas.ForeColor = SystemColors.ControlDarkDark;
            lblTotalVendas.Location = new Point(357, 104);
            lblTotalVendas.Name = "lblTotalVendas";
            lblTotalVendas.Size = new Size(148, 18);
            lblTotalVendas.TabIndex = 14;
            lblTotalVendas.Text = "Total de vendas";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(316, 100);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 268);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.BackColor = Color.Black;
            label7.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(309, 488);
            label7.Name = "label7";
            label7.Size = new Size(99, 17);
            label7.TabIndex = 9;
            label7.Text = "DeMaria";
            // 
            // label6
            // 
            label6.BackColor = Color.Black;
            label6.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(309, 474);
            label6.Name = "label6";
            label6.Size = new Size(99, 12);
            label6.TabIndex = 8;
            label6.Text = "DESAFIO";
            // 
            // label5
            // 
            label5.BackColor = Color.Black;
            label5.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(309, 469);
            label5.Name = "label5";
            label5.Size = new Size(99, 40);
            label5.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(281, 469);
            label4.Name = "label4";
            label4.Size = new Size(28, 40);
            label4.TabIndex = 6;
            label4.Text = "I";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(52, 469);
            label3.Name = "label3";
            label3.Size = new Size(229, 40);
            label3.TabIndex = 5;
            label3.Text = "EDMUR DEV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(46, 373);
            label2.Name = "label2";
            label2.Size = new Size(226, 33);
            label2.TabIndex = 4;
            label2.Text = "ESTATÍSTICAS";
            // 
            // label1
            // 
            label1.Font = new Font("Russo One", 39.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(38, 404);
            label1.Name = "label1";
            label1.Size = new Size(659, 57);
            label1.TabIndex = 2;
            label1.Text = "CONTROLE DE VENDAS";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlVendas
            // 
            pnlVendas.Controls.Add(dgvVendas);
            pnlVendas.Controls.Add(pnlLocalizarVendas);
            pnlVendas.Controls.Add(pnlMenuVendas);
            pnlVendas.Location = new Point(444, 45);
            pnlVendas.Name = "pnlVendas";
            pnlVendas.Size = new Size(186, 528);
            pnlVendas.TabIndex = 8;
            pnlVendas.Visible = false;
            // 
            // dgvVendas
            // 
            dgvVendas.AllowUserToAddRows = false;
            dgvVendas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
            dgvVendas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVendas.Columns.AddRange(new DataGridViewColumn[] { id, data, cliente, total, status });
            dgvVendas.Dock = DockStyle.Fill;
            dgvVendas.Location = new Point(0, 64);
            dgvVendas.Name = "dgvVendas";
            dgvVendas.ReadOnly = true;
            dgvVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVendas.Size = new Size(186, 464);
            dgvVendas.TabIndex = 4;
            dgvVendas.DoubleClick += dgvVendas_DoubleClick;
            dgvVendas.MouseDown += dgvVendas_MouseDown;
            // 
            // id
            // 
            id.HeaderText = "Venda";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // data
            // 
            data.HeaderText = "Data";
            data.Name = "data";
            data.ReadOnly = true;
            data.Width = 150;
            // 
            // cliente
            // 
            cliente.HeaderText = "Cliente";
            cliente.Name = "cliente";
            cliente.ReadOnly = true;
            cliente.Width = 366;
            // 
            // total
            // 
            total.HeaderText = "Total";
            total.Name = "total";
            total.ReadOnly = true;
            total.Width = 200;
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.Name = "status";
            status.ReadOnly = true;
            status.Width = 200;
            // 
            // pnlLocalizarVendas
            // 
            pnlLocalizarVendas.BorderStyle = BorderStyle.FixedSingle;
            pnlLocalizarVendas.Controls.Add(lblTipoVenda);
            pnlLocalizarVendas.Controls.Add(cmbTipoVenda);
            pnlLocalizarVendas.Controls.Add(lblLocalizarVendas);
            pnlLocalizarVendas.Controls.Add(txtLocalizarVenda);
            pnlLocalizarVendas.Dock = DockStyle.Top;
            pnlLocalizarVendas.Location = new Point(0, 30);
            pnlLocalizarVendas.Name = "pnlLocalizarVendas";
            pnlLocalizarVendas.Size = new Size(186, 34);
            pnlLocalizarVendas.TabIndex = 2;
            // 
            // lblTipoVenda
            // 
            lblTipoVenda.AutoSize = true;
            lblTipoVenda.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoVenda.ForeColor = SystemColors.ControlText;
            lblTipoVenda.Location = new Point(407, 8);
            lblTipoVenda.Name = "lblTipoVenda";
            lblTipoVenda.Size = new Size(34, 15);
            lblTipoVenda.TabIndex = 291;
            lblTipoVenda.Text = "Tipo:";
            // 
            // cmbTipoVenda
            // 
            cmbTipoVenda.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoVenda.FormattingEnabled = true;
            cmbTipoVenda.Items.AddRange(new object[] { "Venda", "Cliente", "Data" });
            cmbTipoVenda.Location = new Point(447, 5);
            cmbTipoVenda.Name = "cmbTipoVenda";
            cmbTipoVenda.Size = new Size(102, 23);
            cmbTipoVenda.TabIndex = 4;
            cmbTipoVenda.SelectedIndexChanged += cmbTipoVenda_SelectedIndexChanged;
            // 
            // lblLocalizarVendas
            // 
            lblLocalizarVendas.AutoSize = true;
            lblLocalizarVendas.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblLocalizarVendas.Location = new Point(3, 8);
            lblLocalizarVendas.Name = "lblLocalizarVendas";
            lblLocalizarVendas.Size = new Size(67, 14);
            lblLocalizarVendas.TabIndex = 2;
            lblLocalizarVendas.Text = "Localizar:";
            // 
            // txtLocalizarVenda
            // 
            txtLocalizarVenda.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtLocalizarVenda.Location = new Point(76, 5);
            txtLocalizarVenda.MaxLength = 30;
            txtLocalizarVenda.Name = "txtLocalizarVenda";
            txtLocalizarVenda.Size = new Size(307, 22);
            txtLocalizarVenda.TabIndex = 3;
            // 
            // pnlMenuVendas
            // 
            pnlMenuVendas.BackColor = SystemColors.ControlLightLight;
            pnlMenuVendas.Controls.Add(lblFiltroVenda);
            pnlMenuVendas.Controls.Add(lblVenda);
            pnlMenuVendas.Controls.Add(ptbMenuVendas);
            pnlMenuVendas.Dock = DockStyle.Top;
            pnlMenuVendas.Location = new Point(0, 0);
            pnlMenuVendas.Name = "pnlMenuVendas";
            pnlMenuVendas.Size = new Size(186, 30);
            pnlMenuVendas.TabIndex = 1;
            // 
            // lblFiltroVenda
            // 
            lblFiltroVenda.AutoSize = true;
            lblFiltroVenda.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFiltroVenda.ForeColor = Color.Brown;
            lblFiltroVenda.Location = new Point(87, 7);
            lblFiltroVenda.Name = "lblFiltroVenda";
            lblFiltroVenda.Size = new Size(170, 17);
            lblFiltroVenda.TabIndex = 4;
            lblFiltroVenda.Text = "Nenhum item selecionado";
            // 
            // lblVenda
            // 
            lblVenda.AutoSize = true;
            lblVenda.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblVenda.Location = new Point(3, 9);
            lblVenda.Name = "lblVenda";
            lblVenda.Size = new Size(55, 14);
            lblVenda.TabIndex = 3;
            lblVenda.Text = "Vendas";
            // 
            // ptbMenuVendas
            // 
            ptbMenuVendas.ContextMenuStrip = mnsSubMainVenda;
            ptbMenuVendas.Image = (Image)resources.GetObject("ptbMenuVendas.Image");
            ptbMenuVendas.Location = new Point(46, 3);
            ptbMenuVendas.Name = "ptbMenuVendas";
            ptbMenuVendas.Size = new Size(40, 25);
            ptbMenuVendas.SizeMode = PictureBoxSizeMode.Zoom;
            ptbMenuVendas.TabIndex = 2;
            ptbMenuVendas.TabStop = false;
            ptbMenuVendas.Click += ptbMenuVendas_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 611);
            Controls.Add(pnlHome);
            Controls.Add(pnlVendas);
            Controls.Add(pnlMenu);
            Controls.Add(sspMain);
            Controls.Add(mnsMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mnsMain;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Vendas";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            mnsMain.ResumeLayout(false);
            mnsMain.PerformLayout();
            pnlMenu.ResumeLayout(false);
            mnsSubMainVenda.ResumeLayout(false);
            pnlHome.ResumeLayout(false);
            pnlHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlVendas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVendas).EndInit();
            pnlLocalizarVendas.ResumeLayout(false);
            pnlLocalizarVendas.PerformLayout();
            pnlMenuVendas.ResumeLayout(false);
            pnlMenuVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbMenuVendas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip mnsMain;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem configurarImpressoraToolStripMenuItem;
        private ToolStripMenuItem encerrarSistemaToolStripMenuItem;
        private ToolStripMenuItem tabelasToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private StatusStrip sspMain;
        private Panel pnlMenu;
        private Button btnVendas;
        private Button btnHome;
        private ContextMenuStrip mnsSubMainVenda;
        private ToolStripMenuItem novaToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private Panel pnlHome;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel pnlVendas;
        private Panel pnlLocalizarVendas;
        private Label lblLocalizarVendas;
        private TextBox txtLocalizarVenda;
        private Panel pnlMenuVendas;
        private Label lblVenda;
        private PictureBox ptbMenuVendas;
        private Label lblFiltroVenda;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblTotalVendas;
        private Label lblTotalProdutos;
        private Label lblTotalClientes;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label lblTipoVenda;
        private ComboBox cmbTipoVenda;
        private DataGridView dgvVendas;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn data;
        private DataGridViewTextBoxColumn cliente;
        private DataGridViewTextBoxColumn total;
        private DataGridViewTextBoxColumn status;
        private Label lblTVenda;
        private Label lblTProduto;
        private Label lblTCliente;
    }
}