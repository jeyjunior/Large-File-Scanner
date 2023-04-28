using Large_File_Scanner.Helpers;
using Large_File_Scanner.Setup;
using System.Diagnostics;
using System.Globalization;
using System.Security.Principal;

namespace Large_File_Scanner
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnProcurarPasta_Click(object sender, EventArgs e)
        {
            var fdb = new FolderBrowserDialog();

            if (fdb.ShowDialog() == DialogResult.OK)
            {
                var path = fdb.SelectedPath;
                InitialSetup.Instance.MyPath = path;
                tbxPastaDestino.Text = path;
            }
        }

        private async void btn_GerarArquivo_Click(object sender, EventArgs e)
        {
            await CreateFile.Instance.CriarArquivosAsync();
        }

        private void txbTotalMB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidateTypedSize.KeyPress(sender, e);
        }

        private async void btn_ListarArquivos_Click(object sender, EventArgs e)
        {
            double valor = 0;

            if (String.IsNullOrEmpty(txbTotalMB.Text))
                return;


            if (double.TryParse(txbTotalMB.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out valor))
            {
                InitialSetup.Instance.MegaBytes = valor;
                CreateFile.Instance.CheckedListBox = checkedListBox;
                await CreateFile.Instance.VerificarArquivosAsync();
            }

        }
    }
}