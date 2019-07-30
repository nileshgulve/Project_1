using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace ECG
{
    public partial class LivePage : Form
    {
        SerialPort port = new SerialPort();
        public LivePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            port = new SerialPort(textBox1.Text,9600);
            port.Open();
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        public static int data = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            string str = port.ReadLine();
            richTextBox1.Text = richTextBox1.Text  + str;

            try 
            {
                string d = port.ReadLine();
            data = int.Parse (d);
            }
            catch{
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            port.Close();
            this.Close();
        }
    }
}
