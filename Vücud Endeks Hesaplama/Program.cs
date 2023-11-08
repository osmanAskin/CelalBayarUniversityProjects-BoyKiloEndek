using System;

namespace Vücud_Endeks_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kilonuzu Giriniz: ");
            int kilo = int.Parse(Console.ReadLine());

            Console.WriteLine("Boyunuzu Giriniz (örnek 1.82): ");
            double boy = double.Parse(Console.ReadLine());

            double bki = kilo / (boy * boy);

            Console.WriteLine("Beden Kitle İndeksiniz: " + bki);

            Console.ReadLine(); // Programın kapanmasını önlemek için bu satırı ekledim.
        }
    }
}
