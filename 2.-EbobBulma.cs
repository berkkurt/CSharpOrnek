using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbobBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İlk sayıyı giriniz: ");
            int sayi_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz: ");
            int sayi_2 = Convert.ToInt32(Console.ReadLine());
            int ebob = 1;
            int bolen = 2;
            while (sayi_1 > 1 || sayi_2 > 1)
            {
                // Sayilardan her ikiside, bolen 
                // degiskenine bolundugu takdirde, 
                // obeb hesabina katilir.
                if (sayi_1 % bolen == 0 && sayi_2 % bolen == 0)
                {
                    ebob *= bolen;
                    sayi_1 /= bolen;
                    sayi_2 /= bolen;
                }
                else if (sayi_1 % bolen == 0)
                {
                    sayi_1 /= bolen;
                }
                else if (sayi_2 % bolen == 0)
                {
                    sayi_2 /= bolen;
                }
                else
                {
                    bolen++;
                }
            }
            Console.WriteLine("Verilen sayıların ebob'u ; ");
            Console.WriteLine(ebob);
            Console.ReadKey();
        }
    }
}
