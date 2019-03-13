using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person person1 = new Person(1, "tomek");
            Person person2 = new Person(2, "Thierry", "Nowak");
            Person person3 = new Person(2, "Thierry", "Nowak", "Katowice",18,"Mężczyzna");
        }
    }
}
