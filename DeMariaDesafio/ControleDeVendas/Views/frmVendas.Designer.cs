namespace ControleDeVendas.Views
{
    partial class frmVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendas));
            lblIdVenda = new Label();
            pctIcone = new PictureBox();
            lblTitulo = new Label();
            pctBarra = new PictureBox();
            pctBarra1 = new PictureBox();
            dtpDataVenda = new DateTimePicker();
            lblData = new Label();
            lblCliente = new Label();
            txtIdCliente = new TextBox();
            btnPesquisarCliente = new Button();
            gpbItensVenda = new GroupBox();
            lvwItensVenda = new ListView();
            columnHeader25 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            btnFechar = new Button();
            btnGravar = new Button();
            btnExcluir = new Button();
            lblNomeCliente = new Label();
            btnExcluirItem = new Button();
            btnIncluirItem = new Button();
            btnImprimir = new Button();
            lblTotalVenda = new Label();
            lblTotal = new Label();
            gpbObservacao = new GroupBox();
            txtObservacao = new TextBox();
            lvwItemVendaExcluir = new ListView();
            ((System.ComponentModel.ISupportInitialize)pctIcone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctBarra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctBarra1).BeginInit();
            gpbItensVenda.SuspendLayout();
            gpbObservacao.SuspendLayout();
            SuspendLayout();
            // 
            // lblIdVenda
            // 
            lblIdVenda.BackColor = Color.FromArgb(224, 224, 224);
            lblIdVenda.BorderStyle = BorderStyle.Fixed3D;
            lblIdVenda.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdVenda.ForeColor = Color.Black;
            lblIdVenda.Location = new Point(70, 11);
            lblIdVenda.Name = "lblIdVenda";
            lblIdVenda.Size = new Size(60, 21);
            lblIdVenda.TabIndex = 0;
            lblIdVenda.Text = "0";
            lblIdVenda.TextAlign = ContentAlignment.MiddleCenter;
            lblIdVenda.Visible = false;
            // 
            // pctIcone
            // 
            pctIcone.BackColor = Color.Transparent;
            pctIcone.Image = (Image)resources.GetObject("pctIcone.Image");
            pctIcone.Location = new Point(5, 8);
            pctIcone.Name = "pctIcone";
            pctIcone.Size = new Size(32, 32);
            pctIcone.SizeMode = PictureBoxSizeMode.AutoSize;
            pctIcone.TabIndex = 103;
            pctIcone.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(597, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(183, 23);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Venda";
            lblTitulo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pctBarra
            // 
            pctBarra.Image = (Image)resources.GetObject("pctBarra.Image");
            pctBarra.Location = new Point(-1, -2);
            pctBarra.Name = "pctBarra";
            pctBarra.Size = new Size(473, 50);
            pctBarra.SizeMode = PictureBoxSizeMode.StretchImage;
            pctBarra.TabIndex = 102;
            pctBarra.TabStop = false;
            // 
            // pctBarra1
            // 
            pctBarra1.Image = (Image)resources.GetObject("pctBarra1.Image");
            pctBarra1.Location = new Point(450, -2);
            pctBarra1.Name = "pctBarra1";
            pctBarra1.Size = new Size(473, 50);
            pctBarra1.SizeMode = PictureBoxSizeMode.StretchImage;
            pctBarra1.TabIndex = 104;
            pctBarra1.TabStop = false;
            // 
            // dtpDataVenda
            // 
            dtpDataVenda.Format = DateTimePickerFormat.Short;
            dtpDataVenda.Location = new Point(69, 58);
            dtpDataVenda.Name = "dtpDataVenda";
            dtpDataVenda.Size = new Size(103, 23);
            dtpDataVenda.TabIndex = 2;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(14, 65);
            lblData.Name = "lblData";
            lblData.Size = new Size(34, 15);
            lblData.TabIndex = 106;
            lblData.Text = "Data:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(14, 99);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 107;
            lblCliente.Text = "Cliente:";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(69, 93);
            txtIdCliente.MaxLength = 3;
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(103, 23);
            txtIdCliente.TabIndex = 3;
            txtIdCliente.TextAlign = HorizontalAlignment.Center;
            txtIdCliente.TextChanged += txtIdCliente_TextChanged;
            txtIdCliente.KeyDown += txtIdCliente_KeyDown;
            txtIdCliente.KeyPress += txtIdCliente_KeyPress;
            txtIdCliente.Leave += txtIdCliente_Leave;
            // 
            // btnPesquisarCliente
            // 
            btnPesquisarCliente.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPesquisarCliente.Location = new Point(143, 94);
            btnPesquisarCliente.Name = "btnPesquisarCliente";
            btnPesquisarCliente.Size = new Size(29, 21);
            btnPesquisarCliente.TabIndex = 4;
            btnPesquisarCliente.Text = "...";
            btnPesquisarCliente.UseVisualStyleBackColor = true;
            btnPesquisarCliente.Click += btnPesquisarCliente_Click;
            // 
            // gpbItensVenda
            // 
            gpbItensVenda.Controls.Add(lvwItensVenda);
            gpbItensVenda.Location = new Point(6, 124);
            gpbItensVenda.Margin = new Padding(4, 3, 4, 3);
            gpbItensVenda.Name = "gpbItensVenda";
            gpbItensVenda.Padding = new Padding(4, 3, 4, 3);
            gpbItensVenda.Size = new Size(779, 281);
            gpbItensVenda.TabIndex = 8;
            gpbItensVenda.TabStop = false;
            gpbItensVenda.Text = " Itens ";
            // 
            // lvwItensVenda
            // 
            lvwItensVenda.Columns.AddRange(new ColumnHeader[] { columnHeader25, columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader7, columnHeader8 });
            lvwItensVenda.FullRowSelect = true;
            lvwItensVenda.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvwItensVenda.Location = new Point(9, 20);
            lvwItensVenda.Margin = new Padding(4, 3, 4, 3);
            lvwItensVenda.Name = "lvwItensVenda";
            lvwItensVenda.Size = new Size(759, 249);
            lvwItensVenda.TabIndex = 9;
            lvwItensVenda.UseCompatibleStateImageBehavior = false;
            lvwItensVenda.View = View.Details;
            lvwItensVenda.Click += lvwItensVenda_Click;
            // 
            // columnHeader25
            // 
            columnHeader25.DisplayIndex = 5;
            columnHeader25.Text = "";
            columnHeader25.Width = 0;
            // 
            // columnHeader1
            // 
            columnHeader1.DisplayIndex = 0;
            columnHeader1.Text = "Produto";
            columnHeader1.TextAlign = HorizontalAlignment.Center;
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.DisplayIndex = 1;
            columnHeader2.Text = "Descrição";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 260;
            // 
            // columnHeader3
            // 
            columnHeader3.DisplayIndex = 2;
            columnHeader3.Text = "Qtde.";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.DisplayIndex = 3;
            columnHeader4.Text = "Valor Unitário";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            columnHeader5.DisplayIndex = 4;
            columnHeader5.Text = "Valor Total";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 140;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "IdItemVenda";
            columnHeader7.Width = 0;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "IdVenda";
            columnHeader8.Width = 0;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(718, 525);
            btnFechar.Margin = new Padding(4, 3, 4, 3);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(65, 25);
            btnFechar.TabIndex = 15;
            btnFechar.TabStop = false;
            btnFechar.Text = "&Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(654, 525);
            btnGravar.Margin = new Padding(4, 3, 4, 3);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(65, 25);
            btnGravar.TabIndex = 14;
            btnGravar.TabStop = false;
            btnGravar.Text = "&Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(589, 525);
            btnExcluir.Margin = new Padding(4, 3, 4, 3);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(65, 25);
            btnExcluir.TabIndex = 13;
            btnExcluir.TabStop = false;
            btnExcluir.Text = "&Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.BackColor = Color.FromArgb(224, 224, 224);
            lblNomeCliente.BorderStyle = BorderStyle.Fixed3D;
            lblNomeCliente.Location = new Point(178, 94);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(400, 23);
            lblNomeCliente.TabIndex = 5;
            // 
            // btnExcluirItem
            // 
            btnExcluirItem.Location = new Point(680, 92);
            btnExcluirItem.Margin = new Padding(4, 3, 4, 3);
            btnExcluirItem.Name = "btnExcluirItem";
            btnExcluirItem.Size = new Size(94, 25);
            btnExcluirItem.TabIndex = 7;
            btnExcluirItem.TabStop = false;
            btnExcluirItem.Text = "&Excluir item";
            btnExcluirItem.UseVisualStyleBackColor = true;
            btnExcluirItem.Click += btnExcluirItem_Click;
            // 
            // btnIncluirItem
            // 
            btnIncluirItem.Location = new Point(585, 92);
            btnIncluirItem.Margin = new Padding(4, 3, 4, 3);
            btnIncluirItem.Name = "btnIncluirItem";
            btnIncluirItem.Size = new Size(94, 25);
            btnIncluirItem.TabIndex = 6;
            btnIncluirItem.TabStop = false;
            btnIncluirItem.Text = "&Incluir item";
            btnIncluirItem.UseVisualStyleBackColor = true;
            btnIncluirItem.Click += btnIncluirItem_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(5, 525);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(65, 25);
            btnImprimir.TabIndex = 12;
            btnImprimir.TabStop = false;
            btnImprimir.Text = "&Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // lblTotalVenda
            // 
            lblTotalVenda.BackColor = Color.FromArgb(224, 224, 224);
            lblTotalVenda.BorderStyle = BorderStyle.Fixed3D;
            lblTotalVenda.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalVenda.Location = new Point(585, 58);
            lblTotalVenda.Name = "lblTotalVenda";
            lblTotalVenda.Size = new Size(189, 23);
            lblTotalVenda.TabIndex = 108;
            lblTotalVenda.Text = "0,00";
            lblTotalVenda.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(542, 61);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(37, 15);
            lblTotal.TabIndex = 109;
            lblTotal.Text = "Total:";
            // 
            // gpbObservacao
            // 
            gpbObservacao.Controls.Add(txtObservacao);
            gpbObservacao.Location = new Point(7, 399);
            gpbObservacao.Margin = new Padding(4, 3, 4, 3);
            gpbObservacao.Name = "gpbObservacao";
            gpbObservacao.Padding = new Padding(4, 3, 4, 3);
            gpbObservacao.Size = new Size(779, 120);
            gpbObservacao.TabIndex = 10;
            gpbObservacao.TabStop = false;
            gpbObservacao.Text = " Observação ";
            // 
            // txtObservacao
            // 
            txtObservacao.Location = new Point(7, 19);
            txtObservacao.MaxLength = 200;
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(760, 84);
            txtObservacao.TabIndex = 11;
            // 
            // lvwItemVendaExcluir
            // 
            lvwItemVendaExcluir.FullRowSelect = true;
            lvwItemVendaExcluir.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvwItemVendaExcluir.Location = new Point(572, 8);
            lvwItemVendaExcluir.Margin = new Padding(4, 3, 4, 3);
            lvwItemVendaExcluir.Name = "lvwItemVendaExcluir";
            lvwItemVendaExcluir.Size = new Size(18, 29);
            lvwItemVendaExcluir.TabIndex = 110;
            lvwItemVendaExcluir.UseCompatibleStateImageBehavior = false;
            lvwItemVendaExcluir.View = View.Details;
            lvwItemVendaExcluir.Visible = false;
            // 
            // frmVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 559);
            Controls.Add(lvwItemVendaExcluir);
            Controls.Add(gpbObservacao);
            Controls.Add(lblTotal);
            Controls.Add(lblTotalVenda);
            Controls.Add(btnImprimir);
            Controls.Add(btnExcluirItem);
            Controls.Add(btnIncluirItem);
            Controls.Add(lblNomeCliente);
            Controls.Add(gpbItensVenda);
            Controls.Add(btnFechar);
            Controls.Add(btnGravar);
            Controls.Add(btnExcluir);
            Controls.Add(btnPesquisarCliente);
            Controls.Add(txtIdCliente);
            Controls.Add(lblCliente);
            Controls.Add(lblData);
            Controls.Add(dtpDataVenda);
            Controls.Add(lblTitulo);
            Controls.Add(pctBarra1);
            Controls.Add(lblIdVenda);
            Controls.Add(pctIcone);
            Controls.Add(pctBarra);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmVendas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Venda";
            Load += frmVendas_Load;
            KeyDown += frmVendas_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pctIcone).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctBarra).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctBarra1).EndInit();
            gpbItensVenda.ResumeLayout(false);
            gpbObservacao.ResumeLayout(false);
            gpbObservacao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdVenda;
        internal PictureBox pctIcone;
        internal Label lblTitulo;
        internal PictureBox pctBarra;
        internal PictureBox pctBarra1;
        private DateTimePicker dtpDataVenda;
        private Label lblData;
        private Label lblCliente;
        private TextBox txtIdCliente;
        private Button btnPesquisarCliente;
        private GroupBox gpbItensVenda;
        internal ListView lvwItensVenda;
        private ColumnHeader columnHeader25;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Button btnFechar;
        private Button btnGravar;
        private Button btnExcluir;
        private Label lblNomeCliente;
        private Button btnExcluirItem;
        private Button btnIncluirItem;
        private Button btnImprimir;
        private Label lblTotalVenda;
        private Label lblTotal;
        private GroupBox gpbObservacao;
        private TextBox txtObservacao;
        internal ListView lvwItemVendaExcluir;
    }
}