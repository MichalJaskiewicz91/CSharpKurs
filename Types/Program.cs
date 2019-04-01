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
            //PassByValueAndRef();

            //Immutable();

            ArraySegment();

            Console.ReadLine();
        }

        private static void ArraySegment()
        {
            float[] raitings = new float[3];

            addRaitings(raitings);

            float sum = 0;
            foreach (float raiting in raitings)
            {
                sum = sum + raiting;

            }
            Console.WriteLine(sum);
        }

        private static void addRaitings(float[] raitings)
        {
                if (raitings.Length >= 4)
                {
                raitings[0] = 3.6f;
                raitings[1] = 4.6f;
                raitings[2] = 5.6f;
                raitings[3] = 6.6f;
                }
        }




        /// <summary>
        /// Immutable
        /// </summary>
        private static void Immutable()
        {
            string name = " Marcin ";
            name = name.Trim();

            DateTime date = new DateTime(2019, 3, 10);
            date = date.AddHours(48);
            Console.WriteLine(date);
            Console.WriteLine(name);
        }

        private static void PassByValueAndRef()
        {
            Diary d1 = new Diary();

            //ref we have to initialize variable
            Diary d2 = d1;


            giveName(ref d2);
            Diary d3 = d2;
            Console.WriteLine(d3.Name);

            // out we don't have to initialize variable
            int x1;


            IncrementNUmber(out x1);
            Console.WriteLine(x1);
        }


    }
}
