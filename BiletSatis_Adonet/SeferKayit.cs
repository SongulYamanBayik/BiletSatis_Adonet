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
    public partial class SeferKayit : Form
    {
        public SeferKayit()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=DB_BiletSatis;Integrated Security=True");

        void Listele()
        {
            SqlCommand sqlCommand = new SqlCommand("select * from TblSeferler", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dtgSeferler.DataSource = dataTable;
        }
        private void SeferKayit_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("select * from TblGuzergah", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            cmbGuzergah.DisplayMember = "GuzergahAdi";
            cmbGuzergah.ValueMember = "ID";
            cmbGuzergah.DataSource = dataTable;


            SqlCommand sqlCommand1 = new SqlCommand("select * from TblOtobus", connection);
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(sqlCommand1);
            DataTable dataTable1 = new DataTable();
            sqlDataAdapter1.Fill(dataTable1);
            cmbOtobus.DisplayMember = "Plaka";
            cmbOtobus.ValueMember = "ID";
            cmbOtobus.DataSource = dataTable1;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TblSeferler (GuzergahID, OtobusID, KalkisTarih, KalkisSaat, VarisTarih, VarisSaat, Ucret) Values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)", connection);
            command.Parameters.AddWithValue("@p1", cmbGuzergah.SelectedValue);
            command.Parameters.AddWithValue("@p2", cmbOtobus.SelectedValue);
            command.Parameters.AddWithValue("@p3", dateTimePicker1.Value);
            command.Parameters.AddWithValue("@p4", txtKalkisSaat.Text);
            command.Parameters.AddWithValue("@p5", dateTimePicker2.Value);
            command.Parameters.AddWithValue("@p6", txtVarisSaat.Text);
            command.Parameters.AddWithValue("@p7", decimal.Parse(txtUcret.Text));

            command.ExecuteNonQuery();
            connection.Close();
           
            MessageBox.Show("Kategori başarılı bir şekilde eklendi");
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete from TblSeferler where ID=@p1", connection);
            command.Parameters.AddWithValue("@p1", txtID.Text);
            command.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("Kategori silindi");
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update TblSeferler set GuzergahID=@p1, OtobusID=@p2, KalkisTarih=@p3, KalkisSaat=@p4, VarisTarih=@p5, VarisSaat=@p6, Ucret=@p7 where ID=@p8", connection);
            command.Parameters.AddWithValue("@p1", cmbGuzergah.SelectedValue);
            command.Parameters.AddWithValue("@p2", cmbOtobus.SelectedValue);
            command.Parameters.AddWithValue("@p3", dateTimePicker1.Value);
            command.Parameters.AddWithValue("@p4", txtKalkisSaat.Text);
            command.Parameters.AddWithValue("@p5", dateTimePicker2.Value);
            command.Parameters.AddWithValue("@p6", txtVarisSaat.Text);
            command.Parameters.AddWithValue("@p7", decimal.Parse(txtUcret.Text));
            command.Parameters.AddWithValue("@p8", txtID.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kategori başarılı bir şekilde güncellendi");
            Listele();
        }

        private void dtgSeferler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dtgSeferler.SelectedCells[0].RowIndex;

            txtID.Text = dtgSeferler.Rows[secilen].Cells[0].Value.ToString();
            cmbGuzergah.SelectedValue = dtgSeferler.Rows[secilen].Cells[1].Value.ToString();
            cmbOtobus.SelectedValue = dtgSeferler.Rows[secilen].Cells[2].Value.ToString();
            dateTimePicker1.Value = DateTime.Parse(dtgSeferler.Rows[secilen].Cells[3].Value.ToString());
            txtKalkisSaat.Text = dtgSeferler.Rows[secilen].Cells[4].Value.ToString();
            dateTimePicker2.Value = DateTime.Parse(dtgSeferler.Rows[secilen].Cells[5].Value.ToString());
            txtVarisSaat.Text = dtgSeferler.Rows[secilen].Cells[6].Value.ToString();
            txtUcret.Text = dtgSeferler.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
