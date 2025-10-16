using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Estructura_de_Control
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PRACTICA
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

            //Banco de Problemas
            //Ejercicio #1
            //Un estudiante realiza un préstamo a un plazo de 5 años, donde la tasa fija de interés es
            //del 5 % anual, se debe solicitar el monto del préstamo y se desea calcular la siguiente
            //información.

            //• Cuanto dinero se ha pagado de intereses en un año.
            //• Cuanto dinero se ha pagado de intereses en el tercer trimestre del año.
            //• Cuanto dinero se ha pagado de intereses en el primer mes.
            //• Cuanto dinero se paga en total del préstamo solicitado incluyendo intereses.

            Console.WriteLine("Ingrese el monto del prestamo: ");
            float montoPrestamo = float.Parse(Console.ReadLine());

            float interesAnual = montoPrestamo * 0.05f;
            float interesTercerTrimestre = (interesAnual / 4) * 3;
            float interesPrimerMes = interesAnual / 12;
            float totalPrestamo = montoPrestamo + (interesAnual * 5);

            Console.WriteLine("El dinero pagado de intereses en un año es: " + interesAnual);
            Console.WriteLine("El dinero pagado de intereses en el tercer trimestre del año es: " + interesTercerTrimestre);
            Console.WriteLine("El dinero pagado de intereses en el primer mes es: " + interesPrimerMes);
            Console.WriteLine("El dinero total pagado del prestamo incluyendo intereses es: " + totalPrestamo);

            //Ejercicio #2
            //Generar la colilla de pago de los empleados de una empresa:

            //● El Salario del Empleado
            //● El Valor de Ahorro mensual programado.
            //● La suma a deducir por aporte a la Salud(EPS) 12,5 %
            //● La suma a deducir por aporte al Fondo de Pensiones 16 %
            //● Total a Recibir

            //Toda la información que debe proveer el usuario del programa es el Salario del
            //Empleado y el Valor de Ahorro mensual programado. El programa debe calcular y
            //devolver el resto de los datos.

            Console.WriteLine("Ingrese el salario del empleado: ");
            float salarioEmpleado = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de ahorro mensual programado: ");
            float ahorroMensual = float.Parse(Console.ReadLine());

            //Factura
            Console.WriteLine("------- COLILLA DE PAGO -------");


            Console.WriteLine("Salario del Empleado: " + salarioEmpleado);

            Console.WriteLine("Valor de Ahorro mensual programado: " + ahorroMensual);

            float deduccionSalud = salarioEmpleado * 0.125f;
            Console.WriteLine("Deduccion por aporte a la Salud (EPS) 12.5%: " + deduccionSalud);

            float deduccionPension = salarioEmpleado * 0.16f;
            Console.WriteLine("Deduccion por aporte al Fondo de Pensiones 16%: " + deduccionPension);

            float totalRecibir = salarioEmpleado - deduccionSalud - deduccionPension - ahorroMensual;
            Console.WriteLine("Total a recibir el empleado:" + totalRecibir);

            //Ejercicio #3
            //Crear una clase llamada "Persona" con las propiedades "Nombre", "Edad", "Género" (el usuario deberá
            //seleccionar (F o M)) y "Teléfono". También crear un constructor para la clase "Persona" y métodos: para
            //editar la información del usuario, agregar un nuevo usuario, imprimir los detalles de la
            //persona y otro para calcular la edad en días.El programa solicitará al usuario que ingrese los
            //detalles de la persona y luego le permitirá elegir entre dos opciones: imprimir los detalles de
            //la persona o calcular la edad en días.
            //Solicitar al usuario que ingrese los detalles de la persona (nombre, edad y género) y luego
            //crea un objeto "Persona" con esos detalles.Luego, le presenta al usuario un menú de
            //opciones que le permite imprimir los detalles de la persona, calcular la edad en días o salir
            //del programa.Si el usuario selecciona la opción de imprimir detalles de la persona, el
            //programa llama al método "ImprimirDetalles" de la clase "Persona", que imprime los
            //detalles de la persona en la consola. Si el usuario selecciona la opción de calcular edad en
            //días, el programa llama al método "CalcularEdadEnDias" de la clase "Persona", que calcula la
            //edad en días y la imprime en la consola.

        }
    }
}
