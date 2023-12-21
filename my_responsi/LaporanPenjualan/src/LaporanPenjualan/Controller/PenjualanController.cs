using System.Collections.Generic;
using LaporanPenjualan.Model.Repository;
using LaporanPenjualan.Model.Entity;

namespace LaporanPenjualan.Controller
{
    public class PenjualanController
    {
        private PenjualanRestApiRepository _repository;

        public PenjualanController()
        {
            _repository = new PenjualanRestApiRepository();
        }

        public List<Penjualan> ReadAll()
        {
            return _repository.ReadAll();
        }

        public List<Penjualan> ReadByBulan(string bulan)
        {
            return _repository.ReadByBulan(bulan);
        }

        public List<Penjualan> ReadByNamaBarang(string namaBarang)
        {
            return _repository.ReadByNamaBarang(namaBarang);
        }

        public List<Penjualan> ReadByKodeBarang(string kodeBarang)
        {
            return _repository.ReadByKodeBarang(kodeBarang);
        }
    }
}
