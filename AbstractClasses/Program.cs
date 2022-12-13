using System.Runtime.Intrinsics.Arm;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen sekil = new Dikdortgen
            {
                Genislik = 3,
                Yukseklik = 4
            };
            Console.WriteLine("Alan: " + sekil.AlanHesapla() + "\nÇevre: " + sekil.CevreHesapla());
            DikUcgen sekil1 = new DikUcgen
            {
                Genislik = 6,
                Yukseklik = 8
            };
            Console.WriteLine("Alan: " + sekil1.AlanHesapla() + "\nÇevre: " + sekil1.CevreHesapla());
            Daire sekil2 = new Daire
            {
                YariCap = 5
            };
            Console.WriteLine("Alan: " + sekil2.AlanHesapla() + "\nÇevre: " + sekil2.CevreHesapla());
            Daire sekil3 = new Daire
            {
                YariCap = 5,
                Pi3Mu = false
            };
            Console.WriteLine("Alan: " + sekil3.AlanHesapla() + "\nÇevre: " + sekil3.CevreHesapla());

            Sekil shape = new Dikdortgen()
            {
                Genislik = 10,
                Yukseklik = 20
            };
            shape.AlanHesapla();
        }
    }

    abstract class Sekil
    {
        abstract public double AlanHesapla();
        abstract public double CevreHesapla();
    }

    abstract class Cokgen : Sekil
    {
        
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }
    }

    class Dikdortgen : Cokgen
    {
        public override  double AlanHesapla()
        {
            return Genislik * Yukseklik;
        }
        public override  double CevreHesapla()
        {
            return (Genislik + Yukseklik) * 2;
        }
    }
    class DikUcgen : Cokgen
    {

        public override double AlanHesapla()
        {
            return (Genislik * Yukseklik) / 2;
        }
        public override double CevreHesapla()
        {
            return Genislik + Yukseklik + HipotenusHesapla();
        }

        public double HipotenusHesapla()
        {
            return Math.Sqrt(Math.Pow(Genislik, 2) + Math.Pow(Yukseklik, 2));
        }
    }

    class Daire : Sekil
    {

        public double YariCap { get; set; }
        public bool Pi3Mu { get; set; } = true;
        public double Pi => Pi3Mu ? 3 : Math.PI;

        public override double AlanHesapla() => Pi * Math.Pow(YariCap, 2);
        public override double CevreHesapla() => 2 * Pi * YariCap;
    }
}