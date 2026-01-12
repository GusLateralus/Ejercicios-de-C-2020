/*
 Cálculo del área y perímetro de un rectángulo
Solicita al usuario la base y la altura de un rectángulo. Calcula y muestra el área y el perímetro.

A = B*H
Perimetro = 2*(B+H)
 
 */

internal class Program
{
    private static void Main(string[] args)
    {
        double b, altura, area, perimetro;
        Console.WriteLine("Bienvenido");
        Console.WriteLine("Digite el valor de la base del rectángulo: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite el valor de la altura del rectángulo: ");
        altura = Convert.ToDouble(Console.ReadLine());
        area = b * altura;
        perimetro=2*(b+altura);

        Console.WriteLine($"Área: {area}\nPerímetro : {perimetro}");
        Console.ReadKey(true);
    }
}