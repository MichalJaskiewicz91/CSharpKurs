using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    public class Diary
    {
        public Diary()
        {
            //inicjalizacja listy
            ratings = new List<float>();
            count++;
        }
        //Stan(zmienne - pola)
        private List<float> ratings;
        public static float minGrade = 0;
        public static float maxGrade = 10;
        public static long count = 0;
        public string Name;

        //Zachowania
        public void addRating(float rating)
        {
            if (rating >= 0 && rating <= 10)
            {
                ratings.Add(rating);
            }
        }
        public DiaryStatistics computeStatistics()
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
