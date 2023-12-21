using RestSharp;
using System.Collections.Generic;
using LaporanPenjualan.Model.Entity;

namespace LaporanPenjualan.Model.Repository
{
    public class PenjualanRestApiRepository
    {
        /// <summary>
        /// Method untuk menampilkan semua data penjualan
        /// </summary>
        /// <returns>Object collection dari penjualan</returns>
        public List<Penjualan> ReadAll()
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/penjualan";

            // membuat objek rest client
            var client = new RestClient(baseUrl);

            // membuat objek request
            var request = new RestRequest(endpoint, Method.GET);

            // kirim request ke server
            var response = client.Execute<List<Penjualan>>(request);

            return response.Data;
        }

        /// <summary>
        /// Method untuk pencarian data penjualan berdasarkan nama bulan
        /// </summary>
        /// <param name="bulan"></param>
        /// <returns>Object collection dari penjualan</returns>
        public List<Penjualan> ReadByBulan(string bulan)
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/penjualan?bulan=" + bulan;

            // membuat objek rest client
            var client = new RestClient(baseUrl);

            // membuat objek request
            var request = new RestRequest(endpoint, Method.GET);

            // kirim request ke server
            var response = client.Execute<List<Penjualan>>(request);

            return response.Data;
        }

        /// <summary>
        /// Method untuk pencarian data penjualan berdasarkan nama barang
        /// </summary>
        /// <param name="namaBarang"></param>
        /// <returns>Object collection dari penjualan</returns>
        public List<Penjualan> ReadByNamaBarang(string namaBarang)
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/penjualan?nama_barang=" + namaBarang;

            // membuat objek rest client
            var client = new RestClient(baseUrl);

            // membuat objek request
            var request = new RestRequest(endpoint, Method.GET);

            // kirim request ke server
            var response = client.Execute<List<Penjualan>>(request);

            return response.Data;
        }

        /// <summary>
        /// Method untuk pencarian data penjualan berdasarkan kode barang
        /// </summary>
        /// <param name="kodeBarang"></param>
        /// <returns>Object collection dari penjualan</returns>
        public List<Penjualan> ReadByKodeBarang(string kodeBarang)
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/penjualan/" + kodeBarang;

            // membuat objek rest client
            var client = new RestClient(baseUrl);

            // membuat objek request
            var request = new RestRequest(endpoint, Method.GET);

            // kirim request ke server
            var response = client.Execute<List<Penjualan>>(request);

            return response.Data;
        }
    }
}
