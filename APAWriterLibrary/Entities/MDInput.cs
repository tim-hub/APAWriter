using System;
namespace APAWriterLibrary
{
    /// <summary>
    /// This is the class for store the content in the Markdinw-like format.
    /// </summary>
    public class MDInput
    {
        protected string content;
        public MDInput(string content) 
        {
            this.content = content;
        }

        public string Get()
        {
            return content;
        }

        public void Set(string content)
        {
            this.content = content;
        }

    }
}
