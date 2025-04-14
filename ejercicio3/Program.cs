using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double h, b, a;
            Console.WriteLine("escribir altura: ");
            h = double.Parse(Console.ReadLine());
            Console.WriteLine("escribir base: ");
            b=double.Parse(Console.ReadLine());
            a = (b * h) / 2;
            Console.WriteLine("el area es: "+a);
            Console.ReadKey();
        }
    }
}
