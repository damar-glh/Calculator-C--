class BujurSangkar : BangunDatar, IluasBangunDatar{
    private double sisi;
    public BujurSangkar(double sisi){
        this.sisi = sisi;
    }

    public override double HitungLuas(){ // override menandakan polymorphism
        return sisi * sisi;
    }
}