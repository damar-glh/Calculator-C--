using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassdanObject
{
    internal class Mahasiswaa
    {
        //properties
        public string Nama { get; set; }
        public string Nim { get; set; }
        public string Jurusan { get; set; }
        public int Angkatan { get; set; }


        //constructor
        public Mahasiswaa(string nama, string nim, string jurusan, int angkatan = 0)
        {
            Nama = nama;
            Nim = nim;
            Jurusan = jurusan;
            Angkatan = angkatan;
        }

        // method
        public void PrintInfo()
        {
            Console.WriteLine("Nama\t: " + Nama);
            Console.WriteLine("Nim\t: " + Nim);
            Console.WriteLine("Jurusan\t:" + Jurusan);
            Console.WriteLine("Angkatan :" + Angkatan);
            Console.WriteLine();
        }
        class Program
        {
            static void Main(string[] args)
            {
                Mahasiswaa mhs1 = new Mahasiswaa("John Doe", "123456789", "Teknik Informatika", 2022);
                Mahasiswaa mhs2 = new Mahasiswaa("Jane Doe", "123456789", "Informatika", 2021);
                Mahasiswaa mhs3 = new Mahasiswaa("Josh Doe", "123456789", "Teknik Kimia", 2024);

                mhs1.PrintInfo();
                mhs2.PrintInfo();
                mhs3.PrintInfo();

                Console.ReadKey();
            }

        }

    }
}

