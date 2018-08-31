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
        private const string DEFAULTPATH = "";
        private APAController apaController;
        private APPController appController;
        

        private string laTexPreview;

        public APAForm()
        {
            InitializeComponent();
            openAndCreate();
        }

        private void openAndCreate()
        {
            this.apaController = new APAController(this);
            this.apaController.init();

            this.appController = new APPController();
        }

        private void clear()
        {
            Console.WriteLine("clearing");
            this.apaController.clear();
            inputBox.Clear();
            outputBox.Clear();
        }

        private void save(String path)
        {
            Console.WriteLine("saving to " + path);
            this.appController.save(
                this.apaController.inputSource(inputBox.Text),
                path);
        }

        private void input(String userInput)
        {

            this.laTexPreview= this.apaController.inputSource(userInput);

            this.outputBox.Text = laTexPreview;
        }

        private void preview(String latexOut)
        {
            outputBox.Text= this.laTexPreview;
        }

        private void quit()
        {
            this.appController.quit();
            MessageBox.Show("Goodbye");
            Application.Exit();
        }

        private string getSyntaxhelp()
        {
            return appController.getSyntaxhelp();
        }

        private string getControlHelp()
        {
            return appController.getControlhelp();
        }

        private void outputBox_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Output preview changed too");
            input(inputBox.Text);
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
