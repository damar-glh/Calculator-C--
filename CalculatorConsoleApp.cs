using System;

namespace CalculatorConsoleApp
{
    class CalculatorConsoleApp
    {
        // membuat method 
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
        
        //function inputan
        static void Inputan(out int a, out int b)
        { // mengubah parameter input menjadi out parameter
            Console.Write("\nInputkan nilai a = ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Inputkan nilai b = ");
            b = int.Parse(Console.ReadLine());
        }
        
        // program utama
        static void Main(string[] args)
        {
            // variabel yang digunakan
            int choice, a, b;

            // array menu
            string[] menu = { "Penambahan", "Pengurangan", "Perkalian", "Pembagian" };

            Console.Title= "Aplikasi Calculator";
            Console.WriteLine("Pilih Menu Calculator : \n");

            // perulangan untuk menampilkan data array diatas
            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {menu[i]}");
            }

            Console.Write("\nInput nomor menu [1..4]: ");

            // inputan
            choice = int.Parse(Console.ReadLine());
        
        
