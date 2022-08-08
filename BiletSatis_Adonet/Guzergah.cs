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
    public partial class Guzergah : Form
    {
        public Guzergah()
        {
            InitializeComponent();
        }
        int sayac = 1;
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=DB_BiletSatis;Integrated Security=True");

        private DataTable cmbSehirDataSource()
        {
            SqlCommand sqlCommand = new SqlCommand("select * from TblSehirler", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            return dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int top = 100;
            string cboAd = "cboAraDurak" + sayac.ToString();
            string lblText = "Ara Durak" + sayac.ToString() + ":";
            ComboBox cboAraDurak = new ComboBox();
            Label lbl = new Label();


            cboAraDurak.Name = cboAd;
            lbl.Text = lblText;
            cboAraDurak.Width = 124;
            cboAraDurak.Left = 120;
            lbl.Left = 50;
            sayac++;

            if (this.Controls.OfType<ComboBox>().Count() > 0)
                top = this.Controls.OfType<ComboBox>().Last().Top + 40;

            cboAraDurak.Top = top;
            lbl.Top = top + 5;

            DataTable dataTable = cmbSehirDataSource();
            cboAraDurak.DisplayMember = "SehirAd";
            cboAraDurak.ValueMember = "ID";
            cboAraDurak.DataSource = dataTable;
            //cboAraDurak.SelectedValueChanged += CboAraDurak_SelectedValueChanged;

            this.Controls.Add(cboAraDurak);
            this.Controls.Add(lbl);

        }


        private void Guzergah_Load(object sender, EventArgs e)
        {
            DataTable dataTable = cmbSehirDataSource();
            cmbBaslangicSehir.DisplayMember = "SehirAd";
            cmbBaslangicSehir.ValueMember = "ID";
            cmbBaslangicSehir.DataSource = dataTable;

            DataTable dataTable1 = cmbSehirDataSource();
            cmbBitisSehir.DisplayMember = "SehirAd";
            cmbBitisSehir.ValueMember = "ID";
            cmbBitisSehir.DataSource = dataTable1;
        }



        private void btnEkle_Click(object sender, EventArgs e)
        {

            string guzergah = txtGuzergah.Text;
            int cmbCount = this.Controls.OfType<ComboBox>().Count() - 2;
            if (guzergah.Length != 0)
            {
                var cmbBaslangıcSehirID = cmbBaslangicSehir.SelectedValue;
                var cmbBitisSehirID = cmbBitisSehir.SelectedValue;
                // başlangıç şehir ile bitiş şehir aynı olamaz.
                // araduraklar başlangıç şehir ve bitiş şehir ile aynı olamaz.
                //( bu kontolü combobox change eventinda kontrol edebilir miyiz ? )


                var a = this.Controls.OfType<ComboBox>();

                List<object> Items = new List<object>();
               
                var comboBoxes = this.Controls
                      .OfType<ComboBox>()
                      .Where(x => x.Name.StartsWith("cboAraDurak"));

                foreach (var cmbBox in comboBoxes)
                {
                    MessageBox.Show(cmbBox.SelectedValue.ToString());
                    Items.Add(cmbBox.SelectedValue);                   
                }
               

            }
            else
            {
                MessageBox.Show("Güzergah Adı alanı boş bırakılamaz!");

            }

        }

      
    }
}
