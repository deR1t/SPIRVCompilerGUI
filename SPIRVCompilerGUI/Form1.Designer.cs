
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flagS = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flagI = new System.Windows.Forms.TextBox();
            this.flagV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flagOs = new System.Windows.Forms.CheckBox();
            this.flagOd = new System.Windows.Forms.CheckBox();
            this.flagH = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.flagD = new System.Windows.Forms.CheckBox();
            this.flagC = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.flaglowerc = new System.Windows.Forms.CheckBox();
            this.flage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flagg = new System.Windows.Forms.CheckBox();
            this.flagg0 = new System.Windows.Forms.CheckBox();
            this.flagloweri = new System.Windows.Forms.CheckBox();
            this.flagl = new System.Windows.Forms.CheckBox();
            this.flagm = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(655, 412);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.flage);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.flagS);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.flagI);
            this.tabPage1.Controls.Add(this.flagV);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.flagm);
            this.tabPage1.Controls.Add(this.flagl);
            this.tabPage1.Controls.Add(this.flagloweri);
            this.tabPage1.Controls.Add(this.flagg0);
            this.tabPage1.Controls.Add(this.flagg);
            this.tabPage1.Controls.Add(this.flaglowerc);
            this.tabPage1.Controls.Add(this.flagOs);
            this.tabPage1.Controls.Add(this.flagOd);
            this.tabPage1.Controls.Add(this.flagH);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.flagD);
            this.tabPage1.Controls.Add(this.flagC);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(647, 384);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GLSLang Validator";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.flagS.Location = new System.Drawing.Point(8, 189);
            this.flagS.Name = "flagS";
            this.flagS.Size = new System.Drawing.Size(121, 23);
            this.flagS.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Include Directories";
            // 
            // flagI
            // 
            this.flagI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flagI.Location = new System.Drawing.Point(412, 29);
            this.flagI.Multiline = true;
            this.flagI.Name = "flagI";
            this.flagI.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.flagI.Size = new System.Drawing.Size(227, 111);
            this.flagI.TabIndex = 3;
            this.flagI.WordWrap = false;
            // 
            // flagV
            // 
            this.flagV.Location = new System.Drawing.Point(8, 85);
            this.flagV.Name = "flagV";
            this.flagV.Size = new System.Drawing.Size(100, 23);
            this.flagV.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "[Version] Create SPIR-V binary w/ Vulkan";
            // 
            // flagOs
            // 
            this.flagOs.AutoSize = true;
            this.flagOs.Location = new System.Drawing.Point(8, 164);
            this.flagOs.Name = "flagOs";
            this.flagOs.Size = new System.Drawing.Size(142, 19);
            this.flagOs.TabIndex = 0;
            this.flagOs.Text = "-Os : Optimize for size";
            this.flagOs.UseVisualStyleBackColor = true;
            // 
            // flagOd
            // 
            this.flagOd.AutoSize = true;
            this.flagOd.Location = new System.Drawing.Point(8, 139);
            this.flagOd.Name = "flagOd";
            this.flagOd.Size = new System.Drawing.Size(235, 19);
            this.flagOd.TabIndex = 0;
            this.flagOd.Text = "-Od : Disable optimization [Dangerous!]";
            this.flagOd.UseVisualStyleBackColor = true;
            // 
            // flagH
            // 
            this.flagH.AutoSize = true;
            this.flagH.Location = new System.Drawing.Point(8, 114);
            this.flagH.Name = "flagH";
            this.flagH.Size = new System.Drawing.Size(244, 19);
            this.flagH.TabIndex = 0;
            this.flagH.Text = "-H : Print human readable form of SPIR-V";
            this.flagH.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 60);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(178, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "-E : Print pre-processed GLSL";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // flagD
            // 
            this.flagD.AutoSize = true;
            this.flagD.Location = new System.Drawing.Point(8, 35);
            this.flagD.Name = "flagD";
            this.flagD.Size = new System.Drawing.Size(117, 19);
            this.flagD.TabIndex = 0;
            this.flagD.Text = "-D : Input is HLSL";
            this.flagD.UseVisualStyleBackColor = true;
            // 
            // flagC
            // 
            this.flagC.AutoSize = true;
            this.flagC.Location = new System.Drawing.Point(8, 10);
            this.flagC.Name = "flagC";
            this.flagC.Size = new System.Drawing.Size(136, 19);
            this.flagC.TabIndex = 0;
            this.flagC.Text = "-C : Cascading Errors";
            this.flagC.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(647, 384);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Spirv Optimizer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 138);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stage override";
            // 
            // flaglowerc
            // 
            this.flaglowerc.AutoSize = true;
            this.flaglowerc.Location = new System.Drawing.Point(8, 218);
            this.flaglowerc.Name = "flaglowerc";
            this.flaglowerc.Size = new System.Drawing.Size(117, 19);
            this.flaglowerc.TabIndex = 0;
            this.flaglowerc.Text = "-c : Config dump";
            this.flaglowerc.UseVisualStyleBackColor = true;
            // 
            // flage
            // 
            this.flage.Location = new System.Drawing.Point(8, 243);
            this.flage.Name = "flage";
            this.flage.Size = new System.Drawing.Size(100, 23);
            this.flage.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Entry point";
            // 
            // flagg
            // 
            this.flagg.AutoSize = true;
            this.flagg.Location = new System.Drawing.Point(8, 272);
            this.flagg.Name = "flagg";
            this.flagg.Size = new System.Drawing.Size(197, 19);
            this.flagg.TabIndex = 0;
            this.flagg.Text = "-g : Generate debug information";
            this.flagg.UseVisualStyleBackColor = true;
            // 
            // flagg0
            // 
            this.flagg0.AutoSize = true;
            this.flagg0.Location = new System.Drawing.Point(8, 297);
            this.flagg0.Name = "flagg0";
            this.flagg0.Size = new System.Drawing.Size(180, 19);
            this.flagg0.TabIndex = 0;
            this.flagg0.Text = "-g0 : Strip debug information";
            this.flagg0.UseVisualStyleBackColor = true;
            // 
            // flagloweri
            // 
            this.flagloweri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flagloweri.AutoSize = true;
            this.flagloweri.Location = new System.Drawing.Point(412, 146);
            this.flagloweri.Name = "flagloweri";
            this.flagloweri.Size = new System.Drawing.Size(161, 19);
            this.flagloweri.TabIndex = 0;
            this.flagloweri.Text = "-i : Intermediate tree print";
            this.flagloweri.UseVisualStyleBackColor = true;
            // 
            // flagl
            // 
            this.flagl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flagl.AutoSize = true;
            this.flagl.Location = new System.Drawing.Point(412, 171);
            this.flagl.Name = "flagl";
            this.flagl.Size = new System.Drawing.Size(129, 19);
            this.flagl.TabIndex = 0;
            this.flagl.Text = "-l : Link all modules";
            this.flagl.UseVisualStyleBackColor = true;
            // 
            // flagm
            // 
            this.flagm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flagm.AutoSize = true;
            this.flagm.Location = new System.Drawing.Point(412, 196);
            this.flagm.Name = "flagm";
            this.flagm.Size = new System.Drawing.Size(154, 19);
            this.flagm.TabIndex = 0;
            this.flagm.Text = "-m : Memory leak mode";
            this.flagm.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(506, 309);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 550);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox flagS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox flagI;
        private System.Windows.Forms.TextBox flagV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox flagOs;
        private System.Windows.Forms.CheckBox flagOd;
        private System.Windows.Forms.CheckBox flagH;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox flagD;
        private System.Windows.Forms.CheckBox flagC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox flage;
        private System.Windows.Forms.CheckBox flagm;
        private System.Windows.Forms.CheckBox flagl;
        private System.Windows.Forms.CheckBox flagloweri;
        private System.Windows.Forms.CheckBox flagg0;
        private System.Windows.Forms.CheckBox flagg;
        private System.Windows.Forms.CheckBox flaglowerc;
    }
}

