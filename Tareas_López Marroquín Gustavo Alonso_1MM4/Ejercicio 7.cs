/*
 * Generar un algoritmo que permita imprimir los números de la serie de Fibonacci, 
* perimtiendo que se ingrese el número de elementos a desplegar N, como valor entero y positivo.
* Recordar que la serie de Fibonacci es: 0,1,1,2,3,5,8,13,21,34,...
 */
using System;

namespace Ejercicio_7
{
	class Program
	{
		public static int enterInt(string message= "Digite el total de elementos de la serie Fibonacci a mostrar: ")
		{
			string res;
			int valor;
			
			while(true)
			{
				Console.WriteLine(message);
				res=Console.ReadLine();
				
				try
				{
					valor=Convert.ToInt32(res);
					break;
				}
				
				catch(FormatException error)
				{
					Console.WriteLine("ERROR GARRAFAL. No has ingresado un NÚMERO ENTERO D:");
					Console.WriteLine("Inténtalo de nuevo: ");
				
				}
			
			
			
			}
			return valor;
		
		}
		
		
		public static void Main(string[] args)
		{
			int n,i,x=1,y=0,z=1;
			
			
			n=enterInt();
			
			if(n<0)
			{
				Console.WriteLine("Este... No puedes ingresar valores negativos...");
				Console.WriteLine("Pero inténtalo de nuevo");
				
				while(n<0)
				{
					n=enterInt();
				}
			
			}
			
			Console.Write(" 1");
			
			for(i=1;i<n;i++)
			{
				x=y+z;
				y=z;
				z=x;
				Console.Write(" {0}",x);
			}
			
			Console.ReadKey(true);
		}
	}
}