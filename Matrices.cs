using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace MultiMatiz
{
    class Program
    {
        public static int n;
        public static int[,] A, B;
        public static int[,,] C;
        public void Main(string[] args)
        {
            Console.WriteLine("Multiplicacion de matrices");

            n = 2;
            A = new int[n + 1, n + 1];
            B = new int[n + 1, n + 1];
            C = new int[n + 1, n + 1, n + 1];

            int num;
            // ingresar los valores de las matrices por el usuario 2x2
            Console.Write("Ingrese el valor en [1,1] de la matriz A:");
            num = Convert.ToInt32(Console.ReadLine());
            A[1, 1] = num;
            Console.Write("Ingrese el valor en [1,2] de la matriz A:");
            num = Convert.ToInt32(Console.ReadLine());
            A[1, 2] = num;
            Console.Write("Ingrese el valor en [2,1] de la matriz A:");
            num = Convert.ToInt32(Console.ReadLine());
            A[2, 1] = num;
            Console.Write("Ingrese el valor en [2,2] de la matriz A:");
            num = Convert.ToInt32(Console.ReadLine());
            A[2, 2] = num;
            Console.Write("\nIngrese el valor en [1,1] de la matriz B:");
            num = Convert.ToInt32(Console.ReadLine());
            B[1, 1] = num;
            Console.Write("Ingrese el valor en [1,2] de la matriz B:");
            num = Convert.ToInt32(Console.ReadLine());
            B[1, 2] = num;
            Console.Write("Ingrese el valor en [2,1] de la matriz B:");
            num = Convert.ToInt32(Console.ReadLine());
            B[2, 1] = num;
            Console.Write("Ingrese el valor en [2,2] de la matriz B:");
            num = Convert.ToInt32(Console.ReadLine());
            B[2, 2] = num;

            // imprimir la primera matrix 
            Console.WriteLine("Matriz A:");
            MuestraMat(A);
            Console.WriteLine();
            // imprimir la segunda matrix 
            Console.WriteLine("Matriz B:");
            MuestraMat(B);
            Console.WriteLine();

            Parallel.For(1, n + 1, i =>
            {
                Parallel.For(1, n + 1, j =>
                {
                    Parallel.For(1, n + 1, k =>
                    {
                        C[i, j, k] = A[i, k] * B[k, j];
                    });
                });
            });

            for (int l = 1; l <= Math.Log(n, 2); l++)
            {
                Parallel.For(1, n + 1, i =>
                {
                    Parallel.For(1, n + 1, j =>
                    {
                        Parallel.For(1, (n / 2) + 1, k =>
                        {
                            if (((2 * k) % (int)Math.Pow(2, l)) == 0)
                            {
                                int r = C[i, j, 2 * k] + C[i, j, (2 * k) - (int)Math.Pow(2, l - 1)];

                                C[i, j, 2 * k] = C[i, j, 2 * k] + C[i, j, (2 * k) - (int)Math.Pow(2, l - 1)];
                            }
                        });
                    });
                });
            }

            Console.WriteLine("Resultado: \n");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(C[i, j, n] + " ");
                }
                Console.WriteLine();
            }
        }


        static void MuestraMat(int[,] X)
        {
            // juntar los valores de i,j en una matriz
            for (int i = 1; i <= 2; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    Console.Write(X[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}