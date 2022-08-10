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
    public partial class Otobus : Form
    {
        public Otobus()
        {
            InitializeComponent();
        }
        static public string secilenCinsiyet = "";

        public void btn1_Click(object sender, EventArgs e)
        {
            Cinsiyet Cinsiyet = new Cinsiyet();
            Cinsiyet.ShowDialog();
            if (secilenCinsiyet=="Kadın")
            {
                btn1.BackColor = Color.Pink;
            }
            else
            {
                btn1.BackColor = Color.Blue;
            }
            KisiselBilgi kisiselBilgi = new KisiselBilgi();
            kisiselBilgi.ShowDialog();
        }

        private void Otobus_Load(object sender, EventArgs e)
        {

        }
    }
}
