using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjectPegawai
{
    public partial class FrmPegawai : Form
    {
        // membuat objek collection dengan nama daftarPegawai
        private List<Pegawai> daftarPegawai = new List<Pegawai>();

        public FrmPegawai()
        {
            InitializeComponent();
            InisialisasiListView();
        }

        // atur kolom listview
        private void InisialisasiListView()
        {
            lvwPegawai.View = View.Details;
            lvwPegawai.FullRowSelect = true;
            lvwPegawai.GridLines = true;

            lvwPegawai.Columns.Add("No .", 30, HorizontalAlignment.Center);
            lvwPegawai.Columns.Add("NIK ", 91, HorizontalAlignment.Center);
            lvwPegawai.Columns.Add("Nama ", 200, HorizontalAlignment.Center);
            lvwPegawai.Columns.Add("Jenis Kelamin ", 70, HorizontalAlignment.Center);
            lvwPegawai.Columns.Add("Jabatan ", 50, HorizontalAlignment.Center);
        }

        private void ResetForm()
        {
            txtNIK.Clear();
            txtNama.Clear();
            rdoLakilaki.Checked = true;
            rdoPerempuan.Checked = false;
            rdoDirektur.Checked = true;
            rdoManager.Checked = false;
            rdoStaf.Checked = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // PERINTAH: lengkapi kode untuk menambahkan data penjualan ke dalam collection
            Pegawai pegawai = new Pegawai();

            pegawai.Nik = txtNIK.Text;
            pegawai.Name = txtNama.Text;
            if (rdoLakilaki.Checked)
            {
                pegawai.jenisKelamin = rdoLakilaki.Text;
            }
            else
            {
                pegawai.jenisKelamin = rdoPerempuan.Text;
            }

            if (rdoDirektur.Checked)
            {
                pegawai.jabatan = rdoDirektur.Text;
            } 
            else if (rdoManager.Checked)
            {
                pegawai.jabatan = rdoManager.Text;
            }
            else
            {
                pegawai.jabatan = rdoStaf.Text;
            }

            daftarPegawai.Add(pegawai);
            var msg = "Data pegawai berhasil disimpan.";

            // tampilkan dialog informasi
            MessageBox.Show(msg, "Informasi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);            

            // tampilkan pegawai ke listview
            TampilkanData();

            // kosongkan form input
            ResetForm();
        }

        private void TampilkanData()
        {
            // kosongkan data listview
            lvwPegawai.Items.Clear();

            foreach (var pegawai in daftarPegawai)
            {
                var noUrut = lvwPegawai.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());

                item.SubItems.Add(pegawai.Nik);
                item.SubItems.Add(pegawai.Name);
                item.SubItems.Add(pegawai.jenisKelamin);
                item.SubItems.Add(pegawai.jabatan);
                lvwPegawai.Items.Add(item);
            }
        }
    }
}
