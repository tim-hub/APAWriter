using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAWriterLibrary
{
    class APAWriter
    {
        private MDInput sourceInput;

        public APAWriter(string source)
        {
            this.sourceInput = new MDInput(source);
        }

        /// <summary>
        /// the export method will return string in LaTex format.
        /// </summary>
        /// <returns></returns>
        public string export()
        {

            return this.sourceInput.get();
        }

        public void clear()
        {
            this.sourceInput.clear();
        }

        public void inputSource(string source)
        {
            this.sourceInput.set(source);
        }
    }
}
