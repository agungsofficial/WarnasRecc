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
    public partial class FormAdvans : Form
    {
        Weightval wvin=new Weightval(); DataTable dt_advanced =new DataTable();
        public FormAdvans(Weightval wvin, DataTable dtC)
        {
            InitializeComponent();
            dt_advanced = dtC;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormAdvans_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt_advanced;
        }

        private void FormAdvans_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
