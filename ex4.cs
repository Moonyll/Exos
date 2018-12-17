using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
        string a;
        string b;
        string c;
        Console.WriteLine("Monsieur ou  Madame ?");
        a = Console.ReadLine();
        Console.WriteLine("Prénom ?");
        b = Console.ReadLine();
        Console.WriteLine("Nombre de visite ?");
        c = Console.ReadLine();
        Console.WriteLine("Bonjour "+a+" "+b+" vous êtes venu "+c+" fois");
        }
    }
}
