/*
 * Generar un algoritmo que permita obtener una cantidad N de números pseudoaleatorios 
* (donde N es un número entero, mayor a 0) utilizando para ello el método/algoritmo de generación de números congruencial.
* En el siguiente documento se encuentra información junto con ejemplos para probar el algoritmo
 */
using System;

namespace Ejercicio_12
{
	class Program
	{
		
		public static void Main()
		{ 
			float a,b,m,xn,n,N;
			float num;
			
			Console.WriteLine("Ingrese los parámetros a,b,m: ");
			
			a=Convert.ToInt32(Console.ReadLine());
			b=Convert.ToInt32(Console.ReadLine());
			m=Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("Ingrese los números a obtener: ");
			N=Convert.ToInt32(Console.ReadLine());
			
			n=0;
			
			Console.WriteLine("Genere un número semilla: ");
			xn=Convert.ToInt32(Console.ReadLine());
			
			while(n<=N)
			{
				num=xn/m;
				xn=((a*xn)+b)%m;
				n++;
				Console.WriteLine("{0}. Número aleatorio generado: {1}",n,num);
			
			
			}
		
		
		 Console.ReadKey();
		}
		
		
			
			
	   
}
}
