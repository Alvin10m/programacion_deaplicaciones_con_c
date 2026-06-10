
/*


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

*/












/*

Console.WriteLine("Ingrese la calificación del estudiante: ");
float calificacion = float.Parse(Console.ReadLine());

while (calificacion < 0)
{
    Console.WriteLine("La calificación no puede ser un valor negativo. Ingrese la calificación nuevamente:");
    calificacion = float.Parse(Console.ReadLine());
}
while (calificacion > 100)
{
    Console.WriteLine("La calificación no puede ser mayor a 100. Ingrese la calificación nuevamente:");
    calificacion = float.Parse(Console.ReadLine());
}

if (calificacion >= 60)
{
    Console.WriteLine("El estudiante ha sido aprobado.");
}
else
{
    Console.WriteLine("El estudiante no ha sido aprobado.");
}

*/











/*

Console.WriteLine("Ingrese un número entero: ");
int valor = int.Parse(Console.ReadLine());
 
if (valor % 2 == 0)
{
    Console.WriteLine("El número ingresado es par.");
}
else
{
    Console.WriteLine("El número ingresado es impar.");
}
 
*/












/*

string tarjetaCorrecta = "1234567890";
string contraseniaCorrecta = "1234";
float saldo = 15000;
 

Console.WriteLine("Ingrese su número de tarjeta: ");
string tarjeta = Console.ReadLine();
 

Console.WriteLine("Ingrese su contraseña: ");
string contrasenia = Console.ReadLine();
 
while (tarjeta != tarjetaCorrecta || contrasenia != contraseniaCorrecta)
{
    Console.WriteLine("Tarjeta o contraseña incorrectas. Intente de nuevo.");
    Console.WriteLine("Ingrese su número de tarjeta: ");
    tarjeta = Console.ReadLine();
    Console.WriteLine("Ingrese su contraseña: ");
    contrasenia = Console.ReadLine();
}
 
Console.WriteLine("Acceso concedido. Bienvenido.");
 

string opcion = "";
 
while (opcion != "3")
{
    Console.WriteLine("\n═══════════════════════════");
    Console.WriteLine("       CAJERO AUTOMÁTICO      ");
    Console.WriteLine("═══════════════════════════");
    Console.WriteLine("1. Mostrar saldo");
    Console.WriteLine("2. Realizar retiro");
    Console.WriteLine("3. Salir");
    Console.WriteLine("═══════════════════════════");
    Console.WriteLine("Seleccione una opción: ");
    opcion = Console.ReadLine();
 
    if (opcion == "1")
    {
        Console.WriteLine($"Su saldo disponible es: RD$ {saldo}");
    }
    else if (opcion == "2")
    {
        Console.WriteLine("Ingrese la cantidad a retirar: ");
        float cantidad = float.Parse(Console.ReadLine());
 
        if (cantidad <= saldo)
        {
            saldo = saldo - cantidad;
            Console.WriteLine($"Retiro exitoso. Dinero retirado: RD$ {cantidad}");
            Console.WriteLine($"Saldo restante: RD$ {saldo}");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente. Operación cancelada.");
        }
    }
    else if (opcion == "3")
    {
        Console.WriteLine("Gracias por usar el cajero. Hasta luego.");
    }
    else
    {
        Console.WriteLine("Opción no válida. Por favor seleccione 1, 2 o 3.");
    }
}
 
*/








/*

Console.WriteLine("Ingrese un número del 1 al 7: ");
int dia = int.Parse(Console.ReadLine());
 
switch (dia)
{
    case 1:
        Console.WriteLine("Lunes");
        break;
    case 2:
        Console.WriteLine("Martes");
        break;
    case 3:
        Console.WriteLine("Miércoles");
        break;
    case 4:
        Console.WriteLine("Jueves");
        break;
    case 5:
        Console.WriteLine("Viernes");
        break;
    case 6:
        Console.WriteLine("Sábado");
        break;
    case 7:
        Console.WriteLine("Domingo");
        break;
    default:
        Console.WriteLine("Día inválido. Ingrese un número entre 1 y 7.");
        break;
}
 










/*

Console.WriteLine("Ingrese la temperatura actual en grados Celsius: ");
float temperatura = float.Parse(Console.ReadLine());
 
if (temperatura < 15)
{
    Console.WriteLine("Clima frío.");
}
else if (temperatura >= 15 && temperatura <= 28)
{
    Console.WriteLine("Clima templado.");
}
else
{
    Console.WriteLine("Alerta: clima cálido.");
}
 
*/







/*


Console.WriteLine("Ingrese el primer número: ");
float numero1 = float.Parse(Console.ReadLine());
 
Console.WriteLine("Ingrese el segundo número: ");
float numero2 = float.Parse(Console.ReadLine());
 
Console.WriteLine("Ingrese la operación (+, -, *, /): ");
string operacion = Console.ReadLine();
 
switch (operacion)
{
    case "+":
        Console.WriteLine($"Resultado: {numero1 + numero2}");
        break;
    case "-":
        Console.WriteLine($"Resultado: {numero1 - numero2}");
        break;
    case "*":
        Console.WriteLine($"Resultado: {numero1 * numero2}");
        break;
    case "/":
        if (numero2 == 0)
        {
            Console.WriteLine("Error: no se puede dividir entre cero.");
        }
        else
        {
            Console.WriteLine($"Resultado: {numero1 / numero2}");
        }
        break;
    default:
        Console.WriteLine("Operación no válida. Use +, -, * o /.");
        break;
}
 

*/






/*


Console.WriteLine("Ingrese su letra de rol (A: Administrador, E: Editor, U: Autor, L: Lector): ");
string rol = Console.ReadLine()?.ToUpper() ?? "";
 
switch (rol)
{
    case "A":
        Console.WriteLine("Rol: Administrador");
        Console.WriteLine("Permisos: Gestionar usuarios, configurar sistema, acceso total.");
        break;
    case "E":
        Console.WriteLine("Rol: Editor");
        Console.WriteLine("Permisos: Crear, editar y publicar contenido.");
        break;
    case "U":
        Console.WriteLine("Rol: Autor");
        Console.WriteLine("Permisos: Crear y editar su propio contenido.");
        break;
    case "L":
        Console.WriteLine("Rol: Lector");
        Console.WriteLine("Permisos: Ver contenido publicado.");
        break;
    default:
        Console.WriteLine("Rol: Invitado");
        Console.WriteLine("Permisos: Acceso limitado a contenido público.");
        break;
}
 
*/








/*


Console.WriteLine("===========================");
Console.WriteLine("     MÁQUINA DE BEBIDAS    ");
Console.WriteLine("===========================");
Console.WriteLine("1. Café        - RD$ 50");
Console.WriteLine("2. Té          - RD$ 40");
Console.WriteLine("3. Chocolate   - RD$ 60");
Console.WriteLine("4. Capuchino   - RD$ 75");
Console.WriteLine("============================");
Console.WriteLine("Seleccione una opción: ");
int opcion = int.Parse(Console.ReadLine());
 
switch (opcion)
{
    case 1:
        Console.WriteLine("Producto: Café");
        Console.WriteLine("Precio: RD$ 50");
        break;
    case 2:
        Console.WriteLine("Producto: Té");
        Console.WriteLine("Precio: RD$ 40");
        break;
    case 3:
        Console.WriteLine("Producto: Chocolate");
        Console.WriteLine("Precio: RD$ 60");
        break;
    case 4:
        Console.WriteLine("Producto: Capuchino");
        Console.WriteLine("Precio: RD$ 75");
        break;
    default:
        Console.WriteLine("Opción no disponible. Seleccione del 1 al 4.");
        break;
}
 
*/





/*


Console.WriteLine("Ingrese el nombre de un mes (ejemplo: Enero, Julio): ");
string mes = Console.ReadLine()?.ToLower() ?? "";
 
switch (mes)
{
    case "diciembre":
    case "enero":
    case "febrero":
        Console.WriteLine($"El mes {mes} pertenece a: Invierno.");
        break;
    case "marzo":
    case "abril":
    case "mayo":
        Console.WriteLine($"El mes {mes} pertenece a: Primavera.");
        break;
    case "junio":
    case "julio":
    case "agosto":
        Console.WriteLine($"El mes {mes} pertenece a: Verano.");
        break;
    case "septiembre":
    case "octubre":
    case "noviembre":
        Console.WriteLine($"El mes {mes} pertenece a: Otoño.");
        break;
    default:
        Console.WriteLine($"'{mes}' no es un mes válido.");
        break;
}
 
*/