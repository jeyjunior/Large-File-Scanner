using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;

namespace Large_File_Scanner.Setup
{
    public sealed class CreateFile
    {
        private static CreateFile instance = new CreateFile();
        
        private CheckedListBox checkedListBox = new CheckedListBox();
        public CheckedListBox CheckedListBox { get => checkedListBox; set => checkedListBox = value; }

        private List<string> checkedFiles = new List<string>();

        private CreateFile()
        {
        }

        public static CreateFile Instance
        {
            get
            {
                return instance;
            }
        }

        public async Task VerificarArquivosAsync()
        {
            await Task.Run(SetCheckedListBox);
        }
        public async Task CriarArquivosAsync()
        {
            await Task.Run(CriarArquivoListandoOsTipos);
        }



        private void SetCheckedListBox()
        {
            var myPath = InitialSetup.Instance.MyPath;
            var mb = InitialSetup.Instance.MegaBytes;


            string[] arquivos = Directory.GetFiles(myPath, "*.*", SearchOption.AllDirectories);

            List<string> fileList = new List<string>();

            foreach (var item in arquivos)
            {
                FileInfo infoArquivo = new FileInfo(item);

                if ((infoArquivo.Length / 1024.00 / 1024.00) >= mb)
                {
                    if (!fileList.Contains(infoArquivo.Extension))
                    {
                        var type = infoArquivo.Extension;
                        if (String.IsNullOrEmpty(type)) type = "Undefined type";
                        
                        fileList.Add(type);
                    }
                }
            }

            checkedListBox.Invoke((MethodInvoker)(() =>
            {
                checkedListBox.Items.Clear();
                foreach (var item in fileList)
                {
                    checkedListBox.Items.Add(item, true);
                }
            }));
        }
        private void CriarArquivoListandoOsTipos()
        {
            var fileName = InitialSetup.Instance.FileName;
            var mb = InitialSetup.Instance.MegaBytes;

            using (StreamWriter file = new StreamWriter(fileName))
            {
                file.WriteLine($"Arquivos com tamanho maior ou igual que {mb:F2} mb");
                CriarArquivoGitAttributes(file, mb);
            }
        }
        private void CriarArquivoGitAttributes(StreamWriter file, double mb)
        {
            var myPath = InitialSetup.Instance.MyPath;
            var git = InitialSetup.Instance.Gitattributes;
            var gitFormat = InitialSetup.Instance.GitattributesFormat;

            //string[] arquivos = Directory.GetFiles(myPath, "*.*", SearchOption.AllDirectories);

            using (var gitFile = new StreamWriter(git))
            {
                foreach (string item in checkedListBox.CheckedItems)
                {
                    gitFile.WriteLine($"*{item} {gitFormat}");
                }

                //foreach (var item in arquivos)
                //{
                //    FileInfo infoArquivo = new FileInfo(item);

                //    if (infoArquivo.Length >= mb)
                //    {
                //        var length = infoArquivo.Length / 1024.0 / 1024.0;
                //        file.WriteLine($"{infoArquivo.Extension}\t{length:F2} mb");
                        
                //        if (!formatos.ContainsKey(infoArquivo.Extension))
                //        {
                            
                //            formatos.Add(infoArquivo.Extension, true);
                //        }
                //    }
                //}
            }
        }

    }
}
