using Members;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diary diary = new Diary();

            //diary.NameChanged += OnNameChanged;

            //try
            //{
            //    Console.WriteLine("Please input quantity");
            //    diary.Name = Console.ReadLine();
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (NullReferenceException)
            //{
            //    Console.WriteLine("Something went wrong!");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{

            //}
            //diary1.NameChanged += OnNameChanged2;

            //diary.NameChanged += OnNameChanged2;
            //diary.NameChanged += OnNameChanged3;
            //diary.NameChanged += OnNameChanged3;
            //diary.NameChanged += OnNameChanged3;
            //diary.NameChanged += OnNameChanged3;
            //diary.NameChanged -= OnNameChanged3;
            //string lol = diary.Name;
            //Console.WriteLine(lol);
            //diary1.Name = "sdad";

            StreamWriter file = new StreamWriter("D:\\General\\plik.txt", true);
            try
            {
                Console.WriteLine("Enter text");
                string lal = Console.ReadLine();
                file.WriteLine(lal);
                file.WriteLine("Hey we entering to file txt");
            }
            finally
            {
                file.Close();
            }

            using (StreamWriter file2 = new StreamWriter("D:\\General\\plik.txt", true))
            {
                file2.WriteLine("Hey we entering to file txt!!!!!!!!!!!!");
            }


            Console.ReadKey();
        }

        private static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Zmiana nazwy z {args.ExistingName} na {args.NewName}");
        }
        private static void OnNameChanged2(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("ssssssssss");
        }
        private static void OnNameChanged3(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("helo");
        }
        private static void OnNameChanged4(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("+++");
        }

    }
}
