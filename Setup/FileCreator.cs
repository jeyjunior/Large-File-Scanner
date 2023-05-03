
namespace Large_File_Scanner.Setup
{
    public sealed class FileCreator
    {
        //Singleton
        private static FileCreator instance = new FileCreator();
        private FileCreator()
        {
        }
        public static FileCreator Instance => instance ??= new FileCreator();

        public void CriarArquivosAsync(CheckedListBox checkedListBox)
        {
            CriarArquivoListandoOsTipos();
            CriarArquivoGitAttributes(checkedListBox);
        }

        //Será criado uma lista de arquivos txt contendo todos os arquivos que foram encontrados
        //e que possuem o tamanho definido pelo usuario
        private void CriarArquivoListandoOsTipos()
        {
            var allFiles = FileChecker.Instance.AllFiles;
            var fileName = InitialSetup.Instance.FileName;
            var mb = InitialSetup.Instance.MegaBytes;

            using (StreamWriter file = new StreamWriter(fileName))
            {
                file.WriteLine($"Arquivos com tamanho maior ou igual que {mb:F2} mb\n\n");

                foreach (var item in allFiles)
                {
                    file.WriteLine($"{item.Key} - {item.Value}\n");
                }
            }
        }


        //Será criado o arquivo gitattributes com os formatos selecionados pelo usuário
        private void CriarArquivoGitAttributes(CheckedListBox checkedListBox)
        {
            var gitAttributes = InitialSetup.Instance.Gitattributes;
            var gitFormat = InitialSetup.Instance.GitattributesFormat;

            try
            {
                using (var gitFile = new StreamWriter(gitAttributes))
                {
                    foreach (string item in checkedListBox.CheckedItems)
                    {
                        var i = item.IndexOf('[') - 1;
                        gitFile.WriteLine($"*{item.Substring(0, i)} {gitFormat}");
                    }
                }

                MessageBox.Show("Arquivos criado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao criar o arquivo. \nCertifique-se de que todas os valores foram definidos corretamente!\nDetalhes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
