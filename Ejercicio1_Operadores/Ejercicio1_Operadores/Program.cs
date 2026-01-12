/*
 Ejercicio 1 de Operadores: Solicita al usuario que ingrese una temperatura 
en grados Celsius y convierte el valor a Fahrenheit usando la fórmula:
F=C×9/5+32
 */

internal class Program
{
    private static void Main(string[] args)
    {
        int tempCelsius, tempFarenheit;
        Console.WriteLine("Bienvenido");
        Console.WriteLine("Ingrese el valor de la temperatura en °C");
        tempCelsius = Convert.ToInt16(Console.ReadLine());

        tempFarenheit = (tempCelsius * 9 / 5) + 32;
        Console.WriteLine("La temperatura en °F es: {0}", tempFarenheit);

        Console.ReadKey(true);
    }
}