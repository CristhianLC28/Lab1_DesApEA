using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab1{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Calcular la suma de dos numeros");
                Console.WriteLine("[2] Imprimir la raiz cuadrada de " +
                    "los dos primeros numeros");
                Console.WriteLine("[3] Calculadora");
                Console.WriteLine("[4] Hallar 10 primeros numeros primos");
                Console.WriteLine("[5] Hallar grados celsius a fahrenheit");
                Console.WriteLine("[6] Hallar grados fahrenheit a celsius");               
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opcion y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer numero");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b,Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Calculando....");
                        raiz();
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Primeros 10 numeros primos");
                        primos();
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Ingrese el numero que quiera convertir");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("La convercion de {0} grados celsius son {1} grados fahrenheit ", c, celsius(c));
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Ingrese el numero que quiera convertir");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("La convercion de {0} grados fahrenheit son {1} grados celsius ", f, fahrenheit(f));
                        Console.ReadKey();
                        break;
                    
                }

            } while (!opcion.Equals("0"));
        }
        static int Suma(int a, int b)
        {
            return a + b;
        }
        static void raiz()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raiz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }
        static int celsius(int c)
        {
            return (c * 9 / 5) + 32;
        }
        static int fahrenheit(int f)
        {
            return (f - 32) * 5 / 9; 
        }
        static void primos()
        {
            int cont = 0;
            for (int i = 2; i <= 30; i++)
            {  
                for (int j = 1; j <= i; j++)
                {   
                    if (i % j == 0)
                    {
                        cont = cont + 1;
                    }
                }
                if (cont <= 2)
                {
                    Console.WriteLine(i);
                }      
                cont = 0;               
            }
        }
    }
}
