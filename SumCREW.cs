using System;

namespace SumCREW
{
    public class Program
    {
        static int i = 1;
        
        public void Main(string[] args){ 
           int[] A ={ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
           int n = 9; 
           int j = 1;
             for (i = 1; i <= Math.Log(n); i++)
            {
                Parallel.For(0, (int)Math.Pow(2,i-1), n =>
                {
                    A[j] = A[j] + A[(j) - (int)(Math.Pow(2, i-1))];
                });
            }
            for(int k = 1; k <= n; k++){
            Console.WriteLine(A[k]);
            }
            // Console.WriteLine("here");
        }
    }
}