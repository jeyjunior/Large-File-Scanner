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
            tbxPastaDestino = new TextBox();
            btnProcurarPasta = new Button();
            lbl_TotalMBs = new Label();
            txbTotalMB = new TextBox();
            btn_GerarArquivo = new Button();
            checkedListBox = new CheckedListBox();
            btn_ListarArquivos = new Button();
            SuspendLayout();
            // 
            // tbxPastaDestino
            // 
            tbxPastaDestino.Location = new Point(22, 27);
            tbxPastaDestino.Name = "tbxPastaDestino";
            tbxPastaDestino.Size = new Size(298, 23);
            tbxPastaDestino.TabIndex = 0;
            // 
            // btnProcurarPasta
            // 
            btnProcurarPasta.Location = new Point(336, 27);
            btnProcurarPasta.Name = "btnProcurarPasta";
            btnProcurarPasta.Size = new Size(75, 23);
            btnProcurarPasta.TabIndex = 1;
            btnProcurarPasta.Text = "Pasta";
            btnProcurarPasta.UseVisualStyleBackColor = true;
            btnProcurarPasta.Click += btnProcurarPasta_Click;
            // 
            // lbl_TotalMBs
            // 
            lbl_TotalMBs.AutoSize = true;
            lbl_TotalMBs.Location = new Point(197, 73);
            lbl_TotalMBs.Name = "lbl_TotalMBs";
            lbl_TotalMBs.Size = new Size(38, 15);
            lbl_TotalMBs.TabIndex = 3;
            lbl_TotalMBs.Text = "label1";
            // 
            // txbTotalMB
            // 
            txbTotalMB.Location = new Point(22, 65);
            txbTotalMB.Name = "txbTotalMB";
            txbTotalMB.Size = new Size(160, 23);
            txbTotalMB.TabIndex = 4;
            txbTotalMB.KeyPress += txbTotalMB_KeyPress;
            // 
            // btn_GerarArquivo
            // 
            btn_GerarArquivo.Location = new Point(354, 402);
            btn_GerarArquivo.Name = "btn_GerarArquivo";
            btn_GerarArquivo.Size = new Size(75, 23);
            btn_GerarArquivo.TabIndex = 5;
            btn_GerarArquivo.Text = "Examinar";
            btn_GerarArquivo.UseVisualStyleBackColor = true;
            btn_GerarArquivo.Click += btn_GerarArquivo_Click;
            // 
            // checkedListBox
            // 
            checkedListBox.FormattingEnabled = true;
            checkedListBox.Location = new Point(22, 107);
            checkedListBox.Name = "checkedListBox";
            checkedListBox.Size = new Size(389, 274);
            checkedListBox.TabIndex = 6;
            // 
            // btn_ListarArquivos
            // 
            btn_ListarArquivos.Location = new Point(336, 78);
            btn_ListarArquivos.Name = "btn_ListarArquivos";
            btn_ListarArquivos.Size = new Size(75, 23);
            btn_ListarArquivos.TabIndex = 7;
            btn_ListarArquivos.Text = "Listar";
            btn_ListarArquivos.UseVisualStyleBackColor = true;
            btn_ListarArquivos.Click += btn_ListarArquivos_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 450);
            Controls.Add(btn_ListarArquivos);
            Controls.Add(checkedListBox);
            Controls.Add(btn_GerarArquivo);
            Controls.Add(txbTotalMB);
            Controls.Add(lbl_TotalMBs);
            Controls.Add(btnProcurarPasta);
            Controls.Add(tbxPastaDestino);
            Name = "FrmMain";
            Text = "Large File Scanner - LFS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbxPastaDestino;
        private Button btnProcurarPasta;
        private Label lbl_TotalMBs;
        private TextBox txbTotalMB;
        private Button btn_GerarArquivo;
        private CheckedListBox checkedListBox;
        private Button btn_ListarArquivos;
    }
}