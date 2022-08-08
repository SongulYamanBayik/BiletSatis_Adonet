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
    public partial class Cinsiyet : Form
    {
        public Cinsiyet()
        {
            InitializeComponent();
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            KisiselBilgi kisiselBilgi = new KisiselBilgi();
            kisiselBilgi.Show();
        }

        public void cmbCinsiyet_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
