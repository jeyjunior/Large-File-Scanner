using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Large_File_Scanner.Setup
{
    public class InitialSetup
    {
        private string path = "";
        private float megabytes = 0;
        public float MegaBytes
        {
            get { return megabytes; }
            set { megabytes = value; }
        }
        private string fileName = "Lista de arquivos ";

        public InitialSetup()
        {

        }

        public string FindPath()
        {
            var fdb = new FolderBrowserDialog();

            if (fdb.ShowDialog() == DialogResult.OK)
            {
                path = fdb.SelectedPath;
                fileName = $"{path}\\{fileName}.txt";
            }

            return path;
        }


        public void GerarArquivo(float mb)
        {
            megabytes = mb;

            using (StreamWriter file = new StreamWriter(fileName))
            {
                file.WriteLine($"Arquivos com tamanho maior ou igual que {megabytes}mb");
            }
        }
    }
}
