using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// C# Metotları Aşırı Yükleme (Overloading) örneğidir.

namespace ConsoleApplication8
{
    class Program
    {
        static int ortalama(int yazili1, int yazili2) // İlk kullanımında metodumuz 2 değer alıyor.
        {
            int sonuc = (yazili1 + yazili2) / 2;
            return sonuc;
        }


        static int ortalama(int yazili1, int yazili2, int sozlu) // İkinci kullanımında metodumuz artık 3 değer alıyor.
        {                                                        // Metodumuza ikinci bir kullanım katarak aşırı yükledik.
            int sonuc = (yazili1 + yazili2 + sozlu) / 3;
            return sonuc;
        }

        static int ortalama(int yazili1, int yazili2, int sozlu, int odev) // Üçüncü kullanımında ise metodumuz 4 değer alıyor.
        {                                                                  //Metodumuza son olarak bir kullanım daha ekleyip aşırı yüklemiş olduk.
            int sonuc = (yazili1 + yazili2 + sozlu + odev) / 4;
            return sonuc;
        }

        static void Main(string[] args)
        {

            Console.WriteLine(ortalama(100, 100));
            Console.WriteLine(ortalama(100, 100, 100));
            Console.WriteLine(ortalama(100, 100, 100, 100));

            Console.ReadKey();
        }



    }
}
