using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FinalProject
{
    /// <summary>
    /// Class Issue represents an issue object with saved meta information relating to a specific issue file.
    /// </summary>
    public class Issue
    {
        /// <summary>
        /// The path to the issue file.
        /// </summary>
        private string path;
        /// <summary>
        /// The filename of the issue file.
        /// </summary>
        private string name;
        /// <summary>
        /// The URI to the issue file.
        /// </summary>
        private System.Uri uri;
        /// <summary>
        /// The text of the html issue file.
        /// </summary>
        private string text;
        /// <summary>
        /// The title of the issue taken from the title tags in the html.
        /// </summary>
        private string title;
        /// <summary>
        /// The user comment associated with this issue.
        /// </summary>
        private string comment;
        /// <summary>
        /// The area of this issue, taken from the prefix of the title.
        /// </summary>
        private string area;
        /// <summary>
        /// The bookmark status of this issue.
        /// </summary>
        private bool bookmarked;

        /// <summary>
        /// Initializes a new instance of the <see cref="Issue"/> class.
        /// </summary>
        /// <param name="p">The fileinfo for the issue file.</param>
        public Issue(FileInfo p)
        {
            // get the name from the filename
            name = p.Name;
            // get the path from the full filename
            path = p.FullName;
            // get all the text of the issue file
            text = File.ReadAllText(path);
            // set the title with this text
            setTitle(text);
            // set the uri for this issue for later browser navigation
            uri = new System.Uri(path);
            // set the bookmarked to false by default
            bookmarked = false;
            // set the area
            this.setArea();
            // set the comment to the default.
            this.setComment("Type your notes for this issue here.");
        }

        /// <summary>
        /// Sets the title for the issue by extracting it from html title tags in the text.
        /// </summary>
        /// <param name="text">The text of the issue file.</param>
        public void setTitle(string text)
        {
            // regex pattern to find the content in the tags
            string pattern = @"<TITLE>(.*?)<\/TITLE>";
            // get the regex matches
            Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
            Match m = r.Match(text);
            // strip the tags and LINGUIST List prefix from the result
            string striptags = Regex.Replace(m.Value,"<.*?>",String.Empty);
            title = striptags.Replace("LINGUIST List ", "");
        }

        /// <summary>
        /// Sets the user comment for this issue.
        /// </summary>
        /// <param name="inputComment">The input comment.</param>
        public void setComment(string inputComment)
        {
            comment = inputComment;
        }

        /// <summary>
        /// Sets the bookmark status.
        /// </summary>
        /// <param name="b">if set to <c>true</c> [b].</param>
        public void setBookmarked(bool b)
        {
            bookmarked = b;
        }

        /// <summary>
        /// Sets the area by looking in the title prefix.
        /// </summary>
        private void setArea()
        {
            // regex pattern to look between colons in the title prefix
            string pattern = @":\s*([a-zA-Z]+)\s*:";
            // find matching groups
            Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
            Match m = r.Match(this.title);
            // set the matching group as the area
            area = m.Groups[1].Value;
        }

        /// <summary>
        /// Gets the URI for this issue
        /// </summary>
        /// <returns>System.Uri.</returns>
        public System.Uri getURI()
        {
            return uri;
        }

        /// <summary>
        /// Gets the title for this issue.
        /// </summary>
        /// <returns>System.String.</returns>
        public string getTitle()
        {
            return title;
        }

        /// <summary>
        /// Gets the filename for this issue.
        /// </summary>
        /// <returns>System.String.</returns>
        public string getName()
        {
            return name;
        }

        /// <summary>
        /// Gets the comment for this issue.
        /// </summary>
        /// <returns>System.String.</returns>
        public string getComment()
        {
            return comment;
        }

        /// <summary>
        /// Gets the area for this issue.
        /// </summary>
        /// <returns>System.String.</returns>
        public string getArea()
        {
            return area;
        }

        /// <summary>
        /// Gets the bookmarked status for this issue.
        /// </summary>
        /// <returns>Bool bookmarked status</returns>
        public bool getBookmarked()
        {
            return bookmarked;
        }

    }
}
