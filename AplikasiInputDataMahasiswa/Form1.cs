using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiInputDataMahasiswa
{
    public partial class Form1 : Form
    {
        private List<Mahasiswa> list = new List<Mahasiswa>();
        public Form1()
        {
            InitializeComponent();
            InisialiasiListView();
        }

        private void InisialiasiListView()
        {
            lvwMahasiswa.View = View.Details;
            lvwMahasiswa.FullRowSelect = true;
            lvwMahasiswa.GridLines = true;

            lvwMahasiswa.Columns.Add("No .", 30,  HorizontalAlignment.Center);
            lvwMahasiswa.Columns.Add("Nim ", 91, HorizontalAlignment.Center);
            lvwMahasiswa.Columns.Add("Nama ", 200, HorizontalAlignment.Center);
            lvwMahasiswa.Columns.Add("Kelas ", 70, HorizontalAlignment.Center);
            lvwMahasiswa.Columns.Add("Nilai ", 50, HorizontalAlignment.Center);
            lvwMahasiswa.Columns.Add("Nilai Huruf", 80, HorizontalAlignment.Center);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void txtNilai_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = NumericOnly(e);
        }

        private void btnTampilkanData_Click(object sender, EventArgs e)
        {
            TampilkanData();
        }

        private void ResetForm()
        {
            txtNim.Clear();
            txtNama.Clear();
            txtKelas.Clear();
            txtNilai.Text = "0";
            txtNim.Focus();
        }
        private bool NumericOnly(KeyPressEventArgs e)
        {
            var strValid = "0123456789";
            if (!(e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                // inputan selain angka
                if (strValid.IndexOf(e.KeyChar) < 0)
                {
                    return true;
                }
                return false;
            }
            else
                return false;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            
            Mahasiswa mhs = new Mahasiswa();

            mhs.Nim = txtNim.Text;
            mhs.Nama = txtNama.Text;
            mhs.Kelas = txtKelas.Text;
            mhs.Nilai = int.Parse(txtNilai.Text);


            list.Add(mhs);
            var msg = "Data mahasiswa berhasil disimpan.";

            MessageBox.Show(msg, "Informasi", MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            ResetForm();

        }

        private void TampilkanData()
        {
            lvwMahasiswa.Items.Clear();
            foreach (var mhs in list)
            {
                var noUrut = lvwMahasiswa.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(mhs.Nim);
                item.SubItems.Add(mhs.Nama);
                item.SubItems.Add(mhs.Kelas);
                item.SubItems.Add(mhs.Nilai.ToString());
                item.SubItems.Add(HitungNilaiHuruf(mhs.Nilai));
                lvwMahasiswa.Items.Add(item);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lvwMahasiswa.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data mahasiswa ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (konfirmasi == DialogResult.Yes)
                {
                    var index = lvwMahasiswa.SelectedIndices[0];

                    Console.WriteLine("Menghapus item dari list pada indeks: " + index);

                    if (index >= 0 && index < list.Count)
                    {
                        list.RemoveAt(index);
                        /*
                        lvwMahasiswa.Items.RemoveAt(index);
                        */
                        TampilkanData();
                    }
                }
            } else {
                MessageBox.Show("Data mahasiswa belum dipilih!!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private string HitungNilaiHuruf(int nilai)
        {
            if (nilai >= 0 && nilai <= 20)
            {
                return "E";
            }
            else if (nilai >= 21 && nilai <= 40)
            {
                return "D";
            }
            else if (nilai >= 41 && nilai <= 60)
            {
                return "C";
            }
            else if (nilai >= 61 && nilai <= 80)
            {
                return "B";
            }
            else if (nilai >= 81 && nilai <= 100)
            {
                return "A";
            }
            else
            {
                return "Nilai tidak valid"; 
            }
        }
    }
}
