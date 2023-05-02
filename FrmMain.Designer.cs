namespace Large_File_Scanner
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnProcurarPasta = new Button();
            lbl_TotalMBs = new Label();
            txbTotalMB = new TextBox();
            btn_GerarArquivo = new Button();
            checkedListBox = new CheckedListBox();
            btn_ListarArquivos = new Button();
            mainProgressBar = new ProgressBar();
            btn_Check = new Button();
            btn_Uncheck = new Button();
            lbl_Title = new Label();
            SuspendLayout();
            // 
            // btnProcurarPasta
            // 
            btnProcurarPasta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnProcurarPasta.Location = new Point(260, 35);
            btnProcurarPasta.Name = "btnProcurarPasta";
            btnProcurarPasta.RightToLeft = RightToLeft.No;
            btnProcurarPasta.Size = new Size(87, 23);
            btnProcurarPasta.TabIndex = 1;
            btnProcurarPasta.Text = "Pasta";
            btnProcurarPasta.UseVisualStyleBackColor = true;
            btnProcurarPasta.Click += btnProcurarPasta_Click;
            // 
            // lbl_TotalMBs
            // 
            lbl_TotalMBs.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_TotalMBs.Location = new Point(270, 82);
            lbl_TotalMBs.Name = "lbl_TotalMBs";
            lbl_TotalMBs.Size = new Size(65, 15);
            lbl_TotalMBs.TabIndex = 3;
            lbl_TotalMBs.Text = "MegaBytes";
            lbl_TotalMBs.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txbTotalMB
            // 
            txbTotalMB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txbTotalMB.Location = new Point(260, 100);
            txbTotalMB.MaxLength = 12;
            txbTotalMB.Name = "txbTotalMB";
            txbTotalMB.Size = new Size(86, 23);
            txbTotalMB.TabIndex = 4;
            txbTotalMB.KeyPress += txbTotalMB_KeyPress;
            // 
            // btn_GerarArquivo
            // 
            btn_GerarArquivo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_GerarArquivo.Location = new Point(12, 363);
            btn_GerarArquivo.Name = "btn_GerarArquivo";
            btn_GerarArquivo.Size = new Size(239, 23);
            btn_GerarArquivo.TabIndex = 5;
            btn_GerarArquivo.Text = "Criar arquivos";
            btn_GerarArquivo.UseVisualStyleBackColor = true;
            btn_GerarArquivo.Click += btn_GerarArquivo_Click;
            // 
            // checkedListBox
            // 
            checkedListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkedListBox.FormattingEnabled = true;
            checkedListBox.Location = new Point(12, 35);
            checkedListBox.Name = "checkedListBox";
            checkedListBox.Size = new Size(239, 292);
            checkedListBox.TabIndex = 6;
            // 
            // btn_ListarArquivos
            // 
            btn_ListarArquivos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_ListarArquivos.Location = new Point(260, 129);
            btn_ListarArquivos.Name = "btn_ListarArquivos";
            btn_ListarArquivos.Size = new Size(86, 23);
            btn_ListarArquivos.TabIndex = 7;
            btn_ListarArquivos.Text = "Listar";
            btn_ListarArquivos.UseVisualStyleBackColor = true;
            btn_ListarArquivos.Click += btn_ListarArquivos_Click;
            // 
            // mainProgressBar
            // 
            mainProgressBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            mainProgressBar.Location = new Point(12, 347);
            mainProgressBar.Name = "mainProgressBar";
            mainProgressBar.Size = new Size(239, 10);
            mainProgressBar.TabIndex = 8;
            // 
            // btn_Check
            // 
            btn_Check.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Check.Location = new Point(262, 207);
            btn_Check.Name = "btn_Check";
            btn_Check.Size = new Size(86, 23);
            btn_Check.TabIndex = 9;
            btn_Check.Text = "Check";
            btn_Check.UseVisualStyleBackColor = true;
            btn_Check.Click += btn_Check_Click;
            // 
            // btn_Uncheck
            // 
            btn_Uncheck.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Uncheck.Location = new Point(262, 236);
            btn_Uncheck.Name = "btn_Uncheck";
            btn_Uncheck.Size = new Size(86, 23);
            btn_Uncheck.TabIndex = 10;
            btn_Uncheck.Text = "Uncheck";
            btn_Uncheck.UseVisualStyleBackColor = true;
            btn_Uncheck.Click += btn_Uncheck_Click;
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Location = new Point(15, 10);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(175, 15);
            lbl_Title.TabIndex = 11;
            lbl_Title.Text = "Formato [quatidade] - tamanho";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 398);
            Controls.Add(lbl_Title);
            Controls.Add(btn_Uncheck);
            Controls.Add(btn_Check);
            Controls.Add(btn_ListarArquivos);
            Controls.Add(mainProgressBar);
            Controls.Add(lbl_TotalMBs);
            Controls.Add(txbTotalMB);
            Controls.Add(checkedListBox);
            Controls.Add(btn_GerarArquivo);
            Controls.Add(btnProcurarPasta);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Large File Scanner - LFS";
            Load += FrmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnProcurarPasta;
        private Label lbl_TotalMBs;
        private TextBox txbTotalMB;
        private Button btn_GerarArquivo;
        private CheckedListBox checkedListBox;
        private Button btn_ListarArquivos;
        private ProgressBar mainProgressBar;
        private Button btn_Check;
        private Button btn_Uncheck;
        private Label lbl_Title;
    }
}