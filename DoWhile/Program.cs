using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1, num2, resultado = 0M;
            int opcion;

            do
            {
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");

                //pedimos una opcion
                Console.WriteLine("Escoga una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
            }
            while ((opcion < 1) || (opcion > 4));

            Console.WriteLine("Dame el primer numero: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Dame el segundo numero: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Divisor no valido");
                    }
                    break;
            }

            Console.WriteLine("El resultado es: {0}", resultado);
            Console.ReadKey();

        }
    }
}
