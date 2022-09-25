using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consola_giris_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad, yas, meslek, sehir;

            Console.Write("adi: ");
            ad = Console.ReadLine();

            Console.Write("soyad: ");
            soyad = Console.ReadLine();

            Console.Write("yas: ");
            yas = Console.ReadLine();

            Console.Write("meslek: ");
            meslek = Console.ReadLine();

            Console.Write("sehir: ");
            sehir = Console.ReadLine();

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("adi: " + ad);
            Console.WriteLine("sayadi: " + soyad);
            Console.WriteLine("yasi: " + yas);
            Console.WriteLine("meslegi: " + meslek);
            Console.WriteLine("sehiri: " + sehir);

            Console.Read();


        }
    }
}
