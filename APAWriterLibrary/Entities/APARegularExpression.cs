using System.Text.RegularExpressions;

namespace APAWriterLibrary.Entities
{
    /// <summary>
    /// This is the base class for all APARegularExpression entities.
    /// This is an abstract class with an abstract method, Replace.
    /// </summary>
    abstract class APARegularExpression
    {
        protected string re;

        public APARegularExpression(string re)
        {
            this.re = re;
        }

        /// <summary>
        /// This is a Replace function instead of the default String.Replace.
        /// </summary>
        /// <param name="content">the content</param>
        /// <param name="oldValue">old value in the content</param>
        /// <param name="newValue">new value we want</param>
        /// <returns></returns>
        protected string ReplaceByValue(string content, string oldValue, string newValue)
        {
            return content.Replace(oldValue, newValue);
        }

        public abstract string Replace(string content);

    }
}
