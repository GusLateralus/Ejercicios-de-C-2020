using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Problema_4
{
	
	class ElementoQuim
	{
		protected string nombre;
		protected string simbolo;
		protected int numAtom;
		protected double masa;
		protected double radio;
		protected string estadoOrd;
		
		public ElementoQuim()
		{
			this.nombre = "";
			this.simbolo = "";
			this.numAtom = 0;
			this.masa = 0.0;
			this.radio = 0.0;
			this.estadoOrd = "";
		}
		
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}
		public string Simbolo
		{
			get { return simbolo; }
			set { simbolo = value; }
		}
		public int NumAtom
		{
			get { return numAtom; }
			set { numAtom = value; }
		}
		public double Masa
		{
			get { return masa; }
			set { masa = value; }
		}
		public double Radio
		{
			get { return radio; }
			set { radio = value; }
		}
		public string EstadoOrd
		{
			get { return estadoOrd; }
			set { estadoOrd = value; }
		}
		
		public void newElement()
		{
			StreamWriter escritura = File.AppendText("pokequimidex.txt");
			escritura.WriteLine("\nNombre   : " + this.nombre);
			escritura.WriteLine("\nSímbolo  : " + this.simbolo);
			escritura.WriteLine("\nNúmero Atómico   : " + this.numAtom);
			escritura.WriteLine("\nMasa  : " + this.masa + " g/mol");
			escritura.WriteLine("\nRadio   : " + this.radio + " Angstrom");
			escritura.WriteLine("\nEstado Ordinario (de agregación)   : " + this.estadoOrd);
			escritura.WriteLine();
			escritura.WriteLine(" . . . . . . . . . . . . . . . . . ");
			escritura.Close();
		}
		
		public void readElement()
		{
			StreamReader lectura;
			string cadena;
			try
			{
				lectura = File.OpenText("pokequimidex.txt");
				cadena = lectura.ReadLine();
				while (cadena != null)
				{
					Console.WriteLine(cadena);
					cadena = lectura.ReadLine();
				}
				lectura.Close();
			}
			catch (FileNotFoundException)
			{
				Console.WriteLine("Mmmmm..... Parece que el archivo no existe aún... Deberías crear alguno.");
			}
		}
	}
	
	
	class Program
	{
		public static int enterInt(string mensaje = "Ingresar un valor: ")
		{
			string resp;
			int valor;

			while (true)
			{
				Console.WriteLine(mensaje);
				resp = Console.ReadLine();
				try
				{
					valor = Convert.ToInt32(resp);
					break;
				}
				catch (FormatException)
				{
					Console.WriteLine("Este.... No has ingresado un parámetro válido :/");
					Console.WriteLine("Inténtalo de nuevo");
				}
			}
			return valor;
		}
		public static double enterDoub(string mensaje = "Ingresar un valor: ")
		{
			string resp;
			double valor;
			while (true)
			{
				Console.WriteLine(mensaje);
				resp = Console.ReadLine();
				try
				{
					valor = Convert.ToDouble(resp);
					break;
				}
				catch (FormatException)
				{
					Console.WriteLine("Error Garrafal D: no has ingresado un parámetro válido.");
					Console.WriteLine("Inténtalo de nuevo");
				}
			}
			return valor;
		}
		public static void Main(string[] args)
		{
			Console.BackgroundColor= ConsoleColor.Black;
			Console.ForegroundColor= ConsoleColor.Yellow;
			Console.WriteLine("B I E N V E N U E");
			Console.WriteLine("-------TABLA PERIÓDICA DE LOS ELEMENTOS (Y NO DEL AVATAR)------");
			Console.WriteLine();
			Console.WriteLine("1.- Agregar elementos a la Pokédex... Perdón, a la tabla....");
			Console.WriteLine("2.- Visualizar la Pokédex... Perdón, la tabla....");
			Console.WriteLine("3.- Sácame de aquí, parfavaaaaar.");
			Console.Write("Digite alguna de las opciones según el número que corresponda: ");
			char ans = Convert.ToChar(Console.ReadLine());
			
			switch(ans)
			{
				case '1':
					ElementoQuim elem = new ElementoQuim();
					Console.WriteLine("Nombre del elemento: ");
					elem.Nombre = Console.ReadLine();
					Console.WriteLine("Símbolo: ");
					elem.Simbolo = Console.ReadLine();
					elem.NumAtom = enterInt("Número Atómico: ");
					elem.Masa = enterDoub("Masa: ");
					elem.Radio = enterDoub("Radio: ");
					Console.WriteLine("Estado Ordinario: ");
					elem.EstadoOrd = Console.ReadLine();
					elem.newElement();
					Console.WriteLine();
					Console.WriteLine("Here you go! Puedes encontrar el archivo .txt en la carpeta Problema 4 >> bin >> Debug o con el nombre de: pokequimidex");
					break;

				case '2':

					ElementoQuim leer = new ElementoQuim();
					leer.readElement();

					break;

				case '3':
					Console.WriteLine("Ha en hyggelig dag! ^^");
					
					break;
			}
			Console.WriteLine();
			Console.ReadKey(true);
		}
	}
}

