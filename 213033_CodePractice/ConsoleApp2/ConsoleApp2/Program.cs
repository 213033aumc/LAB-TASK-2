// Ali Shaan - 213033
using System;
namespace prime { 
    class Pro 
    {
        public static void Main()
        {
            int i, c, m = 1;
            Console.WriteLine("Enter a value: ");

            int n = int.Parse(Console.ReadLine());
            c = 0;
            i = 1;
            while (i <= n)
            {
                if (n % i == 0)
                {
                    c++;
                    if (i != n);
                    {
                        m = i;
                    }
                    
                }
             i++;
            }
            if (c == 2)
            {
                Console.WriteLine("It is Prime.");
            }
            else
            { 
            Console.WriteLine(m + " is the largest factor for " + n);
            }

            Console.ReadKey();
        }
    } 
}
