using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace FinalProject
{
    /// <summary>
    /// Class IssueScanner: a scanner to read and write to the saved issue information.
    /// </summary>
    class IssueScanner
    {
        /// <summary>
        /// The path to the issues directory.
        /// </summary>
        private string path;

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueScanner"/> class.
        /// </summary>
        /// <param name="p">The p.</param>
        public IssueScanner(string p)
        {
            // path set to input path string.
            path = p;
        }

        /// <summary>
        /// Reads the information in the saved issues file and updates the database.
        /// </summary>
        /// <param name="db">The database being updated.</param>
        public void readInfo(Database db)
        {
            // try to read in the information.
            try
            {
                // create new csv parser from visual basic textfieldparser.
                TextFieldParser csvParser = new TextFieldParser(path + "\\saved.txt");
                // set the parser to be delimited by commas.
                csvParser.TextFieldType = FieldType.Delimited;
                csvParser.SetDelimiters(",");
                // while not end of data in the file
                while (!csvParser.EndOfData)
                {
                    // get an array of items in the line
                    string[] parts = csvParser.ReadFields();
                    // if there's nothing in the line, break
                    if (parts == null) { break; }

                    // get the issue that matches the name information given in the line of text
                    Issue thisIssue = db.getIssues().Where(issue => issue.getName() == parts[0]).FirstOrDefault();
                    // set the issue's comment to the comment information in the line of text
                    thisIssue.setComment(parts[1]);
                    // if the bookmark string here is a valid bool, set the bookmark bool of the issue to that value
                    if (Boolean.TryParse(parts[2], out bool flag))
                    {
                        thisIssue.getBookmarked(flag);
                    }
                }
            }
            // return if file is not found.
            catch(FileNotFoundException)
            {
                return;
            }

        }

        /// <summary>
        /// Writes the updated custom issue information to the saved issue file.
        /// </summary>
        /// <param name="db">The updated database to be saved.</param>
        public void writeInfo(Database db)
        {
            // if the file already exists wipe it
            try
            {
                File.WriteAllText(path + "\\saved.txt", String.Empty);
            }
            // if not found, create it and leave empty
            catch(FileNotFoundException)
            {
                File.Create(path + "\\saved.txt").Close();
            }
            // get array of issues in the database
            Issue[] issueArray = db.getIssues();
            // create new streamwriter and set it to write to that text file
            StreamWriter sw = new StreamWriter(path + "\\saved.txt");
            // for each issue in the array, do the following
            foreach (Issue issue in issueArray)
            {
                // if the issue has a non-default comment or is bookmarked
                if (issue.getComment() != "Type your notes for this issue here." || issue.getBookmarked())
                {
                    // write a line with the filename, comment and bookmark value, delimited by commas
                    sw.WriteLine(issue.getName() + "," + issue.getComment() + "," + issue.getBookmarked().ToString());
                    // flush to write
                    sw.Flush();
                }
            }
        }
    }
}
