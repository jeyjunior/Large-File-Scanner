using Large_File_Scanner.Components;
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

        private void btn_GerarArquivo_Click(object sender, EventArgs e)
        {
            FileCreator.Instance.CriarArquivosAsync(checkedListBox);
        }

        private void txbTotalMB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidateTypedSize.KeyPress(sender, e);
        }

        private async void btn_ListarArquivos_Click(object sender, EventArgs e)
        {
            if (ValidateInputs.InputValues(txbTotalMB.Text))
            {
                var directoryPath = InitialSetup.Instance.MyPath;
                await Task.Run(async () =>
                {
                    await FileChecker.Instance.VerificarArquivosAsync(checkedListBox, directoryPath, InitialSetup.Instance.MegaBytes);
                });
            }
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            MainCheckedListBox.Instance.CheckOrUncheck(false);
        }

        private void btn_Uncheck_Click(object sender, EventArgs e)
        {
            MainCheckedListBox.Instance.CheckOrUncheck(false);
        }



        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Frm_Principal;

            MainCheckedListBox.Instance.SetCheckedListBox(checkedListBox);
            MainProgressBar.Instance.SetProgressBar(mainProgressBar);
        }
    }
}