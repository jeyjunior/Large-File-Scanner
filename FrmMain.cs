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
            }
        }

        private async void btn_GerarArquivo_Click(object sender, EventArgs e)
        {
            await FileCreator.Instance.CriarArquivosAsync(checkedListBox);
        }

        private void txbTotalMB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidateTypedSize.KeyPress(sender, e);
        }

        private async void btn_ListarArquivos_Click(object sender, EventArgs e)
        {
            double valor = 0;
            var myPath = InitialSetup.Instance.MyPath;

            if (String.IsNullOrEmpty(txbTotalMB.Text) || String.IsNullOrEmpty(myPath))
            {
                MessageBox.Show("Opera��o inv�lida!");
                return;


            if (double.TryParse(txbTotalMB.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out valor))
            {
                InitialSetup.Instance.MegaBytes = valor;
                await FileChecker.Instance.VerificarArquivosAsync(checkedListBox);
            }
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            SetCheckedListBoxValues(true);
        }

        private void btn_Uncheck_Click(object sender, EventArgs e)
        {
            SetCheckedListBoxValues(false);
        }

        private void SetCheckedListBoxValues(bool value)
        {
            if (checkedListBox.Items.Count > 0)
            {
                for (int i = 0; i < checkedListBox.Items.Count; i++)
                {
                    checkedListBox.SetItemChecked(i, value);
                }

                return;
            }

            MessageBox.Show("Nenhum item listado!", "Falha!", MessageBoxButtons.OK);
        }
    }
}