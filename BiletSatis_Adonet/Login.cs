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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=DB_BiletSatis;Integrated Security=True");

        private void btnGiris_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("select KullaniciAdi,YetkiID from TblKullanici where KullaniciAdi=@p1 and sifre=@p2", connection);
            sqlCommand.Parameters.AddWithValue("@p1", txtKullanici.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtSifre.Text);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.Read())
            {
                if (sqlDataReader[1].ToString() == "1" || sqlDataReader[1].ToString() == "2")
                {

                    Navigation navigation = new Navigation();
                    navigation.KullaniciAdi = sqlDataReader[0].ToString();
                    this.Hide();
                    navigation.ShowDialog();
                    //this.Close();
                }
                else if (sqlDataReader[1].ToString() == "3")
                {
                    Navigation2 navigation2 = new Navigation2();
                    navigation2.kullaniciAdi = sqlDataReader[0].ToString();
                    this.Hide();
                    navigation2.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("Yetkiniz Yok Yada Hatalı Giriş Yaptınız.");

            }
            connection.Close();

        }

        

        private void txtKullanici_TextChanged(object sender, EventArgs e)
        {
            txtKullanici.Text = txtKullanici.Text.ToUpper();
            txtKullanici.SelectionStart = txtKullanici.Text.Length;
        }
    }
}
