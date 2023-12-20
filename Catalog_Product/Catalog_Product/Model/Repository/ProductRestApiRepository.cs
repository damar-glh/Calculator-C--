using RestSharp;
using Catalog_Product.Model.Entity;
using System.Collections.Generic;
using System;

namespace Catalog_Product.Model.Repository
{
    internal class ProductRestApiRepository
    {
        public List<Product> ReadAll()
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/product";

            // membuat objek rest client
            var client = new RestClient(baseUrl);

            // membuat objek request
            var request = new RestRequest(endpoint, Method.GET);

            // kirim request ke server
            var response = client.Execute<List<Product>>(request);

            return response.Data;
        }

        public List<Product> ReadByProductNama(string ProductName)
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/product?product_name=" + ProductName;

            // membuat objek rest client
            var client = new RestClient(baseUrl);

            // membuat objek request
            var request = new RestRequest(endpoint, Method.GET);

            // kirim request ke server
            var response = client.Execute<List<Product>>(request);

            return response.Data;
        }

        public List<Product> ReadByCategory(string Category)
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/product?category=" + Category;

            // membuat objek rest client
            var client = new RestClient(baseUrl);

            // membuat objek request
            var request = new RestRequest(endpoint, Method.GET);

            // kirim request ke server
            var response = client.Execute<List<Product>>(request);

            return response.Data;
        }

        public Product ReadByProductId(int productId)
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            var client = new RestClient(baseUrl);
            var request = new RestRequest($"api/product/{productId}", Method.GET);

            IRestResponse<Product> response = client.Execute<Product>(request);

            if (response.IsSuccessful)
            {
                return response.Data;
            }
            else
            {
                // Handle error
                Console.WriteLine($"Error: {response.ErrorMessage}");
                return null;
            }
        }

    }
}
