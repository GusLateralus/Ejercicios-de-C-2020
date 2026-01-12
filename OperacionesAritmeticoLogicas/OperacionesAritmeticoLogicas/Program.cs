internal class Program
{
    private static void Main(string[] args)
    {
        // Operadores aritméticos
        Console.WriteLine(5 + 9); // Suma
        Console.WriteLine(5 - 9); // Resta
        Console.WriteLine(5 * 9); // Multiplicación
        Console.WriteLine(5 / 9); // División
        Console.WriteLine(5 % 9); // Módulo

        // Al igual que en C y Java, puedes utilizar +=, -=, *=, /=

        // Operadores lógicos (comparación)
        Console.WriteLine(true && true); // Operador AND
        Console.WriteLine(false || true); // Operador OR
        Console.WriteLine(!true); // Operador NOT

        // Operadores lógicos a nivel de bits
        Console.WriteLine(12 & 10); // Operador AND
        Console.WriteLine(12 | 10); // Operador OR
        Console.WriteLine(12 ^ 10); // Operador XOR
        Console.WriteLine(12 >> 2); // Operador de desplazamiento de bits a la derecha
        Console.WriteLine(12 << 2); // Operador de desplazamiento de bits a la izquierda

        // Funciones matemáticas:
        Console.WriteLine(Math.Max(5, 12)); // Máximo
        Console.WriteLine(Math.Min(5, 10)); // Mínimo
        Console.WriteLine(Math.Sqrt(81)); // Raíz
        Console.WriteLine(Math.Abs(-650)); // Valor absoluto

        Console.ReadKey(true);

    }
}