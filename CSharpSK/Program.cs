using System;

namespace CSharpSK
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();   // sprawdza wertości min i max typów w C#

            for (; ; )
            {
                Greeting();
                Age();
                Settings();
            }
        }

        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt: " + maxInt);
            Console.WriteLine("minInt: " + minInt);
            Console.WriteLine("maxLong: " + maxLong);
            Console.WriteLine("minLong: " + minLong);
        }

        /// <summary>
        /// Ustawienia
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
        
        /// <summary>
        /// Zapytanie o wiek
        /// </summary>
        private static void Age()
        {
            Console.Write("Podaj wiek: ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Witaj, jesteś pełnoletni! :)");
            }
            else if (result == false)
            {
                Console.WriteLine("Wprowadziles niepoprawny wiek!");
            }
            else
            {
                Console.WriteLine("Nie nazywasz się Marcin i coś tam!");
            }
        }
       
        /// <summary>
       /// Powitanie użytkownika
       /// </summary>
        private static string Greeting()
        {
            Console.Write("Podaj imię: ");
            string name = Console.ReadLine();
            Console.WriteLine("Witaj " + name);
            return name;
        }
    }
}
