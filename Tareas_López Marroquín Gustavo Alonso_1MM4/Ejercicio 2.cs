/*
 * Generar un algoritmo que indique si al ingresar un año como un número entero positivo, este sea o no bisiesto. 
* Un año es bisiesto si es múltiplo de 4, exceptuando los múltiplos de 100, que sólo son bisiestos 
* cuando son múltiplos además de 400, por ejemplo el año 1900 no fue bisiesto, pero el año 2000 si lo es
 */
using System;

namespace Ejercicio_2
{
	class Program
	{
		
		public static int ingresarInt(string mensaje = "Ingresar un valor entero: ")
		{
			string resp;
			int valor;
			
			while(true)
			{
				
				Console.WriteLine(mensaje);
				resp = Console.ReadLine();
				
				try
				{
					
					valor = Convert.ToInt32(resp);
					
					break;
				}
				
				catch(FormatException e)
				{
					Console.WriteLine("El valor no es un número entero");
					Console.WriteLine("¡Favor de ingresar de nuevo!");
				}
			}
		
			return valor;
		}
		
		public static void Main(string[] args)
		{
			
			int year;
	           
			year = ingresarInt();
			
	        
			if(year<0)
			{
				Console.WriteLine("Este... No existen años negativos :C");
				
				while(year<0)
				{
					//Console.WriteLine("Pero inténtalo de nuevo, ingresa un número entero POSITIVO: ");
					year= ingresarInt();
					
				
				}
				               
			}
			
			
		
			if( (year % 4 == 0)&&(year % 100 != 0)||(year % 400 == 0) )
				Console.WriteLine("El año {0} es bisiesto", year);
			else
				Console.WriteLine("El año {0} NO es bisiesto", year);
			
			Console.Write("Presione una tecla para continuar . . . ");
			Console.ReadKey();	
		
	}
	
	
	
	}
}
		