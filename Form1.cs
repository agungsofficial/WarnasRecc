using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarnasRecommender
{
    public partial class Homeform : Form
    {
        
        public Homeform()
        {
            InitializeComponent();
        }
        
        private void btnFinishValuing_Click(object sender, EventArgs e)
        {
            
            Weightval wv1 = new Weightval();
            wv1.Kualitasweight= Convert.ToInt32(Math.Round(nUDKualitas.Value, 0));
            wv1.hargaweight = Convert.ToInt32(Math.Round(nUDHarga.Value, 0));
            wv1.pelayananweight = Convert.ToInt32(Math.Round(nUDPelayanan.Value, 0));
            wv1.suasanaweight = Convert.ToInt32(Math.Round(nUDSuasana.Value, 0));
            wv1.jarakweight = Convert.ToInt32(Math.Round(nUDJarak.Value, 0));
            Formkriteria fk = new Formkriteria(wv1);
            this.Hide();
            fk.Show();
        }

        private void Homeform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Homeform_Load(object sender, EventArgs e)
        {

        }
    }
}
