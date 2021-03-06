﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace APAWriterLibrary
{
    /// <summary>
    /// This is the UI of the application.
    /// All users' operations are here.
    /// </summary>
    public partial class APAForm: UserControl
    {

        private string docPath = @"C:\Users\User\Documents\a.tex";

        private APAController apaController;
        private APPController appController;
        
        private string laTexPreview;

        public APAForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            this.apaController = new APAController(this);
            this.apaController.Init();

            this.appController = new APPController();

            
        }

        private void Clear()
        {
            Console.WriteLine("clearing");
            this.apaController.Clear();
            inputBox.Clear();
            outputBox.Clear();
        }

        private void Save(String path)
        {

            Console.WriteLine("saving to " + path);
            this.appController.Save(
                outputBox.Text,
                path);
        }

        private void Input(String userInput)
        {
            Thread.Sleep(100);
            this.laTexPreview= this.apaController.ExportToLaTeX(userInput);

            this.outputBox.Text = laTexPreview;
        }

        private void Preview(String latexOut)
        {
            outputBox.Text= this.laTexPreview;
        }

        private void Quit()
        {
            this.appController.Quit();
            MessageBox.Show("Goodbye");
            Application.Exit();
        }

        private string getSyntaxhelp()
        {
            return appController.GetSyntaxHelp();
        }

        private string getControlHelp()
        {
            return appController.GetControlHelp();
        }

        private void outputBox_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Output preview changed too");
            Input(inputBox.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Input(inputBox.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            
            
            docPath = System.IO.Directory.GetCurrentDirectory()
            +"APATemp.tex";

            Save(docPath);
            
            MessageBox.Show("Save to MyDocuments");
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void btnCtrlHelp_Click(object sender, EventArgs e)
        {
            Clear();
            inputBox.Text = getControlHelp();
            Input(inputBox.Text);
        }

        private void btnSyntaxHelp_Click(object sender, EventArgs e)
        {
            Clear();
            inputBox.Text = getSyntaxhelp();
            Input(inputBox.Text);
        }
    }
}
