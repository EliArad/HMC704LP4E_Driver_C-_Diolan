namespace HMC704ControlLib
{
    partial class HMC703LP4EControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSetFrequency = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnReadAll = new System.Windows.Forms.Button();
            this.Reg13_result = new System.Windows.Forms.TextBox();
            this.Label24 = new System.Windows.Forms.Label();
            this.Reg12_result = new System.Windows.Forms.TextBox();
            this.Label25 = new System.Windows.Forms.Label();
            this.Reg11_result = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.Reg10_result = new System.Windows.Forms.TextBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.RegF_result = new System.Windows.Forms.TextBox();
            this.Label18 = new System.Windows.Forms.Label();
            this.RegC_result = new System.Windows.Forms.TextBox();
            this.Label19 = new System.Windows.Forms.Label();
            this.RegB_result = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.RegA_result = new System.Windows.Forms.TextBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.Reg9_result = new System.Windows.Forms.TextBox();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.Reg8_result = new System.Windows.Forms.TextBox();
            this.Reg7_result = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Reg6_result = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Reg5_result = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Reg4_result = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Reg3_result = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Reg2_result = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Reg1_result = new System.Windows.Forms.TextBox();
            this.Reg01h = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Reg0_result = new System.Windows.Forms.TextBox();
            this.btnReadReg0 = new System.Windows.Forms.Button();
            this.btnReadReg1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSetFrequency
            // 
            this.btnSetFrequency.Location = new System.Drawing.Point(147, 43);
            this.btnSetFrequency.Name = "btnSetFrequency";
            this.btnSetFrequency.Size = new System.Drawing.Size(75, 23);
            this.btnSetFrequency.TabIndex = 1;
            this.btnSetFrequency.Text = "Set frequency";
            this.btnSetFrequency.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Frequency";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1.575Ghz",
            "1 Ghz"});
            this.comboBox1.Location = new System.Drawing.Point(27, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(27, 122);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2600,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2600,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(108, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            2600,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Set frequency";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Frequency";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(790, 569);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnSetFrequency);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(779, 543);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Frequency";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnReadReg1);
            this.tabPage2.Controls.Add(this.btnReadReg0);
            this.tabPage2.Controls.Add(this.btnReadAll);
            this.tabPage2.Controls.Add(this.Reg13_result);
            this.tabPage2.Controls.Add(this.Label24);
            this.tabPage2.Controls.Add(this.Reg12_result);
            this.tabPage2.Controls.Add(this.Label25);
            this.tabPage2.Controls.Add(this.Reg11_result);
            this.tabPage2.Controls.Add(this.Label16);
            this.tabPage2.Controls.Add(this.Reg10_result);
            this.tabPage2.Controls.Add(this.Label17);
            this.tabPage2.Controls.Add(this.RegF_result);
            this.tabPage2.Controls.Add(this.Label18);
            this.tabPage2.Controls.Add(this.RegC_result);
            this.tabPage2.Controls.Add(this.Label19);
            this.tabPage2.Controls.Add(this.RegB_result);
            this.tabPage2.Controls.Add(this.Label20);
            this.tabPage2.Controls.Add(this.RegA_result);
            this.tabPage2.Controls.Add(this.Label21);
            this.tabPage2.Controls.Add(this.Reg9_result);
            this.tabPage2.Controls.Add(this.Label22);
            this.tabPage2.Controls.Add(this.Label23);
            this.tabPage2.Controls.Add(this.Reg8_result);
            this.tabPage2.Controls.Add(this.Reg7_result);
            this.tabPage2.Controls.Add(this.Label8);
            this.tabPage2.Controls.Add(this.Reg6_result);
            this.tabPage2.Controls.Add(this.Label7);
            this.tabPage2.Controls.Add(this.Reg5_result);
            this.tabPage2.Controls.Add(this.Label6);
            this.tabPage2.Controls.Add(this.Reg4_result);
            this.tabPage2.Controls.Add(this.Label5);
            this.tabPage2.Controls.Add(this.Reg3_result);
            this.tabPage2.Controls.Add(this.Label4);
            this.tabPage2.Controls.Add(this.Reg2_result);
            this.tabPage2.Controls.Add(this.Label3);
            this.tabPage2.Controls.Add(this.Reg1_result);
            this.tabPage2.Controls.Add(this.Reg01h);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.Reg0_result);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(782, 543);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnReadAll
            // 
            this.btnReadAll.Location = new System.Drawing.Point(48, 504);
            this.btnReadAll.Name = "btnReadAll";
            this.btnReadAll.Size = new System.Drawing.Size(126, 23);
            this.btnReadAll.TabIndex = 136;
            this.btnReadAll.Text = "Read all";
            this.btnReadAll.UseVisualStyleBackColor = true;
            // 
            // Reg13_result
            // 
            this.Reg13_result.Location = new System.Drawing.Point(98, 444);
            this.Reg13_result.Margin = new System.Windows.Forms.Padding(2);
            this.Reg13_result.Name = "Reg13_result";
            this.Reg13_result.Size = new System.Drawing.Size(76, 20);
            this.Reg13_result.TabIndex = 135;
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(45, 444);
            this.Label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(45, 13);
            this.Label24.TabIndex = 134;
            this.Label24.Text = "Reg13h";
            // 
            // Reg12_result
            // 
            this.Reg12_result.Location = new System.Drawing.Point(98, 421);
            this.Reg12_result.Margin = new System.Windows.Forms.Padding(2);
            this.Reg12_result.Name = "Reg12_result";
            this.Reg12_result.Size = new System.Drawing.Size(76, 20);
            this.Reg12_result.TabIndex = 133;
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Location = new System.Drawing.Point(45, 421);
            this.Label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(45, 13);
            this.Label25.TabIndex = 132;
            this.Label25.Text = "Reg12h";
            // 
            // Reg11_result
            // 
            this.Reg11_result.Location = new System.Drawing.Point(98, 397);
            this.Reg11_result.Margin = new System.Windows.Forms.Padding(2);
            this.Reg11_result.Name = "Reg11_result";
            this.Reg11_result.Size = new System.Drawing.Size(76, 20);
            this.Reg11_result.TabIndex = 131;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(45, 397);
            this.Label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(45, 13);
            this.Label16.TabIndex = 130;
            this.Label16.Text = "Reg11h";
            // 
            // Reg10_result
            // 
            this.Reg10_result.Location = new System.Drawing.Point(98, 374);
            this.Reg10_result.Margin = new System.Windows.Forms.Padding(2);
            this.Reg10_result.Name = "Reg10_result";
            this.Reg10_result.Size = new System.Drawing.Size(76, 20);
            this.Reg10_result.TabIndex = 129;
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(45, 374);
            this.Label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(45, 13);
            this.Label17.TabIndex = 128;
            this.Label17.Text = "Reg10h";
            // 
            // RegF_result
            // 
            this.RegF_result.Location = new System.Drawing.Point(98, 351);
            this.RegF_result.Margin = new System.Windows.Forms.Padding(2);
            this.RegF_result.Name = "RegF_result";
            this.RegF_result.Size = new System.Drawing.Size(76, 20);
            this.RegF_result.TabIndex = 127;
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Location = new System.Drawing.Point(45, 351);
            this.Label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(45, 13);
            this.Label18.TabIndex = 126;
            this.Label18.Text = "Reg0Fh";
            // 
            // RegC_result
            // 
            this.RegC_result.Location = new System.Drawing.Point(98, 328);
            this.RegC_result.Margin = new System.Windows.Forms.Padding(2);
            this.RegC_result.Name = "RegC_result";
            this.RegC_result.Size = new System.Drawing.Size(76, 20);
            this.RegC_result.TabIndex = 125;
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Location = new System.Drawing.Point(45, 328);
            this.Label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(46, 13);
            this.Label19.TabIndex = 124;
            this.Label19.Text = "Reg0Ch";
            // 
            // RegB_result
            // 
            this.RegB_result.Location = new System.Drawing.Point(98, 306);
            this.RegB_result.Margin = new System.Windows.Forms.Padding(2);
            this.RegB_result.Name = "RegB_result";
            this.RegB_result.Size = new System.Drawing.Size(76, 20);
            this.RegB_result.TabIndex = 123;
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(45, 308);
            this.Label20.Margin = new System.Windows.Forms.Padding(0);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(46, 13);
            this.Label20.TabIndex = 122;
            this.Label20.Text = "Reg0Bh";
            // 
            // RegA_result
            // 
            this.RegA_result.Location = new System.Drawing.Point(98, 283);
            this.RegA_result.Margin = new System.Windows.Forms.Padding(2);
            this.RegA_result.Name = "RegA_result";
            this.RegA_result.Size = new System.Drawing.Size(76, 20);
            this.RegA_result.TabIndex = 121;
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(45, 283);
            this.Label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(46, 13);
            this.Label21.TabIndex = 120;
            this.Label21.Text = "Reg0Ah";
            // 
            // Reg9_result
            // 
            this.Reg9_result.Location = new System.Drawing.Point(98, 260);
            this.Reg9_result.Margin = new System.Windows.Forms.Padding(2);
            this.Reg9_result.Name = "Reg9_result";
            this.Reg9_result.Size = new System.Drawing.Size(76, 20);
            this.Reg9_result.TabIndex = 119;
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(45, 260);
            this.Label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(45, 13);
            this.Label22.TabIndex = 118;
            this.Label22.Text = "Reg09h";
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Location = new System.Drawing.Point(45, 240);
            this.Label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(45, 13);
            this.Label23.TabIndex = 117;
            this.Label23.Text = "Reg08h";
            // 
            // Reg8_result
            // 
            this.Reg8_result.Location = new System.Drawing.Point(98, 237);
            this.Reg8_result.Margin = new System.Windows.Forms.Padding(2);
            this.Reg8_result.Name = "Reg8_result";
            this.Reg8_result.Size = new System.Drawing.Size(76, 20);
            this.Reg8_result.TabIndex = 116;
            this.Reg8_result.TextChanged += new System.EventHandler(this.Reg8_result_TextChanged);
            // 
            // Reg7_result
            // 
            this.Reg7_result.Location = new System.Drawing.Point(98, 215);
            this.Reg7_result.Margin = new System.Windows.Forms.Padding(2);
            this.Reg7_result.Name = "Reg7_result";
            this.Reg7_result.Size = new System.Drawing.Size(76, 20);
            this.Reg7_result.TabIndex = 115;
            this.Reg7_result.TextChanged += new System.EventHandler(this.Reg7_result_TextChanged);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(45, 215);
            this.Label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(45, 13);
            this.Label8.TabIndex = 114;
            this.Label8.Text = "Reg07h";
            // 
            // Reg6_result
            // 
            this.Reg6_result.Location = new System.Drawing.Point(98, 192);
            this.Reg6_result.Margin = new System.Windows.Forms.Padding(2);
            this.Reg6_result.Name = "Reg6_result";
            this.Reg6_result.Size = new System.Drawing.Size(76, 20);
            this.Reg6_result.TabIndex = 113;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(45, 192);
            this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(45, 13);
            this.Label7.TabIndex = 112;
            this.Label7.Text = "Reg06h";
            // 
            // Reg5_result
            // 
            this.Reg5_result.Location = new System.Drawing.Point(98, 169);
            this.Reg5_result.Margin = new System.Windows.Forms.Padding(2);
            this.Reg5_result.Name = "Reg5_result";
            this.Reg5_result.Size = new System.Drawing.Size(76, 20);
            this.Reg5_result.TabIndex = 111;
            this.Reg5_result.TextChanged += new System.EventHandler(this.Reg5_result_TextChanged);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(45, 169);
            this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(45, 13);
            this.Label6.TabIndex = 110;
            this.Label6.Text = "Reg05h";
            // 
            // Reg4_result
            // 
            this.Reg4_result.Location = new System.Drawing.Point(98, 146);
            this.Reg4_result.Margin = new System.Windows.Forms.Padding(2);
            this.Reg4_result.Name = "Reg4_result";
            this.Reg4_result.Size = new System.Drawing.Size(76, 20);
            this.Reg4_result.TabIndex = 109;
            this.Reg4_result.TextChanged += new System.EventHandler(this.Reg4_result_TextChanged);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(45, 146);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(45, 13);
            this.Label5.TabIndex = 108;
            this.Label5.Text = "Reg04h";
            // 
            // Reg3_result
            // 
            this.Reg3_result.AcceptsReturn = true;
            this.Reg3_result.Location = new System.Drawing.Point(98, 124);
            this.Reg3_result.Margin = new System.Windows.Forms.Padding(2);
            this.Reg3_result.Name = "Reg3_result";
            this.Reg3_result.Size = new System.Drawing.Size(76, 20);
            this.Reg3_result.TabIndex = 107;
            this.Reg3_result.TextChanged += new System.EventHandler(this.Reg3_result_TextChanged);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(45, 126);
            this.Label4.Margin = new System.Windows.Forms.Padding(0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(45, 13);
            this.Label4.TabIndex = 106;
            this.Label4.Text = "Reg03h";
            // 
            // Reg2_result
            // 
            this.Reg2_result.Location = new System.Drawing.Point(98, 101);
            this.Reg2_result.Margin = new System.Windows.Forms.Padding(2);
            this.Reg2_result.Name = "Reg2_result";
            this.Reg2_result.Size = new System.Drawing.Size(76, 20);
            this.Reg2_result.TabIndex = 105;
            this.Reg2_result.TextChanged += new System.EventHandler(this.Reg2_result_TextChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(46, 101);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(45, 13);
            this.Label3.TabIndex = 104;
            this.Label3.Text = "Reg02h";
            // 
            // Reg1_result
            // 
            this.Reg1_result.Location = new System.Drawing.Point(98, 56);
            this.Reg1_result.Margin = new System.Windows.Forms.Padding(2);
            this.Reg1_result.Name = "Reg1_result";
            this.Reg1_result.Size = new System.Drawing.Size(76, 20);
            this.Reg1_result.TabIndex = 103;
            this.Reg1_result.TextChanged += new System.EventHandler(this.Reg1_result_TextChanged);
            // 
            // Reg01h
            // 
            this.Reg01h.AutoSize = true;
            this.Reg01h.Location = new System.Drawing.Point(45, 56);
            this.Reg01h.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Reg01h.Name = "Reg01h";
            this.Reg01h.Size = new System.Drawing.Size(45, 13);
            this.Reg01h.TabIndex = 102;
            this.Reg01h.Text = "Reg01h\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 101;
            this.label9.Text = "Reg00h";
            // 
            // Reg0_result
            // 
            this.Reg0_result.Location = new System.Drawing.Point(98, 25);
            this.Reg0_result.Margin = new System.Windows.Forms.Padding(2);
            this.Reg0_result.Name = "Reg0_result";
            this.Reg0_result.Size = new System.Drawing.Size(76, 20);
            this.Reg0_result.TabIndex = 100;
            this.Reg0_result.TextChanged += new System.EventHandler(this.Reg0_result_TextChanged);
            // 
            // btnReadReg0
            // 
            this.btnReadReg0.Location = new System.Drawing.Point(190, 25);
            this.btnReadReg0.Name = "btnReadReg0";
            this.btnReadReg0.Size = new System.Drawing.Size(79, 23);
            this.btnReadReg0.TabIndex = 137;
            this.btnReadReg0.Text = "Read";
            this.btnReadReg0.UseVisualStyleBackColor = true;
            this.btnReadReg0.Click += new System.EventHandler(this.btnReadReg0_Click);
            // 
            // btnReadReg1
            // 
            this.btnReadReg1.Location = new System.Drawing.Point(189, 55);
            this.btnReadReg1.Name = "btnReadReg1";
            this.btnReadReg1.Size = new System.Drawing.Size(79, 24);
            this.btnReadReg1.TabIndex = 138;
            this.btnReadReg1.Text = "Read";
            this.btnReadReg1.UseVisualStyleBackColor = true;
            this.btnReadReg1.Click += new System.EventHandler(this.btnReadReg1_Click);
            // 
            // HMC703LP4EControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Name = "HMC703LP4EControl";
            this.Size = new System.Drawing.Size(793, 572);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSetFrequency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnReadAll;
        internal System.Windows.Forms.TextBox Reg13_result;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.TextBox Reg12_result;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.TextBox Reg11_result;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.TextBox Reg10_result;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.TextBox RegF_result;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.TextBox RegC_result;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.TextBox RegB_result;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.TextBox RegA_result;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.TextBox Reg9_result;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.TextBox Reg8_result;
        internal System.Windows.Forms.TextBox Reg7_result;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox Reg6_result;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox Reg5_result;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox Reg4_result;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox Reg3_result;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox Reg2_result;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox Reg1_result;
        internal System.Windows.Forms.Label Reg01h;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox Reg0_result;
        private System.Windows.Forms.Button btnReadReg0;
        private System.Windows.Forms.Button btnReadReg1;
    }
}
