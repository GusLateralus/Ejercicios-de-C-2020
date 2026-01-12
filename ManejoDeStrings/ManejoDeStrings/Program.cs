/*
 Dentro del método Main() declare una variable de tipo string cuyo valor literal sea Cadena;de;texto. 
Luego se debe reemplazar los punto y coma (;) por espacios e imprimir ese resultado en consola. Para esto se debe utilizar 
la función Replace('char','char') dentro de los métodos que nos brinda la clase String
 
 */

using System;
internal class Program
{
    private static void Main(string[] args)
    {
        string cadena = "Cadena;de;texto.";
        Console.WriteLine(cadena.Replace(";"," "));
        
    }
}