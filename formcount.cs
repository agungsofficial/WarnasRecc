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
    public partial class formcount : Form
    {
        Weightval wvin; DataTable dt_foruser; DataTable dt_advanced;
        public formcount(Weightval wv, DataTable dtC, DataTable dtU)
        {
            wvin = wv;
            dt_foruser = dtU;
            dt_advanced = dtC;
            InitializeComponent();
        }

        private void formcount_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt_foruser;
            label2.Text = dt_foruser.Rows[0][0].ToString();
            label4.Text= dt_foruser.Rows[0][1].ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAdvans fa = new FormAdvans(wvin, dt_advanced);
            //this.Hide();
            fa.Show();
        }

        private void formcount_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
