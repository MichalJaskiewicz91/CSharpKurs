using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();
            for (; ; )
            {
                Greeting();
                Age();
                settings();
            }
        }
        /// <summary>
        /// Types of Values
        /// </summary>
        private static void ValueTypes()
        {
            int maxint = int.MaxValue;
            int minint = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;
            Console.WriteLine("maxint = " + maxint);
            Console.WriteLine("minint = " + minint);
            Console.WriteLine("maxLong = " + maxLong);
            Console.WriteLine("minLong = " + minLong);
        }

        /// <summary>
        /// setting needed settings
        /// </summary>
        private static void settings()
        {
            Console.ReadLine();
            Console.Clear();
            Console.ResetColor();
        }
        /// <summary>
        /// getting age from user
        /// </summary>
        private static void Age()
        {
            Console.WriteLine("Ile masz lat?: ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("mozesz napic sie browara");
            }
            else if (result == false)
            {
                Console.WriteLine("wrong age");
            }
            else
            {
                Console.WriteLine("Mozesz napic sie mleczka");
            }
        }
        /// <summary>
        /// prints greeting to user
        /// </summary>
        private static void Greeting()
        {
            Console.Write("Jak masz na imie?: ");
            string name = Console.ReadLine();
        }
    }
}
