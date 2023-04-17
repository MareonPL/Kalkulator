using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Obliczenia
    {
        public static void Suma()
        {
            Console.WriteLine("Podaj a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b");
            int b = int.Parse(Console.ReadLine());

            int wynik = a + b;
            Console.WriteLine($"Wynik obliczenia to: {wynik}");
        }

        public static void Róznica()
        {
            Console.WriteLine("Podaj a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b");
            int b = int.Parse(Console.ReadLine());

            int wynik = a - b;
            Console.WriteLine($"Wynik obliczenia to: {wynik}");
        }

        public static void Iloczyn()
        {
            Console.WriteLine("Podaj a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b");
            int b = int.Parse(Console.ReadLine());

            int wynik = a * b;
            Console.WriteLine($"Wynik obliczenia to: {wynik}");
        }

        public static void Iloraz()
        {
            Console.WriteLine("Podaj a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b");
            int b = int.Parse(Console.ReadLine());

            if (b == 0)
            {
                Console.WriteLine("Nie można podzielić przez 0!");
            } else {
                int wynik = a / b;
                Console.WriteLine($"Wynik obliczenia to: {wynik}");
            }
        }

        public static void Potęga()
        {
            Console.WriteLine("Podaj liczbę");
            int liczba = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj potęgę");
            int potęga = int.Parse(Console.ReadLine());

            int wynik = (int)Math.Pow(liczba, potęga);
            Console.WriteLine($"Wynik obliczenia to: {wynik}");
        }

        public static void Pierwiastek()
        {
            Console.WriteLine("Podaj liczbę");
            int liczba = int.Parse(Console.ReadLine());

            int wynik = (int)Math.Sqrt(liczba);
            Console.WriteLine($"Wynik obliczenia to: {wynik}");
        }

        public static void FunkcjaTrygometyczna()
        {
            Console.WriteLine("Podaj a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c:");
            int c = int.Parse(Console.ReadLine());

            int sin = a / c;
            int cos = b / c;
            int tg = a / b;
            int ctg = b / a;

            Console.WriteLine($"Wynik obliczenia to: (sin = {sin}, cos = {cos}, tg = {tg}, ctg = {ctg}.");
        }
    }
}
