using System;
using System.IO;

namespace Tiro_parabolico
{
	class Program
	{
		public static double enterDoub(string message= "Ingrese el parámetro indicado: ")
		{
			string ans;
			double value;
			
			Console.ForegroundColor=ConsoleColor.Yellow;
			
			while(true)
			{
				Console.WriteLine(message);
				ans=Console.ReadLine();
				
				try
				{
					value=Convert.ToDouble(ans);
					break;
				
				}
				
				catch(FormatException error)
				{
					Console.WriteLine("No has ingresado un parámetro válido :(");
					Console.WriteLine("Inténtalo de nuevo: ");
				
				}
			
			}
			return value;
		
		}
		
		
		public static void Main(string[] args)
		{
			double angulo=0,v0 =0,y0= 0,g=0,p=0,pasoi=0,vy=0,t=0,totalTime=0,xt=0,yt=0;
			string tabla;
		    Console.Title = "PHYSICS SIMULATION";
			
			Console.CursorVisible = true;
		    Console.CursorSize = 50;
			Console.ForegroundColor = ConsoleColor.Green;
			Console.BackgroundColor = ConsoleColor.Black;
			Console.Clear();
			
			Console.WriteLine("\tSIMULADOR DE TIRO PARABÓLICO.\n");
			
			
			tabla = "paso\t\tx\t\ty\t\t\t\ttiempo\n";
			
			do {
				
				angulo = enterDoub("Ingrese el ángulo inicial (0-360°): ");
				
			}while(angulo >360 || angulo <= 0);
			
			Console.ForegroundColor=ConsoleColor.Green;
			
			do {
				v0 = enterDoub("Ingrese la velocidad inicial Vo: ");
			}while( v0 <0);
			
			Console.ForegroundColor=ConsoleColor.Green;
			
			do {
				
				y0 = enterDoub("Ingrese la altura inicial y0: ");
				
			}while( y0 <0);
			
			Console.ForegroundColor=ConsoleColor.Green;
		
			do {
				
				g = enterDoub("Ingrese el valor de la aceleración de la gravedad: ");
			
			}while( g <0);
			
			Console.ForegroundColor=ConsoleColor.Green;
		
			do {
				
				p = enterDoub("Ingrese el paso de la simulación: ");
			
			}while( p <0);
			
			Console.ForegroundColor=ConsoleColor.Magenta;
			
			pasoi=p;
			totalTime = (2*v0*Math.Sin(angulo * ( Math.PI / 180)))/g;
		    Console.WriteLine(" Tiempo Total= {0}",totalTime);
		    
		   while (p <= totalTime ) {		       
		       totalTime = (2*v0*Math.Sin(angulo * ( Math.PI / 180)))/g;
		       xt = v0*Math.Cos(angulo*( Math.PI / 180))*p;
		       vy = (v0*Math.Sin(angulo*( Math.PI / 180)))-(g*p);
		       yt = y0 +(vy*p) +(0.5*(g)*p*p);
		       
		       tabla += (pasoi.ToString()+"\t\t"+xt.ToString()+", "+ yt.ToString()+"\t\t"+p.ToString() +"\n");
		       
		       Console.WriteLine("Paso= {0}",p);
		       Console.WriteLine(" x= {0}",xt);
		       Console.WriteLine(" y= {0}",yt);
		       Console.WriteLine(" Vy= {0}",vy);
		       p = p + pasoi ;
		   }
		       
		       Console.WriteLine(" t= {0}",totalTime);
			   xt = v0*Math.Cos(angulo*( Math.PI / 180))*totalTime;
		      
		       yt = y0 +(vy*t) +(0.5*(g)*totalTime*totalTime);
		       yt = y0 +(vy*totalTime) +(0.5*(g)*totalTime*totalTime);
		       Console.WriteLine(" x= {0}",xt);
		       Console.WriteLine(" y= {0}",yt);
		  		
			
			File.WriteAllText("tiroparabolico.txt", tabla);
			Console.Write("Listo, hemos terminado :D");
			Console.ReadKey(true);
		}
	}
}