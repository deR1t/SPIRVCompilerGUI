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
            Dictionary<string, bool> simpleFlags = new Dictionary<string, bool>
            { // these are all simple booleans, so ill just loop through this
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

            foreach (var (flagString, flagChecked) in simpleFlags)
            {
                if (flagChecked)
                {
                    cmd.Append(flagString + " ");
                }
            }

            // now i have to do everything else manually!! weeee
            //flagV
            //flagS
            //flage
            //flagI
            //flagtargetenv
            //flagvn





        }
    }
}
