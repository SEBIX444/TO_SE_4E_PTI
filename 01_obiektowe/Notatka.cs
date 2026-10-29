using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace NotatkiKonsola
{
    /* 
     * Nazwa klasy: Notatka
     * Opis: Klasa reprezentuje pojedynczą notatkę zawierającą tytuł i treść.
     * Pola:
     * - licznik - statyczny licznik utworzonych notatek,
     * - id - numer indentyfikacyjny notatki,
     * - tytul - tytuł notatki,
     * - tresc - treść notatki.
     * Metody:
     * - wyswietl() - wyświetla identyfikator, tytuł i treść notatki,
     * - diag() - wyświetla wszystkie pola oddzielone średnikami.
     * Numer autora: 19
     * Autor: Sebastian Tomczyk
     */
    class Notatka
    {
        private static int licznik = 0;
        private int id;
        protected string tytul;
        protected string tresc;

        public int identyfikator
        {
            get { return id; }
        }
        public static int liczbaNotatek
        {
            get { return licznik; }
        }

        public Notatka(string tytul, string tresc)
        {
            licznik++;
            id = licznik;
            this.tytul = tytul;
            this.tresc = tresc;
        }

        public void wyswietl()
        {
            Console.WriteLine($"Tytul: {tytul}");
            Console.WriteLine($"Tresc: {tresc}");
        }

        public void diag()
        {
            Console.WriteLine($"Identyfikator: {id}; " + $"Tytul: {tytul}; " + $"Tresc: {tresc}");
        }
    }
}
