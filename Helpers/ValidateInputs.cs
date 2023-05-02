using Large_File_Scanner.Setup;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Large_File_Scanner.Helpers
{
    public static class ValidateInputs
    {
        public static bool InputValues(string totalMegabytes)
        {
            double valor = 0;
            var directoryPath = InitialSetup.Instance.MyPath;

            if (String.IsNullOrEmpty(totalMegabytes) || String.IsNullOrEmpty(directoryPath))
            {
                MessageBox.Show("Operação inválida!");
                return false;
            }

            try
            {
                var files = Directory.GetFiles(directoryPath, "*.*", SearchOption.AllDirectories);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Acesso ao diretório negado. Verifique as permissões de acesso.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (IOException)
            {
                MessageBox.Show("Ocorreu um erro de E/S ao acessar o diretório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (double.TryParse(totalMegabytes, NumberStyles.Float, CultureInfo.InvariantCulture, out valor))
            {
                InitialSetup.Instance.MegaBytes = valor;

                return true;
            }

            return false;
        }
    }
}
