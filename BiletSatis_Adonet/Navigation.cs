using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiletSatis_Adonet
{
    public partial class Navigation : Form
    {
        public Navigation()
        {
            InitializeComponent();
        }
        public string KullaniciAdi;
        private void btnPersonel_Click(object sender, EventArgs e)
        {
            frmPersonel frmPersonel = new frmPersonel();
            frmPersonel.ShowDialog();
        }

        private void btnGuzergah_Click(object sender, EventArgs e)
        {
            Guzergah guzergah = new Guzergah();
            guzergah.ShowDialog();
        }

        private void Navigation_Load(object sender, EventArgs e)
        {
            label1.Text = KullaniciAdi;
        }

        private void btnSefer_Click(object sender, EventArgs e)
        {
            SeferKayit seferKayit = new SeferKayit();
            seferKayit.ShowDialog();
        }

        private void btnOtobuss_Click(object sender, EventArgs e)
        {
            OtobusKayit otobusKayit = new OtobusKayit();
            otobusKayit.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
