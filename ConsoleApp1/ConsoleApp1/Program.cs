// a) Imprime si a es mayor, menor o igual que b

int a, b;

Console.WriteLine("Digite dos números enteros cualesquiera: ");

a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());

if(a>b)
{
    Console.WriteLine($"El número {a} es mayor que {b}");
}
else
{
    if (b > a)
    {
        Console.WriteLine($"El número {b} es mayor que {a}");
    }
    else if (b == a)
    {
        Console.WriteLine("Los números ingresados son idénticos");
        
    }
}

