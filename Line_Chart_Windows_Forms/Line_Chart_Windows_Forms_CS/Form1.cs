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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SerialPort port;
        Graphics graphics =null;
        Bitmap bt;
        Graphics gr;
        int p1 = 0;
        int p2 = 0;
        int p5 = 0;
        int p6 = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            bt = new Bitmap(Application.StartupPath + "\\ECG1.png");
            //Fetch the Statistical data from database.
            //string query = "SELECT ShipCity, COUNT(OrderId) [Total]";
            //query += " FROM Orders WHERE ShipCountry = 'Brazil'";
            //query += " GROUP BY ShipCity";
            //DataTable dt = GetData(query);

            ////Get the names of Cities.
            //string[] x = (from p in dt.AsEnumerable()
            //              orderby p.Field<string>("ShipCity") ascending
            //              select p.Field<string>("ShipCity")).ToArray();

            ////Get the Total of Orders for each City.
            //int[] y = (from p in dt.AsEnumerable()
            //           orderby p.Field<string>("ShipCity") ascending
            //           select p.Field<int>("Total")).ToArray();

            //Chart1.Series[0].LegendText = "Brazil Order Statistics";
            //Chart1.Series[0].ChartType = SeriesChartType.Line;
            //Chart1.Series[0].BorderWidth = 3;
            //Chart1.Series[0].IsValueShownAsLabel = true;
            //Chart1.Series[0].Points.DataBindXY(x, y);
        }

        //private static DataTable GetData(string query)
        //{
        //    string constr = @"Data Source=.\SQL2005;Initial Catalog=Northwind;User ID=sa;Password=pass@123";
        //    using (SqlConnection con = new SqlConnection(constr))
        //    {
        //        using (SqlDataAdapter sda = new SqlDataAdapter(query, con))
        //        {
        //            DataTable dt = new DataTable();
        //            sda.Fill(dt);
        //            return dt;
        //        }
        //    }
        //}

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
              


            //   gr = Graphics.FromImage(bt);
              

             //   string values1 = port.ReadLine().ToString();
                port.Open();
                String values = port.ReadLine().Trim();
                port.Close();
                p2 =int.Parse(values);
                Point p3 = new Point(p1, p2);
                Point p4 = new Point(20, 200);
              //  picgr.DrawLine(p, p3, p4);
                 p1 = p2;
                 p5 = p1;
                 p6 = p2;
                //  string[] data = values.Split('\r');
              //  richTextBox2.Text += values + "\n";
             //   string[] val = richTextBox2.Text.Split('\n');
               // for (int x = 0; x < val.Length-1; x++)
               // {
                    Chart1.Series[0].ChartType = SeriesChartType.Line;
                    Chart1.Series[0].BorderWidth = 1;
                   // Chart1.Series[0].IsValueShownAsLabel = true;
                    Chart1.Series[0].Points.AddY(double.Parse(values.ToString()));
                    //pictureBox1.Image = bt;
              //  }
                //textBox1.Text = data[1].Trim();
                //textBox2.Text = data[2].Trim();
                //textBox3.Text = data[3].Trim();
                //textBox4.Text = data[4].Trim();
                //textBox5.Text = data[5].Trim();
                //textBox6.Text = data[6].Trim();
                //textBox7.Text = data[7].Trim();
                //textBox8.Text = data[8].Trim();
                //textBox9.Text = data[9].Trim();



            }
            catch
            {
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            port = new SerialPort(toolStripComboBox1.Text.Trim(), 9600);
            port.Open();
            timer1.Enabled = true;
        }
        int vvlaue = 250;
        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {



                Random rnd = new Random();
                int values = rnd.Next(255, 265);
                p2 = values;
                Point p3 = new Point(p1, p2);
                Point p4 = new Point(20, 200);
           
                p1 = p2;
                p5 = p1;
                p6 = p2;
             
               
                Chart1.Series[0].ChartType = SeriesChartType.Line;
                Chart1.Series[0].BorderWidth = 1;
              
                Chart1.Series[0].Points.AddY(double.Parse(vvlaue.ToString()));
           


            }
            catch
            {
            }
        }
        int flg = 0;
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
                flg=0;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer3.Enabled = true;
        }

        int ab = 0;
        private void timer4_Tick(object sender, EventArgs e)
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
                    vvlaue = 260;
                    timer4.Interval = 200;
                    // flg++;

                }


                if (flg == 4)
                {
                    vvlaue = 255;
                    timer4.Interval = 500;
                    // flg++;

                }
                if (flg == 5)
                {
                    vvlaue = 257;
                    // flg++;


                }

                if (flg == 6)
                {
                    vvlaue = 257;
                    timer4.Interval = 1000;
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
                    timer4.Interval = 200;
                    // flg++;

                }


                if (flg == 4)
                {
                    vvlaue = 266;
                    timer4.Interval = 500;
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
                    timer4.Interval = 1000;
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

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer4.Enabled = true;
        }
    }
}
