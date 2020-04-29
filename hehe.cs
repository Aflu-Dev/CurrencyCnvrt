using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Currency
{

    public static class Program 
    {
        public static void Main() 
        {
           Console.WriteLine("What is your currency?, USD or EURO");
           string a = Console.ReadLine();
           if (a == "USD") 
           {
             Console.Write("Input USD value: ");
             double input = double.Parse(Console.ReadLine());
             if (input < 1) 
             {
               Console.Write("The value cannot be negative or 0!");
               Environment.Exit(1);
             }
             double euro = 0.92;
             double total;
             total = input * euro;
             Console.Write("The value is: " + total);
           }
           if (a == "EURO")
           {
             Console.Write("Input EURO value: ");
             double Input = double.Parse(Console.ReadLine());
             if (Input < 1)
             {
               Console.Write("The value cannot be negative or 0!");
               Environment.Exit(1);
             }
             double dollar = 1.08;
             double Total;
             Total = Input * dollar;
             Console.WriteLine("The value is: " + Total);
           } 
        }
    }
}
