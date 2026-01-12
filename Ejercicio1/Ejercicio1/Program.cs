// Calcula el año de nacimiento con base en la edad de la persona y año actual. Imprime por pantalla.

internal class Program
{
    private static void Main(string[] args)
    {
        int edad, anioActual, anioNacimiento;

        Console.WriteLine("Digite su edad: ");
        edad = int.Parse(Console.ReadLine()); // Aquí el usuario escribe algo, pero si no es un string, tendrás que parsear 

        Console.WriteLine("Digite el año actual: ");
        anioActual = int.Parse(Console.ReadLine());

        anioNacimiento = anioActual - edad;
        Console.WriteLine($"El año de nacimiento es: {anioNacimiento}");


    }
}