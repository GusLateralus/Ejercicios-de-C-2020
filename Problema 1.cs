/*Generar un algoritmo que permita calcular el factorial de un número N ingresado por el usuario, 
 * debe tomarse en cuenta que el usuario solo puede ingresar números enteros y positivos
*/
using System;

namespace Prueba
{
	class Program
	{
		public static void Main()
		{
			int i,n,fact=1;
			Console.WriteLine("Ingresa un número entero positivo: ");
			n=Convert.ToInt32(Console.ReadLine());
			
			
			for(i=1;i<=n;i++)
			{
				fact *=i;
			}
			
			Console.WriteLine("El factorial del número es: {0}",fact);
			
			Console.ReadKey(true);
			
		}
	}
}