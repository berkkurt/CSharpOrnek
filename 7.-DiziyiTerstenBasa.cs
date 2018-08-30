using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziyiTerstenBasa
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strDizi = { "Ali", "Buğra", "Gözde", "Hakan", "Seda" }; // Dizi ve içerisine elemanlar tanımlandı.
            int son = strDizi.Length - 1; // int son değerine dizinin son karakteri atandı.
            
            for (int i = son; i >= 0; --i)
            {
                Console.WriteLine(strDizi[i]);
            }
            
            Console.Readline();
        }
    }
}
