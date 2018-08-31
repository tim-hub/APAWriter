﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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
            string source =  this.sourceInput.get();
            //System.Diagnostics.Debug.WriteLine("input" + source);

            

            string headingPattern = @"# ([a-zA-Z0-9])\w* ";
            Regex regex = new Regex(headingPattern, RegexOptions.IgnoreCase);
            string newSource = source;

            MatchCollection matches = regex.Matches(source);

            newSource += matches.Count;
            foreach(Match m in matches)
            {

            }

            //string newSource = source.Replace("a", "b");
            
            

            //System.Diagnostics.Trace.WriteLine("output: " + source);

            return newSource;
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