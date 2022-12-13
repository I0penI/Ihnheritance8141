namespace Ihnheritance8141
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci()
            {
                Adi = "Ali",
                Id = 1,
                Soyadi = "Arslan",
                Okulu = "GAUN"

            };
            Musteri musteri = new Musteri()
            {
                Adi = "Ali",
                Id = 1,
                Soyadi = "Arslan",
                KartNo = "5282 0800 1468 2264"
            };
            Insan insan = new Insan()
            {
                Adi = "Ali",
                Soyadi = "Arslan",
                Id = 1

            };
           
            Console.WriteLine(insan.AdSoyadGetir());
            Console.WriteLine(musteri.AdSoyadGetir());
            Console.WriteLine(ogrenci.AdSoyadGetir());
        }
    }
    class Insan // Base, Parent
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }

        public string AdSoyadGetir()
        {
            return $"{Adi} {Soyadi}";
        }
    }

    class Ogrenci : Insan // sub, child
    {
        public string Okulu { get; set; }
    }
    class Musteri : Insan // sub, child
    {
        public string KartNo { get; set; }
    }
    
}