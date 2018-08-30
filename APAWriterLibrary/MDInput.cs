using System;
namespace APAWriterLibrary
{
    public class MDInput
    {
        private string content;
        public MDInput(string content)
        {
            set(content);
        }

        public string get()
        {
            return this.content;
        }

        public void set(string content)
        {
            if(validate())
            {
                this.content = content;
            }
           
        }

        public void clear()
        {
            this.content = "";
        }
        /// <summary>
        /// this validate function is not the feature in the 6 features designed 
        /// it is an optional feature in the future.
        /// </summary>

        public bool validate()
        {
            return true;
            // it should check whether the input is legal markdown format.
        }
    }
}
