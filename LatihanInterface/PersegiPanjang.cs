class PersegiPanjang : BangunDatar, IluasBangunDatar{ // inheritance & interface
    private double panjang;
    private double lebar;
    public PersegiPanjang(double panjang, double lebar){
        this.panjang = panjang;
        this.lebar = lebar;
    }
    public override double HitungLuas(){ // override menandakan polymorphism
        return panjang * lebar;
    }
}