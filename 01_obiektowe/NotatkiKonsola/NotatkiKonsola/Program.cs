using System;

namespace NotatkiKonsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notatka pierwszaNotatka = new Notatka(
                "Gotowanie",
                "Ugotowac zupe ogorkowa."
            );

            Notatka drugaNotatka = new Notatka(
                "Nauka jezyka polskiego",
                "Powtorzyc Mloda Polske."
            );

            Console.WriteLine("PIERWSZA NOTATKA");
            pierwszaNotatka.wyswietl();
            Console.WriteLine($"Identyfikator: {pierwszaNotatka.identyfikator}");
            Console.WriteLine();

            Console.WriteLine("Diagnostyka:");
            pierwszaNotatka.diag();
            Console.WriteLine();

            Console.WriteLine("DRUGA NOTATKA");
            drugaNotatka.wyswietl();
            Console.WriteLine($"Identyfikator: {drugaNotatka.identyfikator}");
            Console.WriteLine();

            Console.WriteLine("Diagnostyka:");
            drugaNotatka.diag();

            Console.WriteLine();

            Console.WriteLine(
                $"Liczba utworzonych notatek: " +
                $"{Notatka.liczbaNotatek}"
            );

            Console.WriteLine();
            Console.WriteLine(
                $"Pierwszy obiekt ma identyfikator 1: " +
                $"{pierwszaNotatka.identyfikator == 1}"
            );

            Console.WriteLine(
                $"Drugi obiekt ma identyfikator 2: " +
                $"{drugaNotatka.identyfikator == 2}"
            );
        }
    }
}