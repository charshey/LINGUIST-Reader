using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace FinalProject
{
    class IssueScanner
    {
        private string path;

        public IssueScanner(string p)
        {
            path = p;
        }

        public void readInfo(Database db)
        {
            try
            {
                TextFieldParser csvParser = new TextFieldParser(path + "\\saved.txt");
                csvParser.TextFieldType = FieldType.Delimited;
                csvParser.SetDelimiters(",");
                while (!csvParser.EndOfData)
                {
                    string[] parts = csvParser.ReadFields();
                    if (parts == null) { break; }

                    Issue thisIssue = db.getIssues().Where(issue => issue.getName() == parts[0]).FirstOrDefault();
                    thisIssue.setComment(parts[1]);
                    if (Boolean.TryParse(parts[2], out bool flag))
                    {
                        thisIssue.setStarred(flag);
                    }
                }
            }
            catch(FileNotFoundException)
            {
                return;
            }

        }

        public void writeInfo(Database db)
        {
            try
            {
                File.WriteAllText(path + "\\saved.txt", String.Empty);
            }
            catch(FileNotFoundException)
            {
                File.Create(path + "\\saved.txt").Close();
            }
            Issue[] issueArray = db.getIssues();
            StreamWriter sw = new StreamWriter(path + "\\saved.txt");
            foreach (Issue issue in issueArray)
            {
                if (issue.getComment() != "Type your notes for this issue here." || issue.getStarred())
                {
                    sw.WriteLine(issue.getName() + "," + issue.getComment() + "," + issue.getStarred().ToString());
                    sw.Flush();
                }
            }
        }
    }
}
