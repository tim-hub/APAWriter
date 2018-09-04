using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APAWriterLibrary.Entities;

namespace APAWriterLibrary
{

    class APAController
    {
        private APAForm theForm;
        private APAWriter theWriter;
        private List<APARegularExpression> res;

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
        public void Init()
        {
            this.theWriter = createNew();
            ExportToLaTeX("");

            // initiate and add re into the collection
            res.Add(new HeadingRE(@"# \b(?<word>\w+) +"));
        }


        public void Clear()
        {
            this.theWriter.Clear();
        }

        public string ExportToLaTeX(string source)
        {
            if (APAWriter.Validate(source))
            {
                this.theWriter.Set(source);

                string tmpSource = source;

                foreach(APARegularExpression re in res)
                {
                    tmpSource=re.Replace(tmpSource);
                }

                return tmpSource;
                
            }

            return "Errors, cannot rendered to LaTex";
            
            
        }

    }
}
