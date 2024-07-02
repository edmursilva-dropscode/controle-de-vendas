namespace ControleDeVendas.Views
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            btnExcluir = new Button();
            btnGravar = new Button();
            btnFechar = new Button();
            listBox1 = new ListBox();
            txtNome = new TextBox();
            lblNome = new Label();
            lblIdCliente = new Label();
            pctIcone = new PictureBox();
            lblTitulo = new Label();
            pctBarra = new PictureBox();
            txtTelefone = new TextBox();
            lblTelefone = new Label();
            txtEndereco = new TextBox();
            lblEndereco = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            radNaoAtivo = new RadioButton();
            radAtivo = new RadioButton();
            lblStatus = new Label();
            lblData = new Label();
            lblDataCadastro = new Label();
            ((System.ComponentModel.ISupportInitialize)pctIcone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctBarra).BeginInit();
            SuspendLayout();
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(253, 228);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(65, 25);
            btnExcluir.TabIndex = 10;
            btnExcluir.TabStop = false;
            btnExcluir.Text = "&Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(318, 228);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(65, 25);
            btnGravar.TabIndex = 11;
            btnGravar.TabStop = false;
            btnGravar.Text = "&Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(383, 228);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(65, 25);
            btnFechar.TabIndex = 12;
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
            listBox1.Location = new Point(-1, 218);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(463, 2);
            listBox1.TabIndex = 9;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(69, 64);
            txtNome.MaxLength = 90;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(331, 23);
            txtNome.TabIndex = 2;
            txtNome.KeyDown += txtNome_KeyDown;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.ForeColor = Color.Navy;
            lblNome.Location = new Point(2, 67);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 101;
            lblNome.Text = "Nome:";
            // 
            // lblIdCliente
            // 
            lblIdCliente.BackColor = Color.FromArgb(224, 224, 224);
            lblIdCliente.BorderStyle = BorderStyle.Fixed3D;
            lblIdCliente.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdCliente.ForeColor = Color.Black;
            lblIdCliente.Location = new Point(71, 14);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new Size(60, 21);
            lblIdCliente.TabIndex = 0;
            lblIdCliente.Text = "0";
            lblIdCliente.TextAlign = ContentAlignment.MiddleCenter;
            lblIdCliente.Visible = false;
            // 
            // pctIcone
            // 
            pctIcone.BackColor = Color.Transparent;
            pctIcone.Image = (Image)resources.GetObject("pctIcone.Image");
            pctIcone.Location = new Point(6, 11);
            pctIcone.Name = "pctIcone";
            pctIcone.Size = new Size(32, 32);
            pctIcone.SizeMode = PictureBoxSizeMode.AutoSize;
            pctIcone.TabIndex = 99;
            pctIcone.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(262, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(183, 23);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Cliente";
            lblTitulo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pctBarra
            // 
            pctBarra.Image = (Image)resources.GetObject("pctBarra.Image");
            pctBarra.Location = new Point(0, 1);
            pctBarra.Name = "pctBarra";
            pctBarra.Size = new Size(473, 50);
            pctBarra.SizeMode = PictureBoxSizeMode.StretchImage;
            pctBarra.TabIndex = 97;
            pctBarra.TabStop = false;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(69, 125);
            txtTelefone.MaxLength = 20;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(123, 23);
            txtTelefone.TabIndex = 4;
            txtTelefone.KeyDown += txtTelefone_KeyDown;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.ForeColor = Color.Navy;
            lblTelefone.Location = new Point(1, 129);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(54, 15);
            lblTelefone.TabIndex = 107;
            lblTelefone.Text = "Telefone:";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(69, 94);
            txtEndereco.MaxLength = 150;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(376, 23);
            txtEndereco.TabIndex = 3;
            txtEndereco.KeyDown += txtEndereco_KeyDown;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.ForeColor = Color.Navy;
            lblEndereco.Location = new Point(1, 98);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(59, 15);
            lblEndereco.TabIndex = 109;
            lblEndereco.Text = "Endereço:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(69, 155);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(331, 23);
            txtEmail.TabIndex = 6;
            txtEmail.KeyDown += txtEmail_KeyDown;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.Navy;
            lblEmail.Location = new Point(5, 157);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 111;
            lblEmail.Text = "Email:";
            // 
            // radNaoAtivo
            // 
            radNaoAtivo.AutoSize = true;
            radNaoAtivo.ForeColor = Color.Navy;
            radNaoAtivo.Location = new Point(135, 185);
            radNaoAtivo.Name = "radNaoAtivo";
            radNaoAtivo.Size = new Size(76, 19);
            radNaoAtivo.TabIndex = 8;
            radNaoAtivo.TabStop = true;
            radNaoAtivo.Text = "Não ativo";
            radNaoAtivo.UseVisualStyleBackColor = true;
            // 
            // radAtivo
            // 
            radAtivo.AutoSize = true;
            radAtivo.ForeColor = Color.Navy;
            radAtivo.Location = new Point(66, 185);
            radAtivo.Name = "radAtivo";
            radAtivo.Size = new Size(53, 19);
            radAtivo.TabIndex = 7;
            radAtivo.TabStop = true;
            radAtivo.Text = "Ativo";
            radAtivo.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.Navy;
            lblStatus.Location = new Point(5, 185);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 293;
            lblStatus.Text = "Status:";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.ForeColor = Color.Navy;
            lblData.Location = new Point(226, 129);
            lblData.Name = "lblData";
            lblData.Size = new Size(34, 15);
            lblData.TabIndex = 295;
            lblData.Text = "Data:";
            // 
            // lblDataCadastro
            // 
            lblDataCadastro.BackColor = Color.White;
            lblDataCadastro.BorderStyle = BorderStyle.Fixed3D;
            lblDataCadastro.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDataCadastro.ForeColor = Color.Black;
            lblDataCadastro.Location = new Point(266, 125);
            lblDataCadastro.Name = "lblDataCadastro";
            lblDataCadastro.Size = new Size(179, 21);
            lblDataCadastro.TabIndex = 5;
            lblDataCadastro.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 261);
            Controls.Add(lblDataCadastro);
            Controls.Add(lblData);
            Controls.Add(lblStatus);
            Controls.Add(radNaoAtivo);
            Controls.Add(radAtivo);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtEndereco);
            Controls.Add(lblEndereco);
            Controls.Add(txtTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(btnExcluir);
            Controls.Add(btnGravar);
            Controls.Add(btnFechar);
            Controls.Add(listBox1);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(lblIdCliente);
            Controls.Add(pctIcone);
            Controls.Add(lblTitulo);
            Controls.Add(pctBarra);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Cliente";
            Load += frmClientes_Load;
            KeyDown += frmClientes_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pctIcone).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctBarra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExcluir;
        private Button btnGravar;
        private Button btnFechar;
        private ListBox listBox1;
        private TextBox txtNome;
        private Label lblNome;
        private Label lblIdCliente;
        internal PictureBox pctIcone;
        internal Label lblTitulo;
        internal PictureBox pctBarra;
        private TextBox txtTelefone;
        private Label lblTelefone;
        private TextBox txtEndereco;
        private Label lblEndereco;
        private TextBox txtEmail;
        private Label lblEmail;
        private RadioButton radNaoAtivo;
        private RadioButton radAtivo;
        private Label lblStatus;
        private Label lblData;
        private Label lblDataCadastro;
    }
}