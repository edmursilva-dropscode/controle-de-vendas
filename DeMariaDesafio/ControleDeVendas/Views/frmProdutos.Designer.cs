namespace ControleDeVendas.Views
{
    partial class frmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            lblIdProduto = new Label();
            pctIcone = new PictureBox();
            lblTitulo = new Label();
            pctBarra = new PictureBox();
            lblDataCadastro = new Label();
            lblData = new Label();
            lblStatus = new Label();
            radNaoAtivo = new RadioButton();
            radAtivo = new RadioButton();
            txtPreco = new TextBox();
            lblPreco = new Label();
            txtDescricao = new TextBox();
            lblDescricao = new Label();
            txtQuantidade = new TextBox();
            lblQuantidade = new Label();
            btnExcluir = new Button();
            btnGravar = new Button();
            btnFechar = new Button();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pctIcone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctBarra).BeginInit();
            SuspendLayout();
            // 
            // lblIdProduto
            // 
            lblIdProduto.BackColor = Color.FromArgb(224, 224, 224);
            lblIdProduto.BorderStyle = BorderStyle.Fixed3D;
            lblIdProduto.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdProduto.ForeColor = Color.Black;
            lblIdProduto.Location = new Point(70, 13);
            lblIdProduto.Name = "lblIdProduto";
            lblIdProduto.Size = new Size(60, 21);
            lblIdProduto.TabIndex = 100;
            lblIdProduto.Text = "0";
            lblIdProduto.TextAlign = ContentAlignment.MiddleCenter;
            lblIdProduto.Visible = false;
            // 
            // pctIcone
            // 
            pctIcone.BackColor = Color.Transparent;
            pctIcone.Image = (Image)resources.GetObject("pctIcone.Image");
            pctIcone.Location = new Point(5, 10);
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
            lblTitulo.Location = new Point(261, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(183, 23);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Produto";
            lblTitulo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pctBarra
            // 
            pctBarra.Image = (Image)resources.GetObject("pctBarra.Image");
            pctBarra.Location = new Point(-1, 0);
            pctBarra.Name = "pctBarra";
            pctBarra.Size = new Size(473, 50);
            pctBarra.SizeMode = PictureBoxSizeMode.StretchImage;
            pctBarra.TabIndex = 102;
            pctBarra.TabStop = false;
            // 
            // lblDataCadastro
            // 
            lblDataCadastro.BackColor = Color.White;
            lblDataCadastro.BorderStyle = BorderStyle.Fixed3D;
            lblDataCadastro.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDataCadastro.ForeColor = Color.Black;
            lblDataCadastro.Location = new Point(69, 126);
            lblDataCadastro.Name = "lblDataCadastro";
            lblDataCadastro.Size = new Size(179, 21);
            lblDataCadastro.TabIndex = 6;
            lblDataCadastro.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.ForeColor = Color.Navy;
            lblData.Location = new Point(4, 126);
            lblData.Name = "lblData";
            lblData.Size = new Size(34, 15);
            lblData.TabIndex = 307;
            lblData.Text = "Data:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.Navy;
            lblStatus.Location = new Point(5, 155);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 306;
            lblStatus.Text = "Status:";
            // 
            // radNaoAtivo
            // 
            radNaoAtivo.AutoSize = true;
            radNaoAtivo.ForeColor = Color.Navy;
            radNaoAtivo.Location = new Point(135, 155);
            radNaoAtivo.Name = "radNaoAtivo";
            radNaoAtivo.Size = new Size(76, 19);
            radNaoAtivo.TabIndex = 10;
            radNaoAtivo.TabStop = true;
            radNaoAtivo.Text = "Não ativo";
            radNaoAtivo.UseVisualStyleBackColor = true;
            // 
            // radAtivo
            // 
            radAtivo.AutoSize = true;
            radAtivo.ForeColor = Color.Navy;
            radAtivo.Location = new Point(66, 155);
            radAtivo.Name = "radAtivo";
            radAtivo.Size = new Size(53, 19);
            radAtivo.TabIndex = 8;
            radAtivo.TabStop = true;
            radAtivo.Text = "Ativo";
            radAtivo.UseVisualStyleBackColor = true;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(285, 96);
            txtPreco.MaxLength = 20;
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(123, 23);
            txtPreco.TabIndex = 5;
            txtPreco.KeyDown += txtPreco_KeyDown;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.ForeColor = Color.Navy;
            lblPreco.Location = new Point(238, 98);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(40, 15);
            lblPreco.TabIndex = 305;
            lblPreco.Text = "Preço:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(69, 64);
            txtDescricao.MaxLength = 150;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(376, 23);
            txtDescricao.TabIndex = 3;
            txtDescricao.KeyDown += txtDescricao_KeyDown;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.ForeColor = Color.Navy;
            lblDescricao.Location = new Point(1, 68);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(61, 15);
            lblDescricao.TabIndex = 304;
            lblDescricao.Text = "Descrição:";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(69, 95);
            txtQuantidade.MaxLength = 20;
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(123, 23);
            txtQuantidade.TabIndex = 4;
            txtQuantidade.KeyDown += txtQuantidade_KeyDown;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.ForeColor = Color.Navy;
            lblQuantidade.Location = new Point(3, 98);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(36, 15);
            lblQuantidade.TabIndex = 303;
            lblQuantidade.Text = "Qtde:";
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(251, 197);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(65, 25);
            btnExcluir.TabIndex = 12;
            btnExcluir.TabStop = false;
            btnExcluir.Text = "&Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(316, 197);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(65, 25);
            btnGravar.TabIndex = 13;
            btnGravar.TabStop = false;
            btnGravar.Text = "&Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(381, 197);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(65, 25);
            btnFechar.TabIndex = 14;
            btnFechar.TabStop = false;
            btnFechar.Text = "&Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // listBox1
            // 
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(-3, 187);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(463, 2);
            listBox1.TabIndex = 309;
            // 
            // frmProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 231);
            Controls.Add(btnExcluir);
            Controls.Add(btnGravar);
            Controls.Add(btnFechar);
            Controls.Add(listBox1);
            Controls.Add(lblDataCadastro);
            Controls.Add(lblData);
            Controls.Add(lblStatus);
            Controls.Add(radNaoAtivo);
            Controls.Add(radAtivo);
            Controls.Add(txtPreco);
            Controls.Add(lblPreco);
            Controls.Add(txtDescricao);
            Controls.Add(lblDescricao);
            Controls.Add(txtQuantidade);
            Controls.Add(lblQuantidade);
            Controls.Add(lblIdProduto);
            Controls.Add(pctIcone);
            Controls.Add(lblTitulo);
            Controls.Add(pctBarra);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Produto";
            Load += frmProdutos_Load;
            KeyDown += frmProdutos_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pctIcone).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctBarra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdProduto;
        internal PictureBox pctIcone;
        internal Label lblTitulo;
        internal PictureBox pctBarra;
        private Label lblDataCadastro;
        private Label lblStatus;
        private RadioButton radNaoAtivo;
        private RadioButton radAtivo;
        private TextBox txtPreco;
        private Label lblPreco;
        private TextBox txtDescricao;
        private Label lblDescricao;
        private TextBox txtQuantidade;
        private Label lblQuantidade;
        private Label lblData;
        private Button btnExcluir;
        private Button btnGravar;
        private Button btnFechar;
        private ListBox listBox1;
    }
}