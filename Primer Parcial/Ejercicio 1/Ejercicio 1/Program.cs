using System;

namespace Ejercicio_1
{
	class Program
	{
		public static int enterInt(string message= "Ingrese un número entero positivo: ")
		{
			string ans;
			int val;
			
			while(true)
			{
				Console.WriteLine(message);
				ans=Console.ReadLine();
				
				try
				{
					val=Convert.ToInt32(ans);
					break;
				}
				
				catch(FormatException error)
				{
					Console.WriteLine("No has ingresado un NÚMERO ENTERO :C");
					Console.WriteLine("Inténtalo de nuevo, amiguit@: ");
				
				}
				
				
			}
			return val;
			
		}
		
		public static void Main(string[] args)
		{
			
			int i,n,fact=1;
			//Console.WriteLine("Ingresa un número entero positivo: ");
			//n=Convert.ToInt32(Console.ReadLine());
			n= enterInt();
			
			
			if(n<0)
			{
				Console.WriteLine("Te dije que un número POSITIVO");
				
				while(n<0)
				{
					Console.WriteLine("Pero está bien, intenta de nuevo");
					n= enterInt();
				}
			
			}
		
			
			for(i=1;i<=n;i++)
			{
				fact *=i;
			}
			
			Console.WriteLine("El factorial del número ingresado es: {0}",fact);
			
			Console.ReadKey(true);
		}
	}
}