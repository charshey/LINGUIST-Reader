using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{

    public class Database
    {
        private DirectoryInfo location;
        private Issue[] issueArray;
        
        public Database(string path)
        {
            location = new DirectoryInfo(path);
            FileInfo[] files = location.GetFiles("*.htm");
            int fileCount = files.Length;
            issueArray = new Issue[fileCount];

            int index = 0;

            foreach(FileInfo file in files)
            {
                issueArray[index] = new Issue(file);  
                index += 1;
            }
            
        }

        public List<Issue> getIssues(string name, string text)
        {
            List<Issue> matchingIssues = new List<Issue>();

            foreach(Issue issue in issueArray)
            {
                if(issue.getArea() == name || issue.getArea() == text)
                {
                    matchingIssues.Add(issue);
                }
            }
            return matchingIssues;
        }
    }
}
