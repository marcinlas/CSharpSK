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

                float rating = float.Parse(Console.ReadLine());


                if (rating == 11)
                {
                    break;
                }

                diary.AddRating(rating);


                Console.WriteLine("Średnia Twoich ocen to: " + diary.CalculateAverage());
                Console.WriteLine("Najwyższa ocena to: " + diary.GiveMaxRating());
                Console.WriteLine("Najniższa ocena to: " + diary.GivenMinRating());
                Console.ReadKey();

            }
        }
    }
}
