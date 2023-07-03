using System;
using System.Collections.Generic;

class Program{
    public static void Main(string[] args){
        // membuat objek list untuk menampung tipe data integer
        List<int> listNilai = new List<int>();

        // menambahkan element list
        // tidak ada proses boxing
        listNilai.Add(70);
        listNilai.Add(100);
        listNilai.Add(85);

        // mengakses element list
        // tidak ada proses unboxing
        int nilaiElement1 = listNilai[1];

        System.Console.WriteLine(nilaiElement1);
        System.Console.WriteLine();

        foreach (int nilai in listNilai)
        {
            System.Console.WriteLine(nilai);
        }
    }
}