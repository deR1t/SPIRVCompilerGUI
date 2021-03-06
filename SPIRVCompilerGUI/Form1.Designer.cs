
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.WordWrapBox = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelFontSize = new System.Windows.Forms.Label();
            this.FontSlider = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CompilePreview = new System.Windows.Forms.TextBox();
            this.CompileButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BrowseOutput = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GLSLangBrowse = new System.Windows.Forms.Button();
            this.OutputFileBox = new System.Windows.Forms.TextBox();
            this.GLSLangBox = new System.Windows.Forms.TextBox();
            this.BrowseInput = new System.Windows.Forms.Button();
            this.InputFileBox = new System.Windows.Forms.TextBox();
            this.OptionsTab = new System.Windows.Forms.TabPage();
            this.OptionsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.flagI = new System.Windows.Forms.TextBox();
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flagr = new System.Windows.Forms.CheckBox();
            this.flagl = new System.Windows.Forms.CheckBox();
            this.flagm = new System.Windows.Forms.CheckBox();
            this.flagx = new System.Windows.Forms.CheckBox();
            this.flagC = new System.Windows.Forms.CheckBox();
            this.flagD = new System.Windows.Forms.CheckBox();
            this.flagOd = new System.Windows.Forms.CheckBox();
            this.flagOs = new System.Windows.Forms.CheckBox();
            this.flagt = new System.Windows.Forms.CheckBox();
            this.flaglowers = new System.Windows.Forms.CheckBox();
            this.flagw = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flagg = new System.Windows.Forms.CheckBox();
            this.flagg0 = new System.Windows.Forms.CheckBox();
            this.flaglowerc = new System.Windows.Forms.CheckBox();
            this.flagloweri = new System.Windows.Forms.CheckBox();
            this.flagq = new System.Windows.Forms.CheckBox();
            this.flaglowerv = new System.Windows.Forms.CheckBox();
            this.flagH = new System.Windows.Forms.CheckBox();
            this.flagBoolE = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ConsoleText = new System.Windows.Forms.TextBox();
            this.openFileDiag = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDiag = new System.Windows.Forms.SaveFileDialog();
            this.PreviewUpdater = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FontSlider)).BeginInit();
            this.OptionsTab.SuspendLayout();
            this.OptionsFlowPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(722, 437);
            this.tabControl1.TabIndex = 0;
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.groupBox1);
            this.MainTab.Controls.Add(this.label9);
            this.MainTab.Controls.Add(this.CompilePreview);
            this.MainTab.Controls.Add(this.CompileButton);
            this.MainTab.Controls.Add(this.label8);
            this.MainTab.Controls.Add(this.BrowseOutput);
            this.MainTab.Controls.Add(this.label11);
            this.MainTab.Controls.Add(this.label7);
            this.MainTab.Controls.Add(this.GLSLangBrowse);
            this.MainTab.Controls.Add(this.OutputFileBox);
            this.MainTab.Controls.Add(this.GLSLangBox);
            this.MainTab.Controls.Add(this.BrowseInput);
            this.MainTab.Controls.Add(this.InputFileBox);
            this.MainTab.Location = new System.Drawing.Point(4, 24);
            this.MainTab.Name = "MainTab";
            this.MainTab.Padding = new System.Windows.Forms.Padding(3);
            this.MainTab.Size = new System.Drawing.Size(714, 409);
            this.MainTab.TabIndex = 1;
            this.MainTab.Text = "Main";
            this.MainTab.UseVisualStyleBackColor = true;
            this.MainTab.Click += new System.EventHandler(this.DeselectCompilePrev);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(8, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 125);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Console Options";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.WordWrapBox);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(201, 103);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // WordWrapBox
            // 
            this.WordWrapBox.AutoSize = true;
            this.WordWrapBox.Location = new System.Drawing.Point(3, 3);
            this.WordWrapBox.Name = "WordWrapBox";
            this.WordWrapBox.Size = new System.Drawing.Size(86, 19);
            this.WordWrapBox.TabIndex = 0;
            this.WordWrapBox.Text = "Word Wrap";
            this.WordWrapBox.UseVisualStyleBackColor = true;
            this.WordWrapBox.Click += new System.EventHandler(this.WordWrapBox_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelFontSize);
            this.panel2.Controls.Add(this.FontSlider);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(3, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 69);
            this.panel2.TabIndex = 7;
            // 
            // labelFontSize
            // 
            this.labelFontSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFontSize.AutoSize = true;
            this.labelFontSize.Location = new System.Drawing.Point(167, 32);
            this.labelFontSize.Name = "labelFontSize";
            this.labelFontSize.Size = new System.Drawing.Size(13, 15);
            this.labelFontSize.TabIndex = 8;
            this.labelFontSize.Text = "0";
            // 
            // FontSlider
            // 
            this.FontSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FontSlider.BackColor = System.Drawing.Color.White;
            this.FontSlider.LargeChange = 1;
            this.FontSlider.Location = new System.Drawing.Point(3, 22);
            this.FontSlider.Maximum = 20;
            this.FontSlider.Minimum = 6;
            this.FontSlider.Name = "FontSlider";
            this.FontSlider.Size = new System.Drawing.Size(163, 45);
            this.FontSlider.TabIndex = 1;
            this.FontSlider.Value = 9;
            this.FontSlider.ValueChanged += new System.EventHandler(this.FontSlider_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Font Size";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Command preview:";
            // 
            // CompilePreview
            // 
            this.CompilePreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompilePreview.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CompilePreview.Location = new System.Drawing.Point(8, 284);
            this.CompilePreview.Multiline = true;
            this.CompilePreview.Name = "CompilePreview";
            this.CompilePreview.ReadOnly = true;
            this.CompilePreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CompilePreview.Size = new System.Drawing.Size(619, 117);
            this.CompilePreview.TabIndex = 4;
            this.CompilePreview.Leave += new System.EventHandler(this.DeselectCompilePrev);
            this.CompilePreview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SelectCompilePrev);
            // 
            // CompileButton
            // 
            this.CompileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CompileButton.Location = new System.Drawing.Point(633, 378);
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
            this.label8.Location = new System.Drawing.Point(7, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Output file:";
            // 
            // BrowseOutput
            // 
            this.BrowseOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseOutput.Location = new System.Drawing.Point(633, 33);
            this.BrowseOutput.Name = "BrowseOutput";
            this.BrowseOutput.Size = new System.Drawing.Size(75, 23);
            this.BrowseOutput.TabIndex = 1;
            this.BrowseOutput.Text = "Browse";
            this.BrowseOutput.UseVisualStyleBackColor = true;
            this.BrowseOutput.Click += new System.EventHandler(this.BrowseOutput_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "glslang.exe location:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Input file:";
            // 
            // GLSLangBrowse
            // 
            this.GLSLangBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GLSLangBrowse.Location = new System.Drawing.Point(633, 62);
            this.GLSLangBrowse.Name = "GLSLangBrowse";
            this.GLSLangBrowse.Size = new System.Drawing.Size(75, 23);
            this.GLSLangBrowse.TabIndex = 1;
            this.GLSLangBrowse.Text = "Browse";
            this.GLSLangBrowse.UseVisualStyleBackColor = true;
            this.GLSLangBrowse.Click += new System.EventHandler(this.GLSLangBrowse_Click);
            // 
            // OutputFileBox
            // 
            this.OutputFileBox.AllowDrop = true;
            this.OutputFileBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputFileBox.Location = new System.Drawing.Point(143, 33);
            this.OutputFileBox.Name = "OutputFileBox";
            this.OutputFileBox.Size = new System.Drawing.Size(484, 23);
            this.OutputFileBox.TabIndex = 0;
            this.OutputFileBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.EDragDrop);
            this.OutputFileBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.EDragEnter);
            // 
            // GLSLangBox
            // 
            this.GLSLangBox.AllowDrop = true;
            this.GLSLangBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GLSLangBox.Location = new System.Drawing.Point(143, 62);
            this.GLSLangBox.Name = "GLSLangBox";
            this.GLSLangBox.Size = new System.Drawing.Size(484, 23);
            this.GLSLangBox.TabIndex = 0;
            this.GLSLangBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.EDragDrop);
            this.GLSLangBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.EDragEnter);
            // 
            // BrowseInput
            // 
            this.BrowseInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseInput.Location = new System.Drawing.Point(633, 4);
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
            this.InputFileBox.Location = new System.Drawing.Point(143, 4);
            this.InputFileBox.Name = "InputFileBox";
            this.InputFileBox.Size = new System.Drawing.Size(484, 23);
            this.InputFileBox.TabIndex = 0;
            this.InputFileBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.EDragDrop);
            this.InputFileBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.EDragEnter);
            // 
            // OptionsTab
            // 
            this.OptionsTab.Controls.Add(this.OptionsFlowPanel);
            this.OptionsTab.Controls.Add(this.panel3);
            this.OptionsTab.Location = new System.Drawing.Point(4, 24);
            this.OptionsTab.Name = "OptionsTab";
            this.OptionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.OptionsTab.Size = new System.Drawing.Size(714, 409);
            this.OptionsTab.TabIndex = 0;
            this.OptionsTab.Text = "Options";
            this.OptionsTab.UseVisualStyleBackColor = true;
            // 
            // OptionsFlowPanel
            // 
            this.OptionsFlowPanel.AutoScroll = true;
            this.OptionsFlowPanel.Controls.Add(this.panel1);
            this.OptionsFlowPanel.Controls.Add(this.flowLayoutPanel2);
            this.OptionsFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionsFlowPanel.Location = new System.Drawing.Point(3, 3);
            this.OptionsFlowPanel.Name = "OptionsFlowPanel";
            this.OptionsFlowPanel.Size = new System.Drawing.Size(708, 403);
            this.OptionsFlowPanel.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
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
            this.panel1.Size = new System.Drawing.Size(579, 149);
            this.panel1.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.flagI);
            this.panel5.Location = new System.Drawing.Point(332, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(244, 133);
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
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.flagr);
            this.flowLayoutPanel2.Controls.Add(this.flagl);
            this.flowLayoutPanel2.Controls.Add(this.flagm);
            this.flowLayoutPanel2.Controls.Add(this.flagx);
            this.flowLayoutPanel2.Controls.Add(this.flagC);
            this.flowLayoutPanel2.Controls.Add(this.flagD);
            this.flowLayoutPanel2.Controls.Add(this.flagOd);
            this.flowLayoutPanel2.Controls.Add(this.flagOs);
            this.flowLayoutPanel2.Controls.Add(this.flagt);
            this.flowLayoutPanel2.Controls.Add(this.flaglowers);
            this.flowLayoutPanel2.Controls.Add(this.flagw);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 158);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(690, 225);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // flagr
            // 
            this.flagr.AutoSize = true;
            this.flagr.Location = new System.Drawing.Point(3, 3);
            this.flagr.Name = "flagr";
            this.flagr.Size = new System.Drawing.Size(118, 19);
            this.flagr.TabIndex = 0;
            this.flagr.Text = "-r : Relaxed errors";
            this.flagr.UseVisualStyleBackColor = true;
            // 
            // flagl
            // 
            this.flagl.AutoSize = true;
            this.flagl.Location = new System.Drawing.Point(3, 28);
            this.flagl.Name = "flagl";
            this.flagl.Size = new System.Drawing.Size(129, 19);
            this.flagl.TabIndex = 0;
            this.flagl.Text = "-l : Link all modules";
            this.flagl.UseVisualStyleBackColor = true;
            // 
            // flagm
            // 
            this.flagm.AutoSize = true;
            this.flagm.Location = new System.Drawing.Point(3, 53);
            this.flagm.Name = "flagm";
            this.flagm.Size = new System.Drawing.Size(154, 19);
            this.flagm.TabIndex = 0;
            this.flagm.Text = "-m : Memory leak mode";
            this.flagm.UseVisualStyleBackColor = true;
            // 
            // flagx
            // 
            this.flagx.AutoSize = true;
            this.flagx.Location = new System.Drawing.Point(3, 78);
            this.flagx.Name = "flagx";
            this.flagx.Size = new System.Drawing.Size(179, 19);
            this.flagx.TabIndex = 0;
            this.flagx.Text = "-x : Save output as 32-bit hex";
            this.flagx.UseVisualStyleBackColor = true;
            // 
            // flagC
            // 
            this.flagC.AutoSize = true;
            this.flagC.Location = new System.Drawing.Point(3, 103);
            this.flagC.Name = "flagC";
            this.flagC.Size = new System.Drawing.Size(136, 19);
            this.flagC.TabIndex = 0;
            this.flagC.Text = "-C : Cascading Errors";
            this.flagC.UseVisualStyleBackColor = true;
            // 
            // flagD
            // 
            this.flagD.AutoSize = true;
            this.flagD.Location = new System.Drawing.Point(3, 128);
            this.flagD.Name = "flagD";
            this.flagD.Size = new System.Drawing.Size(117, 19);
            this.flagD.TabIndex = 0;
            this.flagD.Text = "-D : Input is HLSL";
            this.flagD.UseVisualStyleBackColor = true;
            // 
            // flagOd
            // 
            this.flagOd.AutoSize = true;
            this.flagOd.Location = new System.Drawing.Point(3, 153);
            this.flagOd.Name = "flagOd";
            this.flagOd.Size = new System.Drawing.Size(235, 19);
            this.flagOd.TabIndex = 0;
            this.flagOd.Text = "-Od : Disable optimization [Dangerous!]";
            this.flagOd.UseVisualStyleBackColor = true;
            // 
            // flagOs
            // 
            this.flagOs.AutoSize = true;
            this.flagOs.Location = new System.Drawing.Point(3, 178);
            this.flagOs.Name = "flagOs";
            this.flagOs.Size = new System.Drawing.Size(142, 19);
            this.flagOs.TabIndex = 0;
            this.flagOs.Text = "-Os : Optimize for size";
            this.flagOs.UseVisualStyleBackColor = true;
            // 
            // flagt
            // 
            this.flagt.AutoSize = true;
            this.flagt.Checked = true;
            this.flagt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.flagt.Location = new System.Drawing.Point(3, 203);
            this.flagt.Name = "flagt";
            this.flagt.Size = new System.Drawing.Size(158, 19);
            this.flagt.TabIndex = 0;
            this.flagt.Text = "-t : Multi-threaded mode";
            this.flagt.UseVisualStyleBackColor = true;
            // 
            // flaglowers
            // 
            this.flaglowers.AutoSize = true;
            this.flaglowers.Location = new System.Drawing.Point(244, 3);
            this.flaglowers.Name = "flaglowers";
            this.flaglowers.Size = new System.Drawing.Size(187, 19);
            this.flaglowers.TabIndex = 0;
            this.flaglowers.Text = "-s : Silence syntax error reports";
            this.flaglowers.UseVisualStyleBackColor = true;
            // 
            // flagw
            // 
            this.flagw.AutoSize = true;
            this.flagw.Location = new System.Drawing.Point(244, 28);
            this.flagw.Name = "flagw";
            this.flagw.Size = new System.Drawing.Size(147, 19);
            this.flagw.TabIndex = 0;
            this.flagw.Text = "-w : Suppress warnings";
            this.flagw.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.flagg);
            this.flowLayoutPanel3.Controls.Add(this.flagg0);
            this.flowLayoutPanel3.Controls.Add(this.flaglowerc);
            this.flowLayoutPanel3.Controls.Add(this.flagloweri);
            this.flowLayoutPanel3.Controls.Add(this.flagq);
            this.flowLayoutPanel3.Controls.Add(this.flaglowerv);
            this.flowLayoutPanel3.Controls.Add(this.flagH);
            this.flowLayoutPanel3.Controls.Add(this.flagBoolE);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(437, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(250, 200);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // flagg
            // 
            this.flagg.AutoSize = true;
            this.flagg.Location = new System.Drawing.Point(3, 3);
            this.flagg.Name = "flagg";
            this.flagg.Size = new System.Drawing.Size(197, 19);
            this.flagg.TabIndex = 0;
            this.flagg.Text = "-g : Generate debug information";
            this.flagg.UseVisualStyleBackColor = true;
            // 
            // flagg0
            // 
            this.flagg0.AutoSize = true;
            this.flagg0.Location = new System.Drawing.Point(3, 28);
            this.flagg0.Name = "flagg0";
            this.flagg0.Size = new System.Drawing.Size(180, 19);
            this.flagg0.TabIndex = 0;
            this.flagg0.Text = "-g0 : Strip debug information";
            this.flagg0.UseVisualStyleBackColor = true;
            // 
            // flaglowerc
            // 
            this.flaglowerc.AutoSize = true;
            this.flaglowerc.Location = new System.Drawing.Point(3, 53);
            this.flaglowerc.Name = "flaglowerc";
            this.flaglowerc.Size = new System.Drawing.Size(117, 19);
            this.flaglowerc.TabIndex = 0;
            this.flaglowerc.Text = "-c : Config dump";
            this.flaglowerc.UseVisualStyleBackColor = true;
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
            // flagq
            // 
            this.flagq.AutoSize = true;
            this.flagq.Location = new System.Drawing.Point(3, 103);
            this.flagq.Name = "flagq";
            this.flagq.Size = new System.Drawing.Size(186, 19);
            this.flagq.TabIndex = 0;
            this.flagq.Text = "-q : Dump reflection Query DB";
            this.flagq.UseVisualStyleBackColor = true;
            // 
            // flaglowerv
            // 
            this.flaglowerv.AutoSize = true;
            this.flaglowerv.Location = new System.Drawing.Point(3, 128);
            this.flaglowerv.Name = "flaglowerv";
            this.flaglowerv.Size = new System.Drawing.Size(112, 19);
            this.flaglowerv.TabIndex = 0;
            this.flaglowerv.Text = "-v : Print version";
            this.flaglowerv.UseVisualStyleBackColor = true;
            // 
            // flagH
            // 
            this.flagH.AutoSize = true;
            this.flagH.Location = new System.Drawing.Point(3, 153);
            this.flagH.Name = "flagH";
            this.flagH.Size = new System.Drawing.Size(244, 19);
            this.flagH.TabIndex = 0;
            this.flagH.Text = "-H : Print human readable form of SPIR-V";
            this.flagH.UseVisualStyleBackColor = true;
            // 
            // flagBoolE
            // 
            this.flagBoolE.AutoSize = true;
            this.flagBoolE.Location = new System.Drawing.Point(3, 178);
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
            this.panel3.Location = new System.Drawing.Point(8, 191);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 0);
            this.panel3.TabIndex = 14;
            // 
            // ConsoleText
            // 
            this.ConsoleText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ConsoleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsoleText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ConsoleText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsoleText.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConsoleText.ForeColor = System.Drawing.Color.White;
            this.ConsoleText.Location = new System.Drawing.Point(722, 0);
            this.ConsoleText.Multiline = true;
            this.ConsoleText.Name = "ConsoleText";
            this.ConsoleText.ReadOnly = true;
            this.ConsoleText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ConsoleText.Size = new System.Drawing.Size(264, 437);
            this.ConsoleText.TabIndex = 0;
            this.ConsoleText.Text = "This will be replaced!\r\nThis is what the console font will look like!";
            this.ConsoleText.WordWrap = false;
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
            this.ClientSize = new System.Drawing.Size(986, 437);
            this.Controls.Add(this.ConsoleText);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "GLSL / SpirV Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.MainTab.ResumeLayout(false);
            this.MainTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FontSlider)).EndInit();
            this.OptionsTab.ResumeLayout(false);
            this.OptionsTab.PerformLayout();
            this.OptionsFlowPanel.ResumeLayout(false);
            this.OptionsFlowPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
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
        private System.Windows.Forms.FlowLayoutPanel OptionsFlowPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar FontSlider;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox WordWrapBox;
        private System.Windows.Forms.Label labelFontSize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button GLSLangBrowse;
        private System.Windows.Forms.TextBox GLSLangBox;
    }
}

