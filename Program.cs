using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //paso 0:declarar variables
            //tipo de dato, int (entero), float (numeros con coma) char(letra) bool (verdadero o falso)
            int n1, n2;
            int resultado;
            //paso 1: pedir valores al usuario


            Console.WriteLine("Ingrese el primer numero: ");
            // con el parse le decimos al programa que el valor que devolvera read line es un entero
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            // con el parse le decimos al programa que el valor que devolvera read line es un entero
            n2 = int.Parse(Console.ReadLine());

            //paso2 : realizar calculo
            // + para sumar, - para restar, * para multiplicar, / para dividir
            resultado = n1 + n2;


            //paso 3 emitir resultado

            Console.WriteLine("El resultado de la suma es: " + resultado);  

        }
    }
}
