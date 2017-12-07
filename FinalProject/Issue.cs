using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FinalProject
{
    class Issue
    {

        private string path;
        private System.Uri uri;
        private string text; 
        private string title;
        private string comment;
        private string area;
        private bool starred;

        public Issue(string p)
        {
            path = p;
            text = File.ReadAllText(path);
            setTitle(text);
            uri = new System.Uri(path);
            starred = false;
            this.setArea();
        }

        public void setTitle(string text)
        {
            string pattern = @"<TITLE>(.*?)<\/TITLE>";
            Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
            Match m = r.Match(text);
            title = m.Value;
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
            string pattern = @":\s(.*):";
            Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
            Match m = r.Match(this.title);
            char[] stripChars = { ' ', ':' };
            area = m.Value.TrimEnd(stripChars).TrimStart(stripChars);
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
