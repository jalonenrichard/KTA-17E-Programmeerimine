using System;

namespace _03ClassInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programmi ühikirjeldus
            /*  
             Klassipäriluse õppimiseks loodud programm, base class on Car class,
             lisasin hetkel 2 automarki, mis kasutavad base classi meetodeid ja properteid,
             lisaks annab automarkide konstruktor kaasa väärtused baasklassi
            */

            // Youtube allikas
            // https://www.youtube.com/watch?v=pFCeRlr34CE
            /*
             Olen kõik tema Beginneritele mõeldud videod läbi käinud, täitsa hea materjal, 
             lihtsalt selleks koduseks tööks otsustasin klassipäriluse kasuks
            */

            // Base class without any values
            Console.WriteLine("Base class");
            var car = new Car();
            car.PrintCarInfo();
            Console.ReadLine();

            // Audi that inherits from Car class
            Console.WriteLine("Audi class that inherits from base (Car) class");
            var audi = new Audi("A6", 250, 4);
            // Inherited boolean
            audi.HandBrakeOn = false;
            // Inherited method
            audi.PrintCarInfo();
            // Inherited method
            audi.Accelerate();
            Console.ReadLine();

            // Range Rover that inherits from Car class
            Console.WriteLine("Range Rover class that inherits from base (Car) class");
            var rangeRover = new RangeRover("Evoque", 210, 5);
            // Inherited boolean
            rangeRover.HandBrakeOn = true;
            // Inherited method
            rangeRover.PrintCarInfo();
            // Inherited method
            rangeRover.Accelerate();
            Console.ReadLine();
        }
    }
}
