/*
 * Created by SharpDevelop.
 * User: buba
 * Date: 24/02/2015
 * Time: 03:37 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace praaaa1
{
	class Program
	{
		public const double pi = 3.14159;
		public static void Main(string[] args)
		{
		
			Console.WriteLine("Elija la operacion a realizar");
 Console.WriteLine("");
Console.WriteLine(" 1 suma");
Console.WriteLine(" 2 resta");
Console.WriteLine(" 3 multiplicacion");
Console.WriteLine(" 4 division");
Console.WriteLine(" 5 area triangulo");
Console.WriteLine(" 6 area circulo");
Console.WriteLine(" 7 area cuadrado");

Console.Write("Ingrese el numero de su opcion: ");

int opcion = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("");
int su,re,mul,di,areat,areacu;
 
       

 switch (opcion)
     {  
  case 1: 
 		
 		
 		Console.WriteLine("suma");
 		
       Console.WriteLine("dame el primer numero");
         int v1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("dame el segundo numero");
           int v2 = Convert.ToInt32(Console.ReadLine());
           	
           	su=v1+v2;
             Console.WriteLine("la suma es:"+ su);
           
  break;
  case 2: 
  
  
       Console.WriteLine("resta");
       
        Console.WriteLine("dame el primer numero");
         int v3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("dame el segundo numero");
           int v4 = Convert.ToInt32(Console.ReadLine());
           	
           	re=v3-v4;
             Console.WriteLine("la resta es:"+ re);
  break;
  case 3: 
  

       Console.WriteLine("multiplicacion");
        
        Console.WriteLine("dame el primer numero");
         int v5 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("dame el segundo numero");
           int v6= Convert.ToInt32(Console.ReadLine());
           	
           	mul=v5*v6;
             Console.WriteLine("la multiplicacion es:"+ mul);
       
  break;
  case 4: 
  
 
       Console.WriteLine("division");
        
        Console.WriteLine("dame el primer numero");
         int v7 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("dame el segundo numero");
           int v8 = Convert.ToInt32(Console.ReadLine());
           	
           	di=v7/v8;
             Console.WriteLine("la division es:"+ di);
  break;
  case 5: 
       Console.WriteLine("area triangulo");
       Console.WriteLine("dame la base");
         int v9 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("dame la altura");
           int v10= Convert.ToInt32(Console.ReadLine());
           	
           	areat=v9*v10/2;
             Console.WriteLine("la area del tringulo es:"+ areat);
  break;
  case 6: 
      
       
         Console.WriteLine("area circulo");
       Console.WriteLine("dame el radio del circulo");
         int r= Convert.ToInt32(Console.ReadLine());
       
          double areaci= pi * Math.Pow(r, 2);
             Console.WriteLine("la area del circulo es:"+ areaci);
  break;
  case 7: 
       
       Console.WriteLine("area cuadrado");
       Console.WriteLine("dame el primer lado del cuadrado");
         int v11 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("dame el segundo lado");
           int v12= Convert.ToInt32(Console.ReadLine());
           	
           	areacu=v11*v12;
             Console.WriteLine("la area del cuadrado es:"+ areacu);
  break;
  default:
  Console.WriteLine("Opcion no valida");
break;

      }    
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}}
	}