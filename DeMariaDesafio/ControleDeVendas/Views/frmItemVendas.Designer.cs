namespace ControleDeVendas.Views
{
    partial class frmItemVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemVendas));
            txtIdItemVenda = new TextBox();
            pctIcone = new PictureBox();
            lblTitulo = new Label();
            pctBarra = new PictureBox();
            lblIdVenda = new Label();
            lblVenda = new Label();
            btnPesquisarProduto = new Button();
            lblDescricaoProduto = new Label();
            txtIdProduto = new TextBox();
            label1 = new Label();
            txtValorUnitario = new TextBox();
            label2 = new Label();
            txtQtde = new TextBox();
            label8 = new Label();
            listBox1 = new ListBox();
            btnIncluir = new Button();
            btnFechar = new Button();
            ((System.ComponentModel.ISupportInitialize)pctIcone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctBarra).BeginInit();
            SuspendLayout();
            // 
            // txtIdItemVenda
            // 
            txtIdItemVenda.ForeColor = Color.Red;
            txtIdItemVenda.Location = new Point(330, 11);
            txtIdItemVenda.Margin = new Padding(4, 3, 4, 3);
            txtIdItemVenda.Name = "txtIdItemVenda";
            txtIdItemVenda.Size = new Size(16, 23);
            txtIdItemVenda.TabIndex = 324;
            txtIdItemVenda.Text = "0";
            txtIdItemVenda.TextAlign = HorizontalAlignment.Center;
            txtIdItemVenda.Visible = false;
            // 
            // pctIcone
            // 
            pctIcone.BackColor = Color.Transparent;
            pctIcone.Image = (Image)resources.GetObject("pctIcone.Image");
            pctIcone.Location = new Point(16, 9);
            pctIcone.Margin = new Padding(4, 3, 4, 3);
            pctIcone.Name = "pctIcone";
            pctIcone.Size = new Size(32, 32);
            pctIcone.SizeMode = PictureBoxSizeMode.AutoSize;
            pctIcone.TabIndex = 323;
            pctIcone.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(363, 11);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(163, 27);
            lblTitulo.TabIndex = 321;
            lblTitulo.Text = "Produto";
            lblTitulo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pctBarra
            // 
            pctBarra.Image = (Image)resources.GetObject("pctBarra.Image");
            pctBarra.Location = new Point(-22, -3);
            pctBarra.Margin = new Padding(4, 3, 4, 3);
            pctBarra.Name = "pctBarra";
            pctBarra.Size = new Size(589, 58);
            pctBarra.SizeMode = PictureBoxSizeMode.StretchImage;
            pctBarra.TabIndex = 322;
            pctBarra.TabStop = false;
            // 
            // lblIdVenda
            // 
            lblIdVenda.BackColor = Color.FromArgb(224, 224, 224);
            lblIdVenda.BorderStyle = BorderStyle.Fixed3D;
            lblIdVenda.ForeColor = Color.Black;
            lblIdVenda.Location = new Point(97, 65);
            lblIdVenda.Margin = new Padding(4, 0, 4, 0);
            lblIdVenda.Name = "lblIdVenda";
            lblIdVenda.Size = new Size(103, 24);
            lblIdVenda.TabIndex = 326;
            lblIdVenda.Text = "0";
            lblIdVenda.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVenda
            // 
            lblVenda.AutoSize = true;
            lblVenda.ForeColor = Color.Navy;
            lblVenda.Location = new Point(4, 72);
            lblVenda.Margin = new Padding(4, 0, 4, 0);
            lblVenda.Name = "lblVenda";
            lblVenda.Size = new Size(42, 15);
            lblVenda.TabIndex = 325;
            lblVenda.Text = "Venda:";
            // 
            // btnPesquisarProduto
            // 
            btnPesquisarProduto.Location = new Point(169, 96);
            btnPesquisarProduto.Margin = new Padding(4, 3, 4, 3);
            btnPesquisarProduto.Name = "btnPesquisarProduto";
            btnPesquisarProduto.Size = new Size(29, 21);
            btnPesquisarProduto.TabIndex = 330;
            btnPesquisarProduto.TabStop = false;
            btnPesquisarProduto.Text = "...";
            btnPesquisarProduto.UseVisualStyleBackColor = true;
            btnPesquisarProduto.Click += btnPesquisarProduto_Click;
            // 
            // lblDescricaoProduto
            // 
            lblDescricaoProduto.BackColor = Color.FromArgb(224, 224, 224);
            lblDescricaoProduto.BorderStyle = BorderStyle.Fixed3D;
            lblDescricaoProduto.ForeColor = Color.Black;
            lblDescricaoProduto.Location = new Point(208, 96);
            lblDescricaoProduto.Margin = new Padding(4, 0, 4, 0);
            lblDescricaoProduto.Name = "lblDescricaoProduto";
            lblDescricaoProduto.Size = new Size(322, 24);
            lblDescricaoProduto.TabIndex = 328;
            lblDescricaoProduto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtIdProduto
            // 
            txtIdProduto.Location = new Point(97, 95);
            txtIdProduto.Margin = new Padding(4, 3, 4, 3);
            txtIdProduto.MaxLength = 3;
            txtIdProduto.Name = "txtIdProduto";
            txtIdProduto.Size = new Size(103, 23);
            txtIdProduto.TabIndex = 327;
            txtIdProduto.TextAlign = HorizontalAlignment.Center;
            txtIdProduto.TextChanged += txtIdProduto_TextChanged;
            txtIdProduto.KeyDown += txtIdProduto_KeyDown;
            txtIdProduto.KeyPress += txtIdProduto_KeyPress;
            txtIdProduto.Leave += txtIdProduto_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(4, 101);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 329;
            label1.Text = "Produto:";
            // 
            // txtValorUnitario
            // 
            txtValorUnitario.Location = new Point(95, 159);
            txtValorUnitario.Margin = new Padding(4, 3, 4, 3);
            txtValorUnitario.MaxLength = 6;
            txtValorUnitario.Name = "txtValorUnitario";
            txtValorUnitario.Size = new Size(103, 23);
            txtValorUnitario.TabIndex = 334;
            txtValorUnitario.TextAlign = HorizontalAlignment.Center;
            txtValorUnitario.KeyPress += txtValorUnitario_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(6, 162);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 333;
            label2.Text = "Valor Unitário:";
            // 
            // txtQtde
            // 
            txtQtde.Location = new Point(95, 128);
            txtQtde.Margin = new Padding(4, 3, 4, 3);
            txtQtde.MaxLength = 6;
            txtQtde.Name = "txtQtde";
            txtQtde.Size = new Size(103, 23);
            txtQtde.TabIndex = 332;
            txtQtde.TextAlign = HorizontalAlignment.Center;
            txtQtde.KeyPress += txtQtde_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(9, 130);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 331;
            label8.Text = "Qtde:";
            // 
            // listBox1
            // 
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(-15, 196);
            listBox1.Margin = new Padding(4, 3, 4, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(582, 2);
            listBox1.TabIndex = 337;
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new Point(394, 208);
            btnIncluir.Margin = new Padding(4, 3, 4, 3);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(65, 25);
            btnIncluir.TabIndex = 336;
            btnIncluir.TabStop = false;
            btnIncluir.Text = "&Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnGravar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(461, 208);
            btnFechar.Margin = new Padding(4, 3, 4, 3);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(65, 25);
            btnFechar.TabIndex = 335;
            btnFechar.TabStop = false;
            btnFechar.Text = "&Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // frmItemVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 239);
            Controls.Add(listBox1);
            Controls.Add(btnIncluir);
            Controls.Add(btnFechar);
            Controls.Add(txtValorUnitario);
            Controls.Add(label2);
            Controls.Add(txtQtde);
            Controls.Add(label8);
            Controls.Add(btnPesquisarProduto);
            Controls.Add(lblDescricaoProduto);
            Controls.Add(txtIdProduto);
            Controls.Add(label1);
            Controls.Add(lblIdVenda);
            Controls.Add(lblVenda);
            Controls.Add(txtIdItemVenda);
            Controls.Add(pctIcone);
            Controls.Add(lblTitulo);
            Controls.Add(pctBarra);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmItemVendas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmItemVendas";
            Load += frmItemVendas_Load;
            KeyDown += frmItemVendas_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pctIcone).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctBarra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal TextBox txtIdItemVenda;
        internal PictureBox pctIcone;
        internal Label lblTitulo;
        internal PictureBox pctBarra;
        private Label lblIdVenda;
        private Label lblVenda;
        private Button btnPesquisarProduto;
        private Label lblDescricaoProduto;
        private TextBox txtIdProduto;
        private Label label1;
        private TextBox txtValorUnitario;
        private Label label2;
        private TextBox txtQtde;
        private Label label8;
        private ListBox listBox1;
        private Button btnIncluir;
        private Button btnFechar;
    }
}