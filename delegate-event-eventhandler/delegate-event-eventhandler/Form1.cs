using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delegate_event_eventhandler
{
    public delegate void MahasiswaAddedHandler(string mahasiswa);
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MahasiswaAdded(string mahasiswa)
        {
            // add mahasiswa ke dalam listBox
            listBox1.Items.Add(mahasiswa);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.MahasiswaAdded += Form1_MahasiswaAdded;
            frm.ShowDialog();
        }
    }
}
