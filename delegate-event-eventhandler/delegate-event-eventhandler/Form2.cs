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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public event MahasiswaAddedHandler MahasiswaAdded;

        private void Button2_Click(object sender, EventArgs e)
        {
            string namaMahasiswa = textBox1.Text;
            MahasiswaAdded?.Invoke(namaMahasiswa);
        }
    }
}
