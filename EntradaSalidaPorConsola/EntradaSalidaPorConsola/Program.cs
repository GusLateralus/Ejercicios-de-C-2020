internal class Program
{
    private static void Main(string[] args)
    {
        string nombre = "Juan Nepomuceno";
        double numDecimal = 3.141592654;
        float otroDecimal = 3.1415f;
        string nombreUsuario;
        int edad;
        Console.WriteLine("Estas son las variables: ");

        Console.WriteLine(numDecimal);
        Console.WriteLine(otroDecimal);
        // Para mostrar una cadena de texto y una variable:
        Console.WriteLine("Ahí les mando a mi querido "+nombre);
        Console.WriteLine("El nombre de mi valedor es {0} y su calificación fue {1}", nombre, otroDecimal);
        // Hay más maneras de hacer la salida por consola:
        Console.WriteLine("El nombre de mi valedor es "+nombre+" y su calificación fue "+otroDecimal);
        // A partir de C# 6, existe la interpolación de cadenas
        Console.WriteLine($"El nombre de mi valedor es {nombre} y su calificación fue {otroDecimal}");

        // Veamos como ingresar datos por teclado en C#

        Console.WriteLine("Ingrese su nombre: ");

        nombreUsuario = Console.ReadLine(); // Utilizamos el método ReadLine() de la clase Console
        Console.WriteLine($"Nombre: {nombreUsuario}");

        // Sin embargo, este método lo que regresa es una cadena de texto, veamos que pasa en el caso de que tengamos otro tipo de dato:
        Console.WriteLine("Digite su edad: ");
        edad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Edad: {edad}");

    }
}