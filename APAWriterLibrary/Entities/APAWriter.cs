using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace APAWriterLibrary
{
    class APAWriter:MDInput
    {
        public APAWriter(string content) : base(content)
        {

        }

        public void Clear()
        {
            this.content = null;
        }

        /// <summary>
        /// This is for validating the input content.
        /// It is an optional feature in future.
        /// Currently, check is null or not only
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool Validate(string source)
        {
            if(source != null)
            {
                return true;
            }

            return false;

            
        }
    }
}
