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
            foreach (string names in args)
            {
                Console.WriteLine(names);
            }
        }   
    }
}
