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
        private List<APARegularExpression> res = new List<APARegularExpression>();

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

            // initiate and add re into the collection, 
            // use RE @"(\n)## \b(?<word>\w+) +(\r)(\n)")
            res.Add(new Heading2RE(@"(\n|^)## .*?(?=\n|$)"));
            res.Add(new HeadingRE(@"(\n|^)# .*?(?=\n|$)"));
            res.Add(new ListRE(@"(\n|^)- .*?(?=\n|$)"));
            
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
