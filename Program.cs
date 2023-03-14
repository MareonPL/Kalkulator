using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args) 
        {
            Run();
        }

        static void Run()
        {
            int wybór;
            while (true)
            {
                Menu();
                wybór = int.Parse(Console.ReadLine());
                switch (wybór)
                {
                    case 1:
                        Obliczenia.Suma();
                        break;
                    case 2:
                        Obliczenia.Róznica();
                        break;
                    case 3:
                        Obliczenia.Iloczyn();
                        break;
                    case 4:
                        Obliczenia.Iloraz();
                        break;
                    case 5:
                        Obliczenia.Potęga();
                        break;
                    case 6:
                        Obliczenia.Pierwiastek();
                        break;
                    case 7:
                        throw new Exception("koniec");
                }
            }
        }

        static void Menu()
        {
            Console.WriteLine("\n\t\t====================");
            Console.WriteLine("\t\t==== Kalkulator ====");
            Console.WriteLine("\n\t\t====================");
            Console.WriteLine("\t\t 1. Suma\n\t\t 2. Różnica \n\t\t 3. Iloczyn \n\t\t 4. Iloraz \n\t\t 5. Potęga \n\t\t 6. Pierwiastek \n\t\t 7. Zakończ");
        }
    }
}
