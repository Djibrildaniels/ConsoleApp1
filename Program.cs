// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Reflection.PortableExecutable;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Limit1;
            int Limit2;
            int Limit3;
            


           Console.Write("Limit1: ");
           Limit1= Convert.ToInt32 (Console.ReadLine());
         

           Console.Write("Limit2: ");
            Limit2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Integer: ");
           Limit3 = Convert.ToInt32 (Console.ReadLine());
           
           if (Limit3 > Limit2)
        
           {
            Console.WriteLine("You have entered "+ Limit3  + " which is greater than " + Limit2 + " which is the maximum");

           }

           Console.Write("Limit 1 :");
           Limit1 = Convert.ToInt32(Console.ReadLine());

           Console.Write("Limit 2 :");
           Limit2 = Convert.ToInt32(Console.ReadLine());

           Console.Write("Integer To Limit : ");
           Limit3 = Convert.ToInt32(Console.ReadLine());

          if (Limit3> Limit1)
           {
            Console.WriteLine(" You have entered " + Limit3 + " which is greater than " + Limit1 + " which is the maximum");

           }

           Console.Write("Limit 1 : ");
           Limit1 = Convert.ToInt32(Console.ReadLine());

           Console.Write("Limit 2 : ");
           Limit2 = Convert.ToInt32(Console.ReadLine());

           Console.Write("Integer to limit : ");
           Limit3 = Convert.ToInt32(Console.ReadLine());

           if (Limit3<Limit1)
           {
            Console.WriteLine("You have entered " + Limit3 +  " which is lower than " + Limit1 +  " which is the minimum");


           }
        }
    }
}





        