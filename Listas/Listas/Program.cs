// Son un tipo de colección como un array, pero con tamaño dinámico.

List<int> listaEnteros = new List<int>();

// List<int> listaEnteros = new List<int>(){1,2,3,4,5,6,7,8,9};

// Vamos a meterle elementos del uno al 10:

for (int i = 1; i <= 10; i++)
{ 
    listaEnteros.Add(i);
}

foreach(int num in listaEnteros)
{
    Console.Write(num+" ");
}

// Ejercicio: haz una lista de cervezas