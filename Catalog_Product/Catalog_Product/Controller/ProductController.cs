using Catalog_Product.Model.Entity;
using Catalog_Product.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog_Product.Controller
{
    public class ProductController
    {
        public List<Product> ReadByNama(string nama)
        {
            // membuat objek collection
            List<Product> list = new List<Product>();

            var repo = new ProductRestApiRepository();
            list = repo.ReadByProductNama(nama);

            return list;
        }

        public List<Product> ReadAll()
        {
            // membuat objek collection
            List<Product> list = new List<Product>();

            var repo = new ProductRestApiRepository();
            list = repo.ReadAll();

            return list;
        }

        public List<Product> ReadByCategory(string category)
        {
            // membuat objek collection
            List<Product> list = new List<Product>();

            var repo = new ProductRestApiRepository();
            list = repo.ReadByCategory(category);

            return list;
        }

        public Product ReadByProductId(int product_id)
        {
            // membuat objek mahasiswa
            //Mahasiswa mhs = null;

            // membuat objek context menggunakan blok using
            /*using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new MahasiswaRepository(context);

                // panggil method ReadByNpm yang ada di dalam class repository
                mhs = _repository.ReadByNpm(npm);
            }*/

            var repo = new ProductRestApiRepository();
            Product prc = repo.ReadByProductId(product_id);

            return prc;
        }
    }
}
