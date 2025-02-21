using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enunciado_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ed;
            Console.WriteLine("Que edad tienes?");
            ed = int.Parse(Console.ReadLine());
            if (ed < 12){Console.WriteLine("Eres un nino"); }
            else if (ed >= 12 && ed <= 17) { Console.WriteLine("Eres un adolescente"); }
            else if (ed >= 18 && ed <= 59) { Console.WriteLine("Eres un adulto"); }
            else if (ed>59) { Console.WriteLine("Eres un adulto mayor"); }
        }  
    }
}
