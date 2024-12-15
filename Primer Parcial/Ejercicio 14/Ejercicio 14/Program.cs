using System;

namespace Ejercicio_14
{
	class Program
	{
		public static int enterInt(string message= "Ingrese 8 números: ")
		{
			string ans;
			int n;
			
			while(true)
			{
				Console.WriteLine(message);
				ans=Console.ReadLine();
				
				try
				{
					n=Convert.ToInt32(ans);
					break;
					
				}
				
				catch(FormatException error)
				{
					Console.WriteLine("Oye, no has ingresado un parámetro válido D:");
					Console.WriteLine("Inténtalo de nuevo: ");
				
				}
			
			}
			return n;
		}
		
		
		public static void Main(string[] args)
		{
			int[] num=new int[8];
			
			int i,tmp,value,temp1=0,temp2=0,p;
			
			for(i=0;i<8;i++)
			{
				value=8-i;
				
				num[i]=enterInt();
			}
			Console.WriteLine("");
			for(i=0;i<8;i++)
			{
				tmp=num[i];
				if(((i+1)%2)==0)
				{
					temp1=temp1+tmp;
					
				}
				else
				{
					temp2=temp2+tmp;
					
				}
				
			}
			
			temp1=temp1*3; 
			p=10-((temp1+temp2)%10);
			Console.WriteLine("El codigo EAN-8 es el siguiente:");
			
			for(i=0;i<8;i++)
			{
				tmp=num[i];
				Console.Write(tmp + " ");
			}
			Console.WriteLine(p);
			Console.WriteLine();
			Console.Write("Aquí termina el programa, pusa cualquier tecla para continuar...");
			Console.ReadKey(true);
			
			
		}
	}
}