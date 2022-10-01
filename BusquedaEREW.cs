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

        public void Main(string[] args){ 
        int[] temp = {1,2,3,4,5};
        // call method 
            broadcast(temp, 5, 4);


        }
    }
}