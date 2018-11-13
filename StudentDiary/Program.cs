using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            diary.AddRating(5);
            diary.AddRating(8.5f);
            diary.AddRating(4.7f);

            float avg = diary.CalculateAverage();
            float max = diary.GiveMaxRating();
            float min = diary.GivenMinRating();

            for (; ; )
            {
                Console.WriteLine("Podaj ocenę z zakresu 1 - 10"); 

                float rating;
                bool result = float.TryParse(Console.ReadLine(), out rating);

                if (rating == 11)
                {
                    break;
                }

                if (result)
                {
                    if (rating > 0 && rating <= 10)
                    {
                        diary.AddRating(rating);
                    }
                    else
                    {
                        Console.WriteLine("Niepoprawna liczba, podaj liczbe z zakresu 1-10");
                    }
                    diary.AddRating(rating);
                }

                diary.AddRating(rating);

                Console.WriteLine("Średnia Twoich ocen to: " + diary.CalculateAverage());
                Console.WriteLine("Najwyższa ocena to: " + diary.GiveMaxRating());
                Console.WriteLine("Najniższa ocena to: " + diary.GivenMinRating());
                Console.ReadKey();

                Diary diary2 = new Diary();
                Diary diary3 = new Diary();
                Diary diary4 = new Diary();
                Diary diary5 = new Diary();
            }
        }
    }
}