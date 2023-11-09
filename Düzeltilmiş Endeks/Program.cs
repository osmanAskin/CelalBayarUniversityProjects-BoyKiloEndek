//int binek = 1;
//int otobüs = 2;
//int diğer = 3;


//Console.WriteLine("Lütfen Arabınzın Modelini Seçiniz [1]binek] - [2]otobüs] - [3]diğer]");


//int secim = int.Parse(Console.ReadLine());


//string arabaName = "";

//if (secim == binek)
//{
//    arabaName = "Binek Araba";
//}
//else if (secim == otobüs)
//{
//    arabaName = "Otobüs";
//}
//else if (secim == diğer)
//{
//    arabaName = "Diğer";
//}
//else
//{
//    arabaName = "Geçersiz Seçim";





//    Console.WriteLine("Araba Seçiminiz :" + arabaName);



//    return;

//}

//using System.Net.Http.Headers;

// Console.Write("2'li Sayıda Veri Girişi Yapınız: ");
//string ikiliGiris = Console.ReadLine();

//if (ikiliGiris == "0" || ikiliGiris == "1")
//{
//    int ondalikGiris = Convert.ToInt32(ikiliGiris, 2); // İkiliyi ondalık olarak çevir
//    Console.WriteLine("Onlu Değerde: " + ondalikGiris);
//}
//else
//{
//    Console.WriteLine("Girdiğiniz Değer Geçersizdir. Sadece 0 veya 1 girebilirsiniz.");
//}
//Vücud Endeks Hesaplama


Console.Write("Cinsiyetinizi Girin: (Kadın için 'K' , Erkek için 'E')");
char cinsiyet = Console.ReadLine()[0];

Console.WriteLine("Boyunuzu Girin(cm türünden) :");
Double boy = Double.Parse(Console.ReadLine());

Console.WriteLine("Kilonuzu Giriniz :");
Double kilo = Double.Parse(Console.ReadLine());

Double idealkilo = 0;
String cinsiyetStr = "";


if (cinsiyet == 'K' || cinsiyet == 'k')
{
    idealkilo = 45.5 + 2.3 * (boy / 2.54 - 60);
    cinsiyetStr = "Kadın";
}
else if (cinsiyet == 'E' || cinsiyet == 'e')
{
    idealkilo = 50 + 2.3 * (boy / 2.54 - 60);
    cinsiyetStr = "Erkek";
}
else
{
    Console.WriteLine("Geçersiz Bir İfade Girdiniz Tekrar Deneyiniz: ");
    return; 
}


if (kilo == idealkilo)
{
    Console.WriteLine(cinsiyetStr + "İdeal Kilodasınız");
}
else if (kilo < idealkilo)
{
    Console.WriteLine(cinsiyetStr + "İdeal Kiloda Değilsiniz, İdeal Kilonuz: " + idealkilo.ToString("f2") + "Kg Olmalı");
}
else
{
    Console.WriteLine(cinsiyetStr + "İdeal Kilonun Üstündesiniz, İdeal Kilonuz: " + idealkilo.ToString("f2") + "Kg Olmalı");
}
