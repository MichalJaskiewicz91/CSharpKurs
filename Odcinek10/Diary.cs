using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odcinek10
{
    class Diary
    {
        public Diary()
        {
            //inicjalizacja listy
            ratings = new List<float>();
        }
        //Stan(zmienne - pola)
        List<float> ratings;
        /// <summary>
        /// adding ratings
        /// </summary>
        //Zachowania
        public void addRating(float rating)
        {
            ratings.Add(rating);
        }
        /// <summary>
        /// calculating average of ratings
        /// </summary>
        public float calculateAverage()
        {
            float sum = 0, avg = 0;
            foreach (var rating in ratings)
            {
                sum += rating;
            }
            return avg = sum / ratings.Count();
        }
        /// <summary>
        /// getting minimum value 
        /// </summary>
        public float getMinimum()
        {
            return ratings.Min();

        }
        /// <summary>
        /// getting maximum value 
        /// </summary>
        public float getMaximum()
        {
            return ratings.Max();
        }

    }
}
