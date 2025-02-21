using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2_P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, res,sum,mul,div;
            Console.WriteLine("Ingrese el primer numero");
            n1= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            n2= int.Parse(Console.ReadLine());
            sum = n1 + n2;
            Console.WriteLine("La suma de ambos numeros es de: {0}",sum);
            res = n1 - n2;
            Console.WriteLine("La resta de ambos numeros es de: {0}", res);
            mul = n1 * n2;
            Console.WriteLine("La multiplicacion de ambos numeros es de: {0}", mul);
            div = n1 / n2;
            Console.WriteLine("La division de ambos numeros es de: {0}", div);
        }
    }
}
