namespace Large_File_Scanner.Components
{
    public class MainProgressBar
    {
        private MainProgressBar() 
        { 
        }
        private static MainProgressBar instance = new MainProgressBar();
        public static MainProgressBar Instance => instance ??= new MainProgressBar();

        private ProgressBar progressBar;

        public void SetProgressBar(ProgressBar progressBar)
        {
            this.progressBar = progressBar;
        }
        public ProgressBar GetProgressBar()
        {
            return progressBar;
        }
        public void SetValue(int value)
        {
            progressBar.Value = value;
        }
        public void SetProgressBarSetup(int max, int min, int value)
        {
            progressBar.Maximum = max;
            progressBar.Minimum = min;
            progressBar.Value = value;
        }
        
        public void MaxValueProgressBar(int totalFiles)
        {
            Instance.GetProgressBar().Invoke(new MethodInvoker(() =>
            {
                Instance.GetProgressBar().Maximum = totalFiles;
            }));
        }

        public void UpdateProgressBar(int value)
        {
            Instance.GetProgressBar().Invoke(new MethodInvoker(() => {
                Instance.GetProgressBar().Value = value;
            }));
        }

    }
}
