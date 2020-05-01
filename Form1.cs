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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

       


        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;



        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-EJFO9BT;Initial Catalog=xxx;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM bilgi where kadi='" + kadi.Text + "' AND sifre='" + pass.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Form2 form = new Form2();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            pass.PasswordChar = '*';
        }
    }
}