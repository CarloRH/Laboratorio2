using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2_P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string l1;
            int n1;
            bool b1;
            double d1;
            Console.Write("Ingrese una palabra: ");
            l1= Console.ReadLine();
            Console.Write("Ingrese un numero entero: ");
            n1= int.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero decimal: ");
            d1= double.Parse(Console.ReadLine());
            Console.WriteLine("El valor booleano se tomara como true si el numero ingresado es mayor a 12");
            b1= n1 > 12;
            Console.WriteLine("Palabra: ",l1);
            Console.WriteLine("Numero entero: ",n1);
            Console.WriteLine("Numero decimal: ",d1);
            Console.WriteLine("Booleano: ",b1);
        }
    }
}
