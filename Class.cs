using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Class
    {


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EJFO9BT;Initial Catalog=xxx;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        public void k_ekle(string adi, string soyadi, string adres, string telefon, string email, string oda, string kat, string yataksayisi, string banyosayisi, string cephe, string giristarihi, string cikistarihi, string odemetürü, string tutar)
        {
            con.Open();
            string e = "INSERT INTO müsteri (Ad,Soyad,Adres,Telefon,Email,Oda,Kat,YatakSayisi,BanyoSayisi,Cephe,GirisTarihi,CikisTarihi,Odeme_türü,Tutar) VALUES ('" + adi + "','" + soyadi + "','" + adres + "','" + telefon + "','" + email + "','" + oda + "','" + kat + "','" + yataksayisi + "','" + banyosayisi + "','" + cephe + "','" + giristarihi + "','" + cikistarihi + "','" + odemetürü + "','" + tutar + "' )";
            SqlDataAdapter sda = new SqlDataAdapter(e, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            sda.Dispose();
        }


        public void k_güncelle(string adi, string soyadi, string adres, string telefon, string email, string oda, string kat, string yataksayisi, string banyosayisi, string cephe, string giristarihi, string cikistarihi, string odemetürü, string tutar)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-EJFO9BT;Initial Catalog=xxx;Integrated Security=True");

            con.Open();

            SqlCommand guncelle = new SqlCommand( "UPDATE müsteri SET Ad='" + adi + "',Soyad='" + soyadi + "',Adres='" + adres + "',Telefon='" + telefon + "',Email='" + email + "',Oda='" + oda + "',Kat='" + kat + "',YatakSayisi='" + yataksayisi + "',BanyoSayisi='" + banyosayisi + "',Cephe='" + cephe + "',GirisTarihi='" + giristarihi + "',CikisTarihi'" + cikistarihi + "',Odeme_türü='" + odemetürü + "',Tutar='" + tutar + "'");

           
       
            guncelle.Parameters.AddWithValue("@ adi", adi);
            guncelle.Parameters.AddWithValue("@ soyadi", soyadi);
            guncelle.Parameters.AddWithValue("@ telefon", telefon);
            guncelle.Parameters.AddWithValue("@ email", email);
            guncelle.Parameters.AddWithValue("@ oda", oda);
            guncelle.Parameters.AddWithValue("@ akat", kat);
            guncelle.Parameters.AddWithValue("@ yataksayisi", yataksayisi);
            guncelle.Parameters.AddWithValue("@ banyosayisi", banyosayisi);
            guncelle.Parameters.AddWithValue("@ cephe", cephe);
            guncelle.Parameters.AddWithValue("@ giristarihi", giristarihi);
            guncelle.Parameters.AddWithValue("@ cikistarihi", cikistarihi);
            guncelle.Parameters.AddWithValue("@ odemetürü", odemetürü);
            guncelle.Parameters.AddWithValue("@ tutar", tutar);
            guncelle.ExecuteNonQuery();
            con.Close();
        }

    }

}