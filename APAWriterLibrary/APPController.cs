using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APAWriterLibrary.Entities;

namespace APAWriterLibrary
{
    public class  APPController
    {
        

        private const string CONTROLTEXT = @"
# Control Help Doc.


This is a control help 
which can be viewed at anytime 
when you click the help button.

";
        private const string SYNTAXTEXT = @"
# Syntax Help Doc.


This is an example which can be viewed at anytime 
when you click the help button.

Currently,

# Heading 1

## Heading 2


- item1
- item2
- item3

";

        private  HelpDoc syntaxDoc;
        private  HelpDoc controlDoc;
        
        /// <summary>
        /// When the controller created, the help do will be initialized too.
        /// 
        /// </summary>
        public APPController()
        {
            syntaxDoc = new HelpDoc(SYNTAXTEXT);
        
            controlDoc= new HelpDoc(CONTROLTEXT);  
        }



        public void Quit()
        {
            Console.WriteLine("App closing");            
        }

        public string GetSyntaxHelp()
        {
            return syntaxDoc.getHepDoc();
        }

        public string GetControlHelp()
        {
            return controlDoc.getHepDoc();
        }

        public void Save(string content, string path )
        {
            path = path + "a.tex";

            File.WriteAllText(path, content);

        }


    }
}
