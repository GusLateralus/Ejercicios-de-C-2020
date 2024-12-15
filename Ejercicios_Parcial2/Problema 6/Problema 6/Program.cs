using System;

namespace Problema_6
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			double num, va;
			int x, dummy = 0, res, counter1 = 0, counter2 = 0;
			string bin1 = "", bin2 = "", signo = "";
			
			Console.ForegroundColor = ConsoleColor.White;
			
			Console.Write("Ingresa un número decimal ");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("(de punto flotante): ");
			Console.ForegroundColor = ConsoleColor.White;
			
			num = Convert.ToDouble( Console.ReadLine() );
			x = Convert.ToInt32( Math.Floor(num) );
			va = num;
			
			
			if ( x < 0)
			{
				x = x + (-2 * x);
				signo = String.Concat("1",signo);
			}
			
			else
			{
				signo = String.Concat("0",signo);
			}
			
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("// Paso #1 //\n");
			Console.ForegroundColor = ConsoleColor.White;
			
			Console.WriteLine("Primero se obtiene el bit del signo del número: \n");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("( 0 ) Para un número positivo\n");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("( 1 ) Para un número negativo\n");
			
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("\nEn este caso el bit del signo es: ");
			
			if ( Convert.ToInt32(signo) == 0)
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine(signo);
			}
			
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(signo);
			}
			
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("\nPresiona cualquier tecla para continuar...");
			Console.ReadKey(true);
			
			
			
			
			
			res = x;
			
			if (x == 0)
			{
				bin1 = String.Concat("00", bin1);
				counter1++;
			}
			
			if (x == 1)
			{
				bin1 = String.Concat("01", bin1);
				counter1++;
			}
			
			else
			{
				bin1 = String.Concat(Convert.ToString(res % 2), bin1);
			
				while ( dummy == 0 )
				{
					res = res / 2;
				
					if (res % 2 == 0)
					{
						bin1 = String.Concat(Convert.ToString(res % 2), bin1);
					}
				
					else
					{
						bin1 = String.Concat(Convert.ToString(res % 2), bin1);
					}
					
					counter1++;
				
					if (res == 1)
						break;
				}
			}
			
			
			while ( counter2 <= counter1 )
			{
				va = va * 2; 
				bin2 = String.Concat( Convert.ToString( Convert.ToInt32( Math.Floor(va) ) % 2 ), bin2 );
				
				counter2++;
				
			}
			
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("// Paso #2 //\n");
			Console.ForegroundColor = ConsoleColor.White;
			
			Console.WriteLine("El siguiente paso es convertir el coeficiente");
			Console.WriteLine("y el decimal del número a binario:");
			
			Console.WriteLine("\nPara este caso:\n");
			
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write(x);
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write(" = ");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine(bin1);
			
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("\nPara el decimal, el valor actual almacenado en memoria es:\n");
			
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write(num % 1);
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write(" = ");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine(bin2);
			
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("\nPresiona cualquier tecla para continuar...");
			Console.ReadKey(true);
			
			
			int exp, expa;
			string expbin = "";
			
			exp = (bin1.Length - 1) + 127;
			expa = exp;
			
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("// Paso #3 //\n");
			Console.ForegroundColor = ConsoleColor.White;
			
			Console.WriteLine("Después se elimina el primer ( 1 ) del coeficiente");
			Console.WriteLine("en binario y se cuentan los bits que sobran. El número");
			Console.WriteLine("que resulta de eliminar el primer ( 1 ) se utilzará ");
			Console.WriteLine("posteriormente para obtener la mantisa:\n");
			
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write(bin1);
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write(" --> ");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine( bin1.Remove(0,1) );
			
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("\nNúmero de bits: ");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(bin1.Length - 1);
			
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("\nLuego se suma ( 127 ) al número de bits para");
			Console.WriteLine("obtener el exponente y así convertirlo a binario:\n");
			
			expbin = String.Concat(Convert.ToString(exp % 2), expbin);
			
				while ( dummy == 0 )
				{
					exp = exp / 2;
				
					if (exp % 2 == 0)
					{
						expbin = String.Concat(Convert.ToString(exp % 2), expbin);
					}
				
					else
					{
						expbin = String.Concat(Convert.ToString(exp % 2), expbin);
					}
				
					if (exp == 1)
						break;
				}
				
			Console.Write("127 + ");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write(bin1.Length - 1);
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write(" = ");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write(expa);
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write(" --> ");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine(expbin);
				
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("\nPresiona cualquier tecla para continuar...");
			Console.ReadKey(true);
			
			
			string mantisa;
			
			mantisa = bin1.Remove(0,1);
			
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("// Paso #4 //\n");
			Console.ForegroundColor = ConsoleColor.White;
			
			Console.WriteLine("Finalmente se obtiene la mantisa tomando el número que");
			Console.WriteLine("resultó de eliminar el primer ( 1 ) del coeficiente en binario");
			Console.WriteLine("junto con el decimal en binario obtenido en el paso #2 y se");
			Console.WriteLine("agregan ( 0 ) hasta completar la mantisa de 23 bits:\n");
			
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write(mantisa);
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write(" --> ");
			
			mantisa = String.Concat(mantisa,bin2);
			
			for (int i = mantisa.Length; i < 23; i++)
			{
				mantisa = String.Concat(mantisa,"0");
			}
			
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine(mantisa);
			
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("\nPresiona cualquier tecla para continuar...");
			Console.ReadKey(true);
			
			
			string bt = "", hex = "";
			string[] hexa = {"","","","","","","",""};
			string h1,h2,h3,h4,h5,h6,h7,h8;
			
			bt = String.Concat(signo,expbin,mantisa);
			
			h1 = bt; h2 = bt; h3 = bt; h4 = bt; h5 = bt; h6 = bt; h7 = bt; h8 = bt;
			
			h1 = bt.Remove(4);
			h2 = bt.Remove(8); h2 = h2.Remove(0,4);
			h3 = bt.Remove(12); h3 = h3.Remove(0,8);
			h4 = bt.Remove(16); h4 = h4.Remove(0,12);
			h5 = bt.Remove(20); h5 = h5.Remove(0,16);
			h6 = bt.Remove(24); h6 = h6.Remove(0,20);
			h7 = bt.Remove(28); h7 = h7.Remove(0,24);
			h8 = bt.Remove(0,28);
			
			hexa.SetValue(h1,0);
			hexa.SetValue(h2,1);
			hexa.SetValue(h3,2);
			hexa.SetValue(h4,3);
			hexa.SetValue(h5,4);
			hexa.SetValue(h6,5);
			hexa.SetValue(h7,6);
			hexa.SetValue(h8,7);
			
			for(int i = 0; i <= 7; i++)
			{
				switch( hexa[i] )
				{
					case "0000":
					hex = String.Concat(hex,"0");
					break;
					
					case "0001":
					hex = String.Concat(hex,"1");
					break;
						
					case "0010":
					hex = String.Concat(hex,"2");
					break;
					
					case "0011":
					hex = String.Concat(hex,"3");
					break;
					
					case "0100":
					hex = String.Concat(hex,"4");
					break;
					
					case "0101":
					hex = String.Concat(hex,"5");
					break;
					
					case "0110":
					hex = String.Concat(hex,"6");
					break;
					
					case "0111":
					hex = String.Concat(hex,"7");
					break;
					
					case "1000":
					hex = String.Concat(hex,"8");
					break;
					
					case "1001":
					hex = String.Concat(hex,"9");
					break;
					
					case "1010":
					hex = String.Concat(hex,"A");
					break;
					
					case "1011":
					hex = String.Concat(hex,"B");
					break;
					
					case "1100":
					hex = String.Concat(hex,"C");
					break;
					
					case "1101":
					hex = String.Concat(hex,"D");
					break;
					
					case "1110":
					hex = String.Concat(hex,"E");
					break;
					
					case "1111":
					hex = String.Concat(hex,"F");
					break;
				}
			}
			
			Console.Clear();
			Console.WriteLine("De esta manera, la respresentación IEEE 754-1985 de");
			Console.Write("precisión sencilla del número ");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write(num);
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(" es la siguiente:\n");
			
			Console.Write("En binario (");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write(" |Signo| ");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write(" |Exponente| ");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Write(" |Mantisa| ");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("):\n");
			
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write( String.Concat(signo, " ") );
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write( String.Concat(expbin, " ") );
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Write(mantisa);
			
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("\n\nEn hexadecimal: ");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine( hex );
			
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("\nPresiona cualquier tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}