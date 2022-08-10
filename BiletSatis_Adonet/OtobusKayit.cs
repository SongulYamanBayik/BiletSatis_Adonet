using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiletSatis_Adonet
{
    public partial class OtobusKayit : Form
    {
        public OtobusKayit()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=DB_BiletSatis;Integrated Security=True");

        void listele()
        {
            
            SqlCommand sqlCommand = new SqlCommand("select * from TblOtobus", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dtgOtobus.DataSource = dataTable;

            


        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into TblOtobus (Plaka, koltukSayi, Durum) values (@p1, @p2, @p3)", connection);
            sqlCommand.Parameters.AddWithValue ("@p1", txtPlaka.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtKoltuk.Text);
            if (rdbAktif.Checked==true)
            {
                sqlCommand.Parameters.AddWithValue("@p3", true);
            }
            if(rdbPasif.Checked==true)
            {
                sqlCommand.Parameters.AddWithValue("@p3", false);
            }
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Otobüs Kaydı Başarılı Şekilde Eklendi.");
            listele();

            connection.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("delete TblOtobus where ID=@p1", connection);
            sqlCommand.Parameters.AddWithValue("@p1", txtID.Text);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Otobüs Kaydı Silindi!");
            listele();

            connection.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("Update TblOtobus set Plaka=@p1, KoltukSayi=@p2, Durum=@p3 where ID=@p4", connection);
            sqlCommand.Parameters.AddWithValue("@p1", txtPlaka.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtKoltuk.Text);
            if (rdbAktif.Checked == true)
            {
                sqlCommand.Parameters.AddWithValue("@p3", true);
            }
            if (rdbPasif.Checked == true)
            {
                sqlCommand.Parameters.AddWithValue("@p3", false);
            }
            sqlCommand.Parameters.AddWithValue("@p4", txtID.Text);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Otobüs Kaydı Başarılı Şekilde Güncellendi.");
            listele();

            connection.Close();
        }
    }
}
