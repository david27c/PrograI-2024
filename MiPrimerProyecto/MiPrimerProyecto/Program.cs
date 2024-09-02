using System;

namespace Parcial_1
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                // Menú principal
                Console.Clear();
                Console.WriteLine("MENÚ PRINCIPAL");
                Console.WriteLine("1. Calcular impuesto sobre actividades económicas");
                Console.WriteLine("2. Conversión de área");
                Console.WriteLine("3. Salir");
                Console.Write("Ingrese su elección (1-3): ");

                int opcion;
                if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 3)
                {
                    Console.WriteLine("Opción no válida, por favor intente de nuevo.");
                    Console.ReadKey();
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        CalcularImpuestoEconomico();
                        break;
                    case 2:
                        ConversorDeArea();
                        break;
                    case 3:
                        Console.WriteLine("Saliendo del programa...");
                        return;
                }
            }
        }

        static void CalcularImpuestoEconomico()
        {
            Console.Clear();
            Console.WriteLine("CÁLCULO DEL IMPUESTO");

            Console.Write("Ingrese el monto total de la actividad económica: ");
            if (double.TryParse(Console.ReadLine(), out double montoActividad))
            {
                double impuesto = CalcularImpuesto(montoActividad);
                Console.WriteLine($"\nEl impuesto a pagar por una actividad económica de {montoActividad:0.00} es: {impuesto:0.00}");
            }
            else
            {
                Console.WriteLine("Monto no válido. Por favor, intente nuevamente.");
            }
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        static double CalcularImpuesto(double monto)
        {
            double impuesto = 0;

            if (monto >= 0.01 && monto <= 500)
            {
                impuesto = 1.5;
            }
            else if (monto >= 500.01 && monto <= 1000)
            {
                impuesto = 1.5 + ((monto - 500) / 1000) * 3;
            }
            else if (monto >= 1000.01 && monto <= 2000)
            {
                impuesto = 3 + ((monto - 1000) / 1000) * 3;
            }
            else if (monto >= 2000.01 && monto <= 3000)
            {
                impuesto = 6 + ((monto - 2000) / 1000) * 3;
            }
            else if (monto >= 3000.01 && monto <= 6000)
            {
                impuesto = 9 + ((monto - 3000) / 1000) * 2;
            }
            else if (monto >= 8000.01 && monto <= 18000)
            {
                impuesto = 15 + ((monto - 8000) / 1000) * 2;
            }
            else if (monto >= 18000.01 && monto <= 30000)
            {
                impuesto = 39 + ((monto - 18000) / 1000) * 2;
            }
            else if (monto >= 30000.01 && monto <= 60000)
            {
                impuesto = 63 + ((monto - 30000) / 1000) * 1;
            }
            else if (monto >= 60000.01 && monto <= 100000)
            {
                impuesto = 93 + ((monto - 60000) / 1000) * 0.8;
            }
            else if (monto >= 100000.01 && monto <= 200000)
            {
                impuesto = 125 + ((monto - 100000) / 1000) * 0.7;
            }
            else if (monto >= 200000.01 && monto <= 300000)
            {
                impuesto = 195 + ((monto - 200000) / 1000) * 0.6;
            }
            else if (monto >= 300000.01 && monto <= 400000)
            {
                impuesto = 255 + ((monto - 300000) / 1000) * 0.45;
            }
            else if (monto >= 400000.01 && monto <= 500000)
            {
                impuesto = 300 + ((monto - 400000) / 1000) * 0.4;
            }
            else if (monto >= 500000.01 && monto <= 1000000)
            {
                impuesto = 340 + ((monto - 500000) / 1000) * 0.3;
            }
            else if (monto > 1000000.01)
            {
                impuesto = 490 + ((monto - 1000000) / 1000) * 0.18;
            }

            return impuesto;
        }

        static void ConversorDeArea()
        {
            Console.Clear();
            Console.WriteLine("CONVERSOR DE ÁREA");

            string[] unidades = { "Pie Cuadrado", "Vara Cuadrada", "Yarda Cuadrada", "Metro Cuadrado", "Tarea", "Manzana", "Hectárea" };
            double[] factoresConversion = { 1.0, 0.698896, 0.111111, 0.092903, 0.0000209, 0.00000131, 0.0000092903 };

            while (true)
            {
                Console.WriteLine("\nUnidades disponibles:");
                for (int i = 0; i < unidades.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {unidades[i]}");
                }

                // Solicitar la unidad de origen y destino
                int unidadOrigen = SolicitarUnidad("Seleccione la unidad de origen (1-7): ", unidades.Length);
                int unidadDestino = SolicitarUnidad("Seleccione la unidad de destino (1-7): ", unidades.Length);

                // Solicitar el valor de la superficie a convertir
                double valor = SolicitarValor();

                // Realizar la conversión
                double resultado = ConvertirArea(valor, factoresConversion[unidadOrigen - 1], factoresConversion[unidadDestino - 1]);
                Console.WriteLine($"\n{valor:0.00} {unidades[unidadOrigen - 1]} es igual a {resultado:0.00} {unidades[unidadDestino - 1]}.");

                // Preguntar al usuario si desea realizar otra conversión
                Console.Write("\n¿Desea realizar otra conversión? (s/n): ");
                char respuesta = Console.ReadKey().KeyChar;
                if (respuesta == 'n' || respuesta == 'N')
                {
                    break;
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nPresione cualquier tecla para volver al menú principal...");
            Console.ReadKey();
        }

        static double ConvertirArea(double valor, double factorOrigen, double factorDestino)
        {
            return valor * factorOrigen / factorDestino;
        }

        static int SolicitarUnidad(string mensaje, int maxUnidades)
        {
            int unidad;
            while (true)
            {
                Console.Write(mensaje);
                if (int.TryParse(Console.ReadLine(), out unidad) && unidad >= 1 && unidad <= maxUnidades)
                {
                    return unidad;
                }
                else
                {
                    Console.WriteLine($"Valor no válido. Por favor, ingrese un número entre 1 y {maxUnidades}.");
                }
            }
        }

        static double SolicitarValor()
        {
            double valor;
            while (true)
            {
                Console.Write("Ingrese el valor del área a convertir: ");
                if (double.TryParse(Console.ReadLine(), out valor) && valor > 0)
                {
                    return valor;
                }
                else
                {
                    Console.WriteLine("Valor no válido. Por favor, ingrese un número positivo.");
                }
            }
        }
    }
}

