namespace Large_File_Scanner
{
    partial class FrmSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSobre));
            lblTitulo = new Label();
            label1 = new Label();
            btnGitLFS = new Button();
            btnGitHub = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(1, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(257, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Desenvolvido por José Junior";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Location = new Point(1, 50);
            label1.Name = "label1";
            label1.Size = new Size(257, 25);
            label1.TabIndex = 1;
            label1.Text = "Versão: 2.0 | Build: 2307.01";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGitLFS
            // 
            btnGitLFS.Location = new Point(25, 88);
            btnGitLFS.Name = "btnGitLFS";
            btnGitLFS.Size = new Size(99, 29);
            btnGitLFS.TabIndex = 3;
            btnGitLFS.Text = "GIT LFS";
            btnGitLFS.UseVisualStyleBackColor = true;
            btnGitLFS.Click += btnGitLFS_Click;
            // 
            // btnGitHub
            // 
            btnGitHub.Location = new Point(138, 88);
            btnGitHub.Name = "btnGitHub";
            btnGitHub.Size = new Size(99, 29);
            btnGitHub.TabIndex = 4;
            btnGitHub.Text = "GitHub";
            btnGitHub.UseVisualStyleBackColor = true;
            btnGitHub.Click += btnGitHub_Click;
            // 
            // FrmSobre
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 137);
            Controls.Add(btnGitHub);
            Controls.Add(btnGitLFS);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmSobre";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sobre";
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Label label1;
        private Button btnGitLFS;
        private Button btnGitHub;
    }
}