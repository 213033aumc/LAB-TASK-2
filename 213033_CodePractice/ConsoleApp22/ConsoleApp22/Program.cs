﻿// Ali Shaan - 213033 
using System;
namespace ConsoleApplication3 
{ 
    public class Sample 
    { 
        public string param1, param2;
        public Sample(string a, string b) 
        { param1 = a;
            param2 = b;
        } 
        private Sample() // Private Constructor Declaration
         { 
            Console.WriteLine("Private Constructor with no pramete");
        } 
    } 
    class Program
    {
        static void Main(string[] args) 
        {
            Sample obj = new Sample("Welcome","to ASP.NET"); 
            Console.WriteLine(obj.param1 +" " + obj.param2);
            Console.ReadLine(); 
        }
    } 
} 