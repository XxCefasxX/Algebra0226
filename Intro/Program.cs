using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 9;
            string texto = "Pedro";
            bool verdaderofalso = false;
            double decimales = 10.0;
           
            
            Console.WriteLine("Cambio realizados");
            Console.WriteLine("Hola " + texto + " su numero es " + numero);
            Console.WriteLine($"Hola {texto} su numero es {numero}");

            string nombre = "";
            int edad = 0;
            string mayoria = "";
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad");
            edad = Convert.ToInt32(Console.ReadLine());
            if (edad>17)
            {
                mayoria = "es mayor de edad";
            }
            else
            {
                mayoria = "es menor de edad";
            }

            Console.WriteLine($"Bienvenido {nombre} su edad es {edad} por lo tanto {mayoria}");

            int num1 = 0;
            int num2 = 0;

            int suma = 0;
            int resta = 0;
            int mult = 0;
            int div = 0;

            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            suma = num1 + num2;
            resta = num1 - num2;
            mult = num1 * num2;
            div = num1 / num2;
            Console.WriteLine($"La suma de {num1} + {num2} es: {suma}");
            Console.WriteLine($"La resta de {num1} - {num2} es: {resta}");
            Console.WriteLine($"La multi de {num1} * {num2} es: {mult}");
            Console.WriteLine($"La div de {num1} / {num2} es: {div}");

            Suma(num1, num2);
        }

        protected static void Suma(int num1,int num2)
        {
            int resultado = num1 + num2;
            Console.WriteLine($"El resultado es:{resultado}");
        }
    }
}
