// Variables y operadores:

//Enteros:
int edad = 56;
double peso = 72.5;
string nombre = "Gustavo";
bool estudiante = true;
char inicial = 'G';

Console.WriteLine($"Hola {nombre}, tienes {edad} años");

// Operadores en C#
int a = 10;
int b = 3;

Console.WriteLine($"Suma de números: {a+b}"); // Suma
Console.WriteLine($"Resta de números: {a - b}"); // Resta
Console.WriteLine($"Multiplicación de números: {a*b}"); // Multiplicación
Console.WriteLine($"Divsión de números: {a / b}"); // División
Console.WriteLine($"Residuo o módulo: {a % b}"); // Residuo o módulo

// Operadores lógicos:

int edad2 = 26;
Console.WriteLine(edad2 > 18); // true
Console.WriteLine(edad2== 30); // false


bool tieneLicencia = true;
bool mayorEdad = true;

Console.WriteLine(tieneLicencia && mayorEdad); // true
Console.WriteLine(tieneLicencia || !mayorEdad); // true
