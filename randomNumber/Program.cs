//1-100 arasında tutulan 
// 3 hakı olsun
// kullanıcıdan1 sayı al
// // tutuğu sayılarla karşılaştır
// tekrar oynama hakı ver
do
{
    int tutulan = (new Random()).Next(1, 10);
    int hak = 3;
    int sayı;
    int sayac = 0;
    double hakPuan = 3 / hak;

    while (0 < hak)
    {
        sayac++;
        Console.WriteLine($"{sayac}.Sayı gir:");
        sayı = int.Parse(Console.ReadLine());

        hak -= 1;

        if (sayı == tutulan)
        {
            double puan = 100 - (hakPuan * (hak - 1));

            Console.WriteLine($"{tutulan} Doğru tahmin.. {Environment.NewLine}{sayac} hakınızda bildiniz bundan dolayı puanınız: {puan}");
            break;
        }

        else
        {
            if (hak == 0) break;

            if (tutulan > sayı) { Console.WriteLine("Yukarı"); }

            else { Console.WriteLine("Asagı"); }

        }
    }
    Console.WriteLine("Oyun bittii");


    Console.WriteLine($"Tekrak oynamak ister misin? {Environment.NewLine}  Y/N secmen yeterli.. ");
    string result = Console.ReadLine();
    if (result == "N" || result == "n") { break; }

} while (true);