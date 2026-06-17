/* 1. Contador simple: Escribe un programa que use un ciclo for para mostrar los números del 1 al 10 en pantalla.*/


using System;

class Program
{
    static void Main()
    {
        for (int x = 1; x <= 10; x++)
        {
            Console.WriteLine(x);
        }
    }
}


/* 2. Suma de números: Utiliza un ciclo while para calcular y mostrar la suma de los primeros 100 números naturales.*/


using System;

class Program
{
    static void Main()
    {
        int contador = 1;
        int suma = 0;

        while (contador <= 100)
        {
            suma = suma + contador;
            contador++;
        }

        Console.WriteLine("La suma es: " + suma);
    }
}


/* 3. Tabla de multiplicar Solicita al usuario un número y muestra su tabla de multiplicar del 1 al 10 usando un ciclo for. */


using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int valor = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
    }
}    