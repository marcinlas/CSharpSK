using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Diary
    {
        public Diary()    // stworzenie konstruktora przy uzycia snipietu ctor + 2x tab
        {
            ratings = new List<float>();
        }

        // Stan (zmienne - pola)
        List<float> ratings = new List<float>();

        // Zachowania
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }

        public float CalculateAverage()
        {
            float sum = 0, avg = 0;

            foreach (var rating in ratings)
            {
                sum = sum + rating;
            }

            avg = sum / ratings.Count();
            return avg;

        }
        public float GiveMaxRating()
        {
             return ratings.Max();
        }

        public float GivenMinRating()
        {
             return ratings.Min();
        }
    }
}
