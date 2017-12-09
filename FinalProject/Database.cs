using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    /// <summary>
    /// This class represents a database comprised of issue objects.
    /// </summary>
    public class Database
    {
        /// <summary>
        /// The location of the issues directory.
        /// </summary>
        private DirectoryInfo location;
        /// <summary>
        /// The array of issues in the database.
        /// </summary>
        private Issue[] issueArray;

        /// <summary>
        /// Initializes a new instance of the <see cref="Database"/> class.
        /// </summary>
        /// <param name="path">The path to the issues directory.</param>
        public Database(string path)
        {
            // set location to the location specified in the path parameter.
            location = new DirectoryInfo(path);
            // get array of .htm files in the location
            FileInfo[] files = location.GetFiles("*.htm");
            // count the files and initialize the issue array with that size
            int fileCount = files.Length;
            issueArray = new Issue[fileCount];
            
            // index to fill out the array
            int index = 0;

            // for each file in the array, do the following
            foreach(FileInfo file in files)
            {
                // initialize that spot in the issue array with a new issue created for this file
                issueArray[index] = new Issue(file);  
                // increment
                index += 1;
            }
            
        }

        /// <summary>
        /// Gets the issues in the database as an array.
        /// </summary>
        /// <returns>Issue[]: array of issues in the database.</returns>
        public Issue[] getIssues()
        {
            return issueArray;
        }

        /// <summary>
        /// Gets the matching issues for a particular area. Checks against both name and text of calling 
        /// code's checkbox.
        /// </summary>
        /// <param name="name">The area name of the checkbox in the calling code.</param>
        /// <param name="text">The area text of the checkbox in the calling code..</param>
        /// <returns>List&lt;Issue&gt;: the list of matching issues.</returns>
        public List<Issue> getMatchingIssues(string name, string text)
        {
            // create list
            List<Issue> matchingIssues = new List<Issue>();

            // for each issue in the database, do the following
            foreach(Issue issue in issueArray)
            {
                // if the issue matches the name or text, add it to the list
                if(issue.getArea() == name || issue.getArea() == text)
                {
                    matchingIssues.Add(issue);
                }
            }
            // return the list.
            return matchingIssues;
        }
    }
}
