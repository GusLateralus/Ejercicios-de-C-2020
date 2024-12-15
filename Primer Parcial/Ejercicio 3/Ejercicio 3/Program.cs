using System;

namespace Ejercicio_3
{
	class Program
	{
		public static int enterInt(string message= "Ingresa un número entero: ")
		{
			string answer;
			int val;
			
			while(true)
			{
				Console.WriteLine(message);
				answer=Console.ReadLine();
				
				try
				{
					val=Convert.ToInt32(answer);
					break;
				}
				
				catch(FormatException error)
				{
					Console.WriteLine("No has ingresado un parámetro válido D:");
					Console.WriteLine("Inténtalo de nuevo: ");
				}
				
			
			}
			return val;
		
		}
		
		public static void Main(string[] args)
		{   
			int a,b,c;
			
			a= enterInt();
			b= enterInt();
			c= enterInt();
			
			if(a<0 || b<0 || c<0)
			{
				Console.WriteLine("No existen distancias negativas :(");
				
				while(a<0 || b<0 || c<0)
				{
					a= enterInt();
					b= enterInt();
					c= enterInt();
				}
			
			}
			
			
			if(a>0&&b>0&&c>0)
			{
			if((a+b)>c)
			{
			Console.WriteLine("Los numeros {0}, {1}, {2} pueden formar un triangulo ", a,b,c);
			}
			else if((b+c)>a)
			{
			Console.WriteLine("Los numeros {0}, {1}, {2} pueden formar un triangulo ", a,b,c);
			}
			else
			{
			Console.WriteLine("Los numeros {0}, {1}, {2} NO pueden formar un triangulo ", a,b,c);
			}
			}
			else
			{
			Console.WriteLine("Los numeros {0}, {1}, {2} NO pueden formar un triangulo ", a,b,c);
			}
			
			Console.ReadKey();
		}
	}
}