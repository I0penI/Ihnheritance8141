namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba()
            {
                Marka = "Toyota",
                Model = "Supra",
                MotorHacmi = 3.6

            };
            Console.Write($"Araç: {araba.Marka}  {araba.Model},  ");
            araba.Calistir();
            araba.Sur();
            Console.WriteLine();
            Otobus otobus = new Otobus()
            {
                Marka = "Otokar",
                Model = "",
                MotorHacmi = 2.5
            };
            Console.Write($"Araç: {otobus.Marka}  {otobus.Model},  ");
            otobus.Calistir();
            otobus.Sur();
            Console.WriteLine();
            Motorsiklet motor = new Motorsiklet()
            {
                Marka = "Yamaha",
                Model = "R25",
                MotorHacmi = 1.6
            };
            Console.Write($"Araç: {motor.Marka}  {motor.Model},  ");
            motor.Calistir();
            motor.Sur();
            




        }
    }

    class Arac// Base
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public double MotorHacmi { get; set; }

        public void Calistir()
        {
            Console.Write("Araç çalıştırıldı. ");
        }
        public virtual void Sur()
        {
            Console.Write("Araç 4 tekerlek üzerinden sürülüyor. ");
        }


    }
    class Araba : Arac
    {
       
    }
    class Otobus : Arac
    {
        
    }
    class Motorsiklet : Arac
    {
        public override void Sur()
        {
            Console.Write("Motorsiklet 2 tekerlek üzerinden sürülüyor. ");
        }
    }
}