using System;

namespace Ejercicio_9
{
	class Program
	{
		public static int enterInt(string message= "Digite el número de elementos para la sucesión de Padovan: ")
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
					Console.WriteLine("No has ingresado un parámetro válido");
					Console.WriteLine("Por favor, intenta de nuevo");
				
				}
				

			
			}
			return val;
		
		
		}
		
	       public static int padovan(int n) 
           { 
          
              int padpPrev = 1, padPrev = 1,padR = 1, padS = 1; 
  
              for (int i = 3; i <= n; i++) 
              {
                padS = padpPrev + padPrev; 
                padpPrev = padPrev; 
                padPrev = padR; 
                padR = padS; 
                Console.Write("{0} ", padS);
                
               } 
  
        return padS; 
            } 
  
	       public static void Main()
	       {
			
	       	 int i,n;
			
			 
			 n=enterInt();
			 
			 if(n<0)
			 {
			 	Console.WriteLine("No puedes ingresar un número negativo :/");
			 	
			 	while(n<0)
			 	{
			 		n=enterInt();
			 	
			 	}
			 
			 }
			
			 if(n<=4)
			 {
				 for(i=0;i<n;i++)
				 {
					 Console.Write("1 ");
				 }
			 }
			
			 else
			 {
				 for(i=0;i<4;i++)
				 {
					Console.Write("1 ");
				 } 
				
			     n=n-2;
			    
			     padovan(n);
			 }
			
			 Console.ReadKey();
		}
	}
}