using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32DersOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            //1589 9851
            int duzSayi;
            int tersSayi = 0;
            Console.Write("Lutfen tersten yazdirmak istediginiz sayiyi giriniz...");
            duzSayi = int.Parse(Console.ReadLine());

            while (duzSayi > 0)
            {
                tersSayi *= 10;
                tersSayi += (duzSayi % 10);
                duzSayi /= 10;

            }

            Console.WriteLine("Ters sayi: {0} ", tersSayi);
        }
    }
}
