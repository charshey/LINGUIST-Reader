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
        /// 
        /// The goal of this program is to be a reader application to access and save personalized notes on issues of the 
        /// LINGUIST List. For this version of the application, HTML issues are accessed locally.

        [STAThread]
        static void Main()
        {
            string path = Path.GetFullPath(Path.Combine(System.IO.Directory.GetCurrentDirectory(), @"..\..\..\")) + @"\Issues";
            Database issuesDB = new Database(path);

            //string savedpath = Path.GetFullPath(Path.Combine(System.IO.Directory.GetCurrentDirectory(), @"..\..\..\")) + @"\SavedIssues";
            //Database savedIssuesDB = new Database(path);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Reader(issuesDB));
        }
    }
}
