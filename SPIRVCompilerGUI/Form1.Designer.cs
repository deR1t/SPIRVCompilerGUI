
namespace SPIRVCompilerGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MainTab = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.CompilePreview = new System.Windows.Forms.TextBox();
            this.CompileButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BrowseOutput = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.OutputFileBox = new System.Windows.Forms.TextBox();
            this.BrowseInput = new System.Windows.Forms.Button();
            this.InputFileBox = new System.Windows.Forms.TextBox();
            this.OptionsTab = new System.Windows.Forms.TabPage();
            this.OptionsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flagV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flagvn = new System.Windows.Forms.TextBox();
            this.flagS = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flagtargetenv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.flage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.flagI = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flagC = new System.Windows.Forms.CheckBox();
            this.flagOs = new System.Windows.Forms.CheckBox();
            this.flagOd = new System.Windows.Forms.CheckBox();
            this.flagD = new System.Windows.Forms.CheckBox();
            this.flagH = new System.Windows.Forms.CheckBox();
            this.flagBoolE = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flaglowerc = new System.Windows.Forms.CheckBox();
            this.flagm = new System.Windows.Forms.CheckBox();
            this.flagg = new System.Windows.Forms.CheckBox();
            this.flagl = new System.Windows.Forms.CheckBox();
            this.flagg0 = new System.Windows.Forms.CheckBox();
            this.flagloweri = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flagq = new System.Windows.Forms.CheckBox();
            this.flagr = new System.Windows.Forms.CheckBox();
            this.flaglowers = new System.Windows.Forms.CheckBox();
            this.flagt = new System.Windows.Forms.CheckBox();
            this.flagx = new System.Windows.Forms.CheckBox();
            this.flaglowerv = new System.Windows.Forms.CheckBox();
            this.flagw = new System.Windows.Forms.CheckBox();
            this.ConsoleText = new System.Windows.Forms.TextBox();
            this.openFileDiag = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDiag = new System.Windows.Forms.SaveFileDialog();
            this.PreviewUpdater = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.OptionsTab.SuspendLayout();
            this.OptionsFlowPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MainTab);
            this.tabControl1.Controls.Add(this.OptionsTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(598, 658);
            this.tabControl1.TabIndex = 0;
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.label9);
            this.MainTab.Controls.Add(this.CompilePreview);
            this.MainTab.Controls.Add(this.CompileButton);
            this.MainTab.Controls.Add(this.label8);
            this.MainTab.Controls.Add(this.BrowseOutput);
            this.MainTab.Controls.Add(this.label7);
            this.MainTab.Controls.Add(this.OutputFileBox);
            this.MainTab.Controls.Add(this.BrowseInput);
            this.MainTab.Controls.Add(this.InputFileBox);
            this.MainTab.Location = new System.Drawing.Point(4, 24);
            this.MainTab.Name = "MainTab";
            this.MainTab.Padding = new System.Windows.Forms.Padding(3);
            this.MainTab.Size = new System.Drawing.Size(590, 513);
            this.MainTab.TabIndex = 1;
            this.MainTab.Text = "Main";
            this.MainTab.UseVisualStyleBackColor = true;
            this.MainTab.Click += new System.EventHandler(this.DeselectCompilePrev);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Command preview:";
            // 
            // CompilePreview
            // 
            this.CompilePreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompilePreview.Location = new System.Drawing.Point(8, 395);
            this.CompilePreview.Multiline = true;
            this.CompilePreview.Name = "CompilePreview";
            this.CompilePreview.ReadOnly = true;
            this.CompilePreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CompilePreview.Size = new System.Drawing.Size(493, 117);
            this.CompilePreview.TabIndex = 4;
            this.CompilePreview.Leave += new System.EventHandler(this.DeselectCompilePrev);
            this.CompilePreview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SelectCompilePrev);
            // 
            // CompileButton
            // 
            this.CompileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CompileButton.Location = new System.Drawing.Point(507, 489);
            this.CompileButton.Name = "CompileButton";
            this.CompileButton.Size = new System.Drawing.Size(75, 23);
            this.CompileButton.TabIndex = 3;
            this.CompileButton.Text = "Compile!";
            this.CompileButton.UseVisualStyleBackColor = true;
            this.CompileButton.Click += new System.EventHandler(this.CompileButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Output file:";
            // 
            // BrowseOutput
            // 
            this.BrowseOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseOutput.Location = new System.Drawing.Point(507, 35);
            this.BrowseOutput.Name = "BrowseOutput";
            this.BrowseOutput.Size = new System.Drawing.Size(75, 23);
            this.BrowseOutput.TabIndex = 1;
            this.BrowseOutput.Text = "Browse";
            this.BrowseOutput.UseVisualStyleBackColor = true;
            this.BrowseOutput.Click += new System.EventHandler(this.BrowseOutput_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Input file:";
            // 
            // OutputFileBox
            // 
            this.OutputFileBox.AllowDrop = true;
            this.OutputFileBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputFileBox.Location = new System.Drawing.Point(86, 35);
            this.OutputFileBox.Name = "OutputFileBox";
            this.OutputFileBox.Size = new System.Drawing.Size(415, 23);
            this.OutputFileBox.TabIndex = 0;
            this.OutputFileBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.EDragDrop);
            this.OutputFileBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.EDragEnter);
            // 
            // BrowseInput
            // 
            this.BrowseInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseInput.Location = new System.Drawing.Point(507, 6);
            this.BrowseInput.Name = "BrowseInput";
            this.BrowseInput.Size = new System.Drawing.Size(75, 23);
            this.BrowseInput.TabIndex = 1;
            this.BrowseInput.Text = "Browse";
            this.BrowseInput.UseVisualStyleBackColor = true;
            this.BrowseInput.Click += new System.EventHandler(this.BrowseInput_Click);
            // 
            // InputFileBox
            // 
            this.InputFileBox.AllowDrop = true;
            this.InputFileBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputFileBox.Location = new System.Drawing.Point(86, 6);
            this.InputFileBox.Name = "InputFileBox";
            this.InputFileBox.Size = new System.Drawing.Size(415, 23);
            this.InputFileBox.TabIndex = 0;
            this.InputFileBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.EDragDrop);
            this.InputFileBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.EDragEnter);
            // 
            // OptionsTab
            // 
            this.OptionsTab.Controls.Add(this.OptionsFlowPanel);
            this.OptionsTab.Controls.Add(this.panel2);
            this.OptionsTab.Controls.Add(this.panel4);
            this.OptionsTab.Controls.Add(this.panel3);
            this.OptionsTab.Location = new System.Drawing.Point(4, 24);
            this.OptionsTab.Name = "OptionsTab";
            this.OptionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.OptionsTab.Size = new System.Drawing.Size(590, 630);
            this.OptionsTab.TabIndex = 0;
            this.OptionsTab.Text = "Options";
            this.OptionsTab.UseVisualStyleBackColor = true;
            // 
            // OptionsFlowPanel
            // 
            this.OptionsFlowPanel.AutoScroll = true;
            this.OptionsFlowPanel.Controls.Add(this.panel1);
            this.OptionsFlowPanel.Controls.Add(this.panel5);
            this.OptionsFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.OptionsFlowPanel.Location = new System.Drawing.Point(374, 60);
            this.OptionsFlowPanel.Name = "OptionsFlowPanel";
            this.OptionsFlowPanel.Size = new System.Drawing.Size(579, 518);
            this.OptionsFlowPanel.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flagV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.flagvn);
            this.panel1.Controls.Add(this.flagS);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.flagtargetenv);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.flage);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 142);
            this.panel1.TabIndex = 13;
            // 
            // flagV
            // 
            this.flagV.Location = new System.Drawing.Point(0, 0);
            this.flagV.Name = "flagV";
            this.flagV.Size = new System.Drawing.Size(100, 23);
            this.flagV.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "[Version] Create SPIR-V binary w/ Vulkan";
            // 
            // flagvn
            // 
            this.flagvn.Location = new System.Drawing.Point(0, 116);
            this.flagvn.Name = "flagvn";
            this.flagvn.Size = new System.Drawing.Size(118, 23);
            this.flagvn.TabIndex = 11;
            // 
            // flagS
            // 
            this.flagS.FormattingEnabled = true;
            this.flagS.Items.AddRange(new object[] {
            "vert",
            "tesc",
            "tese",
            "geom",
            "frag",
            "comp"});
            this.flagS.Location = new System.Drawing.Point(0, 29);
            this.flagS.Name = "flagS";
            this.flagS.Size = new System.Drawing.Size(121, 23);
            this.flagS.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "-vn : Variable name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stage override";
            // 
            // flagtargetenv
            // 
            this.flagtargetenv.Location = new System.Drawing.Point(0, 87);
            this.flagtargetenv.Name = "flagtargetenv";
            this.flagtargetenv.Size = new System.Drawing.Size(155, 23);
            this.flagtargetenv.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Target env";
            // 
            // flage
            // 
            this.flage.Location = new System.Drawing.Point(0, 58);
            this.flage.Name = "flage";
            this.flage.Size = new System.Drawing.Size(100, 23);
            this.flage.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Entry point";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.flagI);
            this.panel5.Location = new System.Drawing.Point(3, 151);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(329, 133);
            this.panel5.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Include Directories (seperated by newlines)";
            // 
            // flagI
            // 
            this.flagI.Location = new System.Drawing.Point(3, 19);
            this.flagI.Multiline = true;
            this.flagI.Name = "flagI";
            this.flagI.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.flagI.Size = new System.Drawing.Size(227, 111);
            this.flagI.TabIndex = 3;
            this.flagI.WordWrap = false;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.flagC);
            this.panel2.Controls.Add(this.flagOs);
            this.panel2.Controls.Add(this.flagOd);
            this.panel2.Controls.Add(this.flagD);
            this.panel2.Controls.Add(this.flagH);
            this.panel2.Controls.Add(this.flagBoolE);
            this.panel2.Location = new System.Drawing.Point(8, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 150);
            this.panel2.TabIndex = 13;
            // 
            // flagC
            // 
            this.flagC.AutoSize = true;
            this.flagC.Location = new System.Drawing.Point(3, 3);
            this.flagC.Name = "flagC";
            this.flagC.Size = new System.Drawing.Size(136, 19);
            this.flagC.TabIndex = 0;
            this.flagC.Text = "-C : Cascading Errors";
            this.flagC.UseVisualStyleBackColor = true;
            // 
            // flagOs
            // 
            this.flagOs.AutoSize = true;
            this.flagOs.Location = new System.Drawing.Point(3, 128);
            this.flagOs.Name = "flagOs";
            this.flagOs.Size = new System.Drawing.Size(142, 19);
            this.flagOs.TabIndex = 0;
            this.flagOs.Text = "-Os : Optimize for size";
            this.flagOs.UseVisualStyleBackColor = true;
            // 
            // flagOd
            // 
            this.flagOd.AutoSize = true;
            this.flagOd.Location = new System.Drawing.Point(3, 103);
            this.flagOd.Name = "flagOd";
            this.flagOd.Size = new System.Drawing.Size(235, 19);
            this.flagOd.TabIndex = 0;
            this.flagOd.Text = "-Od : Disable optimization [Dangerous!]";
            this.flagOd.UseVisualStyleBackColor = true;
            // 
            // flagD
            // 
            this.flagD.AutoSize = true;
            this.flagD.Location = new System.Drawing.Point(3, 28);
            this.flagD.Name = "flagD";
            this.flagD.Size = new System.Drawing.Size(117, 19);
            this.flagD.TabIndex = 0;
            this.flagD.Text = "-D : Input is HLSL";
            this.flagD.UseVisualStyleBackColor = true;
            // 
            // flagH
            // 
            this.flagH.AutoSize = true;
            this.flagH.Location = new System.Drawing.Point(3, 78);
            this.flagH.Name = "flagH";
            this.flagH.Size = new System.Drawing.Size(244, 19);
            this.flagH.TabIndex = 0;
            this.flagH.Text = "-H : Print human readable form of SPIR-V";
            this.flagH.UseVisualStyleBackColor = true;
            // 
            // flagBoolE
            // 
            this.flagBoolE.AutoSize = true;
            this.flagBoolE.Location = new System.Drawing.Point(3, 53);
            this.flagBoolE.Name = "flagBoolE";
            this.flagBoolE.Size = new System.Drawing.Size(178, 19);
            this.flagBoolE.TabIndex = 0;
            this.flagBoolE.Text = "-E : Print pre-processed GLSL";
            this.flagBoolE.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.flaglowerc);
            this.panel3.Controls.Add(this.flagm);
            this.panel3.Controls.Add(this.flagg);
            this.panel3.Controls.Add(this.flagl);
            this.panel3.Controls.Add(this.flagg0);
            this.panel3.Controls.Add(this.flagloweri);
            this.panel3.Location = new System.Drawing.Point(8, 191);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(203, 150);
            this.panel3.TabIndex = 14;
            // 
            // flaglowerc
            // 
            this.flaglowerc.AutoSize = true;
            this.flaglowerc.Location = new System.Drawing.Point(3, 3);
            this.flaglowerc.Name = "flaglowerc";
            this.flaglowerc.Size = new System.Drawing.Size(117, 19);
            this.flaglowerc.TabIndex = 0;
            this.flaglowerc.Text = "-c : Config dump";
            this.flaglowerc.UseVisualStyleBackColor = true;
            // 
            // flagm
            // 
            this.flagm.AutoSize = true;
            this.flagm.Location = new System.Drawing.Point(3, 128);
            this.flagm.Name = "flagm";
            this.flagm.Size = new System.Drawing.Size(154, 19);
            this.flagm.TabIndex = 0;
            this.flagm.Text = "-m : Memory leak mode";
            this.flagm.UseVisualStyleBackColor = true;
            // 
            // flagg
            // 
            this.flagg.AutoSize = true;
            this.flagg.Location = new System.Drawing.Point(3, 28);
            this.flagg.Name = "flagg";
            this.flagg.Size = new System.Drawing.Size(197, 19);
            this.flagg.TabIndex = 0;
            this.flagg.Text = "-g : Generate debug information";
            this.flagg.UseVisualStyleBackColor = true;
            // 
            // flagl
            // 
            this.flagl.AutoSize = true;
            this.flagl.Location = new System.Drawing.Point(3, 103);
            this.flagl.Name = "flagl";
            this.flagl.Size = new System.Drawing.Size(129, 19);
            this.flagl.TabIndex = 0;
            this.flagl.Text = "-l : Link all modules";
            this.flagl.UseVisualStyleBackColor = true;
            // 
            // flagg0
            // 
            this.flagg0.AutoSize = true;
            this.flagg0.Location = new System.Drawing.Point(3, 53);
            this.flagg0.Name = "flagg0";
            this.flagg0.Size = new System.Drawing.Size(180, 19);
            this.flagg0.TabIndex = 0;
            this.flagg0.Text = "-g0 : Strip debug information";
            this.flagg0.UseVisualStyleBackColor = true;
            // 
            // flagloweri
            // 
            this.flagloweri.AutoSize = true;
            this.flagloweri.Location = new System.Drawing.Point(3, 78);
            this.flagloweri.Name = "flagloweri";
            this.flagloweri.Size = new System.Drawing.Size(161, 19);
            this.flagloweri.TabIndex = 0;
            this.flagloweri.Text = "-i : Intermediate tree print";
            this.flagloweri.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.flagq);
            this.panel4.Controls.Add(this.flagr);
            this.panel4.Controls.Add(this.flaglowers);
            this.panel4.Controls.Add(this.flagt);
            this.panel4.Controls.Add(this.flagx);
            this.panel4.Controls.Add(this.flaglowerv);
            this.panel4.Controls.Add(this.flagw);
            this.panel4.Location = new System.Drawing.Point(8, 347);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(193, 176);
            this.panel4.TabIndex = 13;
            // 
            // flagq
            // 
            this.flagq.AutoSize = true;
            this.flagq.Location = new System.Drawing.Point(3, 3);
            this.flagq.Name = "flagq";
            this.flagq.Size = new System.Drawing.Size(186, 19);
            this.flagq.TabIndex = 0;
            this.flagq.Text = "-q : Dump reflection Query DB";
            this.flagq.UseVisualStyleBackColor = true;
            // 
            // flagr
            // 
            this.flagr.AutoSize = true;
            this.flagr.Location = new System.Drawing.Point(3, 28);
            this.flagr.Name = "flagr";
            this.flagr.Size = new System.Drawing.Size(118, 19);
            this.flagr.TabIndex = 0;
            this.flagr.Text = "-r : Relaxed errors";
            this.flagr.UseVisualStyleBackColor = true;
            // 
            // flaglowers
            // 
            this.flaglowers.AutoSize = true;
            this.flaglowers.Location = new System.Drawing.Point(3, 53);
            this.flaglowers.Name = "flaglowers";
            this.flaglowers.Size = new System.Drawing.Size(187, 19);
            this.flaglowers.TabIndex = 0;
            this.flaglowers.Text = "-s : Silence syntax error reports";
            this.flaglowers.UseVisualStyleBackColor = true;
            // 
            // flagt
            // 
            this.flagt.AutoSize = true;
            this.flagt.Checked = true;
            this.flagt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.flagt.Location = new System.Drawing.Point(3, 78);
            this.flagt.Name = "flagt";
            this.flagt.Size = new System.Drawing.Size(158, 19);
            this.flagt.TabIndex = 0;
            this.flagt.Text = "-t : Multi-threaded mode";
            this.flagt.UseVisualStyleBackColor = true;
            // 
            // flagx
            // 
            this.flagx.AutoSize = true;
            this.flagx.Location = new System.Drawing.Point(3, 154);
            this.flagx.Name = "flagx";
            this.flagx.Size = new System.Drawing.Size(179, 19);
            this.flagx.TabIndex = 0;
            this.flagx.Text = "-x : Save output as 32-bit hex";
            this.flagx.UseVisualStyleBackColor = true;
            // 
            // flaglowerv
            // 
            this.flaglowerv.AutoSize = true;
            this.flaglowerv.Location = new System.Drawing.Point(3, 103);
            this.flaglowerv.Name = "flaglowerv";
            this.flaglowerv.Size = new System.Drawing.Size(112, 19);
            this.flaglowerv.TabIndex = 0;
            this.flaglowerv.Text = "-v : Print version";
            this.flaglowerv.UseVisualStyleBackColor = true;
            // 
            // flagw
            // 
            this.flagw.AutoSize = true;
            this.flagw.Location = new System.Drawing.Point(3, 129);
            this.flagw.Name = "flagw";
            this.flagw.Size = new System.Drawing.Size(147, 19);
            this.flagw.TabIndex = 0;
            this.flagw.Text = "-w : Suppress warnings";
            this.flagw.UseVisualStyleBackColor = true;
            // 
            // ConsoleText
            // 
            this.ConsoleText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ConsoleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsoleText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ConsoleText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsoleText.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConsoleText.ForeColor = System.Drawing.Color.White;
            this.ConsoleText.Location = new System.Drawing.Point(598, 0);
            this.ConsoleText.Multiline = true;
            this.ConsoleText.Name = "ConsoleText";
            this.ConsoleText.ReadOnly = true;
            this.ConsoleText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ConsoleText.Size = new System.Drawing.Size(338, 658);
            this.ConsoleText.TabIndex = 0;
            this.ConsoleText.Text = "This will be replaced!\r\nThis is what the console font will look like!";
            // 
            // openFileDiag
            // 
            this.openFileDiag.Filter = "All files|*.*";
            this.openFileDiag.InitialDirectory = "Application.StartupPath";
            // 
            // saveFileDiag
            // 
            this.saveFileDiag.Filter = "All files|*.*";
            this.saveFileDiag.InitialDirectory = "Application.StartupPath";
            // 
            // PreviewUpdater
            // 
            this.PreviewUpdater.Enabled = true;
            this.PreviewUpdater.Interval = 250;
            this.PreviewUpdater.Tick += new System.EventHandler(this.PreviewUpdater_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 658);
            this.Controls.Add(this.ConsoleText);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "GLSL / SpirV Tool";
            this.tabControl1.ResumeLayout(false);
            this.MainTab.ResumeLayout(false);
            this.MainTab.PerformLayout();
            this.OptionsTab.ResumeLayout(false);
            this.OptionsTab.PerformLayout();
            this.OptionsFlowPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage OptionsTab;
        private System.Windows.Forms.TabPage MainTab;
        private System.Windows.Forms.ComboBox flagS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox flagI;
        private System.Windows.Forms.TextBox flagV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox flagOs;
        private System.Windows.Forms.CheckBox flagOd;
        private System.Windows.Forms.CheckBox flagH;
        private System.Windows.Forms.CheckBox flagBoolE;
        private System.Windows.Forms.CheckBox flagD;
        private System.Windows.Forms.CheckBox flagC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox flage;
        private System.Windows.Forms.CheckBox flagm;
        private System.Windows.Forms.CheckBox flagl;
        private System.Windows.Forms.CheckBox flagloweri;
        private System.Windows.Forms.CheckBox flagg0;
        private System.Windows.Forms.CheckBox flagg;
        private System.Windows.Forms.CheckBox flaglowerc;
        private System.Windows.Forms.TextBox InputFileBox;
        private System.Windows.Forms.CheckBox flaglowerv;
        private System.Windows.Forms.CheckBox flagt;
        private System.Windows.Forms.CheckBox flaglowers;
        private System.Windows.Forms.CheckBox flagr;
        private System.Windows.Forms.CheckBox flagq;
        private System.Windows.Forms.CheckBox flagx;
        private System.Windows.Forms.CheckBox flagw;
        private System.Windows.Forms.TextBox flagvn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox flagtargetenv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BrowseOutput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox OutputFileBox;
        private System.Windows.Forms.Button BrowseInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CompilePreview;
        private System.Windows.Forms.Button CompileButton;
        private System.Windows.Forms.TextBox ConsoleText;
        private System.Windows.Forms.OpenFileDialog openFileDiag;
        private System.Windows.Forms.SaveFileDialog saveFileDiag;
        private System.Windows.Forms.Timer PreviewUpdater;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel OptionsFlowPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
    }
}

