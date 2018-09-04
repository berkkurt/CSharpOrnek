using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukKucukToplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, s3, buyuk, kucuk;
            Console.WriteLine("3 sayı gireceksiniz ve sonra e büyüğü,en küçüğü son olarak en büyük ile küçük toplamını alacaksınız.\n ");

            Console.Write("Birinci sayıyı girin; ");
            s1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayıyı girin; ");
            s2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Üçüncü sayıyı girin; ");
            s3 = Convert.ToInt32(Console.ReadLine());


            if (s1 > s2 && s1 > s3)
                buyuk = s1;
            else if (s2 > s3)
                buyuk = s2;
            else
                buyuk = s3;

            
            
            if (s1 < s2 && s1 < s3)
                kucuk = s1;
            else if (s2 < s3)
                kucuk = s2;
            else
                kucuk = s3;


            Console.WriteLine("En büyük sayı: " + buyuk);
            Console.WriteLine("En küçük sayı: " + kucuk);
            Console.WriteLine("en büyük ile en küçük toplamı:{0} ", kucuk + buyuk);
            Console.ReadLine();

           
        }
    }
}
