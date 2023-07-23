namespace Large_File_Scanner
{
    partial class FrmPrincipal
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            dtgPrincipal = new DataGridView();
            colAtivo = new DataGridViewCheckBoxColumn();
            colFormato = new DataGridViewTextBoxColumn();
            colQtd = new DataGridViewTextBoxColumn();
            colTamanho = new DataGridViewTextBoxColumn();
            btnProcurarDiretorio = new Button();
            pgbPrincipal = new ProgressBar();
            btnGerarTXT = new Button();
            gpbDiretorio = new GroupBox();
            lblTotalTamanho = new Label();
            lblTotalArquivos = new Label();
            lblTotalExtensoes = new Label();
            txtTamanhoMB = new TextBox();
            lblUnidade = new Label();
            cboUnidade = new ComboBox();
            lblMaiorQue = new Label();
            lblOrdenacao = new Label();
            cboOrdenacao = new ComboBox();
            btnSobre = new Button();
            chkHeader = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dtgPrincipal).BeginInit();
            gpbDiretorio.SuspendLayout();
            SuspendLayout();
            // 
            // dtgPrincipal
            // 
            dtgPrincipal.AllowUserToAddRows = false;
            dtgPrincipal.AllowUserToDeleteRows = false;
            dtgPrincipal.AllowUserToResizeColumns = false;
            dtgPrincipal.AllowUserToResizeRows = false;
            dtgPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgPrincipal.BackgroundColor = Color.White;
            dtgPrincipal.BorderStyle = BorderStyle.Fixed3D;
            dtgPrincipal.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgPrincipal.ColumnHeadersHeight = 35;
            dtgPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgPrincipal.Columns.AddRange(new DataGridViewColumn[] { colAtivo, colFormato, colQtd, colTamanho });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dtgPrincipal.DefaultCellStyle = dataGridViewCellStyle5;
            dtgPrincipal.EnableHeadersVisualStyles = false;
            dtgPrincipal.Location = new Point(6, 109);
            dtgPrincipal.Name = "dtgPrincipal";
            dtgPrincipal.RowHeadersVisible = false;
            dtgPrincipal.RowHeadersWidth = 50;
            dtgPrincipal.RowTemplate.Height = 29;
            dtgPrincipal.Size = new Size(514, 435);
            dtgPrincipal.TabIndex = 4;
            // 
            // colAtivo
            // 
            colAtivo.HeaderText = "";
            colAtivo.MinimumWidth = 6;
            colAtivo.Name = "colAtivo";
            colAtivo.Width = 25;
            // 
            // colFormato
            // 
            colFormato.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            colFormato.DefaultCellStyle = dataGridViewCellStyle2;
            colFormato.HeaderText = "Formato / Extensão ";
            colFormato.MinimumWidth = 6;
            colFormato.Name = "colFormato";
            colFormato.ReadOnly = true;
            // 
            // colQtd
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            colQtd.DefaultCellStyle = dataGridViewCellStyle3;
            colQtd.HeaderText = "  Quantidade";
            colQtd.MinimumWidth = 6;
            colQtd.Name = "colQtd";
            colQtd.ReadOnly = true;
            colQtd.Width = 125;
            // 
            // colTamanho
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.Format = "0.## mb";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.Padding = new Padding(0, 0, 5, 0);
            colTamanho.DefaultCellStyle = dataGridViewCellStyle4;
            colTamanho.HeaderText = "Tamanho Total";
            colTamanho.MinimumWidth = 6;
            colTamanho.Name = "colTamanho";
            colTamanho.ReadOnly = true;
            colTamanho.Width = 125;
            // 
            // btnProcurarDiretorio
            // 
            btnProcurarDiretorio.BackColor = Color.Teal;
            btnProcurarDiretorio.FlatAppearance.BorderColor = Color.DarkSlateGray;
            btnProcurarDiretorio.FlatAppearance.BorderSize = 2;
            btnProcurarDiretorio.FlatStyle = FlatStyle.Flat;
            btnProcurarDiretorio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProcurarDiretorio.ForeColor = SystemColors.ButtonHighlight;
            btnProcurarDiretorio.Location = new Point(362, 40);
            btnProcurarDiretorio.Name = "btnProcurarDiretorio";
            btnProcurarDiretorio.Size = new Size(157, 52);
            btnProcurarDiretorio.TabIndex = 3;
            btnProcurarDiretorio.Text = "Procurar";
            btnProcurarDiretorio.UseVisualStyleBackColor = false;
            btnProcurarDiretorio.Click += btnProcurarDiretorio_Click;
            // 
            // pgbPrincipal
            // 
            pgbPrincipal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pgbPrincipal.Location = new Point(6, 550);
            pgbPrincipal.Name = "pgbPrincipal";
            pgbPrincipal.Size = new Size(514, 5);
            pgbPrincipal.TabIndex = 3;
            // 
            // btnGerarTXT
            // 
            btnGerarTXT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGerarTXT.BackColor = Color.ForestGreen;
            btnGerarTXT.FlatAppearance.BorderColor = Color.DarkGreen;
            btnGerarTXT.FlatAppearance.BorderSize = 2;
            btnGerarTXT.FlatStyle = FlatStyle.Flat;
            btnGerarTXT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGerarTXT.ForeColor = Color.White;
            btnGerarTXT.Location = new Point(374, 606);
            btnGerarTXT.Margin = new Padding(0);
            btnGerarTXT.Name = "btnGerarTXT";
            btnGerarTXT.Size = new Size(164, 46);
            btnGerarTXT.TabIndex = 1;
            btnGerarTXT.Text = "Gerar .txt";
            btnGerarTXT.UseVisualStyleBackColor = false;
            btnGerarTXT.Click += btnGerarTXT_Click;
            // 
            // gpbDiretorio
            // 
            gpbDiretorio.Controls.Add(chkHeader);
            gpbDiretorio.Controls.Add(lblTotalTamanho);
            gpbDiretorio.Controls.Add(lblTotalArquivos);
            gpbDiretorio.Controls.Add(lblTotalExtensoes);
            gpbDiretorio.Controls.Add(txtTamanhoMB);
            gpbDiretorio.Controls.Add(lblUnidade);
            gpbDiretorio.Controls.Add(cboUnidade);
            gpbDiretorio.Controls.Add(lblMaiorQue);
            gpbDiretorio.Controls.Add(lblOrdenacao);
            gpbDiretorio.Controls.Add(cboOrdenacao);
            gpbDiretorio.Controls.Add(btnProcurarDiretorio);
            gpbDiretorio.Controls.Add(pgbPrincipal);
            gpbDiretorio.Controls.Add(dtgPrincipal);
            gpbDiretorio.Location = new Point(12, 12);
            gpbDiretorio.Name = "gpbDiretorio";
            gpbDiretorio.Size = new Size(526, 588);
            gpbDiretorio.TabIndex = 0;
            gpbDiretorio.TabStop = false;
            gpbDiretorio.Text = "Pesquisar Diretório";
            // 
            // lblTotalTamanho
            // 
            lblTotalTamanho.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTotalTamanho.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalTamanho.ForeColor = Color.RoyalBlue;
            lblTotalTamanho.Location = new Point(351, 558);
            lblTotalTamanho.Name = "lblTotalTamanho";
            lblTotalTamanho.Size = new Size(169, 22);
            lblTotalTamanho.TabIndex = 14;
            lblTotalTamanho.Text = "Tamanho: 0";
            lblTotalTamanho.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalArquivos
            // 
            lblTotalArquivos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTotalArquivos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalArquivos.ForeColor = Color.DarkOrchid;
            lblTotalArquivos.Location = new Point(188, 558);
            lblTotalArquivos.Name = "lblTotalArquivos";
            lblTotalArquivos.Size = new Size(157, 22);
            lblTotalArquivos.TabIndex = 13;
            lblTotalArquivos.Text = "Arquivos: 0";
            lblTotalArquivos.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalExtensoes
            // 
            lblTotalExtensoes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTotalExtensoes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalExtensoes.ForeColor = Color.DarkGreen;
            lblTotalExtensoes.Location = new Point(6, 558);
            lblTotalExtensoes.Name = "lblTotalExtensoes";
            lblTotalExtensoes.Size = new Size(176, 22);
            lblTotalExtensoes.TabIndex = 12;
            lblTotalExtensoes.Text = "Formatos: 0 ";
            lblTotalExtensoes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTamanhoMB
            // 
            txtTamanhoMB.Location = new Point(6, 65);
            txtTamanhoMB.Name = "txtTamanhoMB";
            txtTamanhoMB.PlaceholderText = "0";
            txtTamanhoMB.Size = new Size(87, 27);
            txtTamanhoMB.TabIndex = 11;
            txtTamanhoMB.TextAlign = HorizontalAlignment.Right;
            txtTamanhoMB.TextChanged += txtBoxValidarText_TextChanged;
            txtTamanhoMB.KeyPress += txtBoxApenasNumerosComCasasDecimais;
            // 
            // lblUnidade
            // 
            lblUnidade.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblUnidade.Location = new Point(99, 39);
            lblUnidade.Name = "lblUnidade";
            lblUnidade.Size = new Size(95, 22);
            lblUnidade.TabIndex = 10;
            lblUnidade.Text = "Unidade";
            lblUnidade.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboUnidade
            // 
            cboUnidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUnidade.Enabled = false;
            cboUnidade.FormattingEnabled = true;
            cboUnidade.Location = new Point(98, 64);
            cboUnidade.Name = "cboUnidade";
            cboUnidade.Size = new Size(102, 28);
            cboUnidade.TabIndex = 1;
            // 
            // lblMaiorQue
            // 
            lblMaiorQue.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMaiorQue.Location = new Point(6, 40);
            lblMaiorQue.Name = "lblMaiorQue";
            lblMaiorQue.Size = new Size(102, 22);
            lblMaiorQue.TabIndex = 8;
            lblMaiorQue.Text = "Maior que:";
            lblMaiorQue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblOrdenacao
            // 
            lblOrdenacao.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblOrdenacao.Location = new Point(218, 39);
            lblOrdenacao.Name = "lblOrdenacao";
            lblOrdenacao.Size = new Size(125, 22);
            lblOrdenacao.TabIndex = 6;
            lblOrdenacao.Text = "Ordenar por:";
            lblOrdenacao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboOrdenacao
            // 
            cboOrdenacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOrdenacao.FormattingEnabled = true;
            cboOrdenacao.Location = new Point(218, 64);
            cboOrdenacao.Name = "cboOrdenacao";
            cboOrdenacao.Size = new Size(125, 28);
            cboOrdenacao.TabIndex = 2;
            // 
            // btnSobre
            // 
            btnSobre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSobre.BackColor = SystemColors.ControlLightLight;
            btnSobre.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnSobre.FlatAppearance.BorderSize = 2;
            btnSobre.FlatStyle = FlatStyle.Flat;
            btnSobre.Location = new Point(12, 606);
            btnSobre.Name = "btnSobre";
            btnSobre.Size = new Size(76, 46);
            btnSobre.TabIndex = 2;
            btnSobre.Text = "Sobre";
            btnSobre.UseVisualStyleBackColor = false;
            btnSobre.Click += btnSobre_Click;
            // 
            // chkHeader
            // 
            chkHeader.AutoSize = true;
            chkHeader.Checked = true;
            chkHeader.CheckState = CheckState.Checked;
            chkHeader.Location = new Point(12, 120);
            chkHeader.Name = "chkHeader";
            chkHeader.Size = new Size(18, 17);
            chkHeader.TabIndex = 15;
            chkHeader.UseVisualStyleBackColor = true;
            chkHeader.CheckedChanged += chkHeader_CheckedChanged;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 664);
            Controls.Add(btnSobre);
            Controls.Add(btnGerarTXT);
            Controls.Add(gpbDiretorio);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Large File Scanner - GIT LFS";
            Load += FrmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dtgPrincipal).EndInit();
            gpbDiretorio.ResumeLayout(false);
            gpbDiretorio.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgPrincipal;
        private Button btnProcurarDiretorio;
        private ProgressBar pgbPrincipal;
        private Button btnGerarTXT;
        private GroupBox gpbDiretorio;
        private Label lblOrdenacao;
        private ComboBox cboOrdenacao;
        private ComboBox cboUnidade;
        private Label lblMaiorQue;
        private Label lblUnidade;
        private Button btnSobre;
        private TextBox txtTamanhoMB;
        private DataGridViewCheckBoxColumn colAtivo;
        private DataGridViewTextBoxColumn colFormato;
        private DataGridViewTextBoxColumn colQtd;
        private DataGridViewTextBoxColumn colTamanho;
        private Label lblTotalExtensoes;
        private Label lblTotalTamanho;
        private Label lblTotalArquivos;
        private CheckBox chkHeader;
    }
}