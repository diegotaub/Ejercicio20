using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer número: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.Write("Debe ingresar un número. Pulse una tecla para salir.");
                Console.ReadKey();
                return;
            }
            Console.Write("Ingrese el segundo número: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.Write("Debe ingresar un número. Pulse una tecla para salir.");
                Console.ReadKey();
                return;
            }
            if(num1 > num2)
            {
                Console.Write($"El primero ({num1}) es mayor que el segundo ({num2})");
            }
            else if (num2 > num1)
            {
                Console.Write($"El segundo ({num2}) es mayor que el primero ({num1})");
            }
            else
            {
                Console.Write("Los números son iguales");
            }
            Console.ReadKey();
        }
    }
}
