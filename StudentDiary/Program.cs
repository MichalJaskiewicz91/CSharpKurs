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
            
            diary.addRating(5);
            diary.addRating(8.5f);
            diary.addRating(4.7f);
            diary.addRating(7.5f);
            diary.addRating(4.7f);
            diary.addRating(10f);

            DiaryStatistics stats = diary.computeStatistics();

        }
    }
}
