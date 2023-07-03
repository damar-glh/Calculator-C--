using System;
using System.Collections.Generic;

class Program{
    public static void Main(string[] args){
        // membuat objek mhs1
        Mahasiswa mhs1 = new Mahasiswa();
        mhs1.Nim = "1234";
        mhs1.NamaMahasiswa = "Erik";
        // membuat objek mhs2
        Mahasiswa mhs2 = new Mahasiswa();
        mhs2.Nim = "1235";
        mhs2.NamaMahasiswa = "Wely";
        // membuat objek mhs3
        Dosen dosen = new Dosen();
        dosen.Nik = "0043";
        dosen.NamaDosen = "Jhono";

        // membuat objek list
        List<Mahasiswa> list = new List<Mahasiswa>();

        // menambahkan element list
        list.Add(mhs1);
        list.Add(mhs2);

        // coba tambahkan objek dosen ke list, apa yang terjadi ?
        // list.Add(dosen);

        // mengakses element list
        Mahasiswa mhs = list[1];
        System.Console.WriteLine("{0}, {1}", mhs.Nim, mhs.NamaMahasiswa);
    }
}