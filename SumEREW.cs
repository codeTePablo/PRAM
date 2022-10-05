using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SumEREW
{
    public class Program
    {
        static int i = 1;
        public void Main(string[] args)
        {
            int[] A = {5, 2, 10, 1, 8, 12, 7, 3};
            // int n = (int)(Math.Pow(2 , i));
            int n = 7;
            int j = 1;

            // for(i = 1; i <= (Math.Log(n, 2)); i++)
            {
                Parallel.For(1, n, i => 
                {
                    if(((2*j) % ((int)(Math.Pow(2,i)))) == 0)
                    {
                        A[j * 2] = A[j * 2] + A[(2 * j) - (int)(Math.Pow(2, i - 1))];
                    }
                });
            for(int i = 1; i <= n; i++){
                Console.WriteLine(A[i]);
            }
            }
        }
    }
}