using Large_File_Scanner.Components;

namespace Large_File_Scanner.Setup
{
    public sealed class FileChecker
    {
        private static readonly FileChecker instance = new FileChecker();
        private readonly Dictionary<string, double> filesLength = new Dictionary<string, double>();
        private readonly Dictionary<string, int> filesCount = new Dictionary<string, int>();
        private readonly Dictionary<int, string> allFiles = new Dictionary<int, string>();

        private FileChecker()
        {
        }

        public static FileChecker Instance => instance;

        public Dictionary<string, double> FilesLength => filesLength;

        public Dictionary<string, int> FilesCount => filesCount;

        public Dictionary<int, string> AllFiles => allFiles;

        private void ClearCollections()
        {
            filesLength.Clear();
            filesCount.Clear();
            allFiles.Clear();
        }

        public async Task VerificarArquivosAsync(CheckedListBox checkedListBox, string directoryPath, double minimumSizeInMegaBytes)
        {
            ClearCollections();

            try
            {
                var directoryInfo = new DirectoryInfo(directoryPath);
                var searchOption = SearchOption.AllDirectories;
                var files = directoryInfo.GetFiles("*.*", searchOption);

                MainProgressBar.Instance.MaxValueProgressBar(files.Count());
                int count = 0;
                foreach (var file in files)
                {
                    try
                    {
                        count++;
                        MainProgressBar.Instance.UpdateProgressBar(count);

                        var sizeInMegaBytes = file.Length / 1024.00 / 1024.00;
                        if (sizeInMegaBytes < minimumSizeInMegaBytes)
                            continue;

                        var extension = file.Extension;

                        if (string.IsNullOrEmpty(extension))
                        {
                            extension = "Undefined type";
                        }

                        if (!filesLength.ContainsKey(extension))
                        {
                            filesLength.Add(extension, file.Length);
                            filesCount.Add(extension, 1);
                        }
                        else
                        {
                            filesLength[extension] += file.Length;
                            filesCount[extension]++;
                        }

                        var path = file.DirectoryName;
                        var value = $"{file.Name} \t size: {sizeInMegaBytes:F2}mb\npath: {path}";
                        allFiles.Add(allFiles.Count, value);
                    }
                    catch (Exception ex)
                    {
                        // Handle exception, log error, etc.
                    }


                }

                AddItemsToCheckedListBox(checkedListBox);
            }
            catch (Exception ex)
            {
                // Handle exception, log error, etc.
            }

            await Task.CompletedTask;
        }

        private void AddItemsToCheckedListBox(CheckedListBox checkedListBox)
        {
            checkedListBox.Invoke((MethodInvoker)(() => {
                checkedListBox.Items.Clear();

                foreach (var entry in filesLength)
                {
                    if (filesCount.TryGetValue(entry.Key, out int count))
                    {
                        double size = entry.Value / 1024 / 1024;
                        string sizeFormat = "mb";

                        if (size > 1024)
                        {
                            size /= 1024;
                            sizeFormat = "gb";
                        }

                        string item = $"{entry.Key} [{count}] - total: {size:F2} {sizeFormat}";
                        checkedListBox.Items.Add(item, true);
                    }
                }
            }));
        }
    }
}
