using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesuperComputer
{
    class Monitor
    {
        // resulation , supporthdmi, size
        private String resolution;
        private Boolean supportHdmi;
        private double size;

        public Monitor (String resolution, Boolean supportHdmi, double size)
        {
            this.resolution = resolution;
            this.supportHdmi = supportHdmi;
            this.size = size;
        }
        private String getResolution ()
        {
            return resolution;
        }
        private Boolean isSupportHdmi()
        {
            return supportHdmi;
        }
        private double getSize()
        {
            return size;
        }
        public override string ToString()
        {
            return $"Monitor resulation: {resolution}; Monitor support hdmi : {supportHdmi}; Monitor dimensi : {size} inch";
        }
    }
    class Printer
    {
        private String brand;
        private String series;
        private int ppm;

        public Printer(String brand, String series, int ppm)
        {
            this.brand = brand;
            this.series = series;
            this.ppm = ppm;
        }
        public String getBrand()
        {
            return brand;
        }
        public String getSeries()
        {
            return series;
        }
        public int getPpm()
        {
            return ppm;
        }
        public override string ToString()
        {
            return $"Printer brand : {this.brand}; Printer series : {this.series}; Printer paper per minutes (ppm) : {this.ppm}";
        }
    }
    class Processor
    {
        private String series;
        private int core;
        private int cache;

        public Processor()
        {

        }
        public void setSeries (String series)
        {
            this .series = series;
        }
        public String getSeries(int core)
        {
            return this .series;
        }
        public void setCore(int core)
        {
            this.core = core;
        }
        public int getCore()
        {
            return core;
        }
        public void setCache (int cache)
        {
            this .cache = cache;
        }
        public int getCache()
        {
            return cache;
        }
        public override string ToString()
        {
            return $"Processor series : {this.series}; Processor core : {this.core}; Processor cache : {this.cache}";
        }
    }
    class Ram
    {
        private String type;
        private int speed;
        private int memorySize;

        public Ram(string type, int speed, int memorySize) {
            this .type = type;
            this .speed = speed;
            this .memorySize = memorySize;
        }
        public String getType()
        {
            return this.type;
        }
        public int getSpeed()
        {
            return this.speed;
        }
        public int getMemorySize()
        {
            return this.memorySize;
        }
        public override string ToString()
        {
            return $"Ram type : {this.type}; Ram speed : {this.speed}; Ram size : {this.memorySize}";
        }
    }
    class Vga
    {
        private String brand;
        private int graphicsClock;
        private int memoryClock;

        public Vga(String brand, int graphicsClock, int memoryClock) {
        
            this.brand = brand;
            this.graphicsClock = graphicsClock;
            this.memoryClock = memoryClock;
        }
        public String getBrand()
        {
            return brand;
        }
        public int getGraphicsClock()
        {
            return graphicsClock;
        }
        public int getMemoryClock()
        {
            return this.memoryClock;
        }
        public override string ToString()
        {
            return $"VGA brand : {this.brand}; VGA clock graphics : {this.graphicsClock}; VGA clock memory : {this. memoryClock}";
        }
    }
    class Computer
    {
        private Monitor monitor;
        private Printer printer;
        private Processor processor;
        private Ram ram;
        private Vga vga;

        private Computer(Builder builder)
        {
            this.monitor = builder.monitor;
            this.printer = builder.printer;
            this.processor = builder.processor;
            this.ram = builder.ram;
            this.vga = builder.vga;
        }
        public override string ToString()
        {
         return $"Monitor spec : {this.monitor} \n "+
                $"Processor spec : {this.processor} \n"+
                $"Printer spec : {this.printer} \n"+
                $"Vga spec : {this.vga} \n" +
                $"Ram spec : {this.ram}";
        }
        public class Builder
        {
            public Monitor monitor;
            public Printer printer;
            public Processor processor;
            public Ram ram;
            public Vga vga;

            public Builder(Ram ram, Vga vga, Processor processor) {
                this.ram = ram;
                this.vga = vga;
                this.processor = processor;
            }
            public Builder withMonitor(Monitor monitor) { 
            this.monitor = monitor;
            return this;
            }
            public Builder withPrinter(Printer printer)
            {
                this.printer = printer;
                return this;
            }
            public Computer build ()
            {
                return new Computer(this);
            }
        }
    }
    
        
        class Program
        {
            static void Main(string[] args)
            {
            Monitor lgMonitor = new Monitor("1200x600", true, 32);
            Printer hpPrinter = new Printer("HP", "MP102", 50);

            Vga nvdiaVga = new Vga("Nvidia", 2054, 2054);
            Ram samsungRam = new Ram("DDR4",5000,8000);
            Processor intelProcessor = new Processor();
            intelProcessor.setCache(254);
            intelProcessor.setCore(8);
            intelProcessor.setSeries("Core i7 8th Gen");

            Computer computer = new Computer.Builder(samsungRam,nvdiaVga,intelProcessor)
                .withMonitor(lgMonitor)
                .withPrinter(hpPrinter)
                .build();
            Console.WriteLine(computer.ToString());
            }

        }

    
}

