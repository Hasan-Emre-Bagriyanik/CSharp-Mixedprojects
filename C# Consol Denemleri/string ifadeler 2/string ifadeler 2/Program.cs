using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_ifadeler_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string isim, meslek, sehir;

            Console.Write("isminizi giriniz: ");
            isim = Console.ReadLine();

            Console.Write("mesleginizi giriniz: ");
            meslek = Console.ReadLine();

            Console.Write("sehirinizi giriniz: ");
            sehir = Console.ReadLine();

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("isim - meslek - sehir:  {0} - {1} - {2}", isim, meslek, sehir);

            Console.Read();

        }
    }
}
