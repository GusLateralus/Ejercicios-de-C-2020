// Los bucles son estructuras repetitivas.

// Bucle while

int count = 10;

Console.WriteLine("------BUCLE WHILE-------\n");
while (count >= 0)
{
    Console.WriteLine($"{count}");
    count--;
}
Console.WriteLine("------BUCLE FOR-------\n");

// Bucle for
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{i}");

}

Console.WriteLine("--------BUCLE FOR-EACH----------");

string[] frutas = { "Manzana", "Pera", "Guanábana", "Guayaba"};

foreach(string fruta in frutas)
{
    Console.WriteLine(fruta);
}