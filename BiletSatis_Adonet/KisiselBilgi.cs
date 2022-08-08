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
        public KisiselBilgi()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=DB_BiletSatis;Integrated Security=True");
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TblMusteri (Ad, Soyad, Cinsiyet, TC, Telefon) Values (@p1, @p2, @p3, @p4, @p5)", connection);
            command.Parameters.AddWithValue("@p1", txtAdi.Text);
            command.Parameters.AddWithValue("@p2", txtSoyadi.Text);
            command.Parameters.AddWithValue("@p3", txtCinsiyet.Text);
            command.Parameters.AddWithValue("@p4", txtTCNo.Text);
            command.Parameters.AddWithValue("@p5", TxtTelefon.Text);

            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Bilgileriniz başarılı bir şekilde eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
