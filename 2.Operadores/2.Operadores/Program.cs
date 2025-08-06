namespace _2.Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OPERADORES
            //Operadores Númericos
            //Cambio de signo

            int num1 = 5;
            int num2 = -num1;
            int num3 = +num2;
            int num4 = -num3;


            Console.WriteLine($"{num1} // {num2} // {num3} // {num4}");//Console.WriteLine tiene incluido el salto de línea
                                                                       //Ctrl+alt+sostenido = realiza el multicursor


            //Operadores Aritméticos

            int num5 = 3 + 5; //Suma
            int num6 = 100 - 26; //Resta
            int num7 = 4 * 2; //Producto
            //float num8 =(float) 5 / 3; //División
            //float num8 = 5 / 3f;
            //float num8 = 5f / 3;
            float num8 = 5f / 3f;
            double num9 = 5d / 3;
            decimal num10 = 5 / 3m;
            //Funciona de las 3 maneras para conseguir una respuesta decimal de un valor entero
            //Int son números enteros y float ya nos deja ver la respuesta en decimal.
            Console.WriteLine($"Suma: {num5}, resta: {num6}, producto: {num7}, división:{num8}, num9: {num9}, num10: {num10}"); // El signo $ para poder mostrar dentro de la consola varios valores


            //Operadores incremento(++), decremento(--)

            num1++; //num1 = num1 + 1; Incremento
            num2--; //num2 = num2 - 1; Decremento
            num3 += 5; //num3 = num3 + 5; Incremento
            num4 -= 20; //num4 = num4 - 20; Decremento
            num5 *= 31; //num5 = num5 * 31; 
            num7 /= num1; //num7 = num7 / num1;


            //Orden de evaluación operadores aritméticos
            int num11 = 4 * 3 / 2;
            int num12 = 4 / 3 * 2; //al ser / y * del mismo nivel se realiza el proceso que se encuentre primero de izquierda a derecha
            int num13 = (4*3) / 2; //Se ejecuta primero el () ya que está en un nivel superior al *
            int num14 = 4*(3 / 2); //Se ejecuta primero la división ya que está dentro del () y va a un nivle mayor al *
            int num15 = 4 + 6 * 3; //Se ejecuta primero la * al estar en un nivel superior al -
            int num16 = 4 + 6 * (2 - 1) / 2; //Se ejecuta primero la - al estar dentro del (), luego la *, luego la / y por último la +
            Console.WriteLine($"num11: {num11}, num12: {num12}, num13: {num13}, num14: {num14}, num15: {num15}, num16: {num16}");


            //Operadores Lógicos
            //Conjunción - AND - &&
            Console.WriteLine("TABLA DE VERDAD CONJUNCIÓN");
            Console.WriteLine($"V && V = {true && true}");
            Console.WriteLine($"V && V = {true && false}");
            Console.WriteLine($"V && V = {false && true}");
            Console.WriteLine($"V && V = {false && false}");

            //Disyunción - OR - ||
            Console.WriteLine("TABLA DE VERDAD DISYUNCIÓN");
            Console.WriteLine($"V || V = {true || true}");
            Console.WriteLine($"V || V = {true || false}");
            Console.WriteLine($"V || V = {false || true}");
            Console.WriteLine($"V || V = {false || false}");
            bool exp1 = true;
            bool exp2 = false;
            bool exp3 = exp1 && exp2;
            bool exp4 = exp2 || exp3;
            bool exp5 = !exp4 || exp2;
            Console.WriteLine($"exp1: {exp1}, exp2: {exp2}, exp3: {exp3}, exp4 {exp4}, exp5: {exp5}");


        }
    }
}
