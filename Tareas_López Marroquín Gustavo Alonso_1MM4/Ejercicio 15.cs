using System;

namespace Ejercicio_15
{
	class Program
	{
		public static int enterInt(string message= "Digite el número de filas (intervalo 1-20): ")
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
					Console.WriteLine("ERROR: No has ingresado un parámetro válido");
					Console.Write("Por favor, intenta de nuevo: ");
					
				
				}
			
			}
			return value;
				
			}
			
		
		
		
		public static void Main(string[] args)
		{
			int n,i,j,filas;
			
			Console.WriteLine("B I E N V E N I D O");
			Console.WriteLine("1.-Pirámide");
			Console.WriteLine("2.-Medio diamante");
			Console.WriteLine("3.-Diamante completo");
			Console.WriteLine("4.-Salir");
			
			Console.Write("Digite una opción: ");
			n=Convert.ToInt32(Console.ReadLine());
			
			switch(n)
			{
				case 1:
					
					
					filas=enterInt();
					
					if(filas<0 || filas>20)
					{
						Console.WriteLine("El valor que ingresaste no está contemplado en el parámetro");
						
						while(filas<0 || filas>20)
						{
							filas=enterInt();
						}
					
					}
					
				
					
					for(i=0;i<=filas;i++)
					{
						for(j=0;j<=i;j++)
						{
							Console.Write("*");
						
						}
						Console.WriteLine();
					
					}
					
					break;
					
				case 2:
					
					filas=enterInt();
					
					if(filas<0 || filas>20)
					{
						Console.WriteLine("El valor que ingresaste no está contemplado en el parámetro");
						
						while(filas<0 || filas>20)
						{
							filas=enterInt();
						}
					
					}
					
					for (i = 1; i <= filas; i++)
						{
							for (j = 1; j <= i; j++)
								Console.Write("*");
							Console.Write("\n");
						}
						for (i = filas; i > 0; i--)
						{
							for (j = 0; j < (i - 1); j++)
								Console.Write("*");
							Console.WriteLine();
						}
						Console.WriteLine();
						
					break;
					
				case 3:
					int line,sp,asterisc;
					
					
					filas=enterInt();
					
					if(filas<0 || filas>20)
					{
						Console.WriteLine("El valor que ingresaste no está contemplado en el parámetro");
						
						while(filas<0 || filas>20)
						{
							filas=enterInt();
						}
					
					}
					
					
					for(line=1;line<=filas;line++)
					{
						for(sp=0;sp<filas-line;sp++)
						{
							Console.Write(" ");
						}
						
						for(asterisc=0;asterisc<(line*2)-1;asterisc++)
						{
							Console.Write("*");
						
						}
						
						Console.WriteLine();
					
					}
					
					for(line=filas-1;line>=1;line--)
					{
						for(sp=0;sp<filas-line;sp++)
						{
							Console.Write(" ");
						}
						
						for(asterisc=0;asterisc<(line*2)-1;asterisc++)
						{
							Console.Write("*");
						
						}
						
						Console.WriteLine();
					
					}
					break;
					
				case 4:
					Console.WriteLine("Ha det bra, tusen takk!");
					break;
			
			
			}
				
			Console.ReadKey(true);
		}
	}
}
