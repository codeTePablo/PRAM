using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumCREW
{
    public class Program
    {
        static int i = 1;
        
        public void Main(string[] args){ 
           int[] A = {3, 1, 0, 4, 2};
           int n = 4; 
            
            Parallel.For(0, (int)(Math.Pow(2, i-1)), i =>
            {
                Parallel.For(0, n, j=>
                {
                    A[j] = A[j] + A[(j) + (int)(Math.Pow(2, i-1))];
                });
            });
            
            for(int k = 0; k <= n; k++){
            Console.WriteLine(A[k]);
            }
        }
    }
}