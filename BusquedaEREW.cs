using System;

namespace BusquedaEREW{
    public class Program{

        public static int i = 1;
        public static int j = 1;
        public static int k = 1;
        public static int x = 5;
        public static int n = (int)(Math.Pow(2, k));
        public static int[] L = {1,2,3,4,5};
        public static int[] A, Temp;

        public void broadcast(int[] A, int x){
            // val es el parametro a buscar 
            i = 1;
            j = 1;
            A[1] = x;
            for(int i = 1; i <= k; i++)
            {
                Parallel.For(1, (int)(Math.Pow(2, i-1)), i =>
                {
                    Parallel.For(1, (int)(Math.Pow(2, i)), j => 
                    {
                        A[j] = A[j - (int)Math.Pow(2, i - 1)];
                    });
                });
            }
        }

        public int minimo(int[] A)
        {
            int i = 1;
            int j = 1;
            int n = 1;

            for(j = 1; j <= ((int)(Math.Log(2, n))); j++)
            {
                    Parallel.For(0, 1, i =>
                    {
                        Parallel.For(0, n / ((int)(Math.Pow(2, j))), j=> {
                            if(L[(int)(Math.Pow(2, i-1))] > L[(int)(Math.Pow(2, i))])
                            {
                                L[i] = L[(int)(Math.Pow(2, i))];
                            }else
                            {
                                L[i] = L[(int)(Math.Pow(2, i-1))];
                            }
                        });
                    });
            }
            return L[1];
        }

        public int busquedaEREW(int[] L, int x)
        {
            broadcast(A, x);

            Parallel.For(0, n, i => {
                if(L[i] == Temp[i])
                {
                    Temp[i] = i;
                }else{
                    Temp[i] = 0;
                }
            });
            return minimo(Temp);
        }

        public void Main(string[] args){ 

        Console.WriteLine("Busqueda EREW");
        busquedaEREW(L, x);
        }
    }
}