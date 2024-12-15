using System;

namespace Ejercicio_8
{
	class Program
	{
		public static int enterInt(string message= "Ingrese el total de números primos a mostrar: ")
		{
			string res;
			int valor;
			
			while(true)
			{
				Console.WriteLine(message);
				res=Console.ReadLine();
				
				try
				{
					valor=Convert.ToInt32(res);
					break;
				}
				
				catch(FormatException error)
				{
					Console.WriteLine("No ingresaste un NÚMERO ENTERO D:");
					Console.WriteLine("Puedes intentar de nuevo: ");
				
				}
			
			}
			return valor;
		}
		
		public static void Main(string[] args)
		{
			int i, y=2;
		    int total=1;
		    int x;
		    
		do
		{
		
		x=enterInt();
		
		}while(x<=0||(x%1)!=0);
		
		while(total<=x)
		{
			Boolean	Primo = true;
			
		for(i=2;i<y;i++)
		{
			if(y%i==0)
			{
				Primo=false;
					break;
			}
		}
		
		if(Primo)
		{
			Console.Write("{0} ",y);
			total++;
		}
		
		y++;
		}
			Console.ReadKey();
		}
	}
}