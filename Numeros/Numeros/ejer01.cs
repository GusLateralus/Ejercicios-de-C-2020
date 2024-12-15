using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string r = "s";
            do
            {
                int idioma;
                string a;
                bool esNumero;
                do
                {
                	Console.Title="Números e idiomas";
                	Console.ForegroundColor=ConsoleColor.White;
                	Console.WriteLine("\t Bienvenido \t Welcome \t Velkommen");
                	Console.WriteLine();
                    Console.WriteLine("Seleccione el número del idioma en el que desea ver su resultado: ");
                    Console.ForegroundColor=ConsoleColor.Green;
                    Console.WriteLine("1.- Español");
                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine("2.- Inglés");
                    Console.ForegroundColor=ConsoleColor.Cyan;
                    Console.WriteLine("3.- Noruego (Bokmål)");
                    Console.ForegroundColor=ConsoleColor.Magenta;
                    Console.Write("\nQuiero el idioma: ");
                    a = Console.ReadLine();
                    esNumero = int.TryParse(a, out idioma);
                    if (idioma % 1 != 0 || idioma > 3 || idioma < 1) esNumero = false;
                }
                while (esNumero == false);

                double numero;
                string b;
                bool esNumero1;
                
                Console.ForegroundColor=ConsoleColor.White;
                
                do
                {
                    Console.WriteLine("\nPor favor introduzca el número entero y positivo que desea");
                    Console.Write("\nNúmero: ");
                    b = Console.ReadLine();
                    esNumero1 = double.TryParse(b, out numero);
                    if (numero % 1 != 0 || numero > 999999 || numero < 0) esNumero1 = false;
                }
                while (esNumero1 == false);


                switch (idioma)
                {
                    case 1:
                        {
                            Espanol traductor;
                            traductor = new Espanol();
                            Console.WriteLine("\n" + traductor.Texto1(numero));
                            Console.WriteLine("¡Genial! Hemos terminado");
                            
                            break;
                        }
                    case 2:
                        {
                            Inglés traductor;
                            traductor = new Inglés();
                            Console.WriteLine("\n" + traductor.Texto2(numero));
                            Console.WriteLine("Great! We've just finished");
                            
                            break;
                        }
                	case 3:
                		{
                			Norsk traductor;
                			traductor= new Norsk();
                			Console.WriteLine("\n"+traductor.Texto3(numero));
                			Console.WriteLine("Kjempefint! Vi er ferdige");
                			
                			break;
                		}
                }
                
                Console.ForegroundColor=ConsoleColor.Yellow;
                Console.WriteLine("\n¿Quieres ingresar otro número? [s/n]");
                Console.Write("R = ");
                r = Console.ReadLine();
                if(r!="n" && r!="s")
                {
                	Console.WriteLine("No ingresaste un parámetro válido D:");
                	while(r!="n" && r!="s")
                	{
                		Console.WriteLine("\n¿Quieres ingresar otro número? [s/n]");
                        Console.Write("R = ");
                        r = Console.ReadLine();
                	
                	}
                
                }
            } while (r == "s");
        }
    }

    class Espanol
    {
        public string Texto1(double numero)
        {
            string aux = "";
            if (numero == 0) aux = "Cero";
            else if (numero == 1) aux = "uno";
            else if (numero == 2) aux = "dos";
            else if (numero == 3) aux = "tres";
            else if (numero == 4) aux = "cuatro";
            else if (numero == 5) aux = "cinco";
            else if (numero == 6) aux = "seis";
            else if (numero == 7) aux = "siete";
            else if (numero == 8) aux = "ocho";
            else if (numero == 9) aux = "nueve";
            else if (numero == 10) aux = "diez";
            else if (numero == 11) aux = "once";
            else if (numero == 12) aux = "doce";
            else if (numero == 13) aux = "trece";
            else if (numero == 14) aux = "catorce";
            else if (numero == 15) aux = "quince";
            else if (numero < 20) aux = "dieci" + Texto1(numero - 10);
            else if (numero == 20) aux = "veinte";
            else if (numero < 30) aux = "veinti" + Texto1(numero - 20);
            else if (numero == 30) aux = "treinta";
            else if (numero == 40) aux = "cuarenta";
            else if (numero == 50) aux = "cincuenta";
            else if (numero == 60) aux = "sesenta";
            else if (numero == 70) aux = "setenta";
            else if (numero == 80) aux = "ochenta";
            else if (numero == 90) aux = "noventa";
            else if (numero < 100) aux = Texto1(Math.Truncate(numero / 10) * 10) + " Y " + Texto1(numero % 10);
            else if (numero == 100) aux = "cien";
            else if (numero < 200) aux = "ciento " + Texto1(numero - 100);
            else if ((numero == 200) || (numero == 300) || (numero == 400) || (numero == 600) || (numero == 800)) aux = Texto1(Math.Truncate(numero / 100)) + "cientos";
            else if (numero == 500) aux = "quinientos ";
            else if (numero == 700) aux = "seiscientos ";
            else if (numero == 900) aux = "novecientos ";
            else if (numero < 1000) aux = Texto1(Math.Truncate(numero / 100) * 100) + " " + Texto1(numero % 100);
            else if (numero == 1000) aux = "mil";
            else if (numero < 2000) aux = "mil " + Texto1(numero % 1000) + " ";
            else if (numero < 1000000)
            {
                aux = Texto1(Math.Truncate(numero / 1000)) + " mil ";
                if ((numero % 1000) > 0) aux = aux + Texto1(numero % 1000);
            }


            return aux;

        }
    }

    class Inglés
    {
        public string Texto2(double numero)
        {
            string aux = "";
            if (numero == 0) aux = "Zero";
            else if (numero == 1) aux = "one";
            else if (numero == 2) aux = "two";
            else if (numero == 3) aux = "three";
            else if (numero == 4) aux = "four";
            else if (numero == 5) aux = "five";
            else if (numero == 6) aux = "six";
            else if (numero == 7) aux = "seven";
            else if (numero == 8) aux = "eight";
            else if (numero == 9) aux = "nine";
            else if (numero == 10) aux = "ten";
            else if (numero == 11) aux = "eleven";
            else if (numero == 12) aux = "twelve";
            else if (numero == 13) aux = "thirteen";
            else if (numero == 14) aux = "fourteen";
            else if (numero == 15) aux = "fifteen";
            else if (numero < 20) aux = Texto2(numero - 10) + "teen";
            else if (numero == 20) aux = "twenty";
            else if (numero < 30) aux = "twenty " + Texto2(numero - 20);
            else if (numero == 30) aux = "thirty";
            else if (numero == 40) aux = "forty";
            else if (numero == 50) aux = "fifty";
            else if (numero == 60) aux = "sixty";
            else if (numero == 70) aux = "seventy";
            else if (numero == 80) aux = "eighty";
            else if (numero == 90) aux = "ninety";
            else if (numero < 100) aux = Texto2(Math.Truncate(numero / 10) * 10) + " " + Texto2(numero % 10);
            else if (numero == 100) aux = "one hundred";
            else if (numero < 200) aux = "one hundred " + Texto2(numero - 100);
            else if ((numero == 200) || (numero == 300) || (numero == 400) || (numero == 500) || (numero == 600) || (numero == 700) || (numero == 800) || (numero == 900)) aux = Texto2(Math.Truncate(numero / 100)) + " hundred";
            else if (numero < 1000) aux = Texto2(Math.Truncate(numero / 100) * 100) + " and " + Texto2(numero % 100);
            else if (numero == 1000) aux = "one thousand";
            else if (numero < 2000) aux = "one thousand " + Texto2(numero % 1000) + " ";
            else if (numero < 1000000)
            {
                aux = Texto2(Math.Truncate(numero / 1000)) + " thousand ";
                if ((numero % 1000) > 0) aux = aux + Texto2(numero % 1000);
            }


            return aux;

        }
    }
    
    class Norsk
    {
    	public string Texto3(double numero)
        {
            string aux = "";
            if (numero == 0) aux = "Null";
            else if (numero == 1) aux = "en";
            else if (numero == 2) aux = "to";
            else if (numero == 3) aux = "tre";
            else if (numero == 4) aux = "fire";
            else if (numero == 5) aux = "fem";
            else if (numero == 6) aux = "seks";
            else if (numero == 7) aux = "sju";
            else if (numero == 8) aux = "åtte";
            else if (numero == 9) aux = "ni";
            else if (numero == 10) aux = "Ti";
            else if (numero == 11) aux = "elleve";
            else if (numero == 12) aux = "tolv";
            else if (numero == 13) aux = "tretten";
            else if (numero == 14) aux = "fjorten";
            else if (numero == 15) aux = "femten";
            else if (numero < 20) aux = Texto3(numero - 10) + "ten";
            else if (numero == 20) aux = "tjue";
            else if (numero < 30) aux = "tjue" + Texto3(numero - 20);
            else if (numero == 30) aux = "tretti";
            else if (numero == 40) aux = "førty";
            else if (numero == 50) aux = "femty";
            else if (numero == 60) aux = "seksti";
            else if (numero == 70) aux = "sytti";
            else if (numero == 80) aux = "åtti";
            else if (numero == 90) aux = "nitti";
            else if (numero < 100) aux = Texto3(Math.Truncate(numero / 10) * 10) + " " + Texto3(numero % 10);
            else if (numero == 100) aux = "hundre";
            else if (numero < 200) aux = "hundre " + Texto3(numero - 100);
            else if ((numero == 200) || (numero == 300) || (numero == 400) || (numero == 500) || (numero == 600) || (numero == 700) || (numero == 800) || (numero == 900)) aux = Texto3(Math.Truncate(numero / 100)) + " hundre";
            else if (numero < 1000) aux = Texto3(Math.Truncate(numero / 100) * 100) + " og " + Texto3(numero % 100);
            else if (numero == 1000) aux = "tusen";
            else if (numero < 2000) aux = "tusen " + Texto3(numero % 1000) + " ";
            else if (numero < 1000000)
            {
                aux = Texto3(Math.Truncate(numero / 1000)) + " tusen ";
                if ((numero % 1000) > 0) aux = aux + Texto3(numero % 1000);
            }

            return aux;   
    
    }
}
}