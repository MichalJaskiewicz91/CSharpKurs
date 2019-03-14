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
            Diary diary1 = new Diary();
            //DiaryStatistics stats = diary.computeStatistics();


            //Diary diary = new Diary();
            diary.addRating(5);
            diary.addRating(8.5f);
            diary.addRating(4.7f);
            diary.addRating(7.5f);
            diary.addRating(4.7f);
            diary.addRating(10f);

            diary1.addRating(5);
            diary1.addRating(1.5f);
            diary1.addRating(1.7f);
            diary1.addRating(5.5f);
            diary1.addRating(4.7f);
            diary1.addRating(5f);
      

            //for (; ; )
            //{
            //    Console.WriteLine("Podaj ocene z zakresu: 1 - 10");
            //    float rating;
            //    bool isFloat = float.TryParse(Console.ReadLine(), out rating);

            //    if (rating == 11)
            //    {
            //        break;
            //    }
            //    if (isFloat)
            //    {
            //        if (rating > 0 && rating <= 10)
            //        {
            //            diary.addRating(rating);
            //        }
            //        else
            //        {
            //            Console.WriteLine("wrong quantity, input correct number from range 1-10");
            //        }
            //    }
            //}
       

            DiaryStatistics stats = diary.computeStatistics();
            Console.WriteLine("Average: " + stats.averageGrade);
            Console.WriteLine("Maximum: " + stats.maxGrade);
            Console.WriteLine("Minimum: " + stats.minGrade);
            Console.ReadLine();

            stats = diary1.computeStatistics();

            Console.WriteLine("Average: "+ stats.averageGrade);
            Console.WriteLine("Maximum: "+ stats.maxGrade);
            Console.WriteLine("Minimum: "+ stats.minGrade);
            Console.ReadLine();
        }
    }
}
