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

        public static bool Limitation(int entrada, int lower, int upper, string error)
        {
            if (entrada >= lower && entrada <= upper)
            {
                return true;
                }
                else
                {
                    Console.WriteLine(error);
                    return false;
                }            
        } 

        public int minimo(int[] A, int numA)
        {
            // int j = 0;
            for(int j = 1; j <= ((int)(Math.Log(2, numA))); j++)
            {
                    for(i = 1; i <= numA / ((int)(Math.Pow(2, j))); i++)
                    {
                    Parallel.For(0, i++, index => {
                        if(A[(int)(Math.Pow(2, i-1))] > A[(int)(Math.Pow(2, i))])
                        {
                            A[i] = A[(int)(Math.Pow(2, i))];
                        }else
                        {
                            A[i] = A[(int)(Math.Pow(2, i-1))];
                        }
                    });
                    }
            }
            // n = temp[1];
            for(i = 0; i <= numA; i++)
            {
                if(n > A[i])
                {
                    n = A[i];
                }
            }
            A[1] = n;
            return A[1];
            // Console.WriteLine(n);
        }

        public int search(int[] A, int val, int numA)
        {
            // int[] temp = new int[100];
            // int[] A = {1, 2, 3, 4, 5, 6, 7, 8, 9};
            // int val = 5;
            broadcast(temp, x, val);

            int i = 1;
            for(i = 1; i <= numA; i++){
                Parallel.For(0, i++, index => {
                    if(A[i] == temp[i])
                    {
                        temp[i] = i;
                    }else{
                        temp[i] = 0;
                    }
                });
                
            }
                    
            // minimo(temp, x);
            // return temp[1];
            return (minimo(A, numA));
        }
        public static int[] temp = {1,2,3,4,5};
        public static int[] A = {};
        // public static A[0] = 0;

        public void Main(string[] args){ 
        // call method 

            int entrada;
            bool valid = false;
            Console.Write("Buscar valor\n");
            while (!valid)
            {
                Console.WriteLine("Introduzca un índice del arreglo: ");
                entrada = Convert.ToInt32(Console.ReadLine());
                valid = Limitation(entrada, 0, temp.Length - 1, "Ese no es un index válido.");
                if (valid)
                {
                    Console.WriteLine($"El valor en el index {entrada} es {temp[entrada]}");
                }
            }

            // broadcast(temp, 5, 4);
            // minimo(temp, 4);
            // search(A, 5, 5);

        }
    }
}