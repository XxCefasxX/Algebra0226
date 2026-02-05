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

            string opcion = "0";
            Console.WriteLine("Que desea hacer?");
            Console.WriteLine("1-Mostrar textos");
            Console.WriteLine("2-Datos de persona");
            Console.WriteLine("3-Calculadora");
            opcion= Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    MostrarTextos();
                    break;
                case "2":
                    DatosDePersona();
                    break;
                case "3":
                    Calculadora();
                    break;
                default:
                    break;
            }
        }

        protected static void Calculadora()
        {

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
            suma = Suma(num1, num2);
            resta = Resta(num1, num2);
            mult = Mult(num1, num2);
            div = Div(num1, num2);
            Console.WriteLine($"La suma de {num1} + {num2} es: {suma}");
            Console.WriteLine($"La resta de {num1} - {num2} es: {resta}");
            Console.WriteLine($"La multi de {num1} * {num2} es: {mult}");
            Console.WriteLine($"La div de {num1} / {num2} es: {div}");
        }
        protected static int Suma(int num1, int num2)
        {
            int resultado = num1 + num2;
           return resultado;
        }
        protected static int Resta(int num1, int num2)
        {
            int resultado = num1 - num2;
            return resultado;
        }
        protected static int Mult(int num1, int num2)
        {
            int resultado = num1 * num2;
            return resultado;
        }
        protected static int Div(int num1, int num2)
        {
            int resultado = num1 / num2;
            return resultado;
        }

        protected static void MostrarTextos()
        {
            int numero = 9;
            string texto = "Pedro";
            bool verdaderofalso = false;
            double decimales = 10.0;


            Console.WriteLine("Cambio realizados");
            Console.WriteLine("Hola " + texto + " su numero es " + numero);
            Console.WriteLine($"Hola {texto} su numero es {numero}");
        }

        protected static void DatosDePersona()
        {
            string nombre = "";
            int edad = 0;
            string mayoria = "";
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad");
            edad = Convert.ToInt32(Console.ReadLine());
            if (edad > 17)
            {
                mayoria = "es mayor de edad";
            }
            else
            {
                mayoria = "es menor de edad";
            }

            Console.WriteLine($"Bienvenido {nombre} su edad es {edad} por lo tanto {mayoria}");

        }
    }
}
