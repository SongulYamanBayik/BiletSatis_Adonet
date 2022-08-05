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

namespace BiletSatis_Adonet
{
    public partial class frmPersonel : Form
    {
        public frmPersonel()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=DB_BiletSatis;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
           
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from TblGorev", sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            cmbGorev.DisplayMember = "GorevAd";
            cmbGorev.ValueMember = "ID";
            cmbGorev.DataSource = dataTable;
            sqlConnection.Close();


            sqlConnection.Open();
            SqlCommand sqlCommand1 = new SqlCommand("select * from TblSehirler", sqlConnection);
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(sqlCommand1);
            DataTable dataTable1 = new DataTable();
            sqlDataAdapter1.Fill(dataTable1);
            cmbSehir.DisplayMember = "SehirAd";
            cmbSehir.ValueMember = "ID";
            cmbSehir.DataSource = dataTable1;
            sqlConnection.Close();
        }

        void List()
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from TblPersonel", sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dtgPersonel.DataSource = dataTable;
            sqlConnection.Close();
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            
            List();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into TblPersonel(PersonelAd,PersonelSoyad,TCNo,Cinsiyet,DogumTarihi,Telefon,GorevID,SehirID) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1", txtPersonelAd.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtPersonelSoyad.Text);
            sqlCommand.Parameters.AddWithValue("@p3", txtPersonelTC.Text);
            sqlCommand.Parameters.AddWithValue("@p4", txtPersonelCinsiyet.Text);
            sqlCommand.Parameters.AddWithValue("@p5", dateTimePicker1.Value);
            sqlCommand.Parameters.AddWithValue("@p6", txtTelefon.Text);
            sqlCommand.Parameters.AddWithValue("@p7", cmbGorev.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@p8", cmbSehir.SelectedValue);
            sqlCommand.ExecuteNonQuery();
            
            sqlConnection.Close();
            MessageBox.Show("Personel başarılı şekilde eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
        }

        private void cmbGorev_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("update TblPersonel set PersonelAd=@p1,PersonelSoyad=@p2,TCNo=@p3,Cinsiyet=@p4,DogumTarihi=@p5,Telefon=@p6,GorevID=@p7,SehirID=@p8 where ID=@p9", sqlConnection);
            command.Parameters.AddWithValue("@p1", txtPersonelAd.Text);
            command.Parameters.AddWithValue("@p2", txtPersonelSoyad.Text);
            command.Parameters.AddWithValue("@p3", txtPersonelTC.Text);
            command.Parameters.AddWithValue("@p4", txtPersonelCinsiyet.Text);
            command.Parameters.AddWithValue("@p5", dateTimePicker1.Value);
            command.Parameters.AddWithValue("@p6", txtTelefon.Text);
            command.Parameters.AddWithValue("@p7", cmbGorev.SelectedValue);
            command.Parameters.AddWithValue("@p8", cmbSehir.SelectedValue);
            command.Parameters.AddWithValue("@p9", txtPersonelID.Text);

            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Personel başarılı bir şekilde güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("delete from TblPersonel where ID=@p1", sqlConnection);
            command.Parameters.AddWithValue("@p1", txtPersonelID.Text);
            command.ExecuteNonQuery();

            sqlConnection.Close();
            MessageBox.Show("Personel silindi","Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            List();
        }
    }
}
