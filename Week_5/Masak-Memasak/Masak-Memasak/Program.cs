using System;

namespace Masak
{
    public class Makanan
    {
        protected string bahanUtama;

        public Makanan(string bahanUtama)
        {
            this.bahanUtama = bahanUtama;
        }
        public virtual string Resep()
        {
            return "Ini adlaah resep makanan.";
        }
        public virtual void PersipanBahan()
        {
            Console.WriteLine($"Siapkan {bahanUtama} sebagai bahan utama.");
        }
        public static void PanaskanOven(int suhu)
        {
            Console.WriteLine($"Panaskan oven pada suhu {suhu} derajat Celcius.");
        }
    }
    public class Roti : Makanan
    {
        private int kadarair;
        public Roti(string bahanUtama, int kadarair) : base(bahanUtama)
        {
            this.kadarair = kadarair;
        }
        public override string Resep()
        {
            return "Ini adalah resep roti. ";
        }
        public void Panggang(int waktu)
        {
            Console.WriteLine($"Panggang roti selama {waktu} menit. ");
        }
        public override void PersipanBahan()
        {
            Console.WriteLine($"Siapkan {bahanUtama} sebagai bahan utama .");
            Console.WriteLine($"Tambahkan air dengan kadar {kadarair} persen .");
        }
    }
    public class Pasta : Makanan
    {
        private string bentuk;
        public Pasta(string bahanUtama, string bentuk) : base(bahanUtama)
        {
            this.bentuk = bentuk;
        }
        public override string Resep()
        {
            return "Ini adalah resep pasta .";
        }
        public void Rebus(int waktu)
        {
            Console.WriteLine($"Rebus {bentuk} selama {waktu} menit.");
        }
        public override void PersipanBahan()
        {
            Console.WriteLine($"Siapkan {bahanUtama} sebagai bahan utama .");
            Console.WriteLine($"Bentuk {bahanUtama} menjadi {bentuk}");
        }
    }
    public class Mie : Makanan
    {
        private string rasa;
        public Mie(string bahanUtama, string rasa) : base(bahanUtama)
        {
            this.rasa = rasa;
        }
        public override string Resep()
        {
            return "Ini adalah reserp mie.";
        }
        public void Rebus(int waktu)
        {
            Console.WriteLine($"Rebus mie dalam {waktu} menit , dengan bumbu {rasa}");
        }
        public override void PersipanBahan()
        {
            Console.WriteLine($"Siapkan {bahanUtama} sebagai bahan utama.");
            Console.WriteLine($"Tambahkan bumbu {rasa} kedalam air rebusan mie");
        }
    }

    public class MiePasta : Makanan
    {
        private string bentuk, rasa;

        public MiePasta(string bahanUtama, string bentuk, string rasa) : base(bahanUtama)
        {
            this.bentuk = bentuk;
            this.rasa = rasa;
        }
        public override string Resep()
        {
            return "Ini adalah resep mie pasta";
        }
        public void rebus(int waktu)
        {
            Console.WriteLine($"Rebus {bentuk} dalam waktu {waktu} menit, dengan bumbu {rasa}.");
        }
        public override void PersipanBahan()
        {
            Console.WriteLine($"Siapkan {bahanUtama} dan tambahkan bumbu {rasa} sebagai bahan utama.");
            Console.WriteLine($"Bentuk {bahanUtama} menjadi {bentuk}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================================");
            Console.WriteLine("    Selamat datang didapur!");
            Console.WriteLine("================================");
            Console.WriteLine(" 1. Membuat Roti");
            Console.WriteLine(" 2. Membuat Pasta");
            Console.WriteLine(" 3. Membuat Mie");
            Console.WriteLine(" 4. Membuat Mie Pasta");
            Console.WriteLine("================================");
            Console.Write("Apa yang ingin anda masak : ");
            int pilihan = int.Parse(Console.ReadLine());
       
            switch (pilihan)
            {
                case 1:
                    Roti roti = new Roti("tepung", 60);
                    roti.PersipanBahan();
                    Makanan.PanaskanOven(180);
                    roti.Panggang(20);
                    Console.WriteLine(roti.Resep());
                    break;
                case 2:
                    Pasta pasta = new Pasta("spagethti", "linguine");
                    pasta.PersipanBahan();
                    pasta.Rebus(8);
                    Console.WriteLine(pasta.Resep());
                    break;
                case 3:
                    Mie mie = new Mie("mie insten", "rendang");
                    mie.PersipanBahan();
                    mie.Rebus(3);
                    Console.WriteLine(mie.Resep());
                    break;
                case 4:
                    MiePasta miepasta = new MiePasta("MiePasta (spagetthi dan mie)", "linguine", "soto");
                    miepasta.PersipanBahan();
                    miepasta.rebus(15);
                    Console.WriteLine(miepasta.Resep());
                    break;
                default:
                    Console.WriteLine("Pilihan tidak tersedia'");
                    break;
            }
            Console.WriteLine("Selamat menikmati makanan anda !");
        }
    }

}