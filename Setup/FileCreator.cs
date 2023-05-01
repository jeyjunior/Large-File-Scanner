using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Large_File_Scanner.Setup
{
    public sealed class FileCreator
    {
        //Singleton
        private static FileCreator instance = new FileCreator();
        private FileCreator()
        {
        }
        public static FileCreator Instance => instance ?? new FileCreator();



        public async Task CriarArquivosAsync(CheckedListBox checkedListBox)
        {
            await Task.Run(() => {
                CriarArquivoListandoOsTipos();
                CriarArquivoGitAttributes(checkedListBox);
            });
        }

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
                    file.WriteLine($"{item.Key}{item.Value}\n");
                }
            }
        }


        //Será criado o arquivo gitattributes com os formatos selecionados pelo usuário
        private void CriarArquivoGitAttributes(CheckedListBox checkedListBox)
        {
            var git = InitialSetup.Instance.Gitattributes;
            var gitFormat = InitialSetup.Instance.GitattributesFormat;

            using (var gitFile = new StreamWriter(git))
            {
                foreach (string item in checkedListBox.CheckedItems)
                {
                    var i = item.IndexOf('[') - 1;
                    gitFile.WriteLine($"*{item.Substring(0, i)} {gitFormat}");
                }
            }
        }
    }
}
