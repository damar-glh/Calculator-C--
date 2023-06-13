// base class polymorphism
public abstract class ItemLibrary 
{
    public string Title { get; set; }

    public abstract void Print();
}

 /* class abstrac = kelas yang tidak dapat dibuat instance-nya.
 Sebagai gantinya,ini berfungsi sebagai kelas dasar untuk kelas lain untuk diwarisi
 Kelas abstrak digunakan untuk mendefinisikan seperangkat perilaku 
 atau properti umum yang harus dimiliki oleh kelas turunan.*/
 