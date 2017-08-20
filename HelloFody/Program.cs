using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloFody
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person { Age = 10, Name = "Xixi" };
            var p2 = new Person { Age = 10, Name = "Xixi" };

            Console.WriteLine(p1 == p2);
            Console.ReadKey();
        }
    }

    [Equals]
    public class Person
    {
        public int Age { get; set; }
        public String Name { get; set; }
    }
}
