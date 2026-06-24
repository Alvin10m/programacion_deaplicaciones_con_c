/* 1. Contador simple: Escribe un programa que use un ciclo for para mostrar los números del 1 al 10 en pantalla.*/


using System;

class Program1
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


// using directives above
class Program2
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


/* 3. Tabla de multiplicar: Solicita al usuario un número y muestra su tabla de multiplicar del 1 al 10 usando un ciclo for. */


class Program3
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");

        int numero = Convert.ToInt32(Console.ReadLine());

        for (int x = 1; x <= 10; x++)
        {
            Console.WriteLine(numero + " x " + x + " = " + (numero * x));
        }
    }
}


/* 4. Números pares: Usa un ciclo for para mostrar todos los números pares entre 1 y 50. */

class Program4
{
    static void Main()
    {
        for (int x = 1; x <= 50; x++)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine(x);
            }
        }
    }
}


/* 5. Promedio de notas Pide al usuario la cantidad de notas a ingresar. Luego, usando un ciclo for, solicita cada nota y calcula el promedio final. */

class Program5
{
    static void Main()
    {
        Console.Write("Cuántas notas quiere ingresar: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        double suma = 0;

        for (int h = 0; h < cantidad; h++)
        {
            Console.Write("Ingrese la nota " + (h + 1) + ": ");
            double nota = Convert.ToDouble(Console.ReadLine());

            suma += nota;
        }

        double promedio = suma / cantidad;

        Console.WriteLine("El promedio es: " + promedio);
    }
}

/* 6. Arreglo de números: Declara un arreglo de 5 números enteros. Usa un ciclo for para cargar los valores y otro ciclo para mostrarlos en pantalla. */

class Program6
{
    static void Main()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter a number: " + (i + 1) + ": ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("The numbers entered are: ");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(numbers[i]);
        }

    }
}


/* 7. Mayor y menor en un arreglo Crea un programa que solicite al usuario 10 números, los almacene en un arreglo y, usando un ciclo repetitivo, determine el número mayor y el menor.*/

class Program
{
    static void Main()
    {
        int[] numbers = new int[10];
        for (int x = 0; x < 10; x++)
        {
            Console.Write("Enter a number: " + (x + 1) + ": ");
            numbers[x] = Convert.ToInt32(Console.ReadLine());
            
        }

        int bigger = numbers[0];
        int least = numbers[0];

        for (int x = 1; x < 10; x++)
        {
            if (numbers[x] > bigger)
            {
                bigger = numbers[x];

            }
            if (numbers[x] < least)
            {
                least = numbers[x];
            }
        }
        Console.WriteLine("The biggest number is: " + bigger);
        Console.WriteLine("The least number is: " + least);
    }
}
/* 8. Contador de positivos, negativos y ceros: Llena un arreglo con n números ingresados por el usuario. Recorre el arreglo con un ciclo y cuenta cuántos son positivos, negativos y cuántos son ceros.*/

class Program
{
    static void Main()
    {
        Console.Write("How many numbers do you want to enter?: ");
        int amount = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[amount];

        int positive = 0;
        int negative = 0;
        int zero = 0;

        for (int i = 0; i < amount; i++)
        {
            Console.Write("Enter a number: " + (i + 1) + ": ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());

            if (numbers[i] > 0)
            {
                positive++;
            }
            else if (numbers[i] < 0)
            {
                negative++;
            }
            else
            {
                zero++;
            }
        }

        Console.WriteLine("Positive numbers: " + positive);
        Console.WriteLine("Negative numbers: " + negative);
        Console.WriteLine("Zeros: " + zero);
    }
}




/* 9. Búsqueda en un arreglo: Crea un arreglo de números enteros y pide al usuario un valor a buscar. Utiliza un ciclo for o while para indicar si el número existe en el arreglo y en qué posición se encuentra. */

class Program
{
    static void Main()
    {
        int[] numeros = new int[5];

        for (int x = 0; x < 5; x++)
        {
            Console.Write("Enter a number " + (x + 1) + ": ");
            numeros[x] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter the number to search for: ");
        int search = Convert.ToInt32(Console.ReadLine());

        int posicion = -1;

        for (int x = 0; x < 5; x++)
        {
            if (numeros[x] == search)
            {
                posicion = x;
            }
        }

        if (posicion != -1)
        {
            Console.WriteLine("Number found at position: " + posicion);
        }
        else
        {
            Console.WriteLine("NNumber not found");
        }
    }
}


/* 10. Frecuencia de valores: Solicita al usuario una lista de números (almacenados en un arreglo). Luego, usando ciclos repetitivos, determina cuántas veces se repite cada número y muestra el resultado. */

class Program
{
    static void Main()
    {
        Console.Write("How many numbers do you want to enter?: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        int[] numeros = new int[cantidad];

        for (int x = 0; x < cantidad; x++)
        {
            Console.Write("Enter the number " + (x + 1) + ": ");
            numeros[x] = Convert.ToInt32(Console.ReadLine());
        }

        for (int x = 0; x < cantidad; x++)
        {
            int repeticiones = 0;

            for (int y = 0; y < cantidad; y++)
            {
                if (numeros[x] == numeros[y])
                {
                    repeticiones++;
                }
            }

            Console.WriteLine(numeros[x] + " is repeated " + repeticiones + " times");
        }
    }
}