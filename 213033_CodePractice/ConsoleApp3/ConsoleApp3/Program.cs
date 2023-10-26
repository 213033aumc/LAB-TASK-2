// Ali Shaan - 213033
using System;
namespace c {
    class pro { 
        public static void Main(String[] args) 
        {
            int n,i = 0;
            Console.WriteLine("Enter value: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            { 
              i++;
              n = n / 10;
            }
            Console.WriteLine("Magnitude of given number is : "+i);
        }
    } 
}