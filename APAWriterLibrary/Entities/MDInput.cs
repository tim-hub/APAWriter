using System;
namespace APAWriterLibrary
{
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
