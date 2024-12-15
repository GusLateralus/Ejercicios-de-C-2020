using System;
using System.Text;
using System.Collections;

	
namespace Problema_2
{


public class RFC
{
	public static void Main()
	{
		Console.Title="Calculadora de RFC";
		Console.BackgroundColor=ConsoleColor.Blue;
		Console.ForegroundColor=ConsoleColor.Yellow;
		Console.Clear();
		string nom, apell1, apell2,fecha;
		Console.WriteLine("\tR F C");
		Console.WriteLine("Ingrese su nombre:");
		nom=Console.ReadLine();
		Console.WriteLine("Ingrese su apellido Paterno:");
		apell1=Console.ReadLine();
		Console.WriteLine("Ingrese su apellido Materno: ");
		apell2=Console.ReadLine();
		Console.WriteLine("Ingrese su fecha de nacimento con formato: xx/xx/xxxx");
		fecha=Console.ReadLine();
		Console.WriteLine(CalcularRFC(nom,apell1,apell2,fecha));
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
	
	static public string CalcularRFC(string nombre, string apellidoPaterno, string apellidoMaterno, string fecha)
	{
		
		nombre = nombre.ToUpper();
		apellidoPaterno = apellidoPaterno.ToUpper();
		apellidoMaterno = apellidoMaterno.ToUpper();

		
		string rfc = String.Empty;

		
		nombre.Trim();
		apellidoPaterno = apellidoPaterno.Trim();
		apellidoMaterno = apellidoMaterno.Trim();
	
		
		apellidoPaterno = QuitarArticulos(apellidoPaterno);
		apellidoMaterno = QuitarArticulos(apellidoMaterno);

		
		rfc = apellidoPaterno.Substring(0, 1);

		foreach (char c in apellidoPaterno)
		{
			if (EsVocal(c))
			{
				rfc += c;
				break;
			}
		}

		
		rfc += apellidoMaterno.Substring(0, 1);

		
		rfc += nombre.Substring(0, 1);

		
		rfc += fecha.Substring(6, 2) +
			fecha.Substring(3, 2) +
			fecha.Substring(0, 2);

		 
		CalcularHomoclave(apellidoPaterno + " " + apellidoMaterno + " " + nombre, fecha, ref rfc);

		return rfc;
	}

	
	static private void CalcularHomoclave(string nombreCompleto, string fecha, ref string rfc)
	{
		StringBuilder nombreEnNumero = new StringBuilder(); ;
		
		long valorSuma = 0;

		Hashtable tablaRFC1 = new Hashtable();
		tablaRFC1.Add("&", 10);
		tablaRFC1.Add("Ñ", 10);
		tablaRFC1.Add("A", 11);
		tablaRFC1.Add("B", 12);
		tablaRFC1.Add("C", 13);
		tablaRFC1.Add("D", 14);
		tablaRFC1.Add("E", 15);
		tablaRFC1.Add("F", 16);
		tablaRFC1.Add("G", 17);
		tablaRFC1.Add("H", 18);
		tablaRFC1.Add("I", 19);
		tablaRFC1.Add("J", 21);
		tablaRFC1.Add("K", 22);
		tablaRFC1.Add("L", 23);
		tablaRFC1.Add("M", 24);
		tablaRFC1.Add("N", 25);
		tablaRFC1.Add("O", 26);
		tablaRFC1.Add("P", 27);
		tablaRFC1.Add("Q", 28);
		tablaRFC1.Add("R", 29);
		tablaRFC1.Add("S", 32);
		tablaRFC1.Add("T", 33);
		tablaRFC1.Add("U", 34);
		tablaRFC1.Add("V", 35);
		tablaRFC1.Add("W", 36);
		tablaRFC1.Add("X", 37);
		tablaRFC1.Add("Y", 38);
		tablaRFC1.Add("Z", 39);
		tablaRFC1.Add("0", 0);
		tablaRFC1.Add("1", 1);
		tablaRFC1.Add("2", 2);
		tablaRFC1.Add("3", 3);
		tablaRFC1.Add("4", 4);
		tablaRFC1.Add("5", 5);
		tablaRFC1.Add("6", 6);
		tablaRFC1.Add("7", 7);
		tablaRFC1.Add("8", 8);
		tablaRFC1.Add("9", 9);
		
		
		Hashtable tablaRFC2 = new Hashtable();
		tablaRFC2.Add(0, "1");
		tablaRFC2.Add(1, "2");
		tablaRFC2.Add(2, "3");
		tablaRFC2.Add(3, "4");
		tablaRFC2.Add(4, "5");
		tablaRFC2.Add(5, "6");
		tablaRFC2.Add(6, "7");
		tablaRFC2.Add(7, "8");
		tablaRFC2.Add(8, "9");
		tablaRFC2.Add(9, "A");
		tablaRFC2.Add(10, "B");
		tablaRFC2.Add(11, "C");
		tablaRFC2.Add(12, "D");
		tablaRFC2.Add(13, "E");
		tablaRFC2.Add(14, "F");
		tablaRFC2.Add(15, "G");
		tablaRFC2.Add(16, "H");
		tablaRFC2.Add(17, "I");
		tablaRFC2.Add(18, "J");
		tablaRFC2.Add(19, "K");
		tablaRFC2.Add(20, "L");
		tablaRFC2.Add(21, "M");
		tablaRFC2.Add(22, "N");
		tablaRFC2.Add(23, "P");
		tablaRFC2.Add(24, "Q");
		tablaRFC2.Add(25, "R");
		tablaRFC2.Add(26, "S");
		tablaRFC2.Add(27, "T");
		tablaRFC2.Add(28, "U");
		tablaRFC2.Add(29, "V");
		tablaRFC2.Add(30, "W");
		tablaRFC2.Add(31, "X");
		tablaRFC2.Add(32, "Y");
		
		
		Hashtable tablaRFC3 = new Hashtable();
		tablaRFC3.Add("A", 10);
		tablaRFC3.Add("B", 11);
		tablaRFC3.Add("C", 12);
		tablaRFC3.Add("D", 13);
		tablaRFC3.Add("E", 14);
		tablaRFC3.Add("F", 15);
		tablaRFC3.Add("G", 16);
		tablaRFC3.Add("H", 17);
		tablaRFC3.Add("I", 18);
		tablaRFC3.Add("J", 19);
		tablaRFC3.Add("K", 20);
		tablaRFC3.Add("L", 21);
		tablaRFC3.Add("M", 22);
		tablaRFC3.Add("N", 23);
		tablaRFC3.Add("O", 25);
		tablaRFC3.Add("P", 26);
		tablaRFC3.Add("Q", 27);
		tablaRFC3.Add("R", 28);
		tablaRFC3.Add("S", 29);
		tablaRFC3.Add("T", 30);
		tablaRFC3.Add("U", 31);
		tablaRFC3.Add("V", 32);
		tablaRFC3.Add("W", 33);
		tablaRFC3.Add("X", 34);
		tablaRFC3.Add("Y", 35);
		tablaRFC3.Add("Z", 36);
		tablaRFC3.Add("0", 0);
		tablaRFC3.Add("1", 1);
		tablaRFC3.Add("2", 2);
		tablaRFC3.Add("3", 3);
		tablaRFC3.Add("4", 4);
		tablaRFC3.Add("5", 5);
		tablaRFC3.Add("6", 6);
		tablaRFC3.Add("7", 7);
		tablaRFC3.Add("8", 8);
		tablaRFC3.Add("9", 9);
		tablaRFC3.Add("", 24);
		tablaRFC3.Add(" ", 37);
		

		
		nombreEnNumero.Append("0"); 

		
		foreach (char c in nombreCompleto)
		{
			if (tablaRFC1.ContainsKey(c.ToString()))
				nombreEnNumero.Append(tablaRFC1[c.ToString()].ToString());
			else
				nombreEnNumero.Append("00");
		}

		for (int i = 0; i < nombreEnNumero.Length - 1; i++)
		{
			valorSuma += ((Convert.ToInt32(nombreEnNumero[i].ToString()) * 10) + Convert.ToInt32(nombreEnNumero[i + 1].ToString())) * Convert.ToInt32(nombreEnNumero[i + 1].ToString());
		}

		int div = 0, mod = 0;
		div = Convert.ToInt32(valorSuma) % 1000;
		mod = div % 34;
		div = (div - mod) / 34;

		int indice = 0;
		string hc = String.Empty;  
		while (indice <= 1)
		{
			if (tablaRFC2.ContainsKey((indice == 0) ? div : mod))
				hc += tablaRFC2[(indice == 0) ? div : mod];
			else
				hc += "Z";
			indice++;
		}

		
		rfc += hc;

		
		int rfcAnumeroSuma = 0, sumaParcial = 0;
		for (int i = 0; i < rfc.Length; i++)
		{
			if (tablaRFC3.ContainsKey(rfc[i].ToString()))
			{
				rfcAnumeroSuma = Convert.ToInt32(tablaRFC3[rfc[i].ToString()]);
				sumaParcial += (rfcAnumeroSuma * (14 - (i + 1)));
			}
		}

		int moduloVerificador = sumaParcial % 11;
		if (moduloVerificador == 0)
			rfc += "0";
		else
		{
			sumaParcial = 11 - moduloVerificador;
			if (sumaParcial == 10)
				rfc += "A";
			else
				rfc += sumaParcial.ToString();
		}
	}

	
	static private bool EsVocal(char letra)
	{
		
		if (letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U' ||
			letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
			return true;
		else
			return false;
	}

	
	
	static private string QuitarArticulos(string palabra)
	{
		return palabra.Replace("DEL ", String.Empty).Replace("LAS ", String.Empty).Replace("DE ", String.Empty).Replace("LA ", String.Empty).Replace("Y ", String.Empty).Replace("A ", String.Empty);
	}
}
}