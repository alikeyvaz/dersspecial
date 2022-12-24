using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evtapsiriqispacial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefon alan = new Telefon();
            alan.ad = "Alik";
            alan.soyad = "Eyvaz";
            // alan.maas = 900; 
            alan.telefon_markasi = "SAMSUNG";
            alan.menu = "Android";
            alan.yaddas = 256;
            alan.qiymet = 1300;

            while (true)
            {
                Console.WriteLine("Secim= ");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {
                    alan.shexsimelumatlar();
                }
                else if (secim == 2)
                {
                    alan.Telefomelumatlari();
                }
                else if (secim == 3)
                {
                    Console.WriteLine("Maas melumatlariniz");
                     alan.maas = Convert.ToInt32(Console.ReadLine());
                    alan.alinabiler();
                }
                else
                {
                    
                }
            }

        }

        
    }
}