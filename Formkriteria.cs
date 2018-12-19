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
    public partial class Formkriteria : Form
    {
        Weightval wvin=new Weightval();
        public Formkriteria( Weightval wv2)
        {
            wvin = wv2;
            InitializeComponent();
        }

        private void Formkriteria_FormClosing(object sender, FormClosingEventArgs e){Application.Exit();}

        private void Formkriteria_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Alternatif war1 = new Alternatif();
            war1.nama = tBNama1.Text;
            war1.Kualitas = Convert.ToInt32(Math.Round(nUDKua1.Value, 0));
            war1.harga = Convert.ToInt32(Math.Round(nUDHarga1.Value, 0));
            war1.pelayanan = Convert.ToInt32(Math.Round(nUDPel1.Value, 0));
            war1.suasana = Convert.ToInt32(Math.Round(nUDSua1.Value, 0));
            war1.jarak = Convert.ToInt32(Math.Round(nUDJar1.Value, 0));

            Alternatif war2 = new Alternatif();
            war2.nama = tBNama2.Text;
            war2.Kualitas = Convert.ToInt32(Math.Round(nUDKua2.Value, 0));
            war2.harga = Convert.ToInt32(Math.Round(nUDHarga2.Value, 0));
            war2.pelayanan = Convert.ToInt32(Math.Round(nUDPel2.Value, 0));
            war2.suasana = Convert.ToInt32(Math.Round(nUDSua2.Value, 0));
            war2.jarak = Convert.ToInt32(Math.Round(nUDJar2.Value, 0));

            Alternatif war3 = new Alternatif();
            war3.nama = tBNama3.Text;
            war3.Kualitas = Convert.ToInt32(Math.Round(nUDKua3.Value, 0));
            war3.harga = Convert.ToInt32(Math.Round(nUDHarga3.Value, 0));
            war3.pelayanan = Convert.ToInt32(Math.Round(nUDPel3.Value, 0));
            war3.suasana = Convert.ToInt32(Math.Round(nUDSua3.Value, 0));
            war3.jarak = Convert.ToInt32(Math.Round(nUDJar3.Value, 0));

            Alternatif war4 = new Alternatif();
            war4.nama = tBNama4.Text;
            war4.Kualitas = Convert.ToInt32(Math.Round(nUDKua4.Value, 0));
            war4.harga = Convert.ToInt32(Math.Round(nUDHarga4.Value, 0));
            war4.pelayanan = Convert.ToInt32(Math.Round(nUDPel4.Value, 0));
            war4.suasana = Convert.ToInt32(Math.Round(nUDSua4.Value, 0));
            war4.jarak = Convert.ToInt32(Math.Round(nUDJar4.Value, 0));

            DataTable usernative = new DataTable();
            usernative.Columns.Add("Nama Warung", typeof(String));
            usernative.Columns.Add("Kualitas Makanan", typeof(double));
            usernative.Columns.Add("Harga Makanan", typeof(double));
            usernative.Columns.Add("Pelayanan Warung", typeof(double));
            usernative.Columns.Add("Suasana Warung", typeof(double));
            usernative.Columns.Add("Jarak rumah ke Warung (M)", typeof(double));

            usernative.Rows.Add
            (
                war1.nama, 
                war1.Kualitas, 
                war1.harga, 
                war1.pelayanan,
                war1.suasana,
                war1.jarak
            );
            usernative.Rows.Add
            (
                war2.nama,
                war2.Kualitas,
                war2.harga,
                war2.pelayanan,
                war2.suasana,
                war2.jarak
            );
            usernative.Rows.Add
            (
                war3.nama,
                war3.Kualitas,
                war3.harga,
                war3.pelayanan,
                war3.suasana,
                war3.jarak
            );
            usernative.Rows.Add
            (
                war4.nama,
                war4.Kualitas,
                war4.harga,
                war4.pelayanan,
                war4.suasana,
                war4.jarak
            );

            WeightedProducts wPM = new WeightedProducts(wvin, usernative);
            DataTable dtU = new DataTable();
            DataTable dtC = new DataTable();
            dtU = wPM.getTableforUser();
            dtC = wPM.getCompleteTable();

            formcount fk = new formcount(wvin, dtC, dtU);
            this.Hide();
            fk.Show();


            //btnGoBack.Text = wPM.getSV1().ToString();



        }
    }
}
