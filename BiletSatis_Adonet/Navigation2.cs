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
    public partial class Navigation2 : Form
    {
        public Navigation2()
        {
            InitializeComponent();
        }
        public string kullaniciAdi;
        private void Navigation2_Load(object sender, EventArgs e)
        {
            label1.Text = kullaniciAdi;
        }

        private void btnBilet_Click(object sender, EventArgs e)
        {
            SeferSorgula seferSorgula = new SeferSorgula();
            seferSorgula.ShowDialog();
        }
    }
}
