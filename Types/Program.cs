﻿using System;
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

            string name1 = "Marcin";
            string name2 = "marcin";

            bool areEqual = name1.Equals(name2,StringComparison.CurrentCulture);
            Console.WriteLine(areEqual);
            Console.ReadLine();
        }
    }
}