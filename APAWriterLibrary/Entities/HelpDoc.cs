using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAWriterLibrary
{
    public abstract class HelpDoc:APAText
    {
        public HelpDoc(string content):base(content)
        {
           
        }

        public string getHepDoc()
        {
            return this.get();
        }

        abstract public void setHelpDoc(string content);
    }
}
