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
    public partial class KisiselBilgi : Form
    {
        public static int musteriID = 0;
        public KisiselBilgi()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=DB_BiletSatis;Integrated Security=True");
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // burada öncelik bu müşteri daha önce kayıt edilmişmi diye bakılması lazım ??
            // müşteri bilgileri daha önce müşteri tablosuna eklendiyse yeni kayıt eklenmemeli ID üzerinden  işlen yapılmalı. kayıt yok ise eklenmeli.
          
            if (!MusteriSorgula(txtTCNo.Text))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("insert into TblMusteri (Ad, Soyad, Cinsiyet, TC, Telefon) Values (@p1, @p2, @p3, @p4, @p5)", connection);
                command.Parameters.AddWithValue("@p1", txtAdi.Text);
                command.Parameters.AddWithValue("@p2", txtSoyadi.Text);
                command.Parameters.AddWithValue("@p3", cmbCinsiyet.Text);
                command.Parameters.AddWithValue("@p4", txtTCNo.Text);
                command.Parameters.AddWithValue("@p5", TxtTelefon.Text);

                command.ExecuteNonQuery();
                connection.Close();
                MusteriSorgula(txtTCNo.Text);

            }
            connection.Open();
            SqlCommand command2 = new SqlCommand("insert into TblSatilanBilet (SeferID, KoltukID,MusteriID) Values (@p1, @p2, @p3)", connection);
            command2.Parameters.AddWithValue("@p1", SeferSorgula.seferID);
            command2.Parameters.AddWithValue("@p2", Convert.ToInt32( txtKoltukNo.Text));
            command2.Parameters.AddWithValue("@p3", musteriID);

            command2.ExecuteNonQuery();
            connection.Close();



            MessageBox.Show("Bilgileriniz başarılı bir şekilde eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);            
            this.Close();
        }

        private void KisiselBilgi_Load(object sender, EventArgs e)
        {
           
        }

        private bool MusteriSorgula(string tc)
        {
            connection.Open();

            bool sonuc = false;
            // kayıt edilen müsterinin tc'den ID bilgisini alıyoruz.
            SqlCommand command1 = new SqlCommand("select * from TblMusteri where TC= @s1", connection);
            command1.Parameters.AddWithValue("@s1", txtTCNo.Text);

            SqlDataReader sqlDataReader = command1.ExecuteReader();

            if (sqlDataReader.Read())
            {
                musteriID = Convert.ToInt32(sqlDataReader[0]);
                MessageBox.Show(musteriID.ToString());
                sonuc = true;
            }

            connection.Close();
            return sonuc;
        }

        private void cmbCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
            Otobus.secilenCinsiyet = cmbCinsiyet.Text;

            if (Otobus.secilenCinsiyet == "Kadın") { 
               
            }
        }
    }
}
