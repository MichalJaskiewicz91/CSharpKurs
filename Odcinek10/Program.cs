using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odcinek10
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            diary.addRating(3);
            diary.addRating(5);

            Diary diary1 = diary;
            diary1.addRating(8);

            Diary diary2 = diary1;
            diary2.addRating(1);

;        }

    }
}
