using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class IssueScanner
    {
        private DirectoryInfo location;
        private FileInfo file;

        public IssueScanner(string p)
        {
            location = new DirectoryInfo(p);
            file = location.GetFiles("saved.txt")[0];

        }

        public void readInfo(Database db)
        {
            string text = File.ReadAllText(file.FullName);
            System.Diagnostics.Debug.Write(text);

        }
    }
}
