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
            Console.WriteLine("Ebob'u bulunacak ilk sayıyı giriniz: ");  
            int sayi_1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Ebob'u bulunacak ikinci sayıyı giriniz: ");
            int sayi_2 = Convert.ToInt32(Console.ReadLine());
            
            int ebob = 1;
            int bolen = 2;
            while (sayi_1 > 1 || sayi_2 > 1)
            {
                // Sayiların ikisi de, bölen degiskenine bolundugunde ebob hesabina katılmış olunur.
                
                if (sayi_1 % bolen == 0 && sayi_2 % bolen == 0)
                {
                    ebob =ebob * bolen;
                    sayi_1 =sayi_1 / bolen;
                    sayi_2 =sayi_2 / bolen;
                }
                else if (sayi_1 % bolen == 0)
                {
                    sayi_1 =sayi_1 / bolen;
                }
                else if (sayi_2 % bolen == 0)
                {
                    sayi_2 =sayi_2 / bolen;
                }
                else
                {
                    bolen++;
                }
            }
            Console.WriteLine("Verilen sayıların ebob'u ; {0} ",ebob);
            Console.ReadKey();
        }
    }
}
