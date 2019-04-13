using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    class Program
    {
        private static int age;
        private static string name;
        static int[] ages = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        static void Main(string[] args)
        {
            int[] ages = { 1, 2, 3, 4, 5, 6, 7, 8,9,10 };

        
            CheckAges(ages);

            Console.ReadKey();
        }
        #region privat methods
        private static void MethodJumps()
        {
            foreach (var age in ages)
            {
                if (age == 2)
                {
                    Console.WriteLine("Age is : {0}", age);
                    continue;
                    Console.WriteLine("Hello");
                }
                if (age == 4)
                {
                    Console.WriteLine("Age is : {0}", age);
                    break;
                    Console.WriteLine("Hello");
                }
            }

            foreach (var age in ages)
            {
                if (age == 2)
                {
                    Console.WriteLine("Age is : {0}", age);
                    goto skip;
                    Console.WriteLine("Hello");
                }
            }

        skip:
            Console.WriteLine("Hello");
        }

        private static void CheckAges(int[] ages)
        {
            foreach (var age in ages)
            {
                if (age == 3)
                {
                    Console.WriteLine(age);
                    return;
                }
            }
        }

        private static void MethodFor()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int a = 0; a < 2; a++)
                {
                    Console.WriteLine("Amount i : {0} and Amount a : {1}", i, a);
                }
                Console.WriteLine("Amount : {0}", i);
            }
        }

        private static void MethodSwitch()
        {
            Console.WriteLine("Input your name");
            name = Console.ReadLine();
            // Instruction switch
            switch (name)
            {
                case "Marcin":
                    method1();
                    break;
                case "Tomek":
                    method2();
                    method3();
                    break;
                default:
                    method4();
                    break;
            }
        }

        private static void MethodIf()
        {
            Console.WriteLine("Input your age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Input your name");
            name = Console.ReadLine();

            string test = age > 18 ? "Pełnoletni" : "Dziecko";
            Console.WriteLine(test);
            if (age <= 10)
            {
                if (name == "Marcin")
                {
                    method1();
                }
            }
            else if (age < 20)
            {
                method2();
            }
            else if (age < 30)
            {
                method3();
            }
            else
            {
                method4();
            }
        }

        private static void method4()
        {
            Console.WriteLine("You are in method 4");
        }

        private static void method3()
        {
            Console.WriteLine("You are in method 3");
        }

        private static void method2()
        {
            Console.WriteLine("You are in method 2");
        }

        private static void method1()
        {
            Console.WriteLine("You are in method 1 ");
        }
        #endregion
    }
}
