using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAWriterLibrary
{
    public class HelpDoc:MDInput
    {
        public HelpDoc(string content):base(content)
        {
           
        }

        public string getHepDoc()
        {
            return this.Get();
        }

        
    }
}
