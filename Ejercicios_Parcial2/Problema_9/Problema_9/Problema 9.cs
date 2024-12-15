using System;

namespace Problema_9
{
	class Program
	{
		public static int enterInt(string mensaje= "Ingrese la longitud de la contraseña a generar (1-10): ")
		{
			string ans;
			int val;
			
			
			while(true)
			{
				Console.WriteLine(mensaje);
				ans=Console.ReadLine();
				
				try
				{
					val=Convert.ToInt32(ans);
					break;
				}
				
				catch(FormatException error)
				{
					Console.WriteLine("No has ingresado un número entero");
					Console.WriteLine("Inténtalo de nuevo ");
				
				}
			}
			return val;
		}
		
		public static class Password
		{
			public static string GenerarPassword(int longitud)
			{
				
				string contrasenia= string.Empty;
				string[] letras= {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
				Random Aleatoria= new Random();
				
				for(int i=0;i<longitud;i++)
				{
					int LetraAleatoria= Aleatoria.Next(0,100);
					int NumeroAleatorio= Aleatoria.Next(0,9);
					
					if(LetraAleatoria< letras.Length)
					{
						contrasenia += letras[LetraAleatoria];
					}
					else
					{
						contrasenia += NumeroAleatorio.ToString();
					}
				}
				return contrasenia;
					
			
			}
		
		
		}
		public static void Main(string[] args)
		{
			int longitud;
			Console.BackgroundColor=ConsoleColor.Blue;
			Console.ForegroundColor=ConsoleColor.White;
			Console.Clear();
			Console.WriteLine("Hola, esta interfaz tal vez recuerde un poco a Turbo Pascal...");
			longitud=enterInt();
			
			if(longitud<=0 || longitud>10)
			{
				Console.ForegroundColor=ConsoleColor.Red;
				Console.WriteLine("No has ingresado un parámetro correcto: ");
				
				while(longitud<=0 || longitud>10)
				{
					Console.ForegroundColor=ConsoleColor.White;
					longitud=enterInt();
				}
			
			}
			
			Console.ForegroundColor=ConsoleColor.Yellow;
			Console.WriteLine("La contraseña generada es: " +Password.GenerarPassword(longitud));
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}