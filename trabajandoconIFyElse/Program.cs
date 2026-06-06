Console.WriteLine("Ingrese su nombre: ");
string nombreUsuario = Console.ReadLine();

Console.WriteLine("Ingrese su edad: ");
int edadUsuario = int.Parse(Console.ReadLine());

while (edadUsuario < 0)
{
    Console.WriteLine("La edad no puede ser negativa, vuelva a ingresar su edad:");
    edadUsuario = int.Parse(Console.ReadLine());
}

while (edadUsuario >= 95)
{
    Console.WriteLine($"Indicaste que tu edad es {edadUsuario}, ¿Ese dato es correcto? Si es así, escribe S; si no lo es, escribe N");
    string respuesta = Console.ReadLine();
    respuesta = respuesta?.ToUpper() ?? "";

    if (respuesta == "S")
    {
        break;
    }
    else if (respuesta == "N")
    {
        Console.WriteLine("Ingrese nuevamente su edad:");
        edadUsuario = int.Parse(Console.ReadLine());

        while (edadUsuario < 0)
        {
            Console.WriteLine("La edad no puede ser negativa, vuelva a ingresar su edad:");
            edadUsuario = int.Parse(Console.ReadLine());
        }
    }
    else
    {
        Console.WriteLine("Respuesta no válida. Debe escribir S o N.");
    }
}

if (edadUsuario >= 18)
{
    Console.WriteLine($"Bienvenido {nombreUsuario}, acceso concedido.");
}
else
{
    Console.WriteLine($"Lo sentimos {nombreUsuario}, eres menor de edad y no tienes acceso.");
}