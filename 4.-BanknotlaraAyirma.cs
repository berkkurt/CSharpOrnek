using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanknotlaraAyirma
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] banknot = { 200, 100, 50, 20, 10, 5, 1 }; // Banknotlar,bir dizinin içerisinde tanımlandı.
            int para, adet, i;
            
            Console.Write("Ödeme yapılacak olan tutarı girin: ");
            para = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("--------------------------------------");
            
            for (i = 0; i <= 6; i++)
            {
              adet = para / banknot[i];
              if (adet != 0)
                Console.WriteLine(adet.ToString() + " adet : " + Convert.ToString(banknot[i] + " TL "));
              para %= banknot[i];
            }
            Console.ReadKey();
        }
    }
}
