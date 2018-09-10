using System;
using System.Text.RegularExpressions;

namespace APAWriterLibrary.Entities
{
    /// <summary>
    /// This is the child class of APA RegularExpression
    /// It is for Heading/section  formatting.
    /// </summary>
    class HeadingRE :APARegularExpression
    {
        public HeadingRE(string re) : base(re)
        {
            
        }
        /// <summary>
        /// Replace the old value by new value in the match.
        /// </summary>
        /// <param name="source">the content which is replaced by other matches</param>
        /// <param name="content">the original content</param>
        /// <param name="m">the match</param>
        /// <returns></returns>
        private string ReplaceByMatch(string source,string content, Match m)
        {
            string tmp = "\n\\section{";
            string newValue = "";
            try
            {
                newValue = tmp + content.Substring(m.Index + 2, m.Length -1 ).Trim() + "}";
                // remove the first # and trim leading and trailing whitespace.

                return ReplaceByValue(source, m.Value, newValue);
            }
            catch (ArgumentOutOfRangeException e)
            {
                // duting the user inputing
                // there might be this exception
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                throw e;
            }
            return content;
        }

        public override string Replace(string content)
        {
            string source = content;
            string headingPattern = this.re;

            Regex regex = new Regex(headingPattern, RegexOptions.IgnoreCase);

            Match match;
            try
            {
                match = regex.Match(source);
                int count = 0;

                if (match.Success)
                {
                    count++;
                    source = ReplaceByMatch(source, content, match);

                    while (match.NextMatch().Success)
                    {
                        count++;
                        match = match.NextMatch();
                        source = ReplaceByMatch(source, content, match);
                    }

                }
                return source;
            }
            catch (ArgumentNullException e)
            {
                // during the user inputing
                // there might be this exception
                Console.WriteLine(e);
            }

            return content;

            

        }
    }
}
