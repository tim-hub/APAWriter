using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAWriterLibrary.Entities
{
    public class ControlHelp : HelpDoc
    {
        public ControlHelp(string content):base(content)
        {

        }

        public override void setHelpDoc(string content)
        {
            this.set(content);
        }
    }
}
