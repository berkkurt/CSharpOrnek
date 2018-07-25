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
            
            Console.Write("Cumleyi Girin : ");  // Kullanıcıdan kelimeler veya cümle
            cumle = Console.ReadLine();         // girişi alıyoruz.
            
            string[] kelimeler = cumle.Split(' '); // Ayırma işlemi için split kullanılır. 
                                                   // Boşluk karakteri yapınca onu 1 kelime sayıyor.
            
            Console.WriteLine(kelimeler.Length);
            
            Console.ReadKey();
        }
    }
}
