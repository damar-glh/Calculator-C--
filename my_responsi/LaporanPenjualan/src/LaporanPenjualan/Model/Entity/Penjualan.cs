namespace LaporanPenjualan.Model.Entity
{
    public class Penjualan
    {
        public string bulan { get; set; }
        public string kode_barang { get; set; }
        public string nama_barang { get; set; }
        public int jumlah { get; set; }
        public int harga { get; set; }
        public int sub_total { get; set; }
    }
}
