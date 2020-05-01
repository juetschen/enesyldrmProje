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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EJFO9BT;Initial Catalog=xxx;Integrated Security=True");


        void göster()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * From müsteri ", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {
          
            con.Open();
            string query = "DELETE FROM müsteri where id ='" + sil.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();                                  
            con.Close();
            MessageBox.Show("Kayıt Başarılı Bir Şekilde Silindi.");
            göster();
        }

        private void dataGridView1_MouseDoubleClick(object sender, EventArgs e)
        {
           sil.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            göster();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

 

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE müsteri SET Ad='" + t1.Text + "',Soyad='" + t2.Text + "',Adres='" + t3.Text + "',Telefon='" + t4.Text + "',Email='" + t5.Text + "',Oda='" + c1.Text + "',Kat='" + t6.Text + "',YatakSayisi='" + t7.Text + "',BanyoSayisi='" + t8.Text + "',Cephe='" + t9.Text + "',GirisTarihi='" + d1.Text + "',CikisTarihi'" + d2.Text + "',Odeme_türü='" + c2.Text + "',Tutar='" + t10.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
        }

       private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
       {
       

          t1.Text = dataGridView1.Rows[e.RowIndex].Cells["Ad"].Value.ToString();
          t2.Text = dataGridView1.Rows[e.RowIndex].Cells["Soyad"].Value.ToString();
          t3.Text = dataGridView1.Rows[e.RowIndex].Cells["Adres"].Value.ToString();
          t4.Text = dataGridView1.Rows[e.RowIndex].Cells["Telefon"].Value.ToString();
          t5.Text = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
          c1.Text  = dataGridView1.Rows[e.RowIndex].Cells["Oda"].Value.ToString();
          t6.Text  = dataGridView1.Rows[e.RowIndex].Cells["Kat"].Value.ToString();
          t7.Text  = dataGridView1.Rows[e.RowIndex].Cells["YatakSayisi"].Value.ToString();
          t8.Text  = dataGridView1.Rows[e.RowIndex].Cells["BanyoSayisi"].Value.ToString();
          t9.Text  = dataGridView1.Rows[e.RowIndex].Cells["Cephe"].Value.ToString();
          d1.Text  = dataGridView1.Rows[e.RowIndex].Cells["Giristarihi"].Value.ToString();
          d2.Text  = dataGridView1.Rows[e.RowIndex].Cells["CikisTarihi"].Value.ToString();
          c2.Text  = dataGridView1.Rows[e.RowIndex].Cells["Odeme_türü"].Value.ToString();
          t10.Text  = dataGridView1.Rows[e.RowIndex].Cells["Tutar"].Value.ToString();

       }
    }
}
