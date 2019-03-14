using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
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

        //Zachowania
        public void addRating(float rating)
        {
            ratings.Add(rating);
        }
        internal DiaryStatistics computeStatistics()
        {
            DiaryStatistics stats = new DiaryStatistics();

            float sum = 0;
            foreach (var rating in ratings)
            {
                sum += rating;
            }
            stats.averageGrade = sum / ratings.Count();
            stats.maxGrade = ratings.Max();
            stats.minGrade = ratings.Min();

            return stats;
            
        }
    }
}
