namespace _1.InicioVisualStudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Está es la declaración e iniciación de una variable 
            string nombre="Samuel"; // Declarar variable tipo nombre mediante la variable tipo string
            const string iva="19%";

            Console.Write("Hola, " + nombre + "\n"); // Se llama a la variable "nombre" mediante la variable +. la variable \n, es como dar scape.
            Console.Write("\tBienvenido a la clase de programación"); // la variable \t sirve para dar tabulador
            nombre = "Juan";
            Console.Write("\n" + nombre);
            // iva = "20%"; No se puede cmabiar el valor de una constante

            //Tipos de datos
            byte dato1 = 255; // el caracter más grande que puede almacenar es 255
            int dato2 = 202321;
            long dato3 = 9202125235;
            double dato4 = 326.625; // se pueden usar caracteres con signo
            char dato5 = ' '; // El espacio cuenta como un caracter y solo se puede almacenar uno solo
            bool dato6= false; // Almacena true o false
            object dato7= new Program(); // Para poder crear un nuevo objeto


        }
    }
}
