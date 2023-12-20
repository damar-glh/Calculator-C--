using RestSharp;
using PerpustakaanAppMVC.Model.Entity;
using System.Collections.Generic;
using System;

public class MahasiswaRestApiRepository
{
    public int Create(Mahasiswa mhs)
    {
        string baseUrl = "http://latihan.coding4ever.net:5555/";
        string endpoint = "api/mahasiswa";

        // membuat objek rest client
        var client = new RestClient(baseUrl);

        // membuat objek request
        var request = new RestRequest(endpoint, Method.POST);

        // tambahkan object mahasiswa kedalam body
        request.AddJsonBody(mhs);

        // kirim request ke server
        var response = client.Execute(request);

        // cek nilai result, jika 1 maka berhasil
        var result = response.Content.IndexOf("1") > 0 ? 1 : 0 ;

        return result;
    }

    public int Update(Mahasiswa mhs)
    {
        string baseUrl = "http://latihan.coding4ever.net:5555/";
        string endpoint = "api/mahasiswa/"+ mhs.Npm;

        // membuat objek rest client
        var client = new RestClient(baseUrl);

        // membuat objek request
        var request = new RestRequest(endpoint, Method.PUT);

        // tambahkan object mahasiswa kedalam body
        request.AddJsonBody(mhs);

        // kirim request ke server
        var response = client.Execute(request);

        // cek nilai result, jika 1 maka berhasil
        var result = response.Content.IndexOf("1") > 0 ? 1 : 0;

        return result;
    }

    public int Delete(Mahasiswa mhs)
    {
        string baseUrl = "http://latihan.coding4ever.net:5555/";
        string endpoint = "api/mahasiswa/" + mhs.Npm;

        // membuat objek rest client
        var client = new RestClient(baseUrl);

        // membuat objek request
        var request = new RestRequest(endpoint, Method.DELETE);

        // tambahkan object mahasiswa kedalam body
        request.AddJsonBody(mhs);

        // kirim request ke server
        var response = client.Execute(request);

        // cek nilai result, jika 1 maka berhasil
        var result = response.Content.IndexOf("1") > 0 ? 1 : 0;

        return result;
    }

    public List<Mahasiswa> ReadAll()
    {
        string baseUrl = "http://latihan.coding4ever.net:5555/";
        string endpoint = "api/mahasiswa";

        // membuat objek rest client
        var client = new RestClient(baseUrl);

        // membuat objek request
        var request = new RestRequest(endpoint, Method.GET);

        // kirim request ke server
        var response = client.Execute<List<Mahasiswa>>(request);

        return response.Data;
    }

    public List<Mahasiswa> ReadByNama(string nama)
    {
        string baseUrl = "http://latihan.coding4ever.net:5555/";
        string endpoint = "api/mahasiswa?nama=" + nama;

        // membuat objek rest client
        var client = new RestClient(baseUrl);

        // membuat objek request
        var request = new RestRequest(endpoint, Method.GET);

        // kirim request ke server
        var response = client.Execute<List<Mahasiswa>>(request);

        return response.Data;
    }

    public Mahasiswa ReadByNpm(string npm)
    {
        string baseUrl = "http://latihan.coding4ever.net:5555/";
        var client = new RestClient(baseUrl);
        var request = new RestRequest("api/mahasiswa", Method.GET);
        request.AddQueryParameter("npm", npm);

        IRestResponse<Mahasiswa> response = client.Execute<Mahasiswa>(request);

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
