﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HipotenusBulma
{
    class Program
    {
        static void Main(string[] args)
        {

            double k1, k2, hipotenus;
            
            Console.Write("Birinci Dik Kenarı Girin....:");
            k1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("İkinci Dik Kenarı Girin....:");
            k2 = Convert.ToDouble(Console.ReadLine());
            
            //k1 ve k2'nin kareleri toplamını yapıp karekökünü alıyoruz.
            
            hipotenus = Math.Sqrt((k1 * k1) + (k2 * k2));
            
            //Karekök alma işlemi Mat.sqrt ile gerçekleştirilir.
            
           
            Console.WriteLine("Hipotenüs değeri....:{0}", hipotenus);
            Console.ReadKey();



        }
    }
}
