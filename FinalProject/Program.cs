using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    static class Program
    {

        /// Clare Harshey
        /// Indiana University
        /// CSCI-A590
        /// Final Project
        /// Last Edited: 12/8/2017
        /// <summary>
        /// The goal of this program is to be a reader application to access and save personalized notes on issues of the 
        /// LINGUIST List. For this version of the application, HTML issues are accessed locally from the "Issues" folder
        /// in the project directory. See README and User Guide for more details.
        /// </summary>

        [STAThread]
        static void Main()
        {
            // get path for issues folder in project directory
            string path = Path.GetFullPath(Path.Combine(System.IO.Directory.GetCurrentDirectory(), @"..\..\..\")) + @"\Issues";

            // create the issue database with issue objects
            Database issuesDB = new Database(path);

            // create scanner and scan in any saved information about issues that have custom notes or are bookmarked.
            IssueScanner scanner = new IssueScanner(path);
            scanner.readInfo(issuesDB);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // run reader
            Application.Run(new Reader(issuesDB));

            // before closing, write updated issue information to the saved.txt file in the Issues folder.
            scanner.writeInfo(issuesDB);
        }
    }
}
