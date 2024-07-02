namespace ControleDeVendas.Views
{
    partial class frmClientesLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientesLista));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pctBarra = new PictureBox();
            pctIcone = new PictureBox();
            lblTitulo = new Label();
            lblTipo = new Label();
            cmbTipo = new ComboBox();
            txtLocalizar = new TextBox();
            lblMensagem = new Label();
            dgvClientes = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            btnNovo = new Button();
            GroupBox1 = new GroupBox();
            btnFechar = new Button();
            btnImprimir = new Button();
            pctBarra1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctBarra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctIcone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctBarra1).BeginInit();
            SuspendLayout();
            // 
            // pctBarra
            // 
            pctBarra.Image = (Image)resources.GetObject("pctBarra.Image");
            pctBarra.Location = new Point(0, 0);
            pctBarra.Name = "pctBarra";
            pctBarra.Size = new Size(532, 53);
            pctBarra.TabIndex = 59;
            pctBarra.TabStop = false;
            // 
            // pctIcone
            // 
            pctIcone.BackColor = Color.Transparent;
            pctIcone.Image = (Image)resources.GetObject("pctIcone.Image");
            pctIcone.Location = new Point(12, 12);
            pctIcone.Name = "pctIcone";
            pctIcone.Size = new Size(32, 32);
            pctIcone.SizeMode = PictureBoxSizeMode.AutoSize;
            pctIcone.TabIndex = 62;
            pctIcone.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(457, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(183, 23);
            lblTitulo.TabIndex = 281;
            lblTitulo.Text = "Clientes";
            lblTitulo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipo.ForeColor = SystemColors.ControlText;
            lblTipo.Location = new Point(390, 66);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(34, 15);
            lblTipo.TabIndex = 289;
            lblTipo.Text = "Tipo:";
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Código", "Nome" });
            cmbTipo.Location = new Point(430, 63);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(102, 23);
            cmbTipo.TabIndex = 2;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // txtLocalizar
            // 
            txtLocalizar.Location = new Point(64, 63);
            txtLocalizar.MaxLength = 30;
            txtLocalizar.Name = "txtLocalizar";
            txtLocalizar.Size = new Size(307, 23);
            txtLocalizar.TabIndex = 1;
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
            lblMensagem.TabIndex = 286;
            lblMensagem.Text = "Localizar:";
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvClientes.Location = new Point(5, 98);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(635, 289);
            dgvClientes.TabIndex = 3;
            dgvClientes.DoubleClick += dgvClientes_DoubleClick;
            dgvClientes.MouseDown += dgvClientes_MouseDown;
            // 
            // Column1
            // 
            Column1.HeaderText = "Código";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nome";
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
            // btnNovo
            // 
            btnNovo.Location = new Point(510, 401);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(65, 25);
            btnNovo.TabIndex = 5;
            btnNovo.TabStop = false;
            btnNovo.Text = "&Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // GroupBox1
            // 
            GroupBox1.Location = new Point(-5, 393);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(743, 2);
            GroupBox1.TabIndex = 291;
            GroupBox1.TabStop = false;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(575, 401);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(65, 25);
            btnFechar.TabIndex = 6;
            btnFechar.TabStop = false;
            btnFechar.Text = "&Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(5, 400);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(65, 25);
            btnImprimir.TabIndex = 4;
            btnImprimir.TabStop = false;
            btnImprimir.Text = "&Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // pctBarra1
            // 
            pctBarra1.Image = (Image)resources.GetObject("pctBarra1.Image");
            pctBarra1.Location = new Point(464, 0);
            pctBarra1.Name = "pctBarra1";
            pctBarra1.Size = new Size(254, 53);
            pctBarra1.TabIndex = 292;
            pctBarra1.TabStop = false;
            // 
            // frmClientesLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 431);
            Controls.Add(lblTitulo);
            Controls.Add(btnImprimir);
            Controls.Add(btnNovo);
            Controls.Add(GroupBox1);
            Controls.Add(btnFechar);
            Controls.Add(lblTipo);
            Controls.Add(cmbTipo);
            Controls.Add(txtLocalizar);
            Controls.Add(lblMensagem);
            Controls.Add(dgvClientes);
            Controls.Add(pctIcone);
            Controls.Add(pctBarra);
            Controls.Add(pctBarra1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmClientesLista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Clientes";
            Load += frmClientesLista_Load;
            KeyDown += frmClientesLista_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pctBarra).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctIcone).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctBarra1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pctBarra;
        internal PictureBox pctIcone;
        internal Label lblTitulo;
        private Label lblTipo;
        private ComboBox cmbTipo;
        private TextBox txtLocalizar;
        private Label lblMensagem;
        private DataGridView dgvClientes;
        private Button btnNovo;
        internal GroupBox GroupBox1;
        private Button btnFechar;
        private Button btnImprimir;
        private PictureBox pctBarra1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}