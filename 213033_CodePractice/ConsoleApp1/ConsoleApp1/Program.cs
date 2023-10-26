//Ali Shaan - 213033
using System;
namespace Factor { 
    class Program { 
        public static void Main() 
        {
            int i = 2, n;
            Console.WriteLine("Enter n value: ");
            n = int.Parse(Console.ReadLine());
            while (i <= n) 
            { 
                if (n < 10 && i <= n)
                {
                    Console.WriteLine(n + " doen't have single digit factor other than one.");
                    break;
                } 
                if (n % i == 0) 
                {
                    Console.WriteLine(i + " is smaller factor.");
                    break;
                } 
                i++; 
            }
            Console.ReadKey(); 
        }
    }
}