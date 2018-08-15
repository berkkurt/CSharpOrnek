using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpimTablosu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Girilen sayının çarpım tablosunu bulan program. ----- \n");

            Console.WriteLine("Çarpım tablosu istenen sayıyı giriniz : ");
            
            int sayi = int.Parse(Console.ReadLine());  // Girilen sayi,sayi adlı değişkene atandı.
            
            Console.WriteLine("\n----- " + sayi + " sayısının çarpım tablosu -----\n");
            
            for (int i = 1; i <= 10 ; i++)
                Console.WriteLine(sayi + " x " + i + " = " + sayi * i);  // Çarpım tablosunun ekrana yazdırıldığı kısım.

            Console.ReadKey();
        }
    }
}
