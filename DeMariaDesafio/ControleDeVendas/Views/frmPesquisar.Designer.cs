namespace ControleDeVendas.Views
{
    partial class frmPesquisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisar));
            radDescricao = new RadioButton();
            radCodigo = new RadioButton();
            lvwPesquisa = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            txtNome = new TextBox();
            btnFechar = new Button();
            btnSelecionar = new Button();
            lblMensagem = new Label();
            pctIcone = new PictureBox();
            lblTitulo = new Label();
            pctBarra = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctIcone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctBarra).BeginInit();
            SuspendLayout();
            // 
            // radDescricao
            // 
            radDescricao.AutoSize = true;
            radDescricao.ForeColor = Color.Navy;
            radDescricao.Location = new Point(76, 301);
            radDescricao.Name = "radDescricao";
            radDescricao.Size = new Size(76, 19);
            radDescricao.TabIndex = 290;
            radDescricao.TabStop = true;
            radDescricao.Text = "Descrição";
            radDescricao.UseVisualStyleBackColor = true;
            radDescricao.CheckedChanged += radDescricao_CheckedChanged;
            // 
            // radCodigo
            // 
            radCodigo.AutoSize = true;
            radCodigo.ForeColor = Color.Navy;
            radCodigo.Location = new Point(7, 301);
            radCodigo.Name = "radCodigo";
            radCodigo.Size = new Size(64, 19);
            radCodigo.TabIndex = 289;
            radCodigo.TabStop = true;
            radCodigo.Text = "Código";
            radCodigo.UseVisualStyleBackColor = true;
            radCodigo.CheckedChanged += radCodigo_CheckedChanged;
            // 
            // lvwPesquisa
            // 
            lvwPesquisa.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lvwPesquisa.FullRowSelect = true;
            lvwPesquisa.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvwPesquisa.Location = new Point(6, 100);
            lvwPesquisa.MultiSelect = false;
            lvwPesquisa.Name = "lvwPesquisa";
            lvwPesquisa.Size = new Size(336, 193);
            lvwPesquisa.TabIndex = 288;
            lvwPesquisa.UseCompatibleStateImageBehavior = false;
            lvwPesquisa.View = View.Details;
            lvwPesquisa.DoubleClick += lvwPesquisa_DoubleClick;
            lvwPesquisa.KeyDown += lvwPesquisa_KeyDown;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Código";
            columnHeader1.Width = 53;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "...";
            columnHeader2.Width = 279;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(5, 75);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(337, 23);
            txtNome.TabIndex = 287;
            txtNome.TextChanged += txtNome_TextChanged;
            txtNome.KeyDown += txtNome_KeyDown;
            txtNome.KeyPress += txtNome_KeyPress;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(272, 298);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(70, 27);
            btnFechar.TabIndex = 286;
            btnFechar.TabStop = false;
            btnFechar.Text = "&Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnSelecionar
            // 
            btnSelecionar.Location = new Point(192, 298);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(80, 27);
            btnSelecionar.TabIndex = 285;
            btnSelecionar.TabStop = false;
            btnSelecionar.Text = "&Selecionar";
            btnSelecionar.UseVisualStyleBackColor = true;
            btnSelecionar.Click += btnSelecionar_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.ForeColor = Color.Navy;
            lblMensagem.Location = new Point(3, 60);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(232, 15);
            lblMensagem.TabIndex = 284;
            lblMensagem.Text = "Digite parte da descrição ... a ser localizado";
            // 
            // pctIcone
            // 
            pctIcone.BackColor = Color.Transparent;
            pctIcone.Image = (Image)resources.GetObject("pctIcone.Image");
            pctIcone.Location = new Point(6, 12);
            pctIcone.Name = "pctIcone";
            pctIcone.Size = new Size(32, 32);
            pctIcone.SizeMode = PictureBoxSizeMode.AutoSize;
            pctIcone.TabIndex = 283;
            pctIcone.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(136, 17);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(209, 23);
            lblTitulo.TabIndex = 282;
            lblTitulo.Text = "...";
            lblTitulo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pctBarra
            // 
            pctBarra.Image = (Image)resources.GetObject("pctBarra.Image");
            pctBarra.Location = new Point(0, 2);
            pctBarra.Name = "pctBarra";
            pctBarra.Size = new Size(489, 50);
            pctBarra.TabIndex = 281;
            pctBarra.TabStop = false;
            // 
            // frmPesquisar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 326);
            Controls.Add(radDescricao);
            Controls.Add(radCodigo);
            Controls.Add(lvwPesquisa);
            Controls.Add(txtNome);
            Controls.Add(btnFechar);
            Controls.Add(btnSelecionar);
            Controls.Add(lblMensagem);
            Controls.Add(pctIcone);
            Controls.Add(lblTitulo);
            Controls.Add(pctBarra);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPesquisar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmPesquisar_Load;
            KeyDown += frmPesquisar_KeyDown;
            KeyPress += frmPesquisar_KeyPress;
            ((System.ComponentModel.ISupportInitialize)pctIcone).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctBarra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radDescricao;
        private RadioButton radCodigo;
        private ListView lvwPesquisa;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private TextBox txtNome;
        private Button btnFechar;
        private Button btnSelecionar;
        private Label lblMensagem;
        internal PictureBox pctIcone;
        internal Label lblTitulo;
        internal PictureBox pctBarra;
    }
}