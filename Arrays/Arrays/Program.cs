// Vectores y matrices
int[] nums = new int[5];

nums[0] = 1;
nums[1] = 2;
nums[2] = 3;
nums[3] = 4;
nums[4] = 5;

Console.WriteLine("-----ELEMENTOS DE UN ARRAY CON FOREACH-----");

foreach (int i in nums)
{
    Console.WriteLine(i);
}

Console.WriteLine("---------ELEMENTOS DE UN ARRAY CON FOR------");

for(int i = nums.Length-1; i >= 0; i--)
{
    Console.WriteLine(nums[i]);
}


// Matrices:
// 1. Cuadradas:

int[,] matrizCuadrada = new int[3,3];

matrizCuadrada[0,0] = 1;
matrizCuadrada[0,1] = 2;
matrizCuadrada[0,2] = 3;
matrizCuadrada[1,0] = 4;
matrizCuadrada[1,1] = 5;
matrizCuadrada[1,2] = 6;
matrizCuadrada[2,0] = 7;
matrizCuadrada[2,1] = 8;
matrizCuadrada[2,2] = 9;

Console.WriteLine("---------------MATRIZ CUADRADA--------------");

for(int i = 0; i<matrizCuadrada.GetLength(0);i++) // La primera dimensión (filas)
{
    for(int j = 0; j < matrizCuadrada.GetLength(1); j++) // La segunda dimensión (columnas)
    {
        Console.Write(matrizCuadrada[i,j]+" ");

    }
    Console.WriteLine();
}

// 2. Jagged:
// Es otra forma de declarar matrices
Console.WriteLine("------------MATRIZ NO CUADRADA O JAGGED----------");

int[][] matriz = new int[3][];
matriz[0] = new int[2]; // fila 1 con 2 columnas
matriz[1] = new int[4]; // fila 2 con 4 columnas
matriz[2] = new int[3]; // fila 3 con 3 columnas

// Asignando valores
matriz[0][0] = 10;
matriz[0][1] = 20;

matriz[1][0] = 30;
matriz[1][1] = 40;
matriz[1][2] = 50;
matriz[1][3] = 60;

// Recorrido con for:
for(int i = 0; i < matriz.Length; i++)
{
    for (int j = 0;j < matriz[i].Length; j++)
    {
        Console.Write(matriz[i][j]+" ");
    }
    Console.WriteLine();
}