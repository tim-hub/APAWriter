using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAWriterLibrary
{
    public class APAText
    {
        private string content;

        public APAText(string content)
        {
            this.content = content;
        }

        public string get()
        {
            return this.content;
        }

        public void set(string content)
        {
            this.content = content;
        }

        public bool validate()
        {
            return true;
        }

        public void clear()
        {
            content = "";
        }
    }
}
