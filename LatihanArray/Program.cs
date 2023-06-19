class Program{
    static void Main(string[] args){
    // membuat array  sekaligus inisialisasi nilai
    string[] arrNama = {"Damar","Nugroho","Mufied","Rizal"};

    // menampilkan semua elemen array
    for (int i =0; i < arrNama.Length; i++){
        System.Console.WriteLine(arrNama[i]);
    }
    System.Console.WriteLine();

    // menampilkan semua element array mengggunakan foreach
    foreach (string nama in arrNama){
        System.Console.WriteLine(nama);
    }
    System.Console.WriteLine();

    // membuat array
    int[] arrBil = new int[3];

    // inisialisasi nilai array
    arrBil[0] = 12;
    arrBil[1] = 14;
    arrBil[2] = 24;

    // menampilakn semua elemen array menggunakan foreach
    foreach(int bil  in arrBil){
        System.Console.WriteLine(bil);
    }
    System.Console.WriteLine();
}
}