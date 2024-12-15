using System;

namespace Ejercicio_10
{
	class Program
	{
		public static int enterInt(string message= "Digita un número entero y positivo a descomponer: ")
		{
			string ans;
			int valor;
			
			while(true)
			{
				Console.WriteLine(message);
				ans=Console.ReadLine();
				
				try
				{
					valor=Convert.ToInt32(ans);
					break;
				}
				
				catch(FormatException error)
				{
					Console.WriteLine("No has ingresado un parámetro válido :(");
					Console.WriteLine("Inténtalo de nuevo");
				
				}
			
			}
			return valor;
		
		}
		
		public static void Main(string[] args)
		{
			int n, unidad, decena, centena, millar;
			
			n = enterInt();
			
			if(n<0)
			{
				Console.WriteLine("No puedes ingresar un número negativo :/");
				
				while(n<0)
				{
					n=enterInt();
				
				}
			
			}
            
            millar = n / 1000;
            millar *=  1000;
            centena = (n - millar)/100;
            centena *=  100;
            decena = (n - (millar + centena))/10;
            decena *= 10;
            unidad = n - (millar+ centena + decena);

            Console.WriteLine("{0} = {1} + {2} + {3} + {4}", n, millar, centena, decena, unidad);
			
			Console.ReadKey();
		}
	}
}