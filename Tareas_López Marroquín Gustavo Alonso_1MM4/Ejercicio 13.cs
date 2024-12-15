using System;

namespace Ejercicio_13
{
	class Program
	{
		
		public static int enterInt(string message= "Ingrese el número de filas: ")
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
					Console.WriteLine("No ingresaste un parámetro válido :(");
					Console.WriteLine("Pero inténtalo de nuevo: ");
				
				}
			
			}
			return value;
		}
		
		
		public static void Main(string[] args)
		{
			int n,r,fila,sp,c=1;
			
	
			fila=enterInt();
			
			if(fila<0)
			{
				Console.WriteLine("No puedes ingresar números negativos :|");
				
				while(fila<0)
				{
					Console.WriteLine("Pero inténtalo de nuevo");
					fila=enterInt();
				
				}
			
			
			}
			
			Console.WriteLine();
			
			for(n=0;n<fila;n++)
			{
				for(sp=1;sp<fila-n;sp++)
				{
					Console.Write(" ");
				}
				
				for(r=0;r<=n;r++)
				{
					if(n==0 || r==0)
					{
						c=1;
						//Console.Write(c+,"\t);
					}
					
					else
					{
						c= c*(n-r+1)/r;
						
					}
					Console.Write(c+"\t");
				}
				Console.WriteLine();
			
			}
			
			Console.ReadKey(true);
		}
	}
}