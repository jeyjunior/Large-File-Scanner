using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Large_File_Scanner.Setup
{
    public sealed class InitialSetup
    {
        private static InitialSetup instance = new InitialSetup();
        private static readonly object padlock = new object();
        public static InitialSetup Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new InitialSetup();
                    }
                    return instance;
                }
            }
        }

        private InitialSetup()
        {

        }

        private bool isPathValid = false;
        public bool IsPathValid => isPathValid;

        private string myPath = "";
        public string MyPath
        {
            get => myPath;
            set 
            {
                if(value !=  null)
                {
                    myPath = value;
                    FileName = $"{myPath}\\{fileName}.txt";
                    Gitattributes = $"{myPath}\\gitattributes.txt";
                    isPathValid = true;
                }
                else
                {
                    isPathValid = false;
                }
            }
        }


        private double megabytes = 0;
        public double MegaBytes 
        { 
            get => megabytes;
            set
            {
                megabytes = value * 1024 * 1024;
            }
        }

        private string fileName = "Lista de arquivos";
        public string FileName { get => fileName; private set => fileName = value; }

        
        private string gitattributes = "";
        public string Gitattributes { get => gitattributes; private set => gitattributes = value; }


        private readonly string gitattributesFormat = "filter=lfs diff=lfs merge=lfs -text";
        public string GitattributesFormat => gitattributesFormat;



    }
}
