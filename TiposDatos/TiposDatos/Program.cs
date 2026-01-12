using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // Hay muchos tipos de datos, pero veremos los más comunes

        // Valor booleano: sólo toma 2 valores, true o false (1 bit)
        bool miBooleano = true;
        Console.WriteLine("Dato booleano: "+miBooleano);
        // Variable caracter (8 bits)
        char caracter = 'a';
        Console.WriteLine("Dato caracter: " + caracter);
        // Variable entero (32 bits)
        int miNum = 15;
        Console.WriteLine("Dato entero: "+miNum);
        // Variable long (64 bits)
        long otroNum = 15314;
        Console.WriteLine("Dato long: ´"+otroNum);
        // Variable flotante (32 bits), se requiere colocar una 'f' al final del número. 7 dígitos de precisión.
        float numDecimal = 1.2f;
        Console.WriteLine("Dato flotante: "+numDecimal);
        // Variable doble (64 bits), se recomienda para todo. 15 dígitos de precisión
        double pi= 3.141592654;
        Console.WriteLine("Dato doble: "+pi);
        // Variable decimal: tiene alta precisión (28 dígitos), se recomienda para aplicaciones financieras:
        decimal miDecimal = 10.55547281m;
        Console.WriteLine("Dato decimal: "+miDecimal);
        // Variable cadena: es una cadena de caracteres
        string cadena = "Juan Nepomuceno";
        Console.WriteLine("Dato cadena: "+cadena);
       
    }
}