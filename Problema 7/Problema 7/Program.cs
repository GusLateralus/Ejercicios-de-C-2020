using System;

namespace Problema_7
{
	class Program
	{
		public static void Main(string[] args)
		{
			double i, precision,t=1,t2=1,j=0,val=0,k,ls,val2=1;
			Console.WriteLine("-------Fracción continua de π/4---------");
			Console.WriteLine("Digite un número de precisión para la serie continua: ");
			
			precision=Convert.ToDouble(Console.ReadLine());
			
			for(i=0;i<precision;i++)
			{
				val=j+(t/t2);
				val2=val2/val;
				
				if(i==1)
				{
					j=1;
					t2=4;
				}
				
				else
				{
					ls=j;
					j=j+2;
					k=j+2;
					t=t2;
					t2=j+ls+k;
				}
			
			}
			Console.WriteLine("π/4= {0}",val);
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}