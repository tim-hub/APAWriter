using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAWriterLibrary
{

    class APAController
    {
        private APAForm theForm;
        private APAWriter theWriter;

        private APAWriter createNew()
        {
            return new APAWriter("");
        }

        public APAController(APAForm theForm)
        {
            this.theForm = theForm;
            
        }

        /// <summary>
        /// user empty string to initialize the input source.
        /// </summary>
        public void init()
        {
            this.theWriter = createNew();
            inputSource("");
        }


        public void clear()
        {
            this.theWriter.clear();
        }

        public string inputSource(string source)
        {
            this.theWriter.inputSource(source);
            return theWriter.export();
        }

    }
}
