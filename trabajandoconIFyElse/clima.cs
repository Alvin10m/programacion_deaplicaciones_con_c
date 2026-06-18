
using System;

class Programa
{
    static void Main(string[] args)
    {
        string[] dia_semana = {"lunes", "martes", "miércoles", "jueves", "viernes", "sábado", "domingo"};
        
        double[] temperatura = new double[7];

        for (int i = 0; i < 7; i++)
        {
            do
            {
                Console.WriteLine("Ingrese la temperatura para {0}: ", dia_semana[i]);
                temperatura[i] = double.Parse(Console.ReadLine());

                if (temperatura[i] < -50 || temperatura[i] > 50)
                {
                    Console.WriteLine("Error. La temperatura debe estar entre -50 y 50 grados");
                }
            } while (temperatura[i] < -50 || temperatura[i] > 50);

            
        }

        BuscarExtremos(temperatura);

        double promedio = CalcularPromedio(temperatura);

        Console.WriteLine("Promedio general: {0:F2}", promedio);

        if (promedio < 4)
        {
            Console.WriteLine("\nNivel de viento:");
            Console.WriteLine("1. Bajo");
            Console.WriteLine("2. Alto");

            int viento = int.Parse(Console.ReadLine());

            switch (viento)
            {
                case 1:
                    Console.WriteLine("Alerta Amarilla");
                    break;
                case 2:
                    Console.WriteLine("Alerta Roja por helada");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }

    }

static void BuscarExtremos(double[] temperaturas)
    {
        double minima = temperaturas [0];
        double maxima = temperaturas [0];

        for (int i = 1; i < temperaturas.Length; i++)
        {
            if (temperaturas[i] < minima)
            {
                minima = temperaturas[i];
            }
            if (temperaturas[i] > maxima)
            {
                maxima = temperaturas[i];
            
            }
        }
        Console.WriteLine("Temperatura mínima: {0:F2}", minima);
        Console.WriteLine("Temperatura máxima: {0:F2}", maxima);
    }

    static double CalcularPromedio(double[] temperaturas)
    {
        double suma = 0;
        for (int i = 0; i < temperaturas.Length; i++)
        {
            suma += temperaturas[i];
        }
        return suma / temperaturas.Length;
    }
}