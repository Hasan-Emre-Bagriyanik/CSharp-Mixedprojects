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
            string isim;
            Console.WriteLine("isminizi giriniz: ");
            isim =Console.ReadLine();
            Console.WriteLine("hoş geldiniz"+ isim);
            Console.Read();
        }
    }
}
