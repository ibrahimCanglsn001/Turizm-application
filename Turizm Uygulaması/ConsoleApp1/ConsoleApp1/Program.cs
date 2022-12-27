using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double odenecekTutar = 0;
            int biletParası = 0;
            int aracTipi = 0;
            Console.WriteLine("      - 10-D Turizm'e Hoşgeldiniz -      ");
            Console.WriteLine("");
            System.Threading.Thread.Sleep(1000); // 1 Saniye Bekle
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("|                                                                                  |");
            Console.WriteLine("| Giriş Yapmak İçin 1'e tıklayınız                                                 |");
            Console.WriteLine("| Şirketimiz'in Kayıt Bölümü Arızalı Olduğu İçin Seçeneklerden Düzenleyebilirsiniz |");
            Console.WriteLine("|                                                                                  |");
            Console.WriteLine("------------------------------------------------------------------------------------");

            if (Console.ReadLine() == "1")
            {
                Console.Clear();
            bas1:
                Console.WriteLine("Kullanıcı Adı Giriniz ; ");
                if (Console.ReadLine() == "turizm")
                    Console.WriteLine("");
                {
                    Console.WriteLine("Şifre Giriniz");
                    if (Console.ReadLine() == "1234")
                        Console.WriteLine("");
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Lütfen Doğru Şifre Giriniz.");
                        goto bas1;
                    }
                    Console.WriteLine("Giriş Başarılı Yönlendiriliyorsunuz");
                    Console.WriteLine("");
                    Console.WriteLine("         | Yolculuk Yapmak İstediğiniz Aracı Seçiniz |          ");
                    Console.WriteLine("");
                    Console.WriteLine("Yolculuk Yapacağınız Toplu Taşıma Araçlarımız Aşağıdaki Seçeneklerde Mevcuttur :  ");
                    Console.WriteLine("");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("|                       |");
                    Console.WriteLine("|     1 - Otobüs        |");
                    Console.WriteLine("|     2 - Hızlı Tren    |");
                    Console.WriteLine("|                       |");
                    Console.WriteLine("-------------------------");
                    Console.Write(" Lütfen Kaç Numaralı Toplu Taşıma İle Yolculuk Yapmak İstediğinizi Seçiniz : ");
                    int aracTipi2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("|                                            |");
                    Console.WriteLine("|        1 - Arnavutköy Merkez Mahallesi.    |");
                    Console.WriteLine("|        2 - Atatürk Mahallesi.              |");
                    Console.WriteLine("|        3 - Baklalı Mahallesi.              |");
                    Console.WriteLine("|        4 - Bolluca Mahallesi.              |");
                    Console.WriteLine("|        5 - Hadımköy                        |");
                    Console.WriteLine("|                                            |");
                    Console.WriteLine("----------------------------------------------");

                    Console.Write(" Lütfen Kaç Numaralı Mahalleye Yolculuk Yapmak İstediğinizi Seçiniz : ");
                    aracTipi = Convert.ToInt32(Console.ReadLine());
                    Console.Write(" Lütfen Bu Mahalleye Yolculuk Yapmak İçin Kaç Tane Bilet Almak İstediğinizi Giriniz ? : ");
                    biletParası = Convert.ToInt32(Console.ReadLine());
                    if (aracTipi2 == 1)
                    {
                        odenecekTutar = biletParası * 500;
                    }
                    else if (aracTipi2 == 2)

                    {
                        odenecekTutar = biletParası * 400;
                    }

                }

                Console.WriteLine(" Ödenecek Tutar : {0} TL'dir 10-D Turizm'e Hoşgeldiniz  Kafe İyi Günler Diler... ", odenecekTutar);
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
