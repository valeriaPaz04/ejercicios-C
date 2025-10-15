using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_de_Control
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            //Numero PAR o IMPAR

            Console.WriteLine("Ingrese un numero: ");

            int numero = int.Parse(Console.ReadLine()); //ReadLine = para leer la entrada del usuario

            if (numero % 2 == 0)
            {
                Console.WriteLine("El numero que usted ingreso " + numero + " es par");
            }
            else
            {
                Console.WriteLine($"El numero que usted ingreso {numero} es impar");
            }

            //Ejercicio 2
            //Pedir al usuario tres notas, donde la primera nota equivale al 20%, la segunda nota al 30% y
            //la tercera nota al 50%. Se debe calificar de 1 a 5, no se debera permitir que el usuario
            //ingrese un numero fuera del rango, al final debe mostrar un mensaje si el estudiante aprobo o no aprobo.

            Console.WriteLine("Ingrese la primera nota: ");
            float numeroUno = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda nota: ");
            float numeroDos = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la tercera nota: ");
            float numeroTres = float.Parse(Console.ReadLine());

            if (numeroUno >= 1 && numeroUno <= 5 &&
                numeroDos >= 1 && numeroDos <= 5 &&
                numeroTres >= 1 && numeroTres <= 5)
            {
                float notaUno = numeroUno * 0.2f;
                float notaDos = numeroDos * 0.3f;
                float notaTres = numeroTres * 0.5f;

                float notaFinal = notaUno + notaDos + notaTres;

                if (notaFinal >= 3)
                {
                    Console.WriteLine("Aprobaste, felicidades.");
                }
                else
                {
                    Console.WriteLine("No aprobaste.");
                }
            }
            else
            {
                Console.WriteLine("Error. Ingrese notas validas desde el 1 al 5.");
            }

            //Ejercicio 3
            //Desarrollar un programa que solicite al usuario el precio de un producto y aplique
            //un descuento basado en su valor.

            //Condiciones:
            //Si el precio del producto es mayor o igual a $100.000, se aplica un descuento del 20%.
            //Si el precio es menor a $100.000, no se aplica descuento.
            //El programa debe mostrar el precio final del producto después de aplicar el descuento.

            Console.WriteLine("Ingrese el precio del producto: ");
            float precioProducto = float.Parse(Console.ReadLine());

            if (precioProducto >= 100000)
            {
                precioProducto = precioProducto - (precioProducto * 0.2f);
                Console.WriteLine("El precio final del producto con descuento es: " + precioProducto);
            }
            else
            {
                Console.WriteLine("El precio final del producto es: " + precioProducto);
            }

        }
    }
}
