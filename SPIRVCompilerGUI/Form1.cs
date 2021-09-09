using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32.SafeHandles;

namespace SPIRVCompilerGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CompileButton_Click(object sender, EventArgs e)
        { // incoming cheese code

            StringBuilder cmd = new StringBuilder("glslangValidator.exe ");
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
                flagIArg.Append($"-I \"{arg.Replace("\r", "")}\"");
            }

            cmd.Append(flagIArg);

            CompilePreview.Text = cmd.ToString();

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

    }
}
