﻿using System;
using System.Text.RegularExpressions;

namespace APAWriterLibrary.Entities
{
    class HeadingRE:APARegularExpression
    {
        public HeadingRE(string re) : base(re)
        {
            
        }

        private string ReplaceByMatch(string source,string content, Match m)
        {
            string tmp = "\\section{";
            string newValue = "";
            try
            {
                newValue = tmp + content.Substring(m.Index + 1, m.Length).Trim() + "}";
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
                // duting the user inputing
                // there might be this exception
                Console.WriteLine(e);
            }

            return content;

            

        }
    }
}
