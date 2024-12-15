using System;

namespace Problema_8
{
	
	class Program
	{
		public static int enterInt(string message= "Digite un número entero positivo: ")
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
					Console.WriteLine("ERROR GARRAFAL: No has ingresado un NÚMERO ENTERO D:");
					Console.WriteLine("Pero puedes intentar de nuevo :D :");
				
				}
			
			}
			return val;
		
		}
		
		public static void Main(string[] args)
		{
			int n,cont=0,i,j;
			Console.Title="Criba de Sundaram";
			Console.BackgroundColor=ConsoleColor.DarkBlue;
			Console.ForegroundColor=ConsoleColor.White;
			Console.Clear();
			n=enterInt();
			
			if(n<0)
			{
				Console.WriteLine("Este.... No has ingresado un número positivo :(");
				
				while(n<0)
				{
					n=enterInt();
				
				}
			
			}
			
			for(i=1;n>=i;i++)
			{
				for(j=1; i>=j;j++)
				{
					if(i%j==0)
					{
						cont++;
					
					}
				
				}
				
				if(cont==2)
				{
					Console.Write(" {0} ",i);
					cont=0;
				}
				
				else
				{
					cont=0;
				}
				
			
			}
			Console.WriteLine();
			
			Console.Write("Ha det bra! ");
			Console.ReadKey(true);
		}
	}
}