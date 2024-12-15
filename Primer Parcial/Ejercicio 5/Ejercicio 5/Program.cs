/*
 * 5.-Generar un algoritmo que indique si al ingresar un número entero positivo, este es par o impar
 * 
 */
using System;

namespace Ejercicio_5
{
	class Program
	{
		public static int enterInt(string message= "Ingrese un número entero positivo para evaluar: ")
		{
			string ans;
			int value;
			
			while(true)
			{
				Console.WriteLine(message);
				ans=Console.ReadLine();
				
				try
				{
					value=Convert.ToInt32(ans);
					break;
				}
				
				catch(FormatException error)
				{
					Console.WriteLine("No has ingresado un NÚMERO ENTERO D:");
					Console.WriteLine("Inténtelo de nuevo :D ");
				
				}
			
			}
		
			return value;
		}
		
		public static void Main(string[] args)
		{
			
			int n;
			
			n= enterInt();
			
			if(n<0)
			{
				Console.WriteLine("No has ingresado un número POSITIVO :(");
				
				while(n<0)	
				{
					Console.WriteLine("Pero no te preocupes, puedes intentarlo otra vez :D");
					n= enterInt();
				}
			}
			
			
			if(n%2==0)
			{
				Console.WriteLine("El número es par");
			}
			
			else
			{
				Console.WriteLine("El número es impar");
			}
			
			Console.ReadKey();
		}
	}
}