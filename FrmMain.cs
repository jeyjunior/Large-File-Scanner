using Large_File_Scanner.Helpers;
using Large_File_Scanner.Setup;

namespace Large_File_Scanner
{
    public partial class FrmMain : Form
    {
        private InitialSetup initialSetup;


        public FrmMain()
        {
            InitializeComponent();

            initialSetup = new InitialSetup();
        }

        private void btnProcurarPasta_Click(object sender, EventArgs e)
        {
            tbxPastaDestino.Text = initialSetup.FindPath();
        }

        private void btn_GerarArquivo_Click(object sender, EventArgs e)
        {
            initialSetup.GerarArquivo(float.Parse(txbTotalMB.Text));
        }

        private void txbTotalMB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidateTypedSize.KeyPress(sender, e);
        }
    }
}