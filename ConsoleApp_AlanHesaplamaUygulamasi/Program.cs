using System;

namespace ConsoleApp_AlanHesaplamaUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            int secim;

            do
            {
                MenuYaz();

                Console.WriteLine("Seçiminiz : ");
                secim = int.Parse(Console.ReadLine());

                switch (secim) 
                {
                    case 1:
                        // Kare alan hesaplama
                        KareAlanHesaplama();
                        break;

                    case 2:
                        // Dikdörtgen alan hesaplama
                        DikdörtgenAlanHesaplama();
                        break;

                    case 3:
                        // Üçgen alan hesaplama
                        UcgenAlanHesaplama();
                        break;

                    case 4:
                        // Yamuk alan hesaplama
                        YamukAlanHesaplama();
                        break;

                    default:
                        break;
                }
            } while (secim != 0);
        }

        static void MenuYaz()
        {
            Console.Clear();

            EkranaBaslikYaz("Alan Hesaplama Uygulaması");
            EkranaBaslikYaz("Menü");
            Console.WriteLine("1) Kare Alanı Hesapla");
            Console.WriteLine("2) Dikdörtgen Alanı Hesapla");
            Console.WriteLine("3) Üçgen Alanı Hesapla");
            Console.WriteLine("4) Yamuk Alanı Hesapla");
            Console.WriteLine("0) Çıkış");
            Console.WriteLine();
        }

        static void EkranaBaslikYaz(string baslik)
        {
            Console.WriteLine(baslik);

            for (int i = 0; i < baslik.Length; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        static void DevamUyarisi()
        {
            Console.WriteLine();
            Console.WriteLine("Lütfen devam etmek için bir tuşa basınız.");
            Console.ReadKey();
        }

        static void KareAlanHesaplama()
        {
            Console.Clear();

            EkranaBaslikYaz("Kare Alan Hesaplama");

            Console.Write("Lütfen a kenar uzunluğu giriniz(cm) : ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Kare alanı : " + (a * a));

            DevamUyarisi();
        }

        static void DikdörtgenAlanHesaplama()
        {
            Console.Clear();

            EkranaBaslikYaz("Dikdörtgen Alan Hesaplama");

            Console.Write("Lütfen a kenar uzunluğu giriniz(cm) : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Lütfen b kenar uzunluğu giriniz(cm) : ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dikdörtgen alanı : " + (a * b));

            DevamUyarisi();
        }

        static void UcgenAlanHesaplama()
        {
            Console.Clear();

            EkranaBaslikYaz("Üçgen Alan Hesaplama");

            Console.Write("Lütfen a kenar uzunluğu giriniz(cm) : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Lütfen h yükseklik giriniz(cm) : ");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Üçgen alanı : " + (Convert.ToDouble(a) * Convert.ToDouble(h) / 2d));

            DevamUyarisi();
        }

        static void YamukAlanHesaplama()
        {
            Console.Clear();

            EkranaBaslikYaz("Yamuk Alan Hesaplama");

            Console.Write("Lütfen a kenar uzunluğu giriniz(cm) : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Lütfen b kenar uzunluğu giriniz(cm) : ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Lütfen h yükseklik giriniz(cm) : ");
            int h = int.Parse(Console.ReadLine());

            double sub = (Convert.ToDouble(a) + Convert.ToDouble(b)) / 2d;
            double result = sub * Convert.ToDouble(h);

            Console.WriteLine();
            Console.WriteLine("Yamuk alanı : " + result);

            DevamUyarisi();
        }
    }
}