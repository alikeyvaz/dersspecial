using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evtapsiriqispacial
{
    public class Telefon
    {
        public string ad;
        public string soyad;
        public string telefon_markasi;
        public string menu;
        public int yaddas;
        public int qiymet;
        public int maas;


        public void shexsimelumatlar()
        {
            Console.WriteLine("adiniz: " + ad);
            Console.WriteLine("soyad: " + soyad);
            // Console.WriteLine("maasiniz: " + maas);
        }

        public void Telefomelumatlari()
        {
            Console.WriteLine("Telefon markasi: " + telefon_markasi);
            Console.WriteLine("Menyusu: " + menu);
            Console.WriteLine("Yaddasi: " + yaddas);
            Console.WriteLine("qiymeti: " + qiymet);
        }

        public void alinabiler()
        {
            if (maas > qiymet)
            {
                Console.WriteLine("Ala bilerse!!!!!!!");
            }
            else
            {
                Console.WriteLine("Ala bilmezsen!!!!!!!");
            }
        }

        // public Telefon (string ad, string soyad,string telefonMarkasi, string menu, int yaddas, int maas, int qiymet)
        // {
        //     //burani yaza bilmedim!!!
        // }



    }
}