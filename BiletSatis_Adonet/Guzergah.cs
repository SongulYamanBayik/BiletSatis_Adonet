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
        private List<string> araduraklariListele()
        {

            List<string> Items = new List<string>();

            var comboBoxes = this.Controls
                  .OfType<ComboBox>()
                  .Where(x => x.Name.StartsWith("cboAraDurak"));

            foreach (var cmbBox in comboBoxes)
            {
                Items.Add(cmbBox.Text);
            }

            return Items;
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
                var baslangıcSehir = cmbBaslangicSehir.Text;
                var bitisSehir = cmbBitisSehir.Text;

                // başlangıç şehir ile bitiş şehir aynı olamaz.
                // araduraklar başlangıç şehir ve bitiş şehir ile aynı olamaz.
                //( bu kontolü combobox change eventinda kontrol edebilir miyiz ? )
                //    List<string> araDuraklar = araduraklariListele();

                //    SeferSorgula ucretKayit = new SeferSorgula();
                //    Label lbl1 = new Label();
                //    lbl1.Left = 50;
                //    lbl1.Top = 50;


                //    lbl1.Text = baslangıcSehir + " - " + bitisSehir + " arası ";
                //    lbl1.AutoSize = true;

                //    Label lbl2 = new Label();
                //    lbl2.Left = 250;
                //    lbl2.Top = 30;


                //    lbl2.Text = "Ücret";
                //    lbl2.AutoSize = true;

                //    Label lbl3 = new Label();
                //    lbl3.Left = 370;
                //    lbl3.Top = 30;


                //    lbl3.Text = "Tarih";
                //    lbl3.AutoSize = true;

                //    Label lbl4 = new Label();
                //    lbl4.Left = 600;
                //    lbl4.Top = 30;


                //    lbl4.Text = "saat";
                //    lbl4.AutoSize = true;

                //    TextBox txt1 = new TextBox();
                //    txt1.Name = "txtbasBitUcret";
                //    txt1.Left = 250;
                //    txt1.Top = 50;


                //    DateTimePicker dateTimePicker1 = new DateTimePicker();
                //    dateTimePicker1.Name = "dtpbasBitTarih";
                //    dateTimePicker1.Left = 370;
                //    dateTimePicker1.Top = 50;

                //    TextBox txt2 = new TextBox();
                //    txt2.Name = "txtbasBitSaat";
                //    txt2.Left = 600;
                //    txt2.Top = 50;

                //    ucretKayit.Controls.Add(lbl1);
                //    ucretKayit.Controls.Add(lbl2);
                //    ucretKayit.Controls.Add(lbl3);
                //    ucretKayit.Controls.Add(lbl4);

                //    ucretKayit.Controls.Add(txt1);
                //    ucretKayit.Controls.Add(dateTimePicker1);
                //    ucretKayit.Controls.Add(txt2);







                //    this.Hide();
                //    ucretKayit.ShowDialog();



                //}
                //else
                //{
                //    MessageBox.Show("Güzergah Adı alanı boş bırakılamaz!");

                //}

            }


        }
    }
}
