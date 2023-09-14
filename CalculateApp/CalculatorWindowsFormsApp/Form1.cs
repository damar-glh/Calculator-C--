using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorMachine;

namespace CalculatorWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstHasil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            var cal = new Calculator();
            var a = int.Parse(txtNilaiA.Text); // casting
            var b = Convert.ToInt32(txtNilaiB.Text); // casting

            lstHasil.Items.Clear(); // kosongkan isi listbox

            // tampilkan hasil semua hasil pemanggilan method calculator ke dalam listbox
            lstHasil.Items.Add(string.Format("Hasil Penambahan : {0} + {1} = {2}", a, b, cal.Penambahan(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Pengurangan: {0} - {1} = {2}", a, b, cal.Pengurangan(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Perkalian: {0} * {1} = {2}", a, b, cal.Perkalian(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Pembagian : {0} / {1} = {2}", a, b, Calculator.Pembagian(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Pangkat: {0} ^ {1} = {2}", a, b, cal.Pangkat(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Module : {0} % {1} = {2}", a, b, Calculator.Modulo(a, b)));
        }
    }
}
