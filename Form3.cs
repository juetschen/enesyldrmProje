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
using System.Data.SqlTypes;
using System.Data.Sql;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EJFO9BT;Initial Catalog=xxx;Integrated Security=True");




        private void button1_Click(object sender, EventArgs e)
        {
            
            string a = t1.Text;
            string b = t2.Text;
            string c = t3.Text;
            string d = t4.Text;
            string f = t5.Text;
            string x = c1.Text;
            string g = t6.Text;
            string h = t7.Text;
            string i = t8.Text;
            string j = t9.Text;
            string k = d1.Text;
            string l = d2.Text;
            string y = c2.Text;
            string z = t10.Text;

            Class cls = new Class();
            cls.k_ekle(a,b,c,d,f,x,g,h,i,j,k,l,y,z);

            System.Windows.Forms.MessageBox.Show("Müşteri Kaydı Başarılı Bir Şekilde Alındı "+x+" No'lu Oda : "+a+" "+b+" İsimli Kişiye Verilmiştir." ,"Bilgi" ,System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);

            
        }

   


        private void c1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
            if ((char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }


        private void c2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
            if ((char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 geridon = new Form2();
            this.Hide();
            geridon.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 verigöster = new Form4();
            this.Hide();
            verigöster.Show();
        }
    }
}
