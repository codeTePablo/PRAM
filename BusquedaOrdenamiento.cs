using System;

namespace BusquedaOrdenamiento{
    public class Program{

        public static int[] L = {95, 10, 6, 15}; 
        // public static int[] win = {0}; 

        public void sortCRCW(int[] L, int n)
        {
            // int n = 0;
            int[] win = {n}; 
            for(int i = 1; i <= n; i++)
            {
                Parallel.For(0, i++, index => {
                    win[i] = 0;
                });
            }

            for(int i = 1; i <= n; i++)
            {
                Parallel.For(0, i++, index => {
                    for(int j = 1; j <= n; j++)
                    {
                        if(L[i] > L[j])
                        {
                            win[i] = win[i] + 1;
                        }else{
                            win[j] = win[j] + 1;
                        }
                    }
                });
            }

            for(int i = 1; i <= n; i++)
            {
                Parallel.For(0, i++, index => {
                    L[1 + win[i]] = L[i];
                });
            }

            imp(win, n);
            // imp(L, n);
        }

        public void min(int[] L, int n)
        {
            int[] win = {n};
            int[] L2 = {n};
            int minIndex = 1;

            for(int i = 1; i <= n; i++)
            {
                Parallel.For(0, i++, index => {
                    win[i] = 0;
                });
            }

            for(int i = 0; i <= n; i++)
            {
                for(int j = 0; j <= n; j++)
                {
                    Parallel.For(0, j++, index => {
                        if(L[i] > L[j])
                        {
                            win[i] = 1;
                        }else{
                            win[j] = 1;
                        }
                    });
                }
            }

            for(int i = 0; i <= n; i++)
            {
                Parallel.For(0, i++, index => {
                    if(win[i] == 0)
                    {
                        // L2[index] = L[i];
                        minIndex = 1;
                    }
                });

            }

            imp(win, n);
        }

        public void imp (int[] L, int n)
        {
            for(int i = 0; i <= n; i++)
            {
                Console.WriteLine(L[i]);
            }
        }
        public static int n = 3;

        public void Main(string[] args)
        {
            // sortCRCW(L, n);
            // min(L, n);
            imp(L, n);
        }
              
    }
}