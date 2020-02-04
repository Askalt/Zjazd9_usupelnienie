using System;
using System.Linq;

namespace Zjazd9_uzupelnienie
{
    public static class ExtensionMethods
    {
        public static (int liczba, int dzielnik) Reszta_z_dzielenia_Zad1(this int liczba_z,int dzielnik_z)
        {
            return (liczba_z / dzielnik_z, liczba_z % dzielnik_z);
        }
        public static int Szukaj_litery_zWyrazu(this string wyraz,char szukane)
        {
            int suma_znaku = 0;
            foreach (var item in wyraz)
            {
                if (item==szukane)
                {
                    suma_znaku++;
                }
            }
            return suma_znaku;
        }
        public static int Suma_grup_wiekowych(this GrupaWiekowa grupa)
        {
            return Enum.GetValues(typeof(GrupaWiekowa)).Cast<int>().Sum(x => x);
        }

    }

 
    internal class Program
    {
        static void Main(string[] args)
        {
            //int zadanie1 = 8;
            //string napis;
            ////ilosc znaku w wyrazie static int
            //napis = Console.ReadLine();
            //napis.Szukaj_litery_zWyrazu('a');     
            //Console.WriteLine($"Szukany znak w słowie:({napis.Szukaj_litery_zWyrazu('a')})");
            ////dzielenie z reszta 
            //zadanie1.Reszta_z_dzielenia_Zad1(2);
            //Console.WriteLine(zadanie1.Reszta_z_dzielenia_Zad1(2));
            //Enum grupa wiekowa zaiteresowania
            // Zad3_enum obj1 = new Zad3_enum("Jan", GrupaWiekowa.Dorosli, Zainteresowania.Komputer);
            var reklama = new Reklama("Witaj w ciemnym zaułku...", GrupaWiekowa.Dorosli|GrupaWiekowa.Młodzież, Zainteresowania.Komputer);
            for (var i = 0; i < GrupaWiekowa.Brak.Suma_grup_wiekowych(); i++) Console.WriteLine((GrupaWiekowa)i);



        }
    }



}
