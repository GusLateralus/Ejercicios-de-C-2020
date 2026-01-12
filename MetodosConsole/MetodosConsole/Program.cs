internal class Program
{
    private static void Main(string[] args)
    {
        // Ejemplo con ReadLine()
        Console.WriteLine("Por favor, ingresa tu nombre:");
        string nombre = Console.ReadLine();
        Console.WriteLine($"¡Hola, {nombre}!");

        // Ejemplo con Read()
        Console.WriteLine("\nPresiona una tecla para continuar...");
        int tecla = Console.Read(); // Lee un carácter como entero (código ASCII)

        Console.WriteLine($"\nCódigo ASCII de la tecla presionada: {tecla}");
        Console.WriteLine($"Tecla presionada: {(char)tecla}");

        // Finaliza el programa
        Console.WriteLine("\nPresiona Enter para salir...");
        Console.ReadLine(); // Para evitar que la consola se cierre inmediatamente


    }
}