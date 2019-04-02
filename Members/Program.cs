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
            diary.addRating(5.5f);
            diary.addRating(6.5f);
            diary.addRating(7.5f);

            DiaryStatistics stats = diary.computeStatistics();
            WriteResult("Average",stats.averageGrade,4,5,6,7);
            WriteResult("Max Value", (int)stats.maxGrade);
            WriteResult("Min Value", (long)stats.minGrade,2);
            WriteResult("Min Value", (float)stats.minGrade,1);

            Console.ReadKey();
        }
        static void WriteResult(string description, params float[] result)
        {
            Console.WriteLine(description + ": " + result[0] + " " + result[1] + " " + result[2] + " " + result[3]);
        }
        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }
        static void WriteResult(string description, long result)
        {
            Console.WriteLine(description + ": " + result);
        }
        static void WriteResult(string description, float result, long test)
        {
            Console.WriteLine("{0}"+ ": " + "{1:F2},{2:},{3},{4}", description,result,1,2,3);
        }
        static void WriteResult(string description, long result, long test)
        {
            Console.WriteLine($"{description},{result:F2},{2},{3},{4}");
        }
    }
}
