using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaCRCW{
    public class Program{
        public static int[] L = {95, 10, 6, 15}; 
        public static int[] win, L2;
        public static int i;
        public static int j;
    public int minCRCW(int[] L, int n)
        {
            // int[] L = {95, 10, 6, 15}; 
            i = 1;
            win = new int[n];
            L2 = new int[n];
            int minIndex = 1;

            // for(int i = 1; i <= n; i++)
            {
                Parallel.For(0, n, i => {
                    win[i] = 0;
                });
            }

            for(int i = 0; i <= n && i < j; i++)
            {
                // for(int j = 0; j <= n; j++)
                {
                    Parallel.For(0, n, i => {
                        if(L[i] > L[j])
                        {
                            win[i] = 1;
                        }else{
                            win[j] = 1;
                        }
                    });
                }
            }

            // for(int i = 0; i <= n; i++)
            {
                Parallel.For(0, n, i => {
                    if(win[i] == 0)
                    {
                        minIndex = 1;
                    }
                });

            }

            return L[minIndex];
        }
        public void Main(string[] args){
            int n = 2;
            int min = minCRCW(L, n);
            Console.WriteLine(min);
        }
    }
}