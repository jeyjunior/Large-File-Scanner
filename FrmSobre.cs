using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Large_File_Scanner
{
    public partial class FrmSobre : Form
    {
        public FrmSobre()
        {
            InitializeComponent();
        }

        private void AbrirSite(string urlSite)
        {
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = urlSite,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o site: " + ex.Message);
            }
        }

        private void btnGitHub_Click(object sender, EventArgs e)
        {
            AbrirSite("https://github.com/JeyJr");
        }
        private void btnGitLFS_Click(object sender, EventArgs e)
        {
            AbrirSite("https://git-lfs.com/");
        }
    }
}
