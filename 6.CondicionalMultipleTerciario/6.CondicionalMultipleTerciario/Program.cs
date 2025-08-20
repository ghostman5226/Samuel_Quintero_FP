using System.Security.Cryptography;
using System.Text;

namespace _6.CondicionalMultipleTerciario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicional Multiple

            /*Tiendas La Avenida desea desarrollar un programa que permita ingresar por teclado el monto de compra y el día de la semana, para saber:
            Si el día es martes o jueves, se realizará un descuento del 15 % por la compra. 
            Si el día es lunes o miércoles, se realizará un descuento del 10 % por la compra.
            Si el día es viernes o sábado, se realizará un descuento del 20 % por la compra.
            Si es domingo no se realiza descuento.
            Visualizar el día, el descuento y el total a pagar por la compra.*/

            /* float valorCompra = 0;
             float descuento = 0;
             char dia = ' ';

             Console.WriteLine("Ingrese el valor de la compra:");
             valorCompra=Single.Parse(Console.ReadLine());
             Console.WriteLine("Ingrese el día de la semana: l: Lunes, m: Martes, x: Miércoles, j: Jueves, v: Viernes, s: Sábado, d: Domingo");
             dia=Convert.ToChar(Console.ReadLine());

             switch (dia) //Para poder tener condiciones multiples.
             {
                 case 'l':
                     descuento = valorCompra * 0.1f; //Se pone la 'f' al final de valor para combertir el numero de double a float.
                     Console.WriteLine($"Hoy es Lunes, descuento: {descuento}, valor a pagar. {valorCompra - descuento}"); //Funcion que se cumple según la respuesta del usuario, en este caso "l" de Lunes.
                     break; // Para cerrar la condicionante y si no se cumple la condición, pasa a la siguiente que sería "m".
                 case 'm':
                     descuento = valorCompra * 0.15f;
                     Console.WriteLine($"Hoy es Martes, descuento: {descuento}, valor a pagar. {valorCompra - descuento}");
                     break;
                 case 'x':
                     descuento = valorCompra * 0.1f;
                     Console.WriteLine($"Hoy es Miércoles, descuento: {descuento}, valor a pagar. {valorCompra - descuento}");
                     break;
                 case 'j':
                     descuento = valorCompra * 0.15f;
                     Console.WriteLine($"Hoy es Jueves, descuento: {descuento}, valor a pagar. {valorCompra - descuento}");
                     break;
                 case 'v':
                     descuento = valorCompra * 0.2f;
                     Console.WriteLine($"Hoy es Viernes, descuento: {descuento}, valor a pagar. {valorCompra - descuento}");
                     break;
                 case 's':
                     descuento = valorCompra * 0.2f;
                     Console.WriteLine($"Hoy es Sábado, descuento: {descuento}, valor a pagar. {valorCompra - descuento}");
                     break;
                 case 'd':
                     descuento = valorCompra * 0;
                     Console.WriteLine($"Hoy es Domingo, descuento: {descuento}, valor a pagar. {valorCompra - descuento}");
                     break;
                 default: //Para casos donde se ingresen valores que no están establecidos como "g".
                     Console.WriteLine("Debe ingresar un valor válido");
                     break;
            }*/


                    /*Diseñar un algoritmo que permita crear una calculadora básica capaz de realizar operaciones aritméticas entre dos números ingresados por el usuario.
                     * Las operaciones disponibles serán: suma, resta, multiplicación y división, las cuales se ejecutarán según la opción seleccionada por el usuario.*/

            float valor1 = 0;
            float valor2 = 0;
            float respuesta = 0;
            char operacion = ' ';

            Console.WriteLine("Ingrese el valor 1:");
            valor1=Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor 2:");
            valor2= Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el proceso aritmético que quiere realizar: +: suma, -: resta, *: multiplicación, /: división");
            operacion=Convert.ToChar(Console.ReadLine());

            switch (operacion)
            {
                case '+':
                    respuesta = valor1 + valor2;
                    Console.WriteLine($"La respuesta es {respuesta}");
                    break;
                case '-':
                    respuesta = valor1 - valor2;
                    Console.WriteLine($"La respuesta es {respuesta}");
                    break;
                case '*':
                    respuesta = valor1 * valor2;
                    Console.WriteLine($"La respuesta es {respuesta}");
                    break;
                case '/':
                    respuesta = valor1 / valor2;
                    Console.WriteLine($"La respuesta es {respuesta}");
                    break;
                default:
                    Console.WriteLine("Debe ingresar una operación aritmética válida");
                    break;
            }
        }
    }
}
