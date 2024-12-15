using System;

namespace Problema_1
{
	
	
	class Square
	{
		public double lado;
		public double areaSq;
		public double perimetroSq;
		
		public void PerimetroSq()
		{
			this.perimetroSq=4*this.lado;
		}
		
		public void AreaSq()
		{
			this.areaSq=this.lado*this.lado;
		
		}
	}
	
	class Rectangle
	{
		public double baseRect;
		public double alturaRect;
		public double perimetroRect;
		public double areaRect;
		
		public void PerimetroRect()
		{
			this.perimetroRect= 2.0*(this.alturaRect+this.baseRect);
		}
		
		public void AreaRect()
		{
			this.areaRect=(this.baseRect*this.alturaRect);
		
		}
	}
	
	class Triangle
	{
		public double baseTrian;
		public double alturaTrian;
		public double perimetroTrian;
		public double areaTrian;
		
		public void PerimetroTrian()
		{
			this.perimetroTrian= this.baseTrian+this.alturaTrian+Math.Sqrt((this.alturaTrian*this.alturaTrian)+(this.baseTrian*this.baseTrian));
		}
		
		public void AreaTrian()
		{
			this.areaTrian=(this.baseTrian*this.alturaTrian)/2;
		}
	}
	
	class Circle
	{
		public double radCirc;
		public double areaCirc;
		public double perimetroCirc;
		
		public void PerimetroCirc()
		{
			this.perimetroCirc=2*Math.PI*this.radCirc;
		
		}
		
		public void AreaCirc()
		{
			this.areaCirc=Math.PI*this.radCirc*this.radCirc;
		
		}
	
	
	}
	
	 class Poligono
    {
        public int lados;
        public double lado;
        public double apotema;
        public double perimetroPoligono;
        public double areaPoligono;
        
        public void PerimetroPoligono()
        {
            this.perimetroPoligono = this.lados * this.lado;
        }
        
        public void AreaPoligono()
        {
            this.areaPoligono = this.perimetroPoligono * this.apotema;
        }
    }
	 
    class Trapecio
    {
        public double baseMayor;
        public double basemenor;
        public double alturaTra;
        public double perimetroTra;
        public double areaTra;
        
        public void PerimetroTra()
        {
            this.perimetroTra = this.baseMayor + this.basemenor + 2;
        }
        public void AreaTra()
        {
            this.areaTra = (this.alturaTra * (this.baseMayor + this.basemenor)) / 2;
        }
    }
    
    class Rombo
    {
        public double diagMayor;
        public double diagMenor;
        public double ladoRomb;
        public double perimetroRomb;
        public double areaRomb;
        
        public void PerimetroRomb()
        {
            this.perimetroRomb = 4 * this.ladoRomb;
        }
        
        public void AreaRomb()
        {
            this.areaRomb = (this.diagMayor * this.diagMenor) / 2;
        }
    }
	
	class Program
	{
		public static int enterInt(string message= "Ingrese un número entero: ")
	    {
			string ans;
			int val;
			
			while(true)
			{
				Console.WriteLine(message);
				ans=Console.ReadLine();
				
				try
				{
					val=Convert.ToInt32(ans);
					break;
				}
				
				catch(FormatException error)
				{
					Console.WriteLine("No has ingresado un parámetro válido :/");
					
				
				}
				
			
			}
	        return val;
	
	    }
		
		public static void Main(string[] args)
		{
			int res;
			
			do{
			Console.WriteLine("\t\tV E L K O M M E N");
			Console.WriteLine();
			Console.WriteLine("Este programa sirve para n veces");
			Console.WriteLine("1.- Área y perímetro de un cuadrado");
			Console.WriteLine("2.- Área y perímetro de un triángulo");
			Console.WriteLine("3.- Área y perímetro de un rectángulo");
			Console.WriteLine("4.- Área y perímetro de un círculo");
			Console.WriteLine("5.- Área y perímetro de un trapecio");
			Console.WriteLine("6.- Área y perímetro de un rombo");
			Console.WriteLine("7.- Área y perímetro de un polígono");
			Console.WriteLine("8.- Salir");
			//Console.Write("Digite una opción según el número que le corresponda: ");
			
			res=enterInt("Digite una opción según el número que le corresponda: ");
			
			switch(res){
		    
			case 1:
			{
						double side;
                        Square miCuadrado = new Square();
                        Console.WriteLine("Ingrese el valor de un lado del cuadrado: ");
                        side = Convert.ToDouble(Console.ReadLine());
            
            if(side<0)
            {
            	Console.WriteLine("No existen lados negativos");
            	
            	while(side<0)
            	{
            		Console.WriteLine("Intente de nuevo, por favor: ");
            		side=Convert.ToDouble(Console.ReadLine());
            	}
            }
            
            
            miCuadrado.lado = side;
            miCuadrado.AreaSq();
            miCuadrado.PerimetroSq();
          
            Console.WriteLine("Área: {0}", miCuadrado.areaSq);
            Console.WriteLine("Perímetro: {0}", miCuadrado.perimetroSq);
            Console.WriteLine();
            Console.WriteLine();
            break;
					}
					
				case 2:
				{
					    double b, h;
                        Triangle miTriangulo = new Triangle();
                        Console.WriteLine("Ingrese la base: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese la altura: ");
                        h = Convert.ToDouble(Console.ReadLine());
                        
                        if(b<0 || h<0)
                        {
                        	Console.WriteLine("No ingresaste un parámetro válido");
                        	
                        	while(b<0 || h<0)
                        	{
                        		Console.Write("Inténtalo de nuevo en el orden que se indicó: ");
                        		b=Convert.ToDouble(Console.ReadLine());
                        		h=Convert.ToDouble(Console.ReadLine());
                        	
                        	}
                        	
                        	
                        }
                        
                        miTriangulo.alturaTrian = h;
                        miTriangulo.baseTrian = b;
                        miTriangulo.PerimetroTrian();
                        miTriangulo.AreaTrian();
                       
                        Console.WriteLine("Área: {0}", miTriangulo.areaTrian);
                        Console.WriteLine("Perímetro: {0}", miTriangulo.perimetroTrian);
                        break;
					
					
					}
					
				case 3:
				{
						double a, b;
                        Rectangle miRectangulo = new Rectangle();
                        
                        Console.WriteLine("Ingrese la base: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese la altura: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        
                        if(a<0 || b<0)
                        {
                        	Console.WriteLine("No existen lados negativos");
                        	
                        	while(a<0 || b<0)
                        	{
                        		Console.Write("Inténtelo de nuevo, ingrese las variables en el orden anteriormente indicado: ");
                        		
                        		b=Convert.ToDouble(Console.ReadLine());
                        		a=Convert.ToDouble(Console.ReadLine());
                        	
                        	}
                        
                        }
                        
                        miRectangulo.alturaRect = a;
                        miRectangulo.baseRect = b;
                        miRectangulo.PerimetroRect();
                        miRectangulo.AreaRect();
                    
                        Console.WriteLine("Área: {0}", miRectangulo.areaRect);
                        Console.WriteLine("Perímetro: {0}", miRectangulo.perimetroRect);
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
					}
					
				case 4:
					{
						double r;
                        Circle miCirculo = new Circle();
                        Console.WriteLine("Ingrese el radio: ");
                        r = Convert.ToDouble(Console.ReadLine());
                        
                        if(r<0)
                        {
                        	Console.WriteLine("No existen radios negativos");
                        	
                        	while(r<0)
                        	{
                        		Console.WriteLine("Ingrese el radio: ");
                        		r=Convert.ToDouble(Console.ReadLine());
                        	
                        	}
                        
                        }
                        
                        miCirculo.radCirc = r;
                        miCirculo.AreaCirc();
                        miCirculo.PerimetroCirc();
                        
                        Console.WriteLine("Área: {0}", miCirculo.areaCirc);
                        Console.WriteLine("Perímetro: {0}", miCirculo.perimetroCirc);
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
					}
					
				case 5:
				{
					    double B, b, alt;
                        Trapecio miTrapecio = new Trapecio();
                        Console.WriteLine("Ingrese el valor de la base mayor: ");
                        B = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el valor de la base menor: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese la altura del trapecio: ");
                        alt = Convert.ToDouble(Console.ReadLine());
                        
                        if(B<0 || b<0 || alt<0)
                        {
                        	Console.WriteLine("No has ingresado un parámetro válido :/");
                        	
                        	while(B<0 || b<0 || alt<0)
                        	{
                        		  Console.WriteLine("Ingrese el valor de la base mayor: ");
                                  B = Convert.ToDouble(Console.ReadLine());
                                  Console.WriteLine("Ingrese el valor de la base menor: ");
                                  b = Convert.ToDouble(Console.ReadLine());
                                  Console.WriteLine("Ingrese la altura del trapecio: ");
                                  alt = Convert.ToDouble(Console.ReadLine());
                        
                        	
                        	}
                        
                        
                        }
                        
                        miTrapecio.baseMayor = B;
                        miTrapecio.basemenor = b;
                        miTrapecio.alturaTra = alt;
                        miTrapecio.AreaTra();
                        miTrapecio.PerimetroTra();
                        
                        Console.WriteLine("Área: {0}", miTrapecio.areaTra);
                        Console.WriteLine("Perímetro: {0}", miTrapecio.perimetroTra);
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
					}
					
				case 6:
				{
					    double dm, dM, lado;
                        Rombo miRombo = new Rombo();
                        Console.WriteLine("Ingrese el valor de un lado del rombo: ");
                        lado = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el valor de una diagonal: ");
                        dM = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el valor de otra diagonal: ");
                        dm = Convert.ToDouble(Console.ReadLine());
                        
                        if(lado<0 || dM <0 || dm<0)
                        {
                        	Console.WriteLine("No has ingresado un parámetro válido :/");
                        	
                        	while(lado<0 || dM<0 || dm<0)
                        	{
                        		Console.WriteLine("Ingrese el valor de un lado del rombo: ");
                                lado = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Ingrese el valor de una diagonal: ");
                                dM = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Ingrese el valor de otra diagonal: ");
                                dm = Convert.ToDouble(Console.ReadLine());
                        	
                        	}
                        
                        }
                        
                        
                        
                        miRombo.diagMayor = dM;
                        miRombo.diagMenor = dm;
                        miRombo.ladoRomb = lado;
                        miRombo.AreaRomb();
                        miRombo.PerimetroRomb();
                        
                        Console.WriteLine("Área: {0}", miRombo.areaRomb);
                        Console.WriteLine("Perímetro: {0}", miRombo.perimetroRomb);
                        Console.WriteLine();
                        Console.WriteLine();
                        
                        break;
					}
					
				case 7:
				{
						int nlados;
					    double l, a;
                        Poligono miPoligono = new Poligono();
                        nlados= enterInt("Ingrese el número de lados del polígono: ");
                        Console.WriteLine("Ingrese el tamaño del lado:");
                        l = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el apotema:");
                        a = Convert.ToDouble(Console.ReadLine());
                        
                        if(nlados<0 || l<0 || a<0)
                        {
                        	Console.WriteLine("No has ingresado un parámetro válido");
                        	
                        	while(nlados<0 || l<0 || a<0)
                        	{
                        		nlados=enterInt("Ingrese el número de lados del polígono: ");
                                Console.WriteLine("Ingrese el tamaño del lado:");
                                l = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Ingrese el apotema:");
                                a = Convert.ToDouble(Console.ReadLine());
                        	
                        	
                        	}
                        
                        }
                        
                        
                        miPoligono.lados = nlados;
                        miPoligono.lado = l;
                        miPoligono.apotema = a;
                        miPoligono.PerimetroPoligono();
                        miPoligono.AreaPoligono();
                   
                        Console.WriteLine("Área: {0}", miPoligono.areaPoligono);
                        Console.WriteLine("Perímetro: {0}", miPoligono.perimetroPoligono);
                        Console.WriteLine();
                        break;
					}
            
			
			}
			
			}while(res != 8);
			
			
			Console.Write("Have a G'day! :D ");
			Console.ReadKey(true);
		}
	}
}