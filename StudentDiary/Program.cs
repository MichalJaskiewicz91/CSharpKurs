using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void giveName(ref Diary diary)
        {
            diary = new Diary();
            diary.Name = "dzienniczek maraaacina";
        }

        static void IncrementNUmber(out int number)
        {
            number = 41;
        }
        static void Main(string[] args)
        {

            //Diary diary = new Diary();

            //diary.addRating(5);
            //diary.addRating(8.5f);
            //diary.addRating(4.7f);
            //diary.addRating(11f);


            //DiaryStatistics stats = diary.computeStatistics();

            //Diary diary10 = new Diary();
            //Diary diary5 = new Diary();
            //Diary diary6 = new Diary();
            //Diary diary7 = new Diary();
            //Diary diary8 = new Diary();
            //Diary diary9 = new Diary();

            //Console.WriteLine(Diary.count);

            Diary d1 = new Diary();
            Diary d2 = d1;
            

            giveName(ref d2);
            Diary d3 = d2;
            Console.WriteLine(d3.Name);


            int x1;
            IncrementNUmber(out x1);
            Console.WriteLine(x1);
            Console.ReadLine();
        }
    }
}
