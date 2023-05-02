using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Large_File_Scanner.Setup
{
    public sealed class FileChecker
    {
        private static FileChecker instance = new FileChecker();
        private FileChecker()
        { 
        }
        public static FileChecker Instance => instance ?? new FileChecker();

        public Dictionary<string, double> FilesLength { get => filesLength;}
        public Dictionary<string, int> FilesCount { get => filesCount; }
        public Dictionary<string, string> AllFiles { get => allFiles; }


        private Dictionary<string, double> filesLength = new Dictionary<string, double>();
        private Dictionary<string, int> filesCount = new Dictionary<string, int>();
        private Dictionary<string, string> allFiles = new Dictionary<string, string>();



        public async Task VerificarArquivosAsync(CheckedListBox checkedListBox)
        {
            await Task.Run(() =>
            {
                SetCheckedListBox(checkedListBox);
            });
        }


        private void SetCheckedListBox(CheckedListBox checkedListBox)
        {
            var myPath = InitialSetup.Instance.MyPath;
            var mb = InitialSetup.Instance.MegaBytes;

            string[] arquivos = Directory.GetFiles(myPath, "*.*", SearchOption.AllDirectories)
                .Where(arquivo => !arquivo.Contains("\\System Volume Information\\"))
                .ToArray();

            FilesLength.Clear();
            filesCount.Clear();
            allFiles.Clear();


            foreach (var item in arquivos)
            {
                FileInfo fileInfo = new FileInfo(item);

                if ((fileInfo.Length / 1024.00 / 1024.00) >= mb)
                {
                    CheckFiles(fileInfo);
                }
            }

            checkedListBox.Invoke((MethodInvoker)(() =>
            {
                checkedListBox.Items.Clear();
                foreach (string keys in FilesLength.Keys)
                {
                    double value = FilesLength[keys] / 1024 / 1024;
                    double count = filesCount[keys];

                    string i = $"{keys}   [{count}] \t size: {value:F2} mb";
                    checkedListBox.Items.Add(i, true);
                }
            }));
        }
        private void CheckFiles(FileInfo file)
        {
            var size = file.Length / 1024.00 / 1024.00;
            var path = file.Directory;
            var value = $"\t size: {size:F2}\ndir: {path}";
            allFiles.Add(file.Name, value);


            if (!FilesLength.ContainsKey(file.Extension))
            {
                var type = file.Extension;
                if (String.IsNullOrEmpty(type)) type = "Undefined type";

                FilesLength.Add(type, file.Length);
                filesCount.Add(type, 1);

                return;
            }

            FilesLength[file.Extension] += file.Length;
            filesCount[file.Extension]++;
        }

    }
}
