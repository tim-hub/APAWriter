using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAWriterLibrary
{
    /// <summary>
    /// This is the class for help document which can be showed in application.
    /// </summary>
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
