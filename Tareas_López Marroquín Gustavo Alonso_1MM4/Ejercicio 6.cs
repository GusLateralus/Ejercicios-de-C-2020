using System;

namespace Ejercicio_6
{
	class Program
	{
		public static int enterInt(string message= "Ingresa un número: ")
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
					Console.WriteLine("No has ingresado un parámetro válido D:");
					Console.WriteLine("Inténtalo otra vez: ");
				}
			
			}
			return val;
		}
		
		public static void Main(string[] args)
		{
			int minC,maxD,a,b,x,y,r;
			
			
			a=enterInt();
			b=enterInt();
			
			if(a<0 || b<0)
			{
				Console.WriteLine("Este... No puedes ingresar números negativos :(");
				Console.WriteLine("Pero inténtalo otra vez");
				
				while(a<0 || b<0)
				{
					a=enterInt();
					b=enterInt();
				}
			
			}
			
			x=a;
			y=b;
			
			while(y!=0)
			{
				r=x%y;
				x=y;
				y=r;
			
			}
			
			maxD=x;
			
			minC=(a*b)/maxD;
			
			Console.WriteLine("El máximo común divisor de los números {0} y {1} es: {2}",a,b,maxD);
			Console.WriteLine("El mínimo común múltiplo de los números {0} y {1} es: {2}",a,b,minC);
			
			
			Console.ReadKey(true);
		}
	}
}