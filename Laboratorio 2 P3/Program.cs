using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2_P3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Ingrese el primer numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            n2 = int.Parse(Console.ReadLine());
            if (n1 > n2 && n2 < n1){
                Console.WriteLine("Mediante la comparacion, utilizando AND, se determino que {0} es mayor que {1}", n1, n2);
            }else if (n1 < n2 && n2 > n1){
                Console.WriteLine("Mediante la comparacion, utilizando AND, se determino que {0} es menor que {1}", n1, n2);
            }else if (n1 == n2 || n2 == n1){ 
                Console.WriteLine("Mediante la comparacion, utilizando OR, se determino que {0} es igual a {1}", n1, n2); }
            }
    }
}
