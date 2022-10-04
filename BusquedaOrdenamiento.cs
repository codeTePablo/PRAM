using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            Console.WriteLine("El minimo es: " + L[n]);
            // imp(win, n);
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
                        minIndex = 1;
                    }
                });

            }
            // Console.WriteLine("El minimo es: " + win[n]);
            // imp(win, n);
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
        int entrada;
        bool valid = false;
        Console.Write("Buscar valor\n");
            while (!valid)
            {
                Console.WriteLine("Introduzca un índice del arreglo: ");
                entrada = Convert.ToInt32(Console.ReadLine());
                valid = Limitation(entrada, 0, L.Length - 1, "Ese no es un index válido.");
                if (valid)
                {
                    Console.WriteLine($"El valor en el index {entrada} es {L[entrada]}");
                }
            }
            // min(L, 6);
            // imp(L, n);
        }
    }
}