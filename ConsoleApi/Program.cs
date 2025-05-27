using System.Net.Http.Headers;
using YMYP67_FirstAPI.Entities.Concrete;

namespace ConsoleApi;

internal class Program
{
    static void Main(string[] args)
    {
        Samsung samsung = new Samsung
        {
            Marka = "Samsung",
            Model = "Galaxy S23",
            Fiyat = 19999.99m,
            Hafiza = 256,
            Ram = 8,
            EkranBoyutu = 6.1m,
            CikisTarihi = new DateTime(2023, 2, 17),
            Aciklama = "Samsung Galaxy S23, güçlü performansı ve şık tasarımıyla dikkat çekiyor.",
            ResimUrl = "https://example.com/samsung-galaxy-s23.jpg"
        };
        Nokia nokia = new Nokia
        {
            Marka = "Nokia",
            Model = "G20",
            Fiyat = 3499.99m,
            Hafiza = 64,
            Ram = 4,
            EkranBoyutu = 6.5m,
            CikisTarihi = new DateTime(2021, 5, 21),
            Aciklama = "Nokia G20, uzun pil ömrü ve dayanıklılığı ile biliniyor.",
            ResimUrl = "https://example.com/nokia-g20.jpg"
        };

        samsung.ResimCek();
        samsung.InternetBaglan();
        Console.WriteLine(nokia.Marka + " " + nokia.Model);
        Console.WriteLine(samsung.Marka + " " + samsung.Model);
        nokia.ResimCek();

    }
}
