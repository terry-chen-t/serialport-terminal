using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Text.RegularExpressions;

namespace SerialPort_Terminal
{
    public partial class SpTerm : Form
    {
        string[] PortNames;
        string RecievedData;
        string RecievedDataHex;
        bool RecievedCTS;
        bool RecievedDSR;
        bool saveType;
        delegate void UpdateCallback();

        public SpTerm()
        {
            InitializeComponent();
        }

        private void SpTerm_Load(object sender, EventArgs e)
        {
            try
            {
                PortNames = SerialPort.GetPortNames();
            }
            catch
            {
                MessageBox.Show("No Serial Port Found", "SpTerm Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            if (PortNames == null)
            {
                MessageBox.Show("No Serial Port Found", "SpTerm Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else if (PortNames.Count() == 0)
            {
                MessageBox.Show("No Serial Port Found", "SpTerm Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                foreach (string Ports in PortNames)
                    comboBox_PortName.Items.Add(Ports);
                    comboBox_PortName.SelectedIndex = 0;
                    comboBox_BaudRate.SelectedIndex = 11;
                    comboBox_StopBit.SelectedIndex = 0;
                    comboBox_Parity.SelectedIndex = 0;
                    comboBox_bits.SelectedIndex = 0;
                    radio_ascii.Select();
                    button_Send.Enabled = false;
                    button_OpenPort.Enabled = true;
                    button_ClosePort.Enabled = false;
                    checkBox_DTR.Enabled = false;
                    checkBox_RTS.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort.PortName = PortNames[comboBox_PortName.SelectedIndex];
            serialPort.BaudRate = Convert.ToInt32(comboBox_BaudRate.SelectedItem.ToString());
            serialPort.DataBits = Convert.ToInt32(comboBox_bits.SelectedItem.ToString());
            switch(comboBox_Parity.SelectedIndex){
                case 0:
                    serialPort.Parity = Parity.None;
                    break;        
                case 1:
                    serialPort.Parity = Parity.Odd;
                    break;        
                case 2:
                    serialPort.Parity = Parity.Even;
                    break;        
                case 3:
                    serialPort.Parity = Parity.Mark;
                    break;        
                case 4:
                    serialPort.Parity = Parity.Space;
                    break;
            }
            switch (comboBox_StopBit.SelectedIndex)
            {
                case 0:
                    serialPort.StopBits = StopBits.One;
                    break;
                case 1:
                    serialPort.StopBits = StopBits.OnePointFive;
                    break;
                case 2:
                    serialPort.StopBits = StopBits.Two;
                    break;
            }
            try
            {
                serialPort.Open();
            }
            catch (Exception ex)
            {
                if(ex is UnauthorizedAccessException)
                    MessageBox.Show("Port Already Open", "SpTerm Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Port Not Found", "SpTerm Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (serialPort.IsOpen)
            {
                checkBox_DSR.Checked = serialPort.DsrHolding;
                checkBox_CTS.Checked = serialPort.CtsHolding;
                checkBox_DTR.Enabled = true;
                checkBox_RTS.Enabled = true;
                button_Send.Enabled = true;
                button_OpenPort.Enabled = false;
                button_ClosePort.Enabled = true;
            }
        }

        private void ClosePort_Click(object sender, EventArgs e)
        {
            serialPort.Close();
            button_Send.Enabled = false;
            button_OpenPort.Enabled = true;
            button_ClosePort.Enabled = false;
            checkBox_DTR.Enabled = false;
            checkBox_RTS.Enabled = false;
        }

        private void Send_Click(object sender, EventArgs e)
        {
            Sent_data(comboBox_Send.Text);
        }

        private void comboSend_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && button_Send.Enabled)
            {
                Sent_data(comboBox_Send.Text);
            }
        }

        private void SpTerm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort.IsOpen)
                serialPort.Close();
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int numOfByte = serialPort.BytesToRead;
            Byte[] RecievedDataTemp = new Byte[numOfByte];
            char[] charTemp = new char[numOfByte];
            serialPort.Read(RecievedDataTemp, 0, numOfByte);
            int i = 0;
            foreach (Byte value in RecievedDataTemp)
            {
                RecievedDataHex += "0x" + String.Format("{0:X2}", value) + " ";
                if ((value < 127 && value > 31) || value == 10 || value == 11)
                {
                    charTemp[i] = Convert.ToChar(value);
                    i++;
                }
            }
            string RcTemp = new string(charTemp);
            RecievedData += RcTemp;
            UpdateAscii();
        }

        private void UpdateAscii()
        {
            if (this.textBox_ASCII.InvokeRequired)
            {
                UpdateCallback d = new UpdateCallback(UpdateAscii);
                this.Invoke(d);
            }
            else
            {
                textBox_ASCII.Text = RecievedData;
                textBox_hex.Text = RecievedDataHex;
            }
        }

        private void Sent_data(string text)
        {
            if (comboBox_Send.Text != "")
            {
                if (radio_ascii.Checked)
                {
                    serialPort.Write(text);
                    comboBox_Send.Items.Add(comboBox_Send.Text);
                    comboBox_Send.Text = "";
                }
                else
                {
                    string[] hexValues = text.Split(' ');
                    Byte[] value = new Byte[hexValues.Count()];
                    int i = 0;
                    bool hex_check = true;
                    Regex hex_regex = new Regex(@"^[a-fA-F0-9][a-fA-F0-9]$");
                    foreach (String hex in hexValues)
                    {
                        if (hex_regex.IsMatch(hex))
                        {
                            value[i] = Convert.ToByte(hex, 16);
                            i++;
                        }
                        else
                        {
                            hex_check = false;
                            break;
                        }
                    }
                    if (hex_check)
                    {
                        serialPort.Write(value, 0, i);
                        comboBox_Send.Items.Add(comboBox_Send.Text);
                        comboBox_Send.Text = "";
                    }
                    else
                        MessageBox.Show("Hex Input Error", "SpTerm Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("No data to send", "SpTerm Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ClearInput_Click(object sender, EventArgs e)
        {
            RecievedData = "";
            RecievedDataHex = "";
            textBox_ASCII.Text = RecievedData;
            textBox_hex.Text = RecievedDataHex;
        }

        private void checkBox_RTS_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_RTS.Checked)
                serialPort.RtsEnable = true;
            else
                serialPort.RtsEnable = false;
        }

        private void checkBox_DTR_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_DTR.Checked)
                serialPort.DtrEnable = true;
            else
                serialPort.DtrEnable = false;
        }

        private void button_SaveAscii_Click(object sender, EventArgs e)
        {
            saveType = true;
            saveFileDialog_ASCII.ShowDialog();
        }

        private void button_SaveHex_Click(object sender, EventArgs e)
        {
            saveType = false;
            saveFileDialog_ASCII.ShowDialog();
        }

        private void saveFileDialog_ASCII_FileOk(object sender, CancelEventArgs e)
        {
            StreamWriter file = new StreamWriter(saveFileDialog_ASCII.OpenFile());
            if (saveType)
                file.Write(RecievedData);
            else
                file.Write(RecievedDataHex);
            file.Dispose();
        }

        private void serialPort_PinChanged(object sender, SerialPinChangedEventArgs e)
        {
            RecievedCTS = serialPort.CtsHolding;
            RecievedDSR = serialPort.DsrHolding;
        }

        private void UpdatePINS()
        {
            if (this.checkBox_DSR.InvokeRequired)
            {
                UpdateCallback d = new UpdateCallback(UpdatePINS);
                this.Invoke(d);
            }
            else
            {
                checkBox_DSR.Checked = RecievedDSR;
                checkBox_CTS.Checked = RecievedCTS;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.enmcu.com");
        }
    }
}
