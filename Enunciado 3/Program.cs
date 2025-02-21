using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enunciado_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string us, co, nom="Carlo", con="1234";
            Console.WriteLine("Ingrese su nombre de usuario");
            us = Console.ReadLine();
            Console.WriteLine("Ingrese su contrasena");
            co = Console.ReadLine();
            if (us ==nom) { if (co == con) { Console.WriteLine("Acceso concedido"); 
                } else { Console.WriteLine("Contrasena incorrecta"); 
                } 
            } else { Console.WriteLine("Usuario no registrado"); }
        }
    }
}
