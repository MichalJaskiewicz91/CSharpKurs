﻿using System;
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
        public float calculateAverage()
        {
            float sum = 0, avg = 0;
            foreach (var rating in ratings)
            {
                sum += rating;
            }
            return avg = sum / ratings.Count();
        }
        public float getMinimum()
        {
            return ratings.Min();

        }
        public float getMaximum()
        {
            return ratings.Max();
        }

    }
}
