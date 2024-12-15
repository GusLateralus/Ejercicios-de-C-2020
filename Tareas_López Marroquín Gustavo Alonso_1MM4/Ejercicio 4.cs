/*
 * 4.-Generar un algortimo que permita generar un triángulo con *, 
*  solicitando al usuario el número de filas a generar (en un intervalo de 1 a 10)
 */
using System;

namespace Ejercicio_4
{
	class Program
	{
		public static int enterInt(string message= "Digite el número de filas de la pirámide (intervalo de 1-10): ")
		{
			string ans;
			int val;
			
			while(true)
			{
				Console.WriteLine(message);
				ans=Console.ReadLine();
				
				try
				{
					val= Convert.ToInt32(ans);
					
					break;
				}
				
				catch(FormatException error)
				{
					Console.WriteLine("No has ingreasado un NÚMERO ENTERO D:");
					Console.WriteLine("Por favor, intenta de nuevo: ");
				}
			
			}
			return val;
		
		}
		
		public static void Main(string[] args)
		{
			
			int n,line,sp,asterisc;
			
			
			n= enterInt();
			
			if(n<0 || n>10)
			{
				Console.WriteLine("El número de filas debe ser entre 1 y 10");
				
				while(n<0 || n>10)
				{
					n= enterInt();
					
				}
			
			}
			
			for(line=1;line<=n;line++)
			{
				for(sp=0;sp<n-line;sp++)
				{
					Console.Write(" ");
				}
				
				for(asterisc=0;asterisc<(line*2)-1;asterisc++)
				{
					Console.Write("*");
				}
				
				Console.WriteLine();
				
			}
			Console.ReadKey(true);
		}
	}
}