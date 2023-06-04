using System;

namespace TheCoffeMachie
{
    class CoffeMachine
    {
        private CoffePowder coffePowder;
        private WaterGalon waterGalon;

        public CoffeMachine(CoffePowder powder, WaterGalon galon) { 
            this.waterGalon = galon;
            this.coffePowder = powder;
        }

        public String makeEspresso()
        {
            if (!this.waterGalon.isAvailable())
            {
                return "Sorry , the water is empty";
            }
            if (!this.coffePowder.isAvailable())
            {
                return "Sorry, the coffe is empty";
            }

            this.waterGalon.makeOneCup();
            this.coffePowder.makeOneCup();
            return "Yey! your coffe is ready";
        }

        public String checkAvailability()
        {
            return $"the water : {this.waterGalon.getVolume()} and the coffe powder : {this.coffePowder.getNetto()}";
        }
    }
    class CoffePowder
    {
        private int netto = 0;
        private int oneCupCoffe = 25;

        public CoffePowder(int netto)
        {
            this.netto = netto;
        }
        public void addCoffe(int netto)
        {
            this.netto += netto;
        }
        public Boolean isAvailable()
        {
            return this.netto >= this.oneCupCoffe;
        }
        public void makeOneCup()
        {
            this.netto = this.netto - oneCupCoffe;
        }
        public int getNetto()
        {
            return this.netto;
        }
    }
    class WaterGalon
    {
        private int volume = 0;
        private int volumeOneCup = 250;

        public WaterGalon(int volume)
        {
            this.volume = volume;
        }
        public Boolean isAvailable()
        {
            return volume >= volumeOneCup;
        }
        public void addWater(int volume)
        {
            this.volume += volume;
        }
        public int makeOneCup()
        {
            this.volume = this.volume - this.volumeOneCup;
            return volumeOneCup;
        }
        public int getVolume()
        {
            return this.volume;
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("\t\t Coffe Machine");
            Console.WriteLine("====================================================");

            CoffePowder coffe = new CoffePowder(100);
            WaterGalon water = new WaterGalon(1000);
            CoffeMachine yummyCoffe = new CoffeMachine(coffe, water);

            //1st cup coffe
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            String result = yummyCoffe.makeEspresso();
            Console.WriteLine("Result " + result);

            //2st cup coffe
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEspresso();
            Console.WriteLine("Result " + result);

            //3st cup coffe
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEspresso();
            Console.WriteLine("Result " + result);

            //4st cup coffe
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEspresso();
            Console.WriteLine("Result " + result);

            //5st cup coffe
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEspresso();
            Console.WriteLine("Result " + result);

            Console.WriteLine();
            Console.WriteLine("====================================================");
            // add water and coffe
            Console.WriteLine($"Add Water {1000} and Coffe powder {100} : ");
            water.addWater(1000);
            coffe.addCoffe(100);
            Console.WriteLine("check " + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEspresso();
            Console.WriteLine("Result " + result);

        }
    }
}