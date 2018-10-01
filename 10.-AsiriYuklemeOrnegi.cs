using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static int ortalama(int yazili1, int yazili2)
        {
            int sonuc = (yazili1 + yazili2) / 2;
            return sonuc;
        }


        static int ortalama(int yazili1, int yazili2, int sozlu)
        {
            int sonuc = (yazili1 + yazili2 + sozlu) / 3;
            return sonuc;
        }

        static int ortalama(int yazili1, int yazili2, int sozlu, int odev)
        {
            int sonuc = (yazili1 + yazili2 + sozlu + odev) / 4;
            return sonuc;
        }




        static void Main(string[] args)
        {

            Console.WriteLine(ortalama(50, 60));
            Console.WriteLine(ortalama(50, 80, 90));
            Console.WriteLine(ortalama(50, 40, 90, 100));

            Console.ReadKey();
        }



    }
}


/* C# Metotları Aşırı Yükleme (Overloading) örneğidir.Metodun 3 kullanımı vardır. 
Burada ortalama metodumuz; 
 1-hem 2 yazılı,
 2-hem 2 yazılı ve 1 sözlü 
 3-hem de 2 yazılı,1 sözlü ve 1 ödev notu 
    değerlerini alabilmektedir.
*/
