// Kullanıcıya mağazaya hoş geldiniz mesajını verir
Console.WriteLine("Rüya Manavına Hoş Geldiniz!");

// Meyve fiyatlarını ekrana yazdırır
Console.WriteLine("Elma = 2 TL");
Console.WriteLine("Armut = 3 TL");
Console.WriteLine("Çilek = 2 TL");
Console.WriteLine("Muz = 3 TL");
Console.WriteLine("Diğer bütün meyveler = 4 TL");

// Kullanıcıdan meyve seçmesini ister
Console.WriteLine("Hangi meyveyi satın almak istersiniz? (Elma/Armut/Çilek/Muz/Diger): ");
string urun = Console.ReadLine(); // Kullanıcının seçimini okur

// Kullanıcının girdiği meyve adını küçük harfe dönüştürür
urun = urun.ToLower();

// Kullanıcının seçimine göre fiyat bilgisini verir
switch (urun)
{
    case "elma":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL"); // Elma için fiyat
        break;
    case "armut":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL"); // Armut için fiyat
        break;
    case "çilek":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL"); // Çilek için fiyat
        break;
    case "muz":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL"); // Muz için fiyat
        break;
    default:
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL"); // Diğer meyveler için fiyat
        break;
}


if (urun == "elma")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
}
else if (urun == "armut")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
}
else if (urun == "çilek")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
}
else if (urun == "muz")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
}
else
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL");
}
// Bence switch case kullanımı bu çalışma için daha doğru oalcaktır.Çünkü kullanıcı bazlı bir seçim mevcut.Eğer şarta bağlı seçim olsaydı if daha doğru olabilirdi.