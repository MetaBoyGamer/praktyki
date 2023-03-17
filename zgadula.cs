using System;

namespace Aplikacj_konsolowa_csharp
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Zgadnij liczbe od 0 - 9 \n");
            Random rand = new Random();
            int prawidlowa = rand.Next(0, 10);

            int liczba = int.Parse(Console.ReadLine());
            for (int i = 5; i >= 0; i--) {
                if (liczba != prawidlowa)
                {
                    Console.WriteLine("Nie zgadłeś\nPróbuj ponownie!\n");
                    liczba = int.Parse(Console.ReadLine());
                }
                else if (i == 0)
                {
                    Console.WriteLine("Przekroczono liczbe prób!\n :c");
                    break;
                }
                else if (liczba == prawidlowa)
                {
                    Console.WriteLine("Gratulacje zgadłeś!\nPrawidlowa liczba to {0}", prawidlowa);
                    break;
                }

            }
                
            }
        }
    }
