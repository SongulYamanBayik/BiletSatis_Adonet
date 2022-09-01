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
    public partial class Otobus : Form
    {
        public Otobus()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=DB_BiletSatis;Integrated Security=True");
        static public string secilenCinsiyet = "";


        private void Otobus_Load(object sender, EventArgs e)
        {
            otobusDuzen();
        }

        private void otobusDuzen()
        {
            int say = 0;
            //panel1.Controls.Clear();
            int olcu = 38;
            for (int i = 1; i <= txtDuzen.Lines.Count(); i++)// textbox satırları arasında
            {
                for (int j = 1; j <= txtDuzen.Lines[i - 1].Count(); j++) // bir satırdaki karakterler arasında
                {
                    string satir = txtDuzen.Lines[i - 1]; // bir satırı aldık
                    if (satir[j - 1] == '*') // satırdaki j index'ine denk gelen ifade * ise
                    {
                        Button nesne = new Button();
                        nesne.Text = (++say).ToString();
                        nesne.Name = "buton_" + nesne.Text;
                        string koltukCinsiyet = koltukCinsiyetSorgu(SeferSorgula.seferID, nesne.Text);
                        if (koltukCinsiyet == "Kadın")
                        {
                            nesne.BackColor =Color.Pink;
                            nesne.Enabled = false;

                        }
                        else if (koltukCinsiyet=="Erkek")
                        {
                            nesne.BackColor = Color.Blue;
                            nesne.Enabled = false;

                        }
                        else
                        {
                            nesne.BackColor = Color.Gray;
                        }
                        nesne.Width = nesne.Height = 40;
                        nesne.Left = olcu * i;// butonun nerede duracağı
                        nesne.Top = olcu * j; // butonun nerede duracağı
                        this.Controls.Add(nesne);
                        nesne.Click += ButtonClick;
                    }
                }
            }
        }
        private string koltukCinsiyetSorgu(int seferID, string koltukNo)
        {
            string cinsiyet = "";
            connection.Close();
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("select MusteriID from TblSatilanBilet where SeferID=@p1 and KoltukID=@p2", connection);
            sqlCommand.Parameters.AddWithValue("@p1", seferID);
            sqlCommand.Parameters.AddWithValue("@p2", koltukNo);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                var musteriID = sqlDataReader[0];
            connection.Close();

                connection.Open();
                SqlCommand sqlCommand1 = new SqlCommand("select Cinsiyet from TblMusteri where ID=@p1", connection);
                sqlCommand1.Parameters.AddWithValue("@p1", musteriID);
                SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
                if (sqlDataReader1.Read())
                {
                    cinsiyet = sqlDataReader1[0].ToString();
                }
                connection.Close();
            }
            return cinsiyet;
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            KisiselBilgi kisiselBilgi = new KisiselBilgi();
            kisiselBilgi.txtKoltukNo.Text = btn.Name.Split('_')[1];
            kisiselBilgi.ShowDialog();
            this.Close();
        }
    }
}
