# README.md
## Pregunta 1
Para llevar un mejor control sobre el flujo del programa, ya que permiten designar condiciones que deben ser cumplidas para llevar a cabo la ejecución de ciertas secciones del código.
## Pregunta 2
Para llevar un mejor orden y evitar errores en el código, además al declarar las variables con nombres sencillos, pero precisos, nos permite recordarlos con facilidad optimizando el tiempo que nos llevaría terminar el programa.
## Enunciado #1
Usaría la estructura del if-else, ya que es más sencillo a la hora de utilizar rangos numéricos, también se puede realizar con un switch, pero no lo termine de comprender.
```cs
            int ed;
            Console.WriteLine("Que edad tienes?");
            ed = int.Parse(Console.ReadLine());
            if (ed < 12){Console.WriteLine("Eres un nino"); }
            else if (ed >= 12 && ed <= 17) { Console.WriteLine("Eres un adolescente"); }
            else if (ed >= 18 && ed <= 59) { Console.WriteLine("Eres un adulto"); }
            else if (ed>59) { Console.WriteLine("Eres un adulto mayor"); }
```
## Enunciado #2
En el caso de elegir opciones únicas, como en este enunciado, optaría por un switch que facilita mucho el trabajo gracias a la estructura ordenada de una sola elección que trabaja.
```cs
            int dia;
            Console.WriteLine("Ingrese un numero del 1 al 7 para ver a que dia le corresponde");
            dia= int.Parse(Console.ReadLine());
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Ingrese un numero valido");
                    break;
            }
```
## Enunciado #3
Por mi parte optaría por utilizar if-else, ya que sin mucho problema puedo hacer que evalúe primero el usuario, para luego evaluar la contraseña, soy consiente que se puede realizar con un switch utilizando los go case.
```cs
            string us, co, nom="Carlo", con="1234";
            Console.WriteLine("Ingrese su nombre de usuario");
            us = Console.ReadLine();
            Console.WriteLine("Ingrese su contrasena");
            co = Console.ReadLine();
            if (us ==nom) { if (co == con) { Console.WriteLine("Acceso concedido"); 
                } else { Console.WriteLine("Contrasena incorrecta"); 
                } 
            } else { Console.WriteLine("Usuario no registrado"); }
```