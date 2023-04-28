using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;

namespace Large_File_Scanner.Setup
{
    public sealed class CreateFile
    {
        private static CreateFile instance = new CreateFile();
        private Dictionary<string, bool> formatos = new Dictionary<string, bool>();
        private CheckedListBox checkedListBox = new CheckedListBox();
        public CheckedListBox CheckedListBox { get => checkedListBox; set => checkedListBox = value; }


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
            var fileName = InitialSetup.Instance.FileName;
            var mb = InitialSetup.Instance.MegaBytes;

            await Task.Run(() =>
            {
                using (StreamWriter file = new StreamWriter(fileName))
                {
                    file.WriteLine($"Arquivos com tamanho maior ou igual que {(mb / 1024 / 1024):F2} mb");

                    SetCheckedListBox();
                    //CriarArquivos(file, mb);
                }
            });
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

                if (infoArquivo.Length >= mb)
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


        private void CriarArquivos(StreamWriter file, double mb)
        {
            var myPath = InitialSetup.Instance.MyPath;
            var git = InitialSetup.Instance.Gitattributes;
            var gitFormat = InitialSetup.Instance.GitattributesFormat;

            string[] arquivos = Directory.GetFiles(myPath, "*.*", SearchOption.AllDirectories);

            using (var gitFile = new StreamWriter(git))
            {
                foreach (var item in arquivos)
                {
                    FileInfo infoArquivo = new FileInfo(item);

                    if (infoArquivo.Length >= mb)
                    {
                        var length = infoArquivo.Length / 1024.0 / 1024.0;
                        file.WriteLine($"{infoArquivo.Extension}\t{length:F2} mb");

                        if (!formatos.ContainsKey(infoArquivo.Extension))
                        {
                            gitFile.WriteLine($"*{infoArquivo.Extension} {gitFormat}");
                            formatos.Add(infoArquivo.Extension, true);
                        }
                    }
                }
            }
        }

    }
}
