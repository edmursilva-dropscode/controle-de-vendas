namespace ControleDeVendas.Views
{
    partial class frmProdutosLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutosLista));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            pctIcone = new PictureBox();
            pctBarra = new PictureBox();
            pctBarra1 = new PictureBox();
            lblTipo = new Label();
            cmbTipo = new ComboBox();
            txtLocalizar = new TextBox();
            lblMensagem = new Label();
            dgvProdutos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            btnImprimir = new Button();
            btnNovo = new Button();
            GroupBox1 = new GroupBox();
            btnFechar = new Button();
            ((System.ComponentModel.ISupportInitialize)pctIcone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctBarra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctBarra1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(457, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(183, 23);
            lblTitulo.TabIndex = 295;
            lblTitulo.Text = "Produtos";
            lblTitulo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pctIcone
            // 
            pctIcone.BackColor = Color.Transparent;
            pctIcone.Image = (Image)resources.GetObject("pctIcone.Image");
            pctIcone.Location = new Point(12, 12);
            pctIcone.Name = "pctIcone";
            pctIcone.Size = new Size(32, 32);
            pctIcone.SizeMode = PictureBoxSizeMode.AutoSize;
            pctIcone.TabIndex = 294;
            pctIcone.TabStop = false;
            // 
            // pctBarra
            // 
            pctBarra.Image = (Image)resources.GetObject("pctBarra.Image");
            pctBarra.Location = new Point(0, 0);
            pctBarra.Name = "pctBarra";
            pctBarra.Size = new Size(532, 53);
            pctBarra.TabIndex = 293;
            pctBarra.TabStop = false;
            // 
            // pctBarra1
            // 
            pctBarra1.Image = (Image)resources.GetObject("pctBarra1.Image");
            pctBarra1.Location = new Point(464, 0);
            pctBarra1.Name = "pctBarra1";
            pctBarra1.Size = new Size(254, 53);
            pctBarra1.TabIndex = 296;
            pctBarra1.TabStop = false;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipo.ForeColor = SystemColors.ControlText;
            lblTipo.Location = new Point(390, 66);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(34, 15);
            lblTipo.TabIndex = 300;
            lblTipo.Text = "Tipo:";
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Código", "Descrição" });
            cmbTipo.Location = new Point(430, 63);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(102, 23);
            cmbTipo.TabIndex = 298;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // txtLocalizar
            // 
            txtLocalizar.Location = new Point(64, 63);
            txtLocalizar.MaxLength = 30;
            txtLocalizar.Name = "txtLocalizar";
            txtLocalizar.Size = new Size(307, 23);
            txtLocalizar.TabIndex = 297;
            txtLocalizar.TextChanged += txtLocalizar_TextChanged;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensagem.ForeColor = SystemColors.ControlText;
            lblMensagem.Location = new Point(4, 66);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(60, 15);
            lblMensagem.TabIndex = 299;
            lblMensagem.Text = "Localizar:";
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvProdutos.Location = new Point(6, 96);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(635, 289);
            dgvProdutos.TabIndex = 301;
            dgvProdutos.DoubleClick += dgvProdutos_DoubleClick;
            dgvProdutos.MouseDown += dgvProdutos_MouseDown;
            // 
            // Column1
            // 
            Column1.HeaderText = "Código";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Descrição";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 373;
            // 
            // Column3
            // 
            Column3.HeaderText = "Status";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(7, 399);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(65, 25);
            btnImprimir.TabIndex = 302;
            btnImprimir.TabStop = false;
            btnImprimir.Text = "&Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(512, 400);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(65, 25);
            btnNovo.TabIndex = 303;
            btnNovo.TabStop = false;
            btnNovo.Text = "&Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // GroupBox1
            // 
            GroupBox1.Location = new Point(-3, 392);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(743, 2);
            GroupBox1.TabIndex = 305;
            GroupBox1.TabStop = false;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(577, 400);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(65, 25);
            btnFechar.TabIndex = 304;
            btnFechar.TabStop = false;
            btnFechar.Text = "&Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // frmProdutosLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 431);
            Controls.Add(lblTitulo);
            Controls.Add(btnImprimir);
            Controls.Add(btnNovo);
            Controls.Add(GroupBox1);
            Controls.Add(btnFechar);
            Controls.Add(dgvProdutos);
            Controls.Add(lblTipo);
            Controls.Add(cmbTipo);
            Controls.Add(txtLocalizar);
            Controls.Add(lblMensagem);
            Controls.Add(pctIcone);
            Controls.Add(pctBarra);
            Controls.Add(pctBarra1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmProdutosLista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Produtos";
            Load += frmProdutosListacs_Load;
            KeyDown += frmProdutosListacs_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pctIcone).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctBarra).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctBarra1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal Label lblTitulo;
        internal PictureBox pctIcone;
        private PictureBox pctBarra;
        private PictureBox pctBarra1;
        private Label lblTipo;
        private ComboBox cmbTipo;
        private TextBox txtLocalizar;
        private Label lblMensagem;
        private DataGridView dgvProdutos;
        private Button btnImprimir;
        private Button btnNovo;
        internal GroupBox GroupBox1;
        private Button btnFechar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}