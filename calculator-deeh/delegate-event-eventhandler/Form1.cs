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
    public delegate void HitungHandler(string hasil);
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Hitung(string hasil)
        {
            // add mahasiswa ke dalam listBox
            listBox1.Items.Add(hasil);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.hitung += Form1_Hitung;
            frm.ShowDialog();
        }
    }
}
