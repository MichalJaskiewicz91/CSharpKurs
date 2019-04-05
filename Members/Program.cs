using Members;
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

            diary.NameChanged += OnNameChanged;
            diary.NameChanged += OnNameChanged2;
            diary.NameChanged += OnNameChanged3;
            diary.NameChanged += OnNameChanged3;
            diary.NameChanged += OnNameChanged3;
            diary.NameChanged += OnNameChanged3;
            //diary.NameChanged -= OnNameChanged3;



            diary.Name = "lol";
            diary.Name = "sdad";





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
