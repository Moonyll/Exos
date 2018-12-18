using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            string b;
            Console.WriteLine("Nom ?");
            a = Console.ReadLine();
            Console.WriteLine("Prénom ?");
            b = Console.ReadLine();
            c = DateTime.Today;
            Console.WriteLine("Bonjour " + a + " " + b + ", nous sommes le "+ ToShortDateString(DateTime.Today) + ",comment allez vous ?");
            Console.ReadKey();
// DateTime.Now.ToLongDateString() affiche date normalement en version longue ou aussi Long par Short

        }
    }
}
