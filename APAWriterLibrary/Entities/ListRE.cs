using System;
using System.Text.RegularExpressions;

namespace APAWriterLibrary.Entities
{
    /// <summary>
    /// This is the child class of APA RegularExpression
    /// It is for List formatting.
    /// </summary>
    class ListRE:APARegularExpression
    {
        public ListRE(string re) : base(re)
        {
            
        }

        private string ReplaceByMatch(string source,string content, Match m)
        {
            string tmp = "\\item ";
            string newValue = "";
            try
            {
                newValue = tmp + content.Substring(m.Index + 2, m.Length-1);

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
                    source = ReplaceByValue(source, match.Value,
                        "\n\\begin{itemsize} \n" + match.Value);

                    count++;
                    source = ReplaceByMatch(source, content, match);


                    while (match.NextMatch().Success)
                    {
                        source = ReplaceByValue(source, "\\end{itemsize}\n", "\n");
                        count++;
                        match = match.NextMatch();
                        source = ReplaceByValue(source, 
                            match.Value, 
                            match.Value + "\\end{itemsize}\n");
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
