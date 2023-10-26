//Ali Shaan - 213033
using System;
namespace matrix {
    class Pro1
    { public static void Main(String[] args) 
        { int i, j, m, n, p, q,k ;
            int[,] a = new int[30, 30];
            int[,] b = new int[30, 30]; 
            int[,] c = new int[30, 30];
            Console.WriteLine("Enter Rows and Column of 1st matrix: ");
            m = Convert.ToInt32(Console.ReadLine()); 
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Rows and Column of 2nd matrix: ");
            p = Convert.ToInt32(Console.ReadLine()); 
            q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Elements of 1st matrix: ");
            for (i = 0; i < m; i++) 
            { 
                for (j = 0; j < n; j++) 
                    a[i, j] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Elements of 2nd matrix: ");
            for (i = 0; i < p; i++) 
            {
                for (j = 0; j < q; j++)
                    b[i, j] = int.Parse(Console.ReadLine()); 
            }
            if((m==p) && (n==p))
            {
                Console.WriteLine("Adddition is Possible. ");
                 for (i = 0; i < m; i++) 
                    {
                    for (j = 0; j < n; j++) 
                        c[i, j] = a[i, j] + b[i, j];
                    }
                for (i = 0; i < m; i++) 
                    { 
                    for (j = 0; j < n; j++)
                            Console.WriteLine(c[i,j]+"\t");
                        Console.WriteLine("\n");
                    }
            }
            else
                Console.WriteLine("Addition not possible. ");
            if (n != p)
                Console.WriteLine("Mul not Possible. ");
            else
            { 
                for (i = 0; i < m; i++)
                {
                        for (j = 0; j < n; j++)
                    { 
                            c[i, j] = 0; 
                            for (k = 0; k < m && k < q; k++)
                                c[i, j] = c[i, j] + a[i, k] * b[k, j]; 
                    }
                }
                Console.WriteLine("The matrix is : ");
                for (i = 0; i < m; i++) 
                { 
                        for (j = 0; j < n; j++)
                        Console.WriteLine("\t"+c[i, j]);
                    Console.WriteLine("\n");
                }
            }
        }
    }
}