namespace SerialPort_Terminal
{
    partial class SpTerm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpTerm));
            this.comboBox_PortName = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_bits = new System.Windows.Forms.ComboBox();
            this.button_ClosePort = new System.Windows.Forms.Button();
            this.button_OpenPort = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Parity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_StopBit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ASCII = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_DSR = new System.Windows.Forms.CheckBox();
            this.checkBox_CTS = new System.Windows.Forms.CheckBox();
            this.button_SaveAscii = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_SaveHex = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_hex = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox_DTR = new System.Windows.Forms.CheckBox();
            this.checkBox_RTS = new System.Windows.Forms.CheckBox();
            this.comboBox_Send = new System.Windows.Forms.ComboBox();
            this.radio_ascii = new System.Windows.Forms.RadioButton();
            this.radio_hex = new System.Windows.Forms.RadioButton();
            this.button_Send = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.saveFileDialog_ASCII = new System.Windows.Forms.SaveFileDialog();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_PortName
            // 
            this.comboBox_PortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PortName.FormattingEnabled = true;
            this.comboBox_PortName.Location = new System.Drawing.Point(110, 30);
            this.comboBox_PortName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_PortName.Name = "comboBox_PortName";
            this.comboBox_PortName.Size = new System.Drawing.Size(148, 26);
            this.comboBox_PortName.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBox_bits);
            this.groupBox1.Controls.Add(this.button_ClosePort);
            this.groupBox1.Controls.Add(this.button_OpenPort);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox_Parity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox_StopBit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_BaudRate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_PortName);
            this.groupBox1.Location = new System.Drawing.Point(18, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(646, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Port Settings";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 111);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Bits:";
            // 
            // comboBox_bits
            // 
            this.comboBox_bits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_bits.FormattingEnabled = true;
            this.comboBox_bits.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.comboBox_bits.Location = new System.Drawing.Point(110, 107);
            this.comboBox_bits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_bits.Name = "comboBox_bits";
            this.comboBox_bits.Size = new System.Drawing.Size(148, 26);
            this.comboBox_bits.TabIndex = 12;
            // 
            // button_ClosePort
            // 
            this.button_ClosePort.Location = new System.Drawing.Point(524, 65);
            this.button_ClosePort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_ClosePort.Name = "button_ClosePort";
            this.button_ClosePort.Size = new System.Drawing.Size(112, 32);
            this.button_ClosePort.TabIndex = 9;
            this.button_ClosePort.Text = "Close Port";
            this.button_ClosePort.UseVisualStyleBackColor = true;
            this.button_ClosePort.Click += new System.EventHandler(this.ClosePort_Click);
            // 
            // button_OpenPort
            // 
            this.button_OpenPort.Location = new System.Drawing.Point(524, 28);
            this.button_OpenPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_OpenPort.Name = "button_OpenPort";
            this.button_OpenPort.Size = new System.Drawing.Size(112, 32);
            this.button_OpenPort.TabIndex = 8;
            this.button_OpenPort.Text = "Open Port";
            this.button_OpenPort.UseVisualStyleBackColor = true;
            this.button_OpenPort.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Parity:";
            // 
            // comboBox_Parity
            // 
            this.comboBox_Parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Parity.FormattingEnabled = true;
            this.comboBox_Parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.comboBox_Parity.Location = new System.Drawing.Point(364, 68);
            this.comboBox_Parity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Parity.Name = "comboBox_Parity";
            this.comboBox_Parity.Size = new System.Drawing.Size(148, 26);
            this.comboBox_Parity.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stop Bit:";
            // 
            // comboBox_StopBit
            // 
            this.comboBox_StopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_StopBit.FormattingEnabled = true;
            this.comboBox_StopBit.Items.AddRange(new object[] {
            "One",
            "OnePointFive",
            "Two"});
            this.comboBox_StopBit.Location = new System.Drawing.Point(364, 30);
            this.comboBox_StopBit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_StopBit.Name = "comboBox_StopBit";
            this.comboBox_StopBit.Size = new System.Drawing.Size(148, 26);
            this.comboBox_StopBit.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud Rate:";
            // 
            // comboBox_BaudRate
            // 
            this.comboBox_BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_BaudRate.FormattingEnabled = true;
            this.comboBox_BaudRate.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.comboBox_BaudRate.Location = new System.Drawing.Point(110, 68);
            this.comboBox_BaudRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_BaudRate.Name = "comboBox_BaudRate";
            this.comboBox_BaudRate.Size = new System.Drawing.Size(148, 26);
            this.comboBox_BaudRate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Com Port:";
            // 
            // textBox_ASCII
            // 
            this.textBox_ASCII.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ASCII.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_ASCII.Location = new System.Drawing.Point(9, 44);
            this.textBox_ASCII.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_ASCII.Multiline = true;
            this.textBox_ASCII.Name = "textBox_ASCII";
            this.textBox_ASCII.ReadOnly = true;
            this.textBox_ASCII.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ASCII.Size = new System.Drawing.Size(262, 276);
            this.textBox_ASCII.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.checkBox_DSR);
            this.groupBox2.Controls.Add(this.checkBox_CTS);
            this.groupBox2.Controls.Add(this.button_SaveAscii);
            this.groupBox2.Controls.Add(this.button_clear);
            this.groupBox2.Controls.Add(this.button_SaveHex);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox_hex);
            this.groupBox2.Controls.Add(this.textBox_ASCII);
            this.groupBox2.Location = new System.Drawing.Point(18, 169);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(646, 399);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Received";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 363);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Data Set Ready";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 331);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Clear To Send";
            // 
            // checkBox_DSR
            // 
            this.checkBox_DSR.AutoSize = true;
            this.checkBox_DSR.Enabled = false;
            this.checkBox_DSR.Location = new System.Drawing.Point(14, 363);
            this.checkBox_DSR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_DSR.Name = "checkBox_DSR";
            this.checkBox_DSR.Size = new System.Drawing.Size(22, 21);
            this.checkBox_DSR.TabIndex = 12;
            this.checkBox_DSR.TabStop = false;
            this.checkBox_DSR.UseVisualStyleBackColor = true;
            // 
            // checkBox_CTS
            // 
            this.checkBox_CTS.AutoSize = true;
            this.checkBox_CTS.Enabled = false;
            this.checkBox_CTS.Location = new System.Drawing.Point(14, 331);
            this.checkBox_CTS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_CTS.Name = "checkBox_CTS";
            this.checkBox_CTS.Size = new System.Drawing.Size(22, 21);
            this.checkBox_CTS.TabIndex = 11;
            this.checkBox_CTS.TabStop = false;
            this.checkBox_CTS.UseVisualStyleBackColor = true;
            // 
            // button_SaveAscii
            // 
            this.button_SaveAscii.Location = new System.Drawing.Point(402, 336);
            this.button_SaveAscii.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_SaveAscii.Name = "button_SaveAscii";
            this.button_SaveAscii.Size = new System.Drawing.Size(112, 32);
            this.button_SaveAscii.TabIndex = 10;
            this.button_SaveAscii.Text = "Save ASCII";
            this.button_SaveAscii.UseVisualStyleBackColor = true;
            this.button_SaveAscii.Click += new System.EventHandler(this.button_SaveAscii_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(280, 336);
            this.button_clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(112, 32);
            this.button_clear.TabIndex = 9;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.ClearInput_Click);
            // 
            // button_SaveHex
            // 
            this.button_SaveHex.Location = new System.Drawing.Point(524, 336);
            this.button_SaveHex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_SaveHex.Name = "button_SaveHex";
            this.button_SaveHex.Size = new System.Drawing.Size(112, 32);
            this.button_SaveHex.TabIndex = 8;
            this.button_SaveHex.Text = "Save Hex";
            this.button_SaveHex.UseVisualStyleBackColor = true;
            this.button_SaveHex.Click += new System.EventHandler(this.button_SaveHex_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Hex";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "ASCII Text";
            // 
            // textBox_hex
            // 
            this.textBox_hex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_hex.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_hex.Location = new System.Drawing.Point(280, 44);
            this.textBox_hex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_hex.Multiline = true;
            this.textBox_hex.Name = "textBox_hex";
            this.textBox_hex.ReadOnly = true;
            this.textBox_hex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_hex.Size = new System.Drawing.Size(354, 276);
            this.textBox_hex.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox_DTR);
            this.groupBox3.Controls.Add(this.checkBox_RTS);
            this.groupBox3.Controls.Add(this.comboBox_Send);
            this.groupBox3.Controls.Add(this.radio_ascii);
            this.groupBox3.Controls.Add(this.radio_hex);
            this.groupBox3.Controls.Add(this.button_Send);
            this.groupBox3.Location = new System.Drawing.Point(18, 576);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(646, 134);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Send";
            // 
            // checkBox_DTR
            // 
            this.checkBox_DTR.AutoSize = true;
            this.checkBox_DTR.Location = new System.Drawing.Point(180, 97);
            this.checkBox_DTR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_DTR.Name = "checkBox_DTR";
            this.checkBox_DTR.Size = new System.Drawing.Size(183, 22);
            this.checkBox_DTR.TabIndex = 6;
            this.checkBox_DTR.Text = "Data Terminal Ready";
            this.checkBox_DTR.UseVisualStyleBackColor = true;
            this.checkBox_DTR.CheckedChanged += new System.EventHandler(this.checkBox_DTR_CheckedChanged);
            // 
            // checkBox_RTS
            // 
            this.checkBox_RTS.AutoSize = true;
            this.checkBox_RTS.Location = new System.Drawing.Point(9, 97);
            this.checkBox_RTS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_RTS.Name = "checkBox_RTS";
            this.checkBox_RTS.Size = new System.Drawing.Size(148, 22);
            this.checkBox_RTS.TabIndex = 5;
            this.checkBox_RTS.Text = "Request To send";
            this.checkBox_RTS.UseVisualStyleBackColor = true;
            this.checkBox_RTS.CheckedChanged += new System.EventHandler(this.checkBox_RTS_CheckedChanged);
            // 
            // comboBox_Send
            // 
            this.comboBox_Send.FormattingEnabled = true;
            this.comboBox_Send.Location = new System.Drawing.Point(9, 29);
            this.comboBox_Send.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Send.Name = "comboBox_Send";
            this.comboBox_Send.Size = new System.Drawing.Size(504, 26);
            this.comboBox_Send.TabIndex = 4;
            this.comboBox_Send.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboSend_KeyUp);
            // 
            // radio_ascii
            // 
            this.radio_ascii.AutoSize = true;
            this.radio_ascii.Location = new System.Drawing.Point(14, 65);
            this.radio_ascii.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radio_ascii.Name = "radio_ascii";
            this.radio_ascii.Size = new System.Drawing.Size(77, 22);
            this.radio_ascii.TabIndex = 3;
            this.radio_ascii.TabStop = true;
            this.radio_ascii.Text = "ASCII";
            this.radio_ascii.UseVisualStyleBackColor = true;
            // 
            // radio_hex
            // 
            this.radio_hex.AutoSize = true;
            this.radio_hex.Location = new System.Drawing.Point(100, 65);
            this.radio_hex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radio_hex.Name = "radio_hex";
            this.radio_hex.Size = new System.Drawing.Size(439, 22);
            this.radio_hex.TabIndex = 2;
            this.radio_hex.TabStop = true;
            this.radio_hex.Text = "Hexadecimal (8 bits seperated by Space. eg: FF FF FF FF)";
            this.radio_hex.UseVisualStyleBackColor = true;
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(524, 26);
            this.button_Send.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(112, 32);
            this.button_Send.TabIndex = 0;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // serialPort
            // 
            this.serialPort.PinChanged += new System.IO.Ports.SerialPinChangedEventHandler(this.serialPort_PinChanged);
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // saveFileDialog_ASCII
            // 
            this.saveFileDialog_ASCII.DefaultExt = "txt";
            this.saveFileDialog_ASCII.Filter = "Text file (*.txt)|*.txt|All files (*.*)|*.*";
            this.saveFileDialog_ASCII.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_ASCII_FileOk);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(484, 714);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(167, 18);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.enmcu.com";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // SpTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 739);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "SpTerm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPTerm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SpTerm_FormClosed);
            this.Load += new System.EventHandler(this.SpTerm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_PortName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ClosePort;
        private System.Windows.Forms.Button button_OpenPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Parity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_StopBit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_BaudRate;
        private System.Windows.Forms.TextBox textBox_ASCII;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_hex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_SaveHex;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radio_ascii;
        private System.Windows.Forms.RadioButton radio_hex;
        private System.Windows.Forms.Button button_Send;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.ComboBox comboBox_Send;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.CheckBox checkBox_RTS;
        private System.Windows.Forms.CheckBox checkBox_DTR;
        private System.Windows.Forms.Button button_SaveAscii;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_ASCII;
        private System.Windows.Forms.CheckBox checkBox_DSR;
        private System.Windows.Forms.CheckBox checkBox_CTS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_bits;
    }
}

