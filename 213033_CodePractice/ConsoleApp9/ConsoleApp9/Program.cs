// Ali Shaan - 213033
namespace Program
{
    class B 
    {
        public static void Main(String[] args) 
        {
            string[,] a = new String[10, 10]; 
            char[] x = new Char[10];
            int[] t = new int[10]; 
            string[] g = new String[10]; 
            string b;
            Console.WriteLine("Enter Rows: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column: "); 
            int n=int.Parse(Console.ReadLine());
                for(int i = 0; i < m; i++) 
            { 
                for (int j = 0; j < n; j++)
                    a[i, j] = Console.ReadLine(); 
            }
            int k = 0, c = 0, s = 0;
            for (int i = 0; i < m; i++) 
            {
                for (int j = 0; j < n; j++) 
                {
                    b = a[i, j];
                    c = 0;
                    for (k = 0; k < b.Length; k++) 
                    { 
                        if(b[k]=='a')
                         c++; 
                      else  if(b[k]=='e')
                         c++; 
                      else  if(b[k]=='i') 
                         c++; 
                      else  if(b[k]=='o')
                         c++; 
                      else   if(b[k]=='u')
                         c++; 
                    }
                    g[s] = b;
                    t[s] = c;
                    s++;
                }
            }
            int temp;
            string tem; 
            for (int j = 0; j < s; j++) 
            { 
                for (int i = 0; i < s; i++) 
                {
                    if (t[i] >= t[j]) 
                    {
                        temp = t[i];
                        t[i] = t[j];
                        t[j] = temp;
                        
                    }
                }
            }
            Console.WriteLine("Strings having more numbers of vowles are.");
                for (int i = 0; i < s; i++) 
            {
                if (t[i] <= t[s - 1]) 
                    Console.WriteLine(g[i]); 
            }
            Console.WriteLine("word has " + t[s - 1] + " vowels.");
            Console.ReadKey();
        }
    }
}