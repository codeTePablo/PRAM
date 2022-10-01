using System;
// using ;

namespace SumCREW
{
    public class Program
    {
        static int i = 1;
        
        public void Main(string[] args){ 
           int[] A = {3, 1, 0, 4, 2};
           int n = 4; 
            // for (int k = 0; k <= n; k++){
            // Console.WriteLine(A[k]);
            // }

           int j = 1;
             for (i = 1; i <= (int)Math.Log(n); i++)
            {
                for(j = 1; j <= (int)((Math.Pow(2, i-1)) + 1); j++)
                { 
                    Parallel.For(0, j++, index=>
                    {
                        A[j] = A[j] + A[(j) + (int)(Math.Pow(2, i-1))];
                    });
                }
            }
            for(int k = 0; k <= n; k++){
            Console.WriteLine(A[k]);
            }
        }
    }
}