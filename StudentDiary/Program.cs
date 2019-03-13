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
            //diary.addRating(5);
            //diary.addRating(8.5f);
            //diary.addRating(4.7f);
            //float avg = diary.calculateAverage();
            //float max = diary.getMaximum();
            //float min = diary.getMinimum();

            for (;;)
            {
                Console.WriteLine("Podaj ocene z zakresu: 1 - 10");
                float rating;
                bool isFloat = float.TryParse(Console.ReadLine(),out rating);

                if (rating == 11)
                {
                    break;
                }
                if (isFloat)
                {
                    if (rating > 0 && rating <= 10)
                    {
                        diary.addRating(rating);
                    }
                    else
                    {
                        Console.WriteLine("wrong quantity, input correct number from range 1-10");
                    }
                }
                
            }
            Console.WriteLine("Average: "+ diary.calculateAverage());
            Console.WriteLine("Maximum: "+ diary.getMaximum());
            Console.WriteLine("Minimum: "+ diary.getMinimum());
            Console.ReadLine();
        }
    }
}
