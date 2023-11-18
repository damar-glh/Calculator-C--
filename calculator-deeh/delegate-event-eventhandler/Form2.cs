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

        public event HitungHandler hitung;

        private void Button2_Click(object sender, EventArgs e)
        {
            // Ambil nilai dari textBox1 dan textBox2
            if (int.TryParse(textBox2.Text, out int nilai2) && int.TryParse(textBox1.Text, out int nilai1))
            {
                // Ambil operasi dari comboBox1
                string operasi = comboBox1.Text;

                // Lakukan operasi sesuai dengan pilihan
                int hasil = 0;
                string operatorString = "";
                string operation = " ";

                switch (operasi)
                {
                    case "Penambahan":
                        hasil = nilai1 + nilai2;
                        operatorString = "Penambahan";
                        operation = "+";
                        break;
                    case "Pengurangan":
                        hasil = nilai1 - nilai2;
                        operatorString = "Pengurangan";
                        operation = "-";
                        break;
                    case "Perkalian":
                        hasil = nilai1 * nilai2;
                        operatorString = "Perkalian";
                        operation = "*";
                        break;
                    case "Pembagian":
                        hasil = nilai1 / nilai2;
                        operatorString = "Pembagian";
                        operation = "/";
                        break;
                    case "Modulo":
                        hasil = nilai1 % nilai2;
                        operatorString = "Modulo";
                        operation = "%";
                        break;
                    default:
                        MessageBox.Show("Operasi tidak dikenal");
                        return;
                }

                // Panggil event hitung dan kirimkan hasil
                hitung?.Invoke(operatorString + nilai1 +" "+ operation + " " + nilai2 + " = " + Math.Abs(hasil).ToString());
            }
            else
            {
                MessageBox.Show("Masukkan nilai yang valid untuk Nilai A dan Nilai B");
            }
        }
    }
}
