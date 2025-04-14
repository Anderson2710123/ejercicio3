using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, promedio;
            Console.WriteLine("ingresar numero 1: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingresar numero 2: ");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingresar numero 3: ");
            num3 = double.Parse(Console.ReadLine());
            promedio = (num1 + num2 + num3) / 3;
            Console.WriteLine("promedio: "+promedio);
            Console.ReadKey();
        }
    }
}
