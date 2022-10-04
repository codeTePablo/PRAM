using System;

namespace SumEREW
{
    public class Program
    {
        static int i = 1;
        public void Main(string[] args)
        {
            int[] A = {1, 2, 3, 4, 5, 6, 7, 8, 9};
            // int n = (int)(Math.Pow(2 , i));
            int n = 8;
            int j = 1;

            for(i = 1; i <= (Math.Log(n, 2)); i++)
            {
                Parallel.For(0, j++, index => 
                {
                    if(((2*j) % ((int)(Math.Pow(2,i)))) == 0)
                    {
                        A[j * 2] = A[j * 2] + A[(2 * j) - (int)(Math.Pow(2, i - 1))];
                    }
                });
            for (int k = 0; k <= n; k++){
                Console.WriteLine(A[k]);
            }
            }                
            }
        }
    }