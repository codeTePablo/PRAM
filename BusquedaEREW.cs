using System;

namespace BusquedaEREW{
    public class Program{

        public static int i = 1;
        public static int k = 1;
        public static int x = 5;
        public static int n = (int)(Math.Pow(2, k));


        public void broadcast(int[] temp, int x, int val){
            // val es el parametro a buscar 
            temp[1] = val;
            for(i = 1; i <= (int)(Math.Log(2, val)); i++){
                for(int j = (int)(Math.Log(2, i -1) + 1); j <= (int)(Math.Log(2, i)); j++){
                    Parallel.For(0, j++, index => {
                        temp[j] = temp[(j) - (int)(Math.Log(2, i -1))];
                    });
                }
            }
            // print the result 
            for(int k = 0; k <= val; k++){
            Console.WriteLine(temp[k]);
            }

        }


        public int minimo(int[] temp, int A)
        {
            // int j = 0;
            for(int j = 1; j <= ((int)(Math.Log(2, A))); j++)
            {
                    for(i = 1; i <= A / ((int)(Math.Pow(2, j))); i++)
                    {
                    Parallel.For(0, i++, index => {
                        if(temp[(int)(Math.Pow(2, i-1))] > temp[(int)(Math.Pow(2, i))])
                        {
                            temp[i] = temp[(int)(Math.Pow(2, i))];
                        }else
                        {
                            temp[i] = temp[(int)(Math.Pow(2, i-1))];
                        }
                    });
                    }
            }
            // n = temp[1];
            for(i = 0; i <= A; i++)
            {
                if(n > temp[i])
                {
                    n = temp[i];
                }
            }
            temp[1] = n;
            return temp[1];
            // Console.WriteLine(n);
        }

        int search(int val, int[] temp, int A)
        {
            // int[] temp = new int[100];
            // int[] A = {1, 2, 3, 4, 5, 6, 7, 8, 9};
            // int val = 5;
            broadcast(temp, x, val);

            int i = 1;
            for(i = 1; i <= A; i++){
                
                Parallel.for(0, i++, index => 
                {
                    if(temp[i] == )
                    {
                
                    }
                });
            }
                    
            // minimo(temp, x);
            // return temp[1];
        }

        public void Main(string[] args){ 
            // checj temp and A
        int[] temp = {1,2,3,4,5};
        // call method 
            // broadcast(temp, 5, 4);
            // minimo(temp, 4);
            search(2, temp, 5);

        }
    }
}