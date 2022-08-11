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
    public partial class SeferSorgula : Form
    {
        public SeferSorgula()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=DB_BiletSatis;Integrated Security=True");
        private void SeferSorgula_Load(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("select * from TblSehirler", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            comboBox1.DisplayMember = "SehirAd";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = dataTable;
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a= comboBox1.Text + "-" + comboBox2.Text;
            DateTime now = Convert.ToDateTime(DateTime.Now.ToString("dd MM yyyy"));
            DateTime selectedDate = Convert.ToDateTime(dateTimePicker1.Value.ToString("dd MM yyyy"));
            if (now <= selectedDate)
            {
                SqlCommand sqlCommand = new SqlCommand("select g.GuzergahAdi, o.Plaka, s.KalkisTarih, s.KalkisSaat, s.VarisTarih, s.VarisSaat, s.Ucret from TblSeferler as s inner join TblGuzergah as g on s.GuzergahID=g.ID inner join TblOtobus as o on s.OtobusID=o.ID where  KalkisTarih >= @p2 and [GuzergahID]= (select ID from TblGuzergah where GuzergahAdi like @p1)", connection);
                sqlCommand.Parameters.AddWithValue("@p1", a);
                sqlCommand.Parameters.AddWithValue("@p2", now);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Eski Tarihli Sefer Sorgusu Yapılamaz!");
            }
            
            
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var secilen = comboBox1.Text;
            SqlCommand command1 = new SqlCommand("select * from TblSehirler where SehirAd!=@p1", connection);
            command1.Parameters.AddWithValue("@p1", secilen);
            SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
            DataTable dataTable1 = new DataTable();
            adapter1.Fill(dataTable1);
            comboBox2.DisplayMember = "SehirAd";
            comboBox2.ValueMember = "ID";
            comboBox2.DataSource = dataTable1;
            
        }
    }
}
