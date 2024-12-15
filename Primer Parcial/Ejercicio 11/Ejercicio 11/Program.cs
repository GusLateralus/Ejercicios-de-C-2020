using System;

namespace Ejercicio_11
{
	class Program
	{
		public static int enterInt(string message= "Ingresa un número entero positivo: ")
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
					Console.WriteLine("No has ingresado un NÚMERO ENTERO D:");
					Console.WriteLine("Intenta de nuevo: ");
				
				}
			
			
			
			}
			return value;
		
		}
		
		public static int dfactorial(int n) 
        { 
            int i,res = 1; 
        
        for (i = n; i >= 0; i = i-2) 
        { 
            if (i == 0 || i == 1) 
            {
            	return res;
            }
            
            else
            {
            	res *= i;
            }
        } 
          
        return res; 
    }  
		 
   public static void Main() 
    { 
    	int num;
    	
    	num=enterInt();
    	
    	if(num<0)
    	{
    		Console.WriteLine("No puedes ingresar números negativos :/");
    		
    		while(num<0)
    		{
    			num=enterInt();
    		
    		}
    	
    	}
        Console.WriteLine("El doble factorial de {0} es {1} ",num,dfactorial(num));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);    	
    }
    
	}
}