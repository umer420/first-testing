using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace myproject
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            string select = "SELECT * FROM login WHERE username = @USER AND password = @PASS";
            SqlCommand cmd1 = new SqlCommand(select, con);
            cmd1.Parameters.AddWithValue("@USER", txtuser.Text);
            cmd1.Parameters.AddWithValue("@PASS", txtpas.Text);
            con.Open();
            SqlDataReader a = cmd1.ExecuteReader();
            if (a.HasRows == true)
            {
                MessageBox.Show("Login Succeded");
                HOME f = new HOME();
                f.Show();


            }
            else { MessageBox.Show("Login Failed"); }
            txtuser.Text = "";
            txtpas.Text = "";
            
        }
    }
}
