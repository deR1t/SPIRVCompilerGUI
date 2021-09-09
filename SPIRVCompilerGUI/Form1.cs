using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32.SafeHandles;

namespace SPIRVCompilerGUI
{
    public partial class Form1 : Form
    {

        readonly Process cmdProc = new Process();
        StreamWriter cmd;

        public Form1()
        {
            InitializeComponent();

            // set a different default (hopefully) for larger resolutions
            if(Screen.FromControl(this).Bounds.X > 2000)
            {
                FontSlider.Value = 12;
                ConsoleText.Font = new Font(ConsoleText.Font.FontFamily, FontSlider.Value);
            }

            OptionsFlowPanel.HorizontalScroll.Enabled = false;
            OptionsFlowPanel.HorizontalScroll.Visible = false;
            labelFontSize.Text = FontSlider.Value.ToString();

            // create cfg if it isnt there yet
            if(!File.Exists("config.txt")) { var a = File.Create("config.txt"); a.Close(); }

            // get the config file
            StreamReader file = new StreamReader("config.txt");
            InputFileBox.Text = file.ReadLine();
            OutputFileBox.Text = file.ReadLine();
            GLSLangBox.Text = file.ReadLine();
            file.Close();

            // set up the console!

            cmdProc.StartInfo.FileName = "cmd.exe";
            cmdProc.StartInfo.CreateNoWindow = true;
            cmdProc.EnableRaisingEvents = true;
            cmdProc.StartInfo.RedirectStandardInput = true;
            cmdProc.StartInfo.RedirectStandardOutput = true;
            cmdProc.StartInfo.RedirectStandardError = true;

            cmdProc.ErrorDataReceived += ConsoleDataReceived;
            cmdProc.OutputDataReceived += ConsoleDataReceived;

            cmdProc.Start();
            cmdProc.BeginErrorReadLine();
            cmdProc.BeginOutputReadLine();
            cmd = cmdProc.StandardInput;
            cmd.WriteLine("@echo off\ncls");
            cmd.WriteLine("echo GLSL Tools GUI command line.");
        }

        public void ConsoleDataReceived(object sender, DataReceivedEventArgs e)
        { // https://stackoverflow.com/questions/7609839/accessing-a-forms-control-from-a-separate-thread
            if (!ConsoleText.InvokeRequired)
            {
                ConsoleText.Text += e.Data + "\r\n";
                if (e.Data.Contains('\f')) { ConsoleText.Text = ""; }
            }
            else
            {
                Invoke(new Action<object, DataReceivedEventArgs>(ConsoleDataReceived), sender, e);
            }
        }

        private string GetCommand()
        { // incoming cheese code

            string glang = "glslangValidator.exe";
            if (!string.IsNullOrWhiteSpace(GLSLangBox.Text))
            {
                glang = GLSLangBox.Text;
            }
            StringBuilder cmd = new StringBuilder(glang + " \"" + InputFileBox.Text + "\" ");
            Dictionary<string, bool> boolFlags = new Dictionary<string, bool>
            { // these are all simple check boxes
                {"-C", flagC.Checked},
                {"-D", flagD.Checked},
                {"-E", flagBoolE.Checked},
                {"-H", flagH.Checked},
                {"-Od", flagOd.Checked},
                {"-Os", flagOs.Checked},
                {"-c", flaglowerc.Checked},
                {"-g", flagg.Checked},
                {"-g0", flagg0.Checked},
                {"-i", flagloweri.Checked},
                {"-l", flagl.Checked},
                {"-m", flagm.Checked},
                {"-q", flagq.Checked},
                {"-r", flagr.Checked},
                {"-s", flaglowers.Checked},
                {"-t", flagt.Checked},
                {"-v", flaglowerv.Checked},
                {"-w", flagw.Checked},
                {"-x", flagx.Checked},
            };

            foreach (var (flagString, flagChecked) in boolFlags)
            {
                if (flagChecked)
                {
                    cmd.Append(flagString + " ");
                }
            }

            // now i do it again with the simple text ones

            Dictionary<string, string> textFlags = new Dictionary<string, string>
            {
                {"-V", flagV.Text},
                {"-S", flagS.Text},
                {"-e", flage.Text},
                {"--target-env", flagtargetenv.Text},
                {"--vn", flagvn.Text},
            };

            foreach (var (flagString, flagValue) in textFlags)
            {
                if (!string.IsNullOrWhiteSpace(flagValue))
                {
                    cmd.Append($"{flagString} \"{flagValue}\" ");
                }
            }

            // ok: do includes separate since this one is weird

            StringBuilder flagIArg = new StringBuilder("");
            string[] args = flagI.Text.Split('\n');
            foreach (var arg in args)
            {
                if (arg != "")
                {
                    flagIArg.Append($"-I \"{arg.Replace("\r", "")}\"");
                }
            }

            cmd.Append(flagIArg);

            // we always compile vulkan because i'm only using vulkan
            // and also i dont feel like adding a checkbox.
            cmd.Append($"-V -o \"{OutputFileBox.Text}\"");

            return cmd.ToString();

        }

        private void CompileButton_Click(object sender, EventArgs e)
        {
            CompilePreview.Text = GetCommand();
            cmd.WriteLine("cls");
            cmd.WriteLine(CompilePreview.Text); // run the command!
        }

        private void BrowseInput_Click(object sender, EventArgs e)
        {
            if (openFileDiag.ShowDialog() != DialogResult.OK) { return; }
            if (!File.Exists(openFileDiag.FileName)) { return; }
            InputFileBox.Text = openFileDiag.FileName;
            saveFileDiag.InitialDirectory = openFileDiag.InitialDirectory;
        }

        private void BrowseOutput_Click(object sender, EventArgs e)
        {
            if (saveFileDiag.ShowDialog() != DialogResult.OK) { return; }
            OutputFileBox.Text = saveFileDiag.FileName;
        }
        private void GLSLangBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDiag.ShowDialog() != DialogResult.OK) { return; }
            if (!File.Exists(openFileDiag.FileName)) { return; }
            GLSLangBox.Text = openFileDiag.FileName;
            saveFileDiag.InitialDirectory = openFileDiag.InitialDirectory;
        }


        // Event to take in the file data on dragging and dropping
        private void EDragDrop(object sender, DragEventArgs e)
        {
            ((TextBox)sender).Text = ((string[])e.Data.GetData(DataFormats.FileDrop, false))[0];
        }

        // Event to toggle the mouse to show feedback
        private void EDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void PreviewUpdater_Tick(object sender, EventArgs e)
        { // yes i couldnt think of a better way to do this. this is bad.
            CompilePreview.Text = GetCommand();
        }

        private void SelectCompilePrev(object sender, MouseEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(CompilePreview.Text))
            {
                CompilePreview.SelectionStart = 0;
                CompilePreview.SelectionLength = CompilePreview.Text.Length;
            }
        }

        private void DeselectCompilePrev(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(CompilePreview.Text))
            {
                CompilePreview.SelectionStart = 0;
                CompilePreview.SelectionLength = 0;
            }
        }

        private void FontSlider_ValueChanged(object sender, EventArgs e)
        {
            ConsoleText.Font = new Font(ConsoleText.Font.FontFamily, FontSlider.Value);
            labelFontSize.Text = FontSlider.Value.ToString();
        }

        private void WordWrapBox_Click(object sender, EventArgs e)
        {
            ConsoleText.WordWrap = WordWrapBox.Checked;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        { // save some stuffs

            StreamWriter file = new StreamWriter("config.txt");
            file.WriteLine($"{InputFileBox.Text}");
            file.WriteLine($"{OutputFileBox.Text}");
            file.WriteLine($"{GLSLangBox.Text}");
            file.Close();

        }

    }
}
