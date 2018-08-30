using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APAWriterLibrary
{
    public partial class APAForm: UserControl
    {
        private APAController controller;

        private string laTexPreview;

        private const string DEFAULTPATH = "";
        
        

        public APAForm()
        {
            InitializeComponent();
            openAndCreate();
        }

        private void openAndCreate()
        {
            this.controller = new APAController(this);
            this.controller.init();
        }

        private void clear()
        {
            Console.WriteLine("clearing");
            this.controller.clear();
            inputBox.Clear();
            outputBox.Clear();
        }

        private void save(String path)
        {
            Console.WriteLine("saving to " + path);
            System.IO.File.WriteAllText(path,
                this.controller.inputSource(inputBox.Text));
        }

        private void input(String userInput)
        {
            this.laTexPreview= this.controller.inputSource(userInput);
        }

        private void preview(String latexOut)
        {
            outputBox.Text= this.laTexPreview;
        }

        private void quit()
        {
            MessageBox.Show("Goodbye");
            Application.Exit();
        }

        private String help()
        {
            return @"
# Help Doc.
This is an example which can be viewed at anytime when you click the help button.

";
        }

        private void outputBox_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Output preview changed too");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            input(inputBox.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            save(DEFAULTPATH);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            quit();
        }
    }
}
