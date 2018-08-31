using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAWriterLibrary.Entities
{
    public class SyntaxHelp:HelpDoc
    {
        public SyntaxHelp(string content) : base(content)
        {

        }

        /// <summary>
        /// This can be different with ContrlHelp.
        /// </summary>
        /// <param name="content"></param>

        public override void setHelpDoc(string content)
        {
            this.set(content);
        }
    }
}
