// Cadenas 
// Son objetos de la clase System.String, son inmutables igual que en Java
using System.Text;

string cadena = "Holas, Gus";

// Tiene métodos y operaciones básicas:
string mensaje = ", esto es un saludo";

// Concatenación
string mensaje2 = String.Concat(cadena, mensaje);
Console.WriteLine(mensaje2);

// Interpolación
string mensajeInterp = $"{cadena} {mensaje}";

Console.WriteLine(mensajeInterp);

// Obtener propiedades de un string 
Console.WriteLine("Longitud de cadena: "+cadena.Length);
Console.WriteLine("Mayúsculas: "+cadena.ToUpper());
Console.WriteLine("Minúsculas: "+cadena.ToLower());

// Indexación
Console.WriteLine(cadena[0]);//Primer caracter
Console.WriteLine(cadena[cadena.Length-1]); // Último caracter

// Subcadenas
Console.WriteLine(cadena.Substring(0,4)); // Toma una cadena de otra cadena

// Búsqueda de elementos:
Console.WriteLine(cadena.Contains("Hey")); // Devuelve un true o un false si encuentra la cadena o no en la cadena 
Console.WriteLine(cadena.IndexOf("S")); // Devuelve un -1 si no encuentra el caracter, también distingue mayúsculas

// Reemplazar:
string nuevaFrase = cadena.Replace("Holas", "Hola");
Console.WriteLine(nuevaFrase);

// StringBuilder
// Es un objeto como string, pero este sí es mutable, importas el namespace System.Text;
StringBuilder sb = new StringBuilder("Hola");

// Operaciones comunes:
// Agregar texto
sb.Append(" Gus");
Console.WriteLine(sb); // Hola Gus

// Insertar en una posición
sb.Insert(5, "!!!");
Console.WriteLine(sb); // Hola !!!Gus

// Reemplazar
sb.Replace("Gus", "Amigo");
Console.WriteLine(sb); // Hola !!!Amigo

// Eliminar
sb.Remove(5, 3); // elimina 3 caracteres desde posición 5
Console.WriteLine(sb);

// Convertir a string
string resultado = sb.ToString();

