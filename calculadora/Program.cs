// See https://aka.ms/new-console-template for more information
using System;

class Calculadora
{
    static void Main()
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("----- Calculadora -----");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Salir");

            Console.Write("Ingrese la opción deseada: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Suma();
                    break;

                case 2:
                    Resta();
                    break;

                case 3:
                    Multiplicacion();
                    break;

                case 4:
                    Division();
                    break;

                case 5:
                    salir = true;
                    break;

                default:
                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void Suma()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultado = num1 + num2;
        Console.WriteLine("El resultado de la suma es: " + resultado);
    }

    static void Resta()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultado = num1 - num2;
        Console.WriteLine("El resultado de la resta es: " + resultado);
    }

    static void Multiplicacion()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultado = num1 * num2;
        Console.WriteLine("El resultado de la multiplicación es: " + resultado);
    }

    static void Division()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (num2 != 0)
        {
            double resultado = num1 / num2;
            Console.WriteLine("El resultado de la división es: " + resultado);
        }
        else
        {
            Console.WriteLine("No se puede dividir entre cero.");
        }
    }
}