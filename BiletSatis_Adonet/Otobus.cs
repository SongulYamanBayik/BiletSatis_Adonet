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
       
        Cinsiyet Cinsiyet = new Cinsiyet();
        public void btn1_Click(object sender, EventArgs e)
        {
            
            Cinsiyet.Show();
        }
    }
}
