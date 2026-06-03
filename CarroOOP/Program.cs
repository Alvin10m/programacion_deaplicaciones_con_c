class Boton
{
    public string Color;
    public float Tamaño;
    public bool Estado;

    public Boton(string color, float tamaño)
    {
        Color = color;
        Tamaño = tamaño;
        Estado = false;
    }

    public void Presionar()
    {
        Estado = true;
    }

    public void Soltar()
    {
        Estado = false;
    }
}

class Carro
{
    public string Color;
    public int Velocidad;
    public bool Estado;
    public string Direccion;

    public Carro(string color)
    {
        Color = color;
        Velocidad = 0;
        Estado = false;
        Direccion = "recto";
    }
    public void Encender()
    {
        Estado = true;
        Console.WriteLine("El carro está encendido.");
    }

    public void Apagar()
    {
        Estado = false;
        Console.WriteLine("El carro está apagado.");
    }

    public void Acelerar()
    {
        if (Estado && Velocidad < 350)
        {
            Velocidad += 10;
            Console.WriteLine($"Acelerando... Velocidad: {Velocidad} km/h");
        }
        else if (Velocidad >= 350)
        {
            Console.WriteLine("350 km/h");
        }
        else
        {
            Console.WriteLine("El carro está apagado, enciéndelo.");
        }
    }

    public void Frenar()
    {
        if (Velocidad > 0)
        {
            Velocidad -= 10;
            Console.WriteLine($"Frenando... Velocidad: {Velocidad} km/h");
        }
        else
        {
            Console.WriteLine("El carro se ha detenido.");
        }
    }

    public void DoblarDerecha()
    {
        if (Estado)
        {
            Direccion = "derecha";
            Console.WriteLine("Doblando a la derecha.");

        }
        else
        {
            Console.WriteLine("El carro está apagado.");
        }
    }

    public void DoblarIzquierda()
    {
        if (Estado)
        {
            Direccion = "izquierda";
            Console.WriteLine("Doblando a la izquierda.");
        }
        else
        {
            Console.WriteLine("El carro está apagado.");
        }
    }

    public void MostrarEstado()
    {
        string encendido = Estado? "Encendido" : "Apagado";
        Console.WriteLine($"El carro {Color} | Estado: {encendido} | Velocidad: {Velocidad} km/h | Direccion: {Direccion}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Carro miCarro = new Carro("rojo");
        Boton boton = new Boton("gris", 2.5f);

        Console.WriteLine("E=Encender | Q=Apagar | W=Acerlerar | S=Frenar | D=Derecha | A=Izquierda | I=Estado | ESC=Salir| ");
        while (true)
        {
            ConsoleKeyInfo tecla = Console.ReadKey(true);
            boton.Presionar();

            switch (tecla.Key)
            {
                case ConsoleKey.E:
                    miCarro.Encender();
                    break;
                case ConsoleKey.Q:
                    miCarro.Apagar();
                    break;
                case ConsoleKey.W:
                    miCarro.Acelerar();
                    break;
                case ConsoleKey.S:
                    miCarro.Frenar();
                    break;
                case ConsoleKey.D:
                    miCarro.DoblarDerecha();
                    break;
                case ConsoleKey.A:
                    miCarro.DoblarIzquierda();
                    break;
                case ConsoleKey.I:
                    miCarro.MostrarEstado();
                    break;
                case ConsoleKey.Escape:
                    Console.WriteLine("Saliendo...");
                    return;
            }

            boton.Soltar();
        }
    }
}