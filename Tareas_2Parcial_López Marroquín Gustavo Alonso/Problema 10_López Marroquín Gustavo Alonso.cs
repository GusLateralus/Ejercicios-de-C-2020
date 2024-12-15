using System;

namespace Problema_10
{
	class Program
	{
		public static void Main(string[] args)
		{
			int i,j,p=1,n=0,sp;
			string cadena;
			Console.Write("Ingresa una cadena que no rebase los ");
			Console.ForegroundColor=ConsoleColor.Red;
			Console.Write("100 caracteres: ");
			Console.ForegroundColor=ConsoleColor.White;
			cadena= Console.ReadLine();
			Console.ForegroundColor=ConsoleColor.Green;
						
			if(cadena.Length>100)
			{
				Console.WriteLine("La cadena ingresada rebasa los 100 caracteres :o");
				while(cadena.Length>100)
				{
					Console.Write("Inténtalo de nuevo: ");
				
				}
			}
			
			Console.WriteLine("{0}",cadena);
			
			for(i=0;i<cadena.Length;i++)
			{
				
				if(cadena[i]==' ')
				{
					n++;
				}
			}
			
			
			for(j=1;j<=n;j++)
			{
				i=0;
				
				for(sp=p;sp<=n;sp=sp)
				{
					
					Console.Write(cadena[i]);
					
					if(cadena[i]==' ')
					{
						sp++;
					}
					i++;
				
				}
				Console.WriteLine();
				p++;
				
			
			}
			              
			Console.ForegroundColor=ConsoleColor.White;
			Console.Write("Ha det bra! ^^");
			Console.ReadKey(true);
		}
	}
}