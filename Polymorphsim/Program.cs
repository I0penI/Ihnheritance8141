using System.Data.SqlTypes;
using System.Security.Principal;

namespace Polymorphsim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Memeli hayvan = new Kopek()
            {
                Id = 1,
                Adi = "Uzay",
                Cinsi = "Rus Finosu",
                ErkekMi = false,
                Renk = "Beyaz",
                DogumTarihi = new DateTime(2019, 1, 1),
                YasamYeri = YasamYeri.Kara,
                BuyukIrkMi = false
                
                
            };

            Console.WriteLine(((Kopek)hayvan).BuyukIrkMi);   // casting
            Console.WriteLine((hayvan as Kopek).BuyukIrkMi); // casting

            hayvan = new Kedi()
            {
                Id = 2,
                Adi = "Gaspi",
                Cinsi = "Scottish Fold",
                ErkekMi = false,
                Renk = "Gri",
                DogumTarihi = new DateTime(2022, 12, 7),
                YasamYeri = YasamYeri.Kara
            };
        }
    }
    class Hayvan // Base
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Renk { get; set; }
        public DateTime DogumTarihi { get; set; }
        public YasamYeri YasamYeri { get; set; }

    }

    class Memeli :Hayvan
    {
        public string Cinsi { get; set; }
        public bool ErkekMi { get; set; }
    }
    class Kopek : Memeli
    {
        public bool BuyukIrkMi { get; set; }
    }

    class Kedi : Memeli
    {

    }
    enum YasamYeri
    {
        Kara, Hava, Su, KaraVeSu
    }
    


}