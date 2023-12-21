using System;
using System.Windows.Forms;
using LaporanPenjualan.Model.Entity;
using LaporanPenjualan.Model.Repository;
using LaporanPenjualan.Controller;
using System.Collections.Generic;

namespace LaporanPenjualan.View
{
    public partial class FrmPencarian : Form
    {
        public PenjualanRestApiRepository repository;
        private List<Penjualan> listOfPenjualan = new List<Penjualan>();
        private PenjualanController _controller;

        public FrmPencarian()
        {
            InitializeComponent();
            _controller = new PenjualanController();
            InisialisasiListView();
            cmbFilter.SelectedIndex = 0;
        }

        private void InisialisasiListView()
        {
            lvwLaporan.View = System.Windows.Forms.View.Details;
            lvwLaporan.FullRowSelect = true;
            lvwLaporan.GridLines = true;

            lvwLaporan.Columns.Add("No.", 40, HorizontalAlignment.Center);
            lvwLaporan.Columns.Add("Bulan", 100, HorizontalAlignment.Left);
            lvwLaporan.Columns.Add("Kode Barang", 100, HorizontalAlignment.Left);
            lvwLaporan.Columns.Add("Nama Barang", 750, HorizontalAlignment.Left);
            lvwLaporan.Columns.Add("Jumlah", 70, HorizontalAlignment.Center);
            lvwLaporan.Columns.Add("Harga", 100, HorizontalAlignment.Right);
            lvwLaporan.Columns.Add("Sub Total", 150, HorizontalAlignment.Right);
        }

        private void ShowData()
        {
            lvwLaporan.Items.Clear();
            foreach (var penjualan in listOfPenjualan)
            {
                var noUrut = lvwLaporan.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(penjualan.bulan);
                item.SubItems.Add(penjualan.kode_barang);
                item.SubItems.Add(penjualan.nama_barang);
                item.SubItems.Add(penjualan.jumlah.ToString());
                item.SubItems.Add(penjualan.harga.ToString());
                item.SubItems.Add(penjualan.sub_total.ToString());
                lvwLaporan.Items.Add(item);
            }
        }

        private void showAll()
        {
            listOfPenjualan = _controller.ReadAll();
            ShowData();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string filter = cmbFilter.Text;
            string keyword = txtKeyword.Text;

            if (filter == "All")
            {
                showAll();
                return;
            }

            if (string.IsNullOrEmpty(txtKeyword.Text))
            {
                MessageBox.Show("Keyword harus di isi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (filter == "Kode Barang")
            {
                listOfPenjualan = _controller.ReadByKodeBarang(keyword);
                ShowData();
            } else if (filter == "Nama Barang")
            {
                listOfPenjualan = _controller.ReadByNamaBarang(keyword);
                ShowData();
            } else if (filter == "Bulan")
            {
                listOfPenjualan = _controller.ReadByBulan(keyword);
                ShowData();
            } 
        }
    }
}
