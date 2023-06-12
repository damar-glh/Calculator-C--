// class Program
class Program{
    public static void Main(string[] args){
        IluasBangunDatar[] bangunDatar = new IluasBangunDatar[3]; 
        bangunDatar[0] = new BujurSangkar(5); 
        bangunDatar[1] = new PersegiPanjang(4, 6);
        bangunDatar[2] = new Segitiga(3, 8);

    foreach(BangunDatar bangun in  bangunDatar){ // polymorphism
        bangun.Print();
    }
    }
}