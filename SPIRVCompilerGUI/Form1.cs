using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                flagIArg.Append($"-I \"{arg}\" ");
            }

            cmd.Append(flagIArg);

            CompilePreview.Text = cmd.ToString();

        }
    }
}
