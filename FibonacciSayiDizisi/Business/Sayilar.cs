using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Sayilar
    {
        public static int Islem(int indeks)
        {
            int[] ciktilar = new int[indeks+1];
            int sonuc = 1;
            int eskisayi = 0;
            int sayi = 1;
            for (int i = 0; i <= indeks; i++)
            {
                ciktilar[i] = sonuc;
                sonuc = eskisayi + sayi;
                eskisayi = sayi;
                sayi = sonuc;
            }

            int indeksdekirakam = ciktilar[indeks];
            return indeksdekirakam;
        }
    }
}
