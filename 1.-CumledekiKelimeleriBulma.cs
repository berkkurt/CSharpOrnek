using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            string cumle;
            Console.Write("Cumleyi Girin : ");  // Kullanıcıdan cümle
            cumle = Console.ReadLine();         // alıyoruz.
            string[] kelimeler = cumle.Split(' '); // Ayırma işlemi için split kullanılır.
            Console.WriteLine(kelimeler.Length);
            Console.ReadKey();
        }
    }
}
