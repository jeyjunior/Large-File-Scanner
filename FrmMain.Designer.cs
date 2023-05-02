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
            progressBar1 = new ProgressBar();
            btn_Check = new Button();
            btn_Uncheck = new Button();
            SuspendLayout();
            // 
            // btnProcurarPasta
            // 
            btnProcurarPasta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnProcurarPasta.Location = new Point(257, 17);
            btnProcurarPasta.Name = "btnProcurarPasta";
            btnProcurarPasta.RightToLeft = RightToLeft.No;
            btnProcurarPasta.Size = new Size(87, 23);
            btnProcurarPasta.TabIndex = 1;
            btnProcurarPasta.Text = "Folder";
            btnProcurarPasta.UseVisualStyleBackColor = true;
            btnProcurarPasta.Click += btnProcurarPasta_Click;
            // 
            // lbl_TotalMBs
            // 
            lbl_TotalMBs.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_TotalMBs.Location = new Point(267, 64);
            lbl_TotalMBs.Name = "lbl_TotalMBs";
            lbl_TotalMBs.Size = new Size(65, 15);
            lbl_TotalMBs.TabIndex = 3;
            lbl_TotalMBs.Text = "MegaBytes";
            lbl_TotalMBs.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txbTotalMB
            // 
            txbTotalMB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txbTotalMB.Location = new Point(257, 82);
            txbTotalMB.MaxLength = 12;
            txbTotalMB.Name = "txbTotalMB";
            txbTotalMB.Size = new Size(86, 23);
            txbTotalMB.TabIndex = 4;
            txbTotalMB.KeyPress += txbTotalMB_KeyPress;
            // 
            // btn_GerarArquivo
            // 
            btn_GerarArquivo.Location = new Point(12, 403);
            btn_GerarArquivo.Name = "btn_GerarArquivo";
            btn_GerarArquivo.Size = new Size(239, 23);
            btn_GerarArquivo.TabIndex = 5;
            btn_GerarArquivo.Text = "Create Files";
            btn_GerarArquivo.UseVisualStyleBackColor = true;
            btn_GerarArquivo.Click += btn_GerarArquivo_Click;
            // 
            // checkedListBox
            // 
            checkedListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkedListBox.FormattingEnabled = true;
            checkedListBox.Location = new Point(12, 17);
            checkedListBox.Name = "checkedListBox";
            checkedListBox.Size = new Size(239, 364);
            checkedListBox.TabIndex = 6;
            // 
            // btn_ListarArquivos
            // 
            btn_ListarArquivos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_ListarArquivos.Location = new Point(257, 111);
            btn_ListarArquivos.Name = "btn_ListarArquivos";
            btn_ListarArquivos.Size = new Size(86, 23);
            btn_ListarArquivos.TabIndex = 7;
            btn_ListarArquivos.Text = "List";
            btn_ListarArquivos.UseVisualStyleBackColor = true;
            btn_ListarArquivos.Click += btn_ListarArquivos_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 387);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(239, 10);
            progressBar1.TabIndex = 8;
            // 
            // btn_Check
            // 
            btn_Check.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Check.Location = new Point(259, 189);
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
            btn_Uncheck.Location = new Point(259, 218);
            btn_Uncheck.Name = "btn_Uncheck";
            btn_Uncheck.Size = new Size(86, 23);
            btn_Uncheck.TabIndex = 10;
            btn_Uncheck.Text = "Uncheck";
            btn_Uncheck.UseVisualStyleBackColor = true;
            btn_Uncheck.Click += btn_Uncheck_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 438);
            Controls.Add(btn_Uncheck);
            Controls.Add(btn_Check);
            Controls.Add(btn_ListarArquivos);
            Controls.Add(progressBar1);
            Controls.Add(lbl_TotalMBs);
            Controls.Add(txbTotalMB);
            Controls.Add(checkedListBox);
            Controls.Add(btn_GerarArquivo);
            Controls.Add(btnProcurarPasta);
            Name = "FrmMain";
            Text = "Large File Scanner - LFS";
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
        private ProgressBar progressBar1;
        private Button btn_Check;
        private Button btn_Uncheck;
    }
}