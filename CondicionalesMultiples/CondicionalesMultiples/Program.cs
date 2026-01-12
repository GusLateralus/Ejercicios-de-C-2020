// La sentencia switch es útil cuando hay múltiples condiciones, como en un menú.
Console.WriteLine("Elige un número entre 1 y 3");
int opcion = int.Parse(Console.ReadLine());

switch (opcion)
{
    case 1:
        Console.WriteLine("Elegiste UNO");
        break;
    case 2:
        Console.WriteLine("Elegiste DOS");
        break;
    case 3:
        Console.WriteLine("Elegiste TRES");
        break;
    default:
        Console.WriteLine("No elegiste ninguna opción");
        break;
}