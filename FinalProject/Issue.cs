using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FinalProject
{
    public class Issue
    {

        private string path;
        private System.Uri uri;
        private string text; 
        private string title;
        private string comment;
        private string area;
        private bool starred;

        public Issue(FileInfo p)
        {
            path = p.FullName;
            text = File.ReadAllText(path);
            setTitle(text);
            uri = new System.Uri(path);
            starred = false;
            this.setArea();

            System.Diagnostics.Debug.Write("Area: " + area);
        }

        public void setTitle(string text)
        {
            string pattern = @"<TITLE>(.*?)<\/TITLE>";
            Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
            Match m = r.Match(text);
            string striptags = Regex.Replace(m.Value,"<.*?>",String.Empty);
            title = striptags.Replace("LINGUIST List ", "");
        }

        public void setComment(string inputComment)
        {
            comment = inputComment;
        }

        public void setStarred(bool star)
        {
            starred = star;
        }

        private void setArea()
        {
            string pattern = @":\s*([a-zA-Z]+)\s*:";
            Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
            Match m = r.Match(this.title);
            area = m.Groups[1].Value;
        }

        public System.Uri getURI()
        {
            return uri;
        }

        public string getTitle()
        {
            return title;
        }

        public string getComment()
        {
            return comment;
        }

        public string getArea()
        {
            return area;
        }

        public bool getStarred()
        {
            return starred;
        }

    }
}
