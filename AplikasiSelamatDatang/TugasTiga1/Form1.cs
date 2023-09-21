using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasTiga1
{
    public partial class frmMahasiswa : Form
    {
        public frmMahasiswa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmMahasiswa_Load(object sender, EventArgs e)
        {

        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            lblIsiNim.Text = "22.11.5209";
            lblIsiNama.Text = "Damar Galih";
            lblIsiKelas.Text = "S1-IF11";
        }

        private void btnKosongkan_Click(object sender, EventArgs e)
        {
            lblIsiNim.Text = "";
            lblIsiNama.Text = "";
            lblIsiKelas.Text = "";
        }
    }
}
