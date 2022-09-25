using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgi_Yarışması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************** BILGI YARISMASINA HOS GELDINIZ ******************");
            Console.Title = "Bilgi yarismasi";

            string ad, soyad;

            Console.Write("ad: ");
            ad = Console.ReadLine();

            Console.Write("soyad: ");
            soyad = Console.ReadLine();

            Console.WriteLine(" ");
            Console.WriteLine("baslıyoruz enter tusuna basın !!!");
            Console.WriteLine(" ");
            Console.WriteLine("Her yanittan sonra enter tusuna basmayi unutmayin !!!");
            Console.WriteLine(" ");
            Console.WriteLine("Yanitlari buyuk harflerle yazmayi unutmayin !!!");
            Console.WriteLine(" ");

            Console.Read();

            int dogru, yanlis, para;

            dogru = 0;
            yanlis = 0;
            para = 0;

            string soru1, cevap1;

            Console.WriteLine("soru 1: Cumhuriyet kac yilinda ilan edilmistir? ");
            soru1 =Convert.ToString(Console.ReadLine());
            Console.Write(" A)1920\n  B)1923\n  C)1924\n  D)1926\n  Cevabiniz: ");
            cevap1=Console.ReadLine();

            if(cevap1 == "B")
            {
                dogru =dogru + 1;
                para = para + 1000;
                Console.WriteLine("Tebrikler dogru cevap ");
                Console.WriteLine("devam etmek icin enter tusuna basin !!!");
                Console.Read();
            }
            else
            {
                yanlis = yanlis + 1;
                Console.WriteLine("Malesef yanlis cevap :(");
                Console.WriteLine("devam etmek icin enter tusuna basin !!!");
                Console.Read();
            }

            string soru2, cevap2;

            Console.WriteLine("Soru 2: Türkiye'nin baskenti neresidir? ");
            soru2= Convert.ToString(Console.ReadLine());
            Console.Write("A)İstanbul\n  B)Bursa\n  C)Ankara\n  D)Hatay\n  Cevabiniz: ");
            cevap2= Console.ReadLine();

            if(cevap2 == "C")
            {
                dogru = dogru + 1;
                para = para + 2000;
                Console.WriteLine("Tebrikler dogru cevap ");
                Console.WriteLine("devam etmek icin enter tusuna basin !!!");
                Console.Read();

            }
            else
            {
                yanlis = yanlis + 1;
                Console.WriteLine("Malesef yanlis cevap :(");
                Console.WriteLine("devam etmek icin enter tusuna basin !!!");
                Console.Read();
            }

            string soru3, cevap3;

            Console.WriteLine("Soru 3: Maki hangi bolgenin bitki ortusudur? ");
            soru3 = Convert.ToString(Console.ReadLine());
            Console.Write("A)Akdeniz Bolgesi\n  B)Karadeniz Bolgesi\n  C)Marmara Bolgesi\n  D)Ege Bolgesi\n  Cevabiniz: ");
            cevap3 = Console.ReadLine();

            if (cevap3 == "A")
            {
                dogru = dogru + 1;
                para = para + 3000;
                Console.WriteLine("Tebrikler dogru cevap ");
                Console.WriteLine("devam etmek icin enter tusuna basin !!!");
                Console.Read();

            }
            else
            {
                yanlis = yanlis + 1;
                Console.WriteLine("Malesef yanlis cevap :(");
                Console.WriteLine("devam etmek icin enter tusuna basin !!!");
                Console.Read();
            }

            string soru4, cevap4;

            Console.WriteLine("Soru 4: Hangisi programlamanin temel renklerinden degildir? ");
            soru4 = Convert.ToString(Console.ReadLine());
            Console.Write("A)Yesil\n  B)Kırmızı\n  C)Mavi\n  D)Sarı\n  Cevabiniz: ");
            cevap4 = Console.ReadLine();

            if ( cevap4 == "D")
            {
                dogru = dogru + 1;
                para = para + 4000;
                Console.WriteLine("Tebrikler dogru cevap ");
                Console.WriteLine("devam etmek icin enter tusuna basin !!!");
                Console.Read();

            }
            else
            {
                yanlis = yanlis + 1;
                Console.WriteLine("Malesef yanlis cevap :(");
                Console.WriteLine("devam etmek icin enter tusuna basin !!!");
                Console.Read();
            }


            string soru5, cevap5;

            Console.WriteLine("Soru 5: Asagidakilerden hangisi Hatay'in bir semti degildir? ");
            soru5 = Convert.ToString(Console.ReadLine());
            Console.Write("A)iskenderun\n  B)Nilufer\n  C)Payas\n  D)Antakya\n  Cevabiniz: ");
            cevap5 = Console.ReadLine();

            if (cevap5 == "B")
            {
                dogru = dogru + 1;
                para = para + 5000;
                Console.WriteLine("Tebrikler dogru cevap ");
                
            }
            else
            {
                yanlis = yanlis + 1;
                Console.WriteLine("Malesef yanlis cevap :(");
                
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Adiniz: " + ad);
            Console.WriteLine("Soyadiniz: " + soyad);
            Console.WriteLine("Dogru cevaplariniz: " + dogru);
            Console.WriteLine("Yanlis cevaplariniz: " + yanlis);
            Console.WriteLine("Kazandiginiz toplam para: {0} TL",para );
            Console.Read ();
        }
    }
}
