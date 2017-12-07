using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{

    class Database
    {
        private string location;
        private Issue[] issueArray;
        
        public Database(string path)
        {
            location = path;
            string[] files = Directory.GetFiles(location, "*.htm", SearchOption.AllDirectories);
            int fileCount = files.Length;
            issueArray = new Issue[fileCount];

            int index = 0;

            foreach(string file in files)
            {
                issueArray[index] = new Issue(file);  
                index += 1;
            }
            
        }

        public List<Issue> getIssues(string area)
        {
            List<Issue> matchingIssues = new List<Issue>();

            foreach(Issue issue in issueArray)
            {
                if(issue.getArea() == area)
                {
                    matchingIssues.Add(issue);
                }
            }

            return matchingIssues;
        }
    }
}
