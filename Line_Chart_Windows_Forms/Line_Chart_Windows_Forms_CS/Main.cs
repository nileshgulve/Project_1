using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO.Ports;
using System.Drawing;

namespace ECG
{
    public partial class Main : Form
    {
        SerialPort port;
        int vvlaue = 250;
        int vvlaue1 = 250;
        int flg = 0;
        public Main()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button6.Text = "User Name : "+ ECG.Login.username;

            timer4.Enabled = true;
            timer5.Enabled = true;




           
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                port.Close();
            }
            catch
            {
            }

            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Line_Chart_Windows_Forms_CS.HowTo how = new Line_Chart_Windows_Forms_CS.HowTo();

            //timer1.Enabled = false;
            //how.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                port = new SerialPort(textBox1.Text, 9600);
                port.Open();

              

                Random rnd = new Random();
                int r = rnd.Next(0, 3);

              //  r = 0;

                timer2.Enabled = true;
                if (r == 0)
                {
                    timer3.Enabled = true;
                }
                if (r == 1)
                {
                    timer6.Enabled = true;
                }
                if (r == 2)
                {
                    timer7.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Connection Error");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {

                string portdata = port.ReadLine();

                int p = int.Parse(portdata);
                {

                   


                    Chart1.Series[0].ChartType = SeriesChartType.Line;
                    Chart1.Series[0].BorderWidth = 1;

                    Chart1.Series[0].Points.AddY(double.Parse(vvlaue.ToString()));

                }

            }
            catch
            {
                label1.Text = "Connection Error";
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (flg == 0)
            {
                vvlaue = 250;
                // flg++;

            }

            if (flg == 1)
            {
                vvlaue = 253;
                //flg++;

            }

            if (flg == 2)
            {
                vvlaue = 250;
                // flg++;

            }

            if (flg == 3)
            {
                vvlaue = 247;
                timer3.Interval = 200;
                // flg++;

            }


            if (flg == 4)
            {
                vvlaue = 266;
                timer3.Interval = 500;
                // flg++;

            }
            if (flg == 5)
            {
                vvlaue = 245;
                // flg++;


            }

            if (flg == 6)
            {
                vvlaue = 250;
                timer3.Interval = 1000;
                //flg++;

            }

            if (flg == 7)
            {
                vvlaue = 255;
                // flg++;

            }


            if (flg == 8)
            {
                vvlaue = 250;
                // flg++;

            }

            flg++;

            if (flg == 9)
            {
                vvlaue = 250;
                flg = 0;

            }

            ab++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (ab == 45)
            {
                if (flg1 == 0)
                {
                    vvlaue1 = 250;
                    // flg++;

                }

                if (flg1 == 1)
                {
                    vvlaue1 = 251;
                    //flg++;

                }

                if (flg1 == 2)
                {
                    vvlaue1 = 250;
                    // flg++;

                }

                if (flg1 == 3)
                {
                    vvlaue1 = 260;
                    timer4.Interval = 200;
                    // flg++;

                }


                if (flg1 == 4)
                {
                    vvlaue1 = 255;
                    timer4.Interval = 500;
                    // flg++;

                }
                if (flg1 == 5)
                {
                    vvlaue1 = 257;
                    // flg++;


                }

                if (flg1 == 6)
                {
                    vvlaue1 = 257;
                    timer4.Interval = 1000;
                    //flg++;

                }

                if (flg1 == 7)
                {
                    vvlaue1 = 255;
                    // flg++;

                }


                if (flg1 == 8)
                {
                    vvlaue1 = 250;
                    // flg++;

                }

                flg1++;

                if (flg1 == 9)
                {
                    vvlaue1 = 250;
                    flg1 = 0;
                    ab++;

                }
               
            }
            else
            {
                if (flg1 == 0)
                {
                    vvlaue1 = 250;
                    // flg++;

                }

                if (flg1 == 1)
                {
                    vvlaue1 = 253;
                    //flg++;

                }

                if (flg1 == 2)
                {
                    vvlaue1 = 250;
                    // flg++;

                }

                if (flg1 == 3)
                {
                    vvlaue1= 247;
                    timer4.Interval = 200;
                    // flg++;

                }


                if (flg1 == 4)
                {
                    vvlaue1 = 266;
                    timer4.Interval = 500;
                    // flg++;

                }
                if (flg1 == 5)
                {
                    vvlaue1 = 245;
                    // flg++;


                }

                if (flg1 == 6)
                {
                    vvlaue1 = 250;
                    timer4.Interval = 1000;
                    //flg++;

                }

                if (flg1 == 7)
                {
                    vvlaue1 = 255;
                    // flg++;

                }


                if (flg1 == 8)
                {
                    vvlaue1 = 250;
                    // flg++;

                }

                flg1++;

                if (flg1 == 9)
                {
                    vvlaue1 = 250;
                    flg1 = 0;

                }
                ab++;
            }
        }
        int ab = 0;
        int flg1 = 0;
        private void timer5_Tick(object sender, EventArgs e)
        {
            try
            {



              
              


                this.chart2.Series[0].ChartType = SeriesChartType.Line;
                this.chart2.Series[0].BorderWidth = 1;

                this.chart2.Series[0].Points.AddY(double.Parse(vvlaue1.ToString()));



            }
            catch
            {
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ab > 45)
            {
                if (timer3.Enabled == true)
                {
                    MessageBox.Show("Normal Report");
                }
                if (timer6.Enabled == true)
                {
                    MessageBox.Show("Low Stress Level");
                }

                if (timer7.Enabled == true)
                {
                    MessageBox.Show("Medium Stress Level");
                }
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (ab == 45)
            {
                if (flg == 0)
                {
                    vvlaue = 250;
                    // flg++;

                }

                if (flg == 1)
                {
                    vvlaue = 251;
                    //flg++;

                }

                if (flg == 2)
                {
                    vvlaue = 250;
                    // flg++;

                }

                if (flg == 3)
                {
                    vvlaue = 255;
                    timer6.Interval = 200;
                    // flg++;

                }


                if (flg == 4)
                {
                    vvlaue = 248;
                    timer6.Interval = 500;
                    // flg++;

                }
                if (flg == 5)
                {
                    vvlaue = 247;
                    // flg++;


                }

                if (flg == 6)
                {
                    vvlaue = 246;
                    timer6.Interval = 1000;
                    //flg++;

                }

                if (flg == 7)
                {
                    vvlaue = 250;
                    // flg++;

                }


                if (flg == 8)
                {
                    vvlaue = 250;
                    // flg++;

                }

                flg++;

                if (flg == 9)
                {
                    vvlaue1 = 250;
                    flg = 0;
                    ab++;

                }

            }
            else
            {
                if (flg== 0)
                {
                    vvlaue= 250;
                    // flg++;

                }

                if (flg == 1)
                {
                    vvlaue = 253;
                    //flg++;

                }

                if (flg == 2)
                {
                    vvlaue = 250;
                    // flg++;

                }

                if (flg == 3)
                {
                    vvlaue = 247;
                    timer6.Interval = 200;
                    // flg++;

                }


                if (flg == 4)
                {
                    vvlaue = 266;
                    timer6.Interval = 500;
                    // flg++;

                }
                if (flg == 5)
                {
                    vvlaue = 245;
                    // flg++;


                }

                if (flg == 6)
                {
                    vvlaue = 250;
                    timer6.Interval = 1000;
                    //flg++;

                }

                if (flg == 7)
                {
                    vvlaue = 255;
                    // flg++;

                }


                if (flg == 8)
                {
                    vvlaue = 250;
                    // flg++;

                }

                flg++;

                if (flg == 9)
                {
                    vvlaue = 250;
                    flg = 0;

                }
                ab++;
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (ab == 45)
            {
                if (flg == 0)
                {
                    vvlaue = 250;
                    // flg++;

                }

                if (flg == 1)
                {
                    vvlaue = 260;
                    //flg++;
                    timer6.Interval = 200;
                }

                if (flg == 2)
                {
                    vvlaue = 240;
                    // flg++;

                }

                if (flg == 3)
                {
                    vvlaue = 255;
                    timer6.Interval = 500;
                    // flg++;

                }


                if (flg == 4)
                {
                    vvlaue = 250;
                   
                    // flg++;

                }
                if (flg == 5)
                {
                    vvlaue = 247;
                    // flg++;


                }

                if (flg == 6)
                {
                    vvlaue = 240;
                    timer6.Interval = 1000;
                    //flg++;

                }

                if (flg == 7)
                {
                    vvlaue = 250;
                    // flg++;

                }


                if (flg == 8)
                {
                    vvlaue = 250;
                    // flg++;

                }

                flg++;

                if (flg == 9)
                {
                    vvlaue1 = 250;
                    flg = 0;
                    ab++;

                }

            }
            else
            {
                if (flg == 0)
                {
                    vvlaue = 250;
                    // flg++;

                }

                if (flg == 1)
                {
                    vvlaue = 253;
                    //flg++;

                }

                if (flg == 2)
                {
                    vvlaue = 250;
                    // flg++;

                }

                if (flg == 3)
                {
                    vvlaue = 247;
                    timer6.Interval = 200;
                    // flg++;

                }


                if (flg == 4)
                {
                    vvlaue = 266;
                    timer6.Interval = 500;
                    // flg++;

                }
                if (flg == 5)
                {
                    vvlaue = 245;
                    // flg++;


                }

                if (flg == 6)
                {
                    vvlaue = 250;
                    timer6.Interval = 1000;
                    //flg++;

                }

                if (flg == 7)
                {
                    vvlaue = 255;
                    // flg++;

                }


                if (flg == 8)
                {
                    vvlaue = 250;
                    // flg++;

                }

                flg++;

                if (flg == 9)
                {
                    vvlaue = 250;
                    flg = 0;

                }
                ab++;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex==2)
            {
                string [] arg = {"as","as"};
                ECGViewer ld = new ECGViewer(arg);
                //  ld.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               // ld.TopLevel = false;
               // ld.Dock = DockStyle.Fill;
               // panel2.Controls.Clear();
              //  panel2.Controls.Add(ld);
                ld.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("History Tab Available on Mobile View");
        }
    }
}
