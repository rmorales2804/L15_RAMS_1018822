using System;

namespace L15_RAMS_1018822
{ }
    class Program
    {
        private static void Main(string[] args)
        {
            string opcion;
            string[] nombres = new string[5];
            string[] puesto = new string[5];
            int[] año = new int[5];
            int edad = 0;
            int promedio = 0;
            int total = 0;
        int mayor = 0;
        int menor = 0;


            Console.WriteLine("Bienvenido al siguiente menú, por favor seleccione una opción: ");
            Console.WriteLine("Presione 1 -------> Opcion 1");
            Console.WriteLine("Presione 2 -------> Opcion 2");
            Console.WriteLine("Presione 3 -------> Opcion 3");

            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write("Ingrese el nombre de la persona: ");
                        nombres[i] = Console.ReadLine();
                        Console.Write("Ingrese la edad de la persona: ");
                        año[i] = int.Parse(Console.ReadLine());
                        edad = año[i];
                        total = edad + total;

                    if (año[i] > mayor)
                    {
                        mayor = año[i];
                    }
                    }
                Console.WriteLine();
                Console.WriteLine("La persona con mayor edad es con la edad de: " + mayor);
                Console.WriteLine("El promedio de edades es de: " + total / 5);

                break;

            case "2":
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Ingrese el nombre y apellido del estudiante: ");
                    nombres[i] = Console.ReadLine();
                    Console.Write("Ingrese la nota del estudiante: ");
                    año[i] = int.Parse(Console.ReadLine());
                    edad = año[i];
                    total = edad + total;

                    if (i == 0)
                    {
                        mayor = edad;
                        menor = edad;
                    }
                    else
                    {
                        if (edad > mayor) mayor = edad;
                        if (edad < menor) menor = edad;
                    }
                    if (edad <= 71)
                    {
                        edad = edad;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("La nota mas alta es de: " + mayor);
                Console.WriteLine("La nota mas baja es de: " + menor);
                Console.WriteLine("El promedio de notas es de: " + total / 5);
                Console.WriteLine("la nota de " + edad + " aprobó el curso") ;

                break;

            case "3":
                Console.WriteLine("Programa terminado");
                Environment.Exit(0);
                break;
        }
    }
}
