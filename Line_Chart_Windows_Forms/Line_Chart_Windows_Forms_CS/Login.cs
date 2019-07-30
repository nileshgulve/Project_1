using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;

namespace ECG
{
    public partial class Login : Form
    {
       public static string username = "";
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=64.71.180.27;Persist Security Info=True;User ID=opass_123;Password=pass_123");

            SqlDataAdapter da = new SqlDataAdapter("select PersonName from RentasetRegistration where Mobile='" + textBox1.Text.Trim() + "' and Password='" + textBox2.Text.Trim() + "'  ", con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                ECG.Program.loginflg = 1;
                username = ds.Tables[0].Rows[0][0].ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalide User name or Password");
            }
        
        }
    }
}
